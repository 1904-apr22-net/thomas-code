-- comments
-- when we dont want to run the whole file, we highlight what we want to run

-- SQL has many commands/statements
-- 
Select firstname, CountryRegion
from SalesLT.Customer, saleslt.Address
where CountryRegion != 'United States'

SELECT Distinct SalesLT.Address.CountryRegion
FROM SalesLT.SalesOrderDetail, SalesLT.Address
Where SalesLT.SalesOrderDetail.SalesOrderID != '0'
--USing SalesLT.SalesOrderheader.ShipToAddressID


SELECT count (distinct SalesLT.SalesOrderDetail.SalesOrderID), Sum(TotalDue)
From SalesLT.SalesOrderDetail, SalesLT.SalesOrderHeader
--where SalesLT.SalesOrderHeader.OrderDate
--Between '2009-01-01 00:00:00.000' AND '2009-12-31 00:00:00.000'

Select Count(SalesOrderID), Sum(TotalDue), CountryRegion
From SalesLT.SalesOrderHeader
Inner Join SalesLT.Address On SalesLT.SalesOrderHeader.ShipToAddressID = SalesLT.Address.AddressID
Group by CountryRegion
Order By Count(TotalDue) DESC



Select *
From SalesLT.Address
--Order by SalesOrderID Desc

Select TotalDue
from SalesLT.SalesOrderHeader