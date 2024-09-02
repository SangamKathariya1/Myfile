-- SQLite
--drop  table Author;
--drop table Book;
--drop table Publisher;

--Tables
--Book(Id(pk),Title, PublishedDate Price,Edition,ISBN,Genre,PublicationId, AuthorID)
--Publication(Id (pk), Name, Address, Established)
--Author (ID(pk), Name Addrsss, Phone, Gender, Education)

--Relation one- one, one-many, many-many


----Author table
create table Author
(
 Id Integer PRIMARY KEY AUTOINCREMENT,
    Name text,
    Address text,
    Phone text,
    Gender text,
    Education text
);

 -- inserting data into author
INSERT INTO Author (Id, Name, Address, Phone, Gender, Education)
VALUES (null, 'Sangam Kathariya', 'Tikapur', '9767692000', 'M', 'Masters in Computer Science');

 select*from Author;

 

--- publication table
CREATE Table Publication(
Id Integer PRIMARY KEY AUTOINCREMENT,
Name text,
Address text,
Established text
);
  
-- inserting data into publication 

 INSERT INTO Publication values (null,'Kec Publication','ktm','2007');

select*from Publication;

--- Book table
CREATE TABLE Book(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Title TEXT,
    PublishedDate TEXT,
    Price TEXT,
    Edition TEXT,
    ISBN TEXT,
    Genre TEXT,
    PublicationId INTEGER,
    AuthorId INTEGER,
    FOREIGN KEY (PublicationId) REFERENCES Publication(Id),
    FOREIGN KEY (AuthorId) REFERENCES Author(Id)
);
INSERT INTO Book (Title, PublishedDate, Price, Edition, ISBN, Genre, PublicationId, AuthorId)
VALUES ('Harry Potter and the Philosopher''s Stone', '1997-06-26', '20.99', 'First', '9780747532699', 'Fantasy', 1, 1);
 
 select*from Book;
