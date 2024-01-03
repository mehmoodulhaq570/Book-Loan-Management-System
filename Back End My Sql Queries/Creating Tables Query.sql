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
