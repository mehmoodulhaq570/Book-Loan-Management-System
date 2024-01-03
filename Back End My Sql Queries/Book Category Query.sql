-- Inserting data into Category table
INSERT INTO Category VALUES
(1, 'Fiction'),
(2, 'Drama'),
(3, 'Satire'),
(4, 'Historical Fiction'),
(5, 'Literary Fiction'),
(6, 'Magical Realism'),
(7, 'Family Saga'),
(8, 'Children''s Fiction'),
(9, 'Crime Fiction'),
(10, 'Humor'),
(11, 'Horror'),
(12, 'Adventure'),
(13, 'Autobiography'),
(14, 'Classic'),
(15, 'Coming-of-Age');

-- Inserting data into Book_Category table based on Book data
-- Pakistani Authors
INSERT INTO Book_Category VALUES
(1, 1),  -- Moth Smoke - Fiction
(2, 2),  -- Home Fire - Drama
(3, 3),  -- A Case of Exploding Mangoes - Satire
(4, 4),  -- Ice Candy Man - Historical Fiction
(5, 5);  -- Basti - Literary Fiction

-- Indian Authors
INSERT INTO Book_Category VALUES
(6, 6),   -- The God of Small Things - Magical Realism
(7, 7),   -- A Suitable Boy - Family Saga
(8, 8),   -- The Blue Umbrella - Children's Fiction
(9, 9),   -- White Tiger - Crime Fiction
(10, 10); -- Five Point Someone - Humor

-- American Authors
INSERT INTO Book_Category VALUES
(11, 11),  -- The Shining - Horror
(12, 12),  -- The Old Man and the Sea - Adventure
(13, 13),  -- I Know Why the Caged Bird Sings - Autobiography
(14, 14),  -- The Great Gatsby - Classic
(15, 15);  -- The Adventures of Tom Sawyer - Coming-of-Age
