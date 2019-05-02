CREATE DATABASE EmployeeDB;

GO
CREATE SCHEMA Employee;
GO

CREATE TABLE Employee.Employee(
	EmployeeId INT NOT NULL IDENTITY,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	SSN INT NOT NULL Default(000000000),
	DepartmentId INT NOT NULL DEFAULT (0),
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE()),
	Active BIT NOT NULL DEFAULT(1),
	CONSTRAINT PK_EmployeeId PRIMARY KEY (EmployeeId),
	CONSTRAINT U_EmployeeId_SSN_LastName UNIQUE (EmployeeId, SSN, LastName),
	CONSTRAINT FK_Employee_Department FOREIGN KEY (DepartmentId) REFERENCES Employee.Department (DepartmentId)
);

CREATE TABLE Employee.Department(
	DepartmentId INT NOT NULL IDENTITY,
	Name NVARCHAR(200) NOT NULL,
	Location NVARCHAR(200) NOT NULL,
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE()),
	Active BIT NOT NULL DEFAULT(1),
	CONSTRAINT PK_DepartmentId PRIMARY KEY (DepartmentId)
	);

	SELECT *
	FROM Employee.Employee

	SELECT *
	FROM Employee.Department

CREATE TABLE Employee.EmpDetails(
	Id INT NOT NULL IDENTITY,
	EmployeeId INT NOT NULL,
	Salary Money NOT NULL DEFAULT(60000.00),
	Address1 NVARCHAR(200) NOT NULL DEFAULT('missing'),
	Address2 NVARCHAR(200) NULL DEFAULT(''),
	City NVARCHAR(200) NOT NULL DEFAULT('missing'),
	State NVARCHAR(200) NOT NULL DEFAULT('missing'),
	Country NVARCHAR(200) NOT NULL DEFAULT('missing'),
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE()),
	Active BIT NOT NULL DEFAULT(1),
	CONSTRAINT PK_EmpDetailsId PRIMARY KEY (Id),
	CONSTRAINT FK_EmpDetails_Employee FOREIGN KEY (EmployeeId) REFERENCES Employee.Employee (EmployeeId),
	CONSTRAINT Full_State_Name_CK CHECK (DATALENGTH(State) > 2)
);

	SELECT *
	FROM Employee.EmpDetails

INSERT INTO Employee.Department(Name, Location) VALUES
	('Marketing', 'Arlington'),
	('Research', 'Phoenix'),
	('Sales', 'New York');

INSERT INTO Employee.Employee (FirstName, LastName, SSN, DepartmentId) VALUES
	('Tina', 'Smith', 123456789, 1);

INSERT INTO Employee.Employee (FirstName, LastName, SSN, DepartmentId) VALUES
	('Fred', 'The', 123456780, 2),
	('Bob', 'Dude', 123456781, 3),
	('Sally', 'Shoal', 123456782, 1);

INSERT INTO Employee.EmpDetails (EmployeeID, Address1, City, State, Country) VALUES
	(2,'123 Drewy Lane', 'Arlington', 'Texas', 'United States'),
	(3,'456 No Grass Drive', 'Phoenix', 'Arizona', 'United States'),
	(4,'789 Cramped Living ct', 'New York', 'New York', 'United States'),
	(5,'321 Drewy Lane', 'Arlington', 'Texas', 'United States');



