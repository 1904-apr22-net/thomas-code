CREATE DATABASE Assessment

GO
CREATE SCHEMA Assessment
GO

CREATE TABLE Assessment.Products(
Id Int IDENTITY NOT NULL,
Name NVARCHAR(200) NOT NULL,
Price MONEY,
CONSTRAINT PK_ProductsId PRIMARY KEY (Id)
)

CREATE TABLE Assessment.Customers(
Id Int Identity NOT NULL,
FirstName NVARCHAR(100) NOT NULL,
LastName NVARCHAR(100) NOT NULL,
CardNumber INT NOT NULL UNIQUE,
CONSTRAINT PK_CustomersId PRIMARY KEY (Id)
)

CREATE TABLE Assessment.Orders(
Id INT IDENTITY NOT NULL,
ProductID INT,
CustomerID INT,
CONSTRAINT PK_OrdersId PRIMARY KEY (Id),
CONSTRAINT FK_Orders_Products FOREIGN KEY (ProductId) REFERENCES Assessment.Products (Id),
CONSTRAINT FK_Orders_Customers FOREIGN KEY (CustomerId) REFERENCES Assessment.Customers (Id)
)

--1
INSERT INTO Assessment.Products(Name, Price) VALUES
	('Galaxy S6', 50.00),
	('Galaxy S7', 100.00),
	('Galaxy S8', 150);

INSERT INTO Assessment.Customers(FirstName, LastName, CardNumber) VALUES
	('Joe', 'Johnson', 12345678901),
	('John', 'Smith', 12345678902),
	('Jane', 'Doe', 12345678903);

INSERT INTO Assessment.Orders(ProductID, CustomerID) VALUES
	(3, 1),
	(2, 3),
	(1, 2);

--2
INSERT INTO Assessment.Products(Name, Price) VALUES
	('iPhone', 200.00);

--3
INSERT INTO Assessment.Customers(FirstName, LastName, CardNumber) VALUES
	('Tina', 'Smith', 12345678904)

--4
INSERT INTO Assessment.Orders(ProductID, CustomerID) VALUES
	(4, 4)

--5
Select *
From Assessment.Orders
INNER JOIN Assessment.Customers ON Assessment.Orders.CustomerID = Assessment.Customers.Id
WHERE Assessment.Customers.FirstName = 'Tina' AND Assessment.Customers.LastName = 'Smith'

--6
SELECT Assessment.Products.Id, Name, SUM(Price)
FROM Assessment.Products
INNER JOIN Assessment.Orders On Assessment.Products.ID = Assessment.Orders.ProductID
WHERE Assessment.Products.Name = 'iPhone'
Having Count(*) > 0 --if it exists on the orders page, then it was ordered

--7
UPDATE Assessment.Products
SET Price = 250.00
WHERE Id = 4;

-- OR

UPDATE Assessment.Products
SET Price = 250.00
WHERE Name = 'iPhone';