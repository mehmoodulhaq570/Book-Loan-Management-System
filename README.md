# Book Loan Management System

## Overview

The Book Loan Management System is a software solution designed to manage book-related information in a library or book loan system. It includes features for handling authors, book categories, book copies, and more. The project utilizes a SQL Server database for backend data storage and a Visual Studio Windows Forms application for the frontend.

## Project Structure

The project is organized into the following main components:

- **Backend:** Contains SQL scripts and queries for creating the database tables and managing data. All SQL files are located in the `Backend` folder.

- **Frontend:** Consists of the Visual Studio Windows Forms application. The forms and associated code files are available in the `Frontend` folder.
## Database

The Book Loan Management System relies on a Microsoft SQL Server database for efficient storage and retrieval of book-related information. The database is structured to capture key entities in the book loan process. Below are the main tables and their purposes:

1. **Author Table**

   The `Author` table stores information about book authors. Each author is uniquely identified by an `author_id`. The table includes fields for the author's first name, last name, email, contact number, address, date of birth, and nationality.

2. **BookCategory Table**

   The `BookCategory` table manages different categories of books. Categories are identified by a unique `category_id`, and the table includes fields for the category name and any additional details.

3. **Book Table**

   The `Book` table contains detailed information about individual books. Each book is assigned a unique identifier (`book_id`) and includes data such as the title, author, category, publication date, ISBN, and other relevant details.

4. **BookCopy Table**

   The `BookCopy` table is crucial for tracking individual copies of books and their loan status. Each copy is associated with a unique `copy_id`. Fields in this table include the copy number, book title, current loan status, and borrower information. It facilitates efficient management of book loans and returns.
   



## Front-End

A comprehensive Book Loan Management System designed to streamline book-related operations in libraries or loan systems.

## Screenshots

### Login Page


![31](https://github.com/mehmoodulhaq570/Book-Loan-Management-System/assets/96229333/553ec990-ddb4-4187-919e-7f1075c75a4c)

The secure and user-friendly login page ensures controlled access to the system.

### Content Page


![32](https://github.com/mehmoodulhaq570/Book-Loan-Management-System/assets/96229333/5d7c2422-ff94-4631-ba89-b64ff2781e37)

The content page provides an organized view, allowing users to quickly navigate and manage book-related data.

### Author Page


![33](https://github.com/mehmoodulhaq570/Book-Loan-Management-System/assets/96229333/cbf2ddbf-56d3-4136-9517-d3326756d4f3)

Effortlessly manage and explore information about book authors on the dedicated Author page.

### Book Page


![34](https://github.com/mehmoodulhaq570/Book-Loan-Management-System/assets/96229333/20614b24-bbf1-4609-8691-3898be14030d)


The Book page offers a centralized hub to add, edit, and view details about various books in the system.

### Borrower Page


![35](https://github.com/mehmoodulhaq570/Book-Loan-Management-System/assets/96229333/9a9ae31e-dbeb-460c-b0c5-b318ad7b763c)

Formerly the "Boardwalk Page," this section facilitates borrower management with a user-friendly interface.

## Project Video


https://github.com/mehmoodulhaq570/Book-Loan-Management-System/assets/96229333/64264b4d-b074-4bca-99f6-97becf5b2602


Explore a visual walkthrough of the Book Loan Management System in action.


## Getting Started

To set up and run the Book Loan Management System:

1. Download the project from the GitHub repository.

2. Extract the contents of the provided ZIP file.

3. Open the SQL Server Management Studio and execute the SQL scripts in the `Backend` folder to create the database and tables.

4. Open the Visual Studio solution in the `Frontend` folder and build/run the application.

5. Explore the various forms and functionalities within the application.


If you encounter any issues or have feedback, please Contact me on the email mehmodulhaq1040@gmail.com
