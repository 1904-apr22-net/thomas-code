--DDL
--Data Definition Language

CREATE DATABASE MovieDb;

GO
CREATE SCHEMA Movie;
GO

-- Create TABLE
CREATE TABLE Movie.Movie (
	--list of columns, constraints, etc.
	-- each column: name, and then type, and then constraints
	MovieId INT NOT NULL
);

SELECT *
FROM Movie.Movie

-- alter can add/delete columns, modify things
ALTER TABLE Movie.Movie ADD
	Title NVARCHAR(200) Not Null;

-- DROP TABLE to delete tables entirely
DROP TABLE Movie.Movie;

--Constraints
	--NOT NULL: does not allow NULL value in column
	--NULL: allows NULL as value in column, already there by default, really there for documentation, not really a constraint
	--Primary Key
		--enforces uniqueness and NOT NULL, sets clustered index
	--UNIQUE: prevents column from having duplicate values, can be set on sets of columns as well as just one
	--DEFAULT: provide a default value for this column. either this or NULL is necessary when adding a new column to a table taht already has data
	--FOREIGN KEY: can set cascade behavior. ON DELETE CASCADE, ON DELETE SET NULL, ON UPDATE...
	--CHECK: catch  all, any boolean exppression you want to write to validate the values in a row. is checked every time a row is updated or inserted
	--IDENTITY(start = 1, increments by 1): 
		--usefuf for integer primary keys. prevents inserts or updates on the column, and gives automatic incrementing id
		-- it is possible to switch on IDENTITY_INSERT

CREATE TABLE Movie.Movie(
	MovieId INT NOT NULL IDENTITY,
	TITLE NVARCHAR(200) NOT NULL,
	ReleaseDate DATE NOT NULL,
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE()),
	Active BIT NOT NULL DEFAULT(1),
	CONSTRAINT PK_MovieId PRIMARY KEY (MovieId),
	CONSTRAINT U_Title_ReleaseDate UNIQUE (Title, ReleaseDate),
	CONSTRAINT CK_DateNotTooEarly CHECK (ReleaseDate > '1900')
	);

	INSERT INTO Movie.Movie (Title, ReleaseDate) VALUES
		('Avengers: Endgame', '2019');

CREATE TABLE Movie.Genre (
	GenreId INT NOT NULL IDENTITY,
	Name NVARCHAR(100) NOT NULL UNIQUE,
	ACTIVE BIT NOT NULL DEFAULT(1)
);

ALTER TABLE Movie.Genre ADD
	CONSTRAINT PK_GenreId PRIMARY KEY (GenreId);

INSERT INTO Movie.Genre (Name) Values
	('Action');

ALTER TABLE Movie.Movie ADD
	GenreId INT NOT NULL DEFAULT(1),
	CONSTRAINT FK_Movie_Genre FOREIGN KEY (GenreId) REFERENCES Movie.Genre (GenreId)
		ON DELETE CASCADE;

ALTER TABLE Movie.Movie DROP
	CONSTRAINT DF__Movie__GenreId__5441852A;