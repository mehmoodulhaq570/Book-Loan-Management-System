-- Inserting data into Fine table for late returns
INSERT INTO Fine (fine_id, copy_id, borrower_id, fine_amount, fine_date)
VALUES
(1, 1, 1, 100.00, '2023-11-25'),  -- Ahmed Khan returns 'Moth Smoke' 10 days late
(2, 2, 2, 70.00, '2023-11-22'),   -- Fatima Ali returns 'Home Fire' 7 days late
(3, 3, 3, 100.00, '2023-11-30'),  -- Muhammad Ahmed returns 'A Case of Exploding Mangoes' 20 days late
(4, 4, 4, 50.00, '2023-11-04'),   -- Ayesha Raza returns 'Ice Candy Man' 5 days late
(5, 5, 5, 140.00, '2023-12-08');  -- Bilal Siddiqui returns 'Basti' 14 days late
