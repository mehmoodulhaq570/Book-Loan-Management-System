----- Delete author and also from its author list too------
CREATE TRIGGER delete_author_list
ON Author
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Author_list WHERE author_id IN (SELECT author_id FROM DELETED);
    DELETE FROM Author WHERE author_id IN (SELECT author_id FROM DELETED);
END;

----- Delete Book, Book Copy and its also delete from its category-----

CREATE TRIGGER delete_book_trigger
ON Book
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete from Book_Category
    DELETE FROM Book_Category WHERE book_id IN (SELECT book_id FROM DELETED);

    -- Delete from Book_Copy
    DELETE FROM Book_Copy WHERE book_id IN (SELECT book_id FROM DELETED);

    -- Delete from Book
    DELETE FROM Book WHERE book_id IN (SELECT book_id FROM DELETED);
END;

------