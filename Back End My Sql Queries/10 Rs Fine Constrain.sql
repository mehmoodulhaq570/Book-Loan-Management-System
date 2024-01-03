-- Trigger to calculate and insert fines for late book returns
CREATE TRIGGER calculate_fine
ON Book_loan
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(return_date) AND NOT UPDATE(loan_date)
        RETURN; -- Do nothing if only loan_date is updated

    DECLARE @days_overdue INT;
    DECLARE @fine_amount DECIMAL(10, 2);

    SELECT @days_overdue = DATEDIFF(day, i.loan_date, i.return_date)
    FROM inserted i
    WHERE i.return_date > i.loan_date;

    IF @days_overdue IS NOT NULL AND @days_overdue > 0
    BEGIN
        SET @fine_amount = @days_overdue * 10.0; -- Assuming 10 rupees per day

        INSERT INTO Fine (copy_id, borrower_id, fine_amount, fine_date)
        SELECT i.copy_id, i.borrower_id, @fine_amount, i.return_date
        FROM inserted i;
    END
END;
