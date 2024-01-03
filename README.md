# Book Loan Management System

## Overview

The Book Loan Management System is a software solution designed to manage book-related information in a library or book loan system. It includes features for handling authors, book categories, book copies, and more. The project utilizes a SQL Server database for backend data storage and a Visual Studio Windows Forms application for the frontend.

## Project Structure

The project is organized into the following main components:

- **Backend:** Contains SQL scripts and queries for creating the database tables and managing data. All SQL files are located in the `Backend` folder.

- **Frontend:** Consists of the Visual Studio Windows Forms application. The forms and associated code files are available in the `Frontend` folder.
## Database

The Book Loan Management System relies on a Microsoft SQL Server database for efficient storage and retrieval of book-related information. The database is structured to capture key entities in the book loan process. Below are the main tables and their purposes:

### Author Table

The `Author` table stores information about book authors. Each author is uniquely identified by an `author_id`. The table includes fields for the author's first name, last name, email, contact number, address, date of birth, and nationality.

### BookCategory Table

The `BookCategory` table manages different categories of books. Categories are identified by a unique `category_id`, and the table includes fields for the category name and any additional details.

### Book Table

The `Book` table contains detailed information about individual books. Each book is assigned a unique identifier (`book_id`) and includes data such as the title, author, category, publication date, ISBN, and other relevant details.

### BookCopy Table

The `BookCopy` table is crucial for tracking individual copies of books and their loan status. Each copy is associated with a unique `copy_id`. Fields in this table include the copy number, book title, current loan status, and borrower information. It facilitates efficient management of book loans and returns.


## Getting Started

To set up and run the Book Loan Management System:

1. Download the project from the GitHub repository: [GitHub Link](https://github.com/your-username/your-repository)

2. Extract the contents of the provided ZIP file.

3. Open the SQL Server Management Studio and execute the SQL scripts in the `Backend` folder to create the database and tables.

4. Open the Visual Studio solution in the `Frontend` folder and build/run the application.

5. Explore the various forms and functionalities within the application.

## Usage

The Book Loan Management System is designed to streamline book-related operations within a library or book loan system. Below are key functionalities and how to use them:

### Adding Authors, Categories, and Books

1. **Authors:**
   - Open the application and navigate to the "Author" form.
   - Use the form to add new authors by providing their details such as first name, last name, email, contact number, address, date of birth, and nationality.

2. **Book Categories:**
   - Access the "BookCategory" form in the application.
   - Add different categories of books by entering the category name and any other relevant information.

3. **Books:**
   - Navigate to the "Book" form within the application.
   - Add books by specifying the title, author, category, publication date, ISBN, and other relevant details.

### Managing Book Copies

1. **BookCopy Form:**
   - Open the "BookCopy" form to manage individual copies of books and their loan status.
   - Add new copies, mark copies as borrowed or returned, and keep track of the availability of each book.

2. **Loan Information:**
   - Utilize the "BookCopy" form to view loan information associated with each copy, including borrower details, loan dates, and return status.
     

### Troubleshooting and Feedback

If you encounter any issues or have suggestions for improvements, please [create an issue](https://github.com/your-username/your-repository/issues) on GitHub. Your feedback is valuable for enhancing the functionality and usability of the Book Loan Management System.

---

**Note:** Please make sure to replace `[Your Name]`, `[Contributor 1]`, and `[GitHub Link]` with the actual information for your project. Additionally, customize the usage section to include specific features and functionalities relevant to your Book Loan Management System.


If you encounter any issues or have feedback, please Contact me on the email mehmodulhaq1040@gmail.com
