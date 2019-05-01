-- comments
-- when we dont want to run the whole file, we highlight what we want to run

-- SQL has many commands/statements
-- 

--4
Select firstname, CountryRegion
from SalesLT.Customer as c inner join SalesLT.CustomerAddress as ca on c.customerID = ca.CustomerID
inner join saleslt.Address as a on ca.AddressID = a.AddressID
where CountryRegion != 'United States'

--5
Select firstname, CountryRegion
from SalesLT.Customer as c inner join SalesLT.CustomerAddress as ca on c.customerID = ca.CustomerID
inner join saleslt.Address as a on ca.AddressID = a.AddressID
where CountryRegion = 'Brasil'

--6
Select distinct SalesPerson
from SalesLT.Customer

--7
Select distinct CountryRegion
from SalesLT.Address

SELECT Distinct SalesLT.Address.CountryRegion
FROM SalesLT.SalesOrderDetail, SalesLT.Address
Where SalesLT.SalesOrderDetail.SalesOrderID != '0'
--USing SalesLT.SalesOrderheader.ShipToAddressID


SELECT count (distinct SalesLT.SalesOrderDetail.SalesOrderID), Sum(TotalDue)
From SalesLT.SalesOrderDetail, SalesLT.SalesOrderHeader
--where SalesLT.SalesOrderHeader.OrderDate
--Between '2009-01-01 00:00:00.000' AND '2009-12-31 00:00:00.000'

--11
Select Count(SalesOrderID), Sum(TotalDue), CountryRegion
From SalesLT.SalesOrderHeader
	Inner Join SalesLT.Address On SalesLT.SalesOrderHeader.ShipToAddressID = SalesLT.Address.AddressID
Group by CountryRegion
Order By Sum(TotalDue) DESC



Select *
From SalesLT.Address
--Order by SalesOrderID Desc

Select TotalDue
from SalesLT.SalesOrderHeader