-- Author table --
CREATE TABLE Author (
    author_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    email_id VARCHAR(60),
    contact_no VARCHAR(15),
    address VARCHAR(255),
	date_of_birth DATE,
    nationality VARCHAR(50)
);

-- Book table --
CREATE TABLE Book (
    book_id INT PRIMARY KEY,
    book_title VARCHAR(30),
    book_edition VARCHAR(50),
    year_of_publication INT,
    price DECIMAL(10),
    ISBN_no VARCHAR(20),
    total_pages INT,
	genre VARCHAR(50),
    language VARCHAR(50),
    description TEXT
);

-- Borrower table --
CREATE TABLE Borrower (
    borrower_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    email_id VARCHAR(60),
    contact_no VARCHAR(15),
    address VARCHAR(255)
);

-- Author_list table --
CREATE TABLE Author_list (
    author_id INT,
    book_id INT,
    role VARCHAR(50),
    PRIMARY KEY (author_id, book_id),
    FOREIGN KEY (author_id) REFERENCES Author(author_id),
    FOREIGN KEY (book_id) REFERENCES Book(book_id)
);

-- Book_copy table --
CREATE TABLE Book_copy (
    copy_id INT PRIMARY KEY,
    book_id INT,
    status VARCHAR(50),
    FOREIGN KEY (book_id) REFERENCES Book(book_id)
);

-- Book_loan table --
CREATE TABLE Book_loan (
    copy_id INT,
    borrower_id INT,
    loan_date DATE,
    loan_days INT,
    return_date DATE,
    PRIMARY KEY (copy_id, borrower_id, loan_date),
    FOREIGN KEY (copy_id) REFERENCES Book_copy(copy_id),
    FOREIGN KEY (borrower_id) REFERENCES Borrower(borrower_id)
);

-- Fine table --
CREATE TABLE Fine (
    fine_id INT PRIMARY KEY,
    copy_id INT,
    borrower_id INT,
    fine_amount DECIMAL(10,2),
    fine_date DATE,
    FOREIGN KEY (copy_id) REFERENCES Book_copy(copy_id),
    FOREIGN KEY (borrower_id) REFERENCES Borrower(borrower_id)
);

CREATE TABLE Category (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50) UNIQUE
);

CREATE TABLE Book_Category (
    book_id INT,
    category_id INT,
    PRIMARY KEY (book_id, category_id),
    FOREIGN KEY (book_id) REFERENCES Book(book_id),
    FOREIGN KEY (category_id) REFERENCES Category(category_id)
);


-- Pakistani Authors
INSERT INTO Author VALUES
(1, 'Mohsin', 'Hamid', 'mohsin.hamid@email.com', '+92 300 1234567', '10 Lahore Street, Lahore', '1971-07-23', 'Pakistani'),
(2, 'Kamila', 'Shamsie', 'kamila.shamsie@email.com', '+92 321 9876543', '15 Karachi Street, Karachi', '1973-08-13', 'Pakistani'),
(3, 'Mohammed', 'Hanif', 'mohammed.hanif@email.com', '+92 333 8765432', '20 Islamabad Avenue, Islamabad', '1965-11-05', 'Pakistani'),
(4, 'Bapsi', 'Sidhwa', 'bapsi.sidhwa@email.com', '+92 311 7654321', '25 Lahore Lane, Lahore', '1938-08-11', 'Pakistani'),
(5, 'Intizar', 'Hussain', 'intizar.hussain@email.com', '+92 302 3456789', 'Pakistan', '1923-12-07', 'Pakistani');

-- Indian Authors
INSERT INTO Author VALUES
(6, 'Arundhati', 'Roy', 'arundhati.roy@email.com', '+91 98765 43210', '15 Mumbai Avenue, Mumbai', '1961-11-24', 'Indian'),
(7, 'Vikram', 'Seth', 'vikram.seth@email.com', '+91 98234 56789', '12 Delhi Street, Delhi', '1952-06-20', 'Indian'),
(8, 'Ruskin', 'Bond', 'ruskin.bond@email.com', '+91 98123 45678', '18 Mussoorie Avenue, Mussoorie', '1934-05-19', 'Indian'),
(9, 'Arvind', 'Adiga', 'arvind.adiga@email.com', '+91 98345 67890', '22 Bangalore Lane, Bangalore', '1974-10-23', 'Indian'),
(10, 'Chetan', 'Bhagat', 'chetan.bhagat@email.com', '+91 98111 22334', '30 Chennai Street, Chennai', '1974-04-22', 'Indian');

-- American Authors
INSERT INTO Author VALUES
(11, 'Stephen', 'King', 'stephen.king@email.com', '+1 207 5551234', '25 Bangor Street, Bangor', '1947-09-21', 'American'),
(12, 'Ernest', 'Hemingway', 'ernest.hemingway@email.com', '+1 305 5555678', '30 Key West Avenue, Key West', '1899-07-21', 'American'),
(13, 'Maya', 'Angelou', 'maya.angelou@email.com', '+1 212 5556789', '40 Harlem Lane, Harlem', '1928-04-04', 'American'),
(14, 'F. Scott', 'Fitzgerald', 'f.scott.fitzgerald@email.com', '+1 301 5558765', 'United States', '1896-09-24', 'American'),
(15, 'Mark', 'Twain', 'mark.twain@email.com', '+1 314 5557890', '50 Hannibal Street, Hannibal', '1835-11-30', 'American');


-- Author List
INSERT INTO Author_list VALUES
(1, 1, 'Author'),      -- Mohsin Hamid for 'Moth Smoke'
(2, 2, 'Author'),      -- Kamila Shamsie for 'Home Fire'
(3, 3, 'Author'),      -- Mohammed Hanif for 'A Case of Exploding Mangoes'
(4, 4, 'Author'),      -- Bapsi Sidhwa for 'Ice Candy Man'
(5, 5, 'Author'),      -- Intizar Hussain for 'Basti'
(6, 6, 'Author'),      -- Arundhati Roy for 'The God of Small Things'
(7, 7, 'Author'),      -- Vikram Seth for 'A Suitable Boy'
(8, 8, 'Author'),      -- Ruskin Bond for 'The Blue Umbrella'
(9, 9, 'Author'),      -- Arvind Adiga for 'White Tiger'
(10, 10, 'Author'),    -- Chetan Bhagat for 'Five Point Someone'
(11, 11, 'Author'),    -- Stephen King for 'The Shining'
(13, 13, 'Author'),    -- Maya Angelou for 'I Know Why the Caged Bird Sings'
(14, 14, 'Author'),    -- F. Scott Fitzgerald for 'The Great Gatsby'
(15, 15, 'Author');    -- Mark Twain for 'The Adventures of Tom Sawyer'

-- Books by Pakistani Authors
INSERT INTO Book VALUES
(1, 'Moth Smoke', 'First Edition', 2000, 15.99, '978-0-307-82183-9', 320, 'Fiction', 'English', 'A novel about the social and economic disparities in Lahore.'),
(2, 'Home Fire', 'First Edition', 2017, 19.99, '978-0-7352-2378-6', 288, 'Drama', 'English', 'Explores the complexities of love, terrorism, and family ties.'),
(3, 'A Case of Exploding Mangoes', 'Revised Edition', 2008, 14.99, '978-0-307-35596-3', 336, 'Satire', 'English', 'A satirical novel about the suspicious plane crash that killed General Zia-ul-Haq.'),
(4, 'Ice Candy Man', 'Second Edition', 1988, 12.99, '978-0-14-012683-2', 264, 'Historical Fiction', 'English', 'Set during the partition of India, it tells the story of a young girl and the impact of the political unrest on her life.'),
(5, 'Basti', 'New Edition', 1979, 11.99, '978-0-14-306335-3', 192, 'Literary Fiction', 'Urdu', 'A poignant novel reflecting the existential angst of a man in a war-torn city.');

-- Books by Indian Authors
INSERT INTO Book VALUES
(6, 'The God of Small Things', '20th Anniversary Edition', 1997, 18.99, '978-0-06-095981-5', 336, 'Magical Realism', 'English', 'An emotionally charged story set in Kerala, India.'),
(7, 'A Suitable Boy', 'First Edition', 1993, 24.99, '978-1-4000-3004-2', 1474, 'Family Saga', 'English', 'A panoramic novel about post-independence India and the search for a suitable boy for a young woman.'),
(8, 'The Blue Umbrella', 'Illustrated Edition', 1980, 14.99, '978-0-14-310376-2', 96, 'Children''s Fiction', 'English', 'A heartwarming tale of a young girl and her cherished blue umbrella.'),
(9, 'White Tiger', 'Man Booker Prize Edition', 2008, 16.99, '978-1-59420-163-3', 304, 'Crime Fiction', 'English', 'A dark and thrilling story about social and economic divides in modern-day India.'),
(10, 'Five Point Someone', '10th Anniversary Edition', 2004, 13.99, '978-0-8129-7297-9', 267, 'Humor', 'English', 'A humorous take on the education system and friendship in an Indian engineering college.');

-- Books by American Authors
INSERT INTO Book VALUES
(11, 'The Shining', 'Deluxe Edition', 1977, 22.99, '978-0-385-12167-5', 447, 'Horror', 'English', 'A classic horror novel that explores the supernatural events in an isolated hotel.'),
(12, 'The Old Man and the Sea', '60th Anniversary Edition', 1952, 12.99, '978-0-451-20859-1', 127, 'Adventure', 'English', 'A novella about an aging Cuban fisherman and his epic battle with a giant marlin.'),
(13, 'I Know Why the Caged Bird Sings', 'Random House Trade Paperback Edition', 1969, 16.99, '978-0-375-50789-2', 289, 'Autobiography', 'English', 'Maya Angelou''s powerful autobiography about her early years.'),
(14, 'The Great Gatsby', 'Revised Edition', 1925, 14.99, '978-0-7432-7356-5', 180, 'Classic', 'English', 'F. Scott Fitzgerald''s masterpiece exploring the American Dream and decadence.'),
(15, 'The Adventures of Tom Sawyer', 'Illustrated Classic Edition', 1876, 10.99, '978-0-06-112555-7', 272, 'Coming-of-Age', 'English', 'Mark Twain''s classic tale of a young boy''s adventures along the Mississippi River.');


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


-- Creating three copies for each book
INSERT INTO Book_copy VALUES
(1, 1, 'Available'),
(2, 1, 'Available'),
(3, 1, 'Available'),
(4, 2, 'Available'),
(5, 2, 'Available'),
(6, 2, 'Available'),
(7, 3, 'Available'),
(8, 3, 'Available'),
(9, 3, 'Available'),
(10, 4, 'Available'),
(11, 4, 'Available'),
(12, 4, 'Available'),
(13, 5, 'Available'),
(14, 5, 'Available'),
(15, 5, 'Available'),
(16, 6, 'Available'),
(17, 6, 'Available'),
(18, 6, 'Available'),
(19, 7, 'Available'),
(20, 7, 'Available'),
(21, 7, 'Available'),
(22, 8, 'Available'),
(23, 8, 'Available'),
(24, 8, 'Available'),
(25, 9, 'Available'),
(26, 9, 'Available'),
(27, 9, 'Available'),
(28, 10, 'Available'),
(29, 10, 'Available'),
(30, 10, 'Available'),
(31, 11, 'Available'),
(32, 11, 'Available'),
(33, 11, 'Available'),
(34, 12, 'Available'),
(35, 12, 'Available'),
(36, 12, 'Available'),
(37, 13, 'Available'),
(38, 13, 'Available'),
(39, 13, 'Available'),
(40, 14, 'Available'),
(41, 14, 'Available'),
(42, 14, 'Available'),
(43, 15, 'Available'),
(44, 15, 'Available'),
(45, 15, 'Available');


-- Borrower Data
INSERT INTO Borrower VALUES
(1, 'Ahmed', 'Khan', 'ahmed.khan@email.com', '+92 300 1234567', '10 Lahore Street, Lahore'),
(2, 'Fatima', 'Ali', 'fatima.ali@email.com', '+92 321 2345678', '15 Lahore Avenue, Lahore'),
(3, 'Muhammad', 'Ahmed', 'muhammad.ahmed@email.com', '+92 333 3456789', '20 Lahore Lane, Lahore'),
(4, 'Ayesha', 'Raza', 'ayesha.raza@email.com', '+92 311 4567890', '25 Lahore Road, Lahore'),
(5, 'Bilal', 'Siddiqui', 'bilal.siddiqui@email.com', '+92 302 5678901', '30 Lahore Boulevard, Lahore');


-- Inserting data into Fine table for late returns
INSERT INTO Fine (fine_id, copy_id, borrower_id, fine_amount, fine_date)
VALUES
(1, 1, 1, 100.00, '2023-11-25'),  -- Ahmed Khan returns 'Moth Smoke' 10 days late
(2, 2, 2, 70.00, '2023-11-22'),   -- Fatima Ali returns 'Home Fire' 7 days late
(3, 3, 3, 100.00, '2023-11-30'),  -- Muhammad Ahmed returns 'A Case of Exploding Mangoes' 20 days late
(4, 4, 4, 50.00, '2023-11-04'),   -- Ayesha Raza returns 'Ice Candy Man' 5 days late
(5, 5, 5, 140.00, '2023-12-08');  -- Bilal Siddiqui returns 'Basti' 14 days late
