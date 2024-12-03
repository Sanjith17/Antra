-- Question1
select COUNT(*) from Production.Product 

-- Question2
select COUNT(ProductSubcategoryID) from Production.Product 


-- Question3
select ProductSubcategoryID, COUNT(ProductID) CountedProducts from Production.Product group by ProductSubcategoryID

-- Question4
SELECT count(ProductID) from Production.Product where ProductSubcategoryID is not NULL

-- Question5

select * from Production.Product



-- Question6
select tab.ProductId ProductId, tab.TheSum TheSum from(
select ProductId, sum(Quantity) as TheSum from Production.ProductInventory where LocationId = 40 group by ProductID) as tab where tab.TheSum <100

-- Question7
select tab.Shelf Shelf,tab.ProductId ProductId, tab.TheSum TheSum from(
select ProductId, sum(Quantity) as TheSum, Shelf as Shelf from Production.ProductInventory where LocationId = 40 group by ProductID, Shelf) as tab where tab.TheSum <100

-- Question8
select ProductId, avg(Quantity) as TheAvg from Production.ProductInventory where LocationId = 10 group by ProductID

-- Question9
select ProductId, Shelf, avg(Quantity) as TheAvg from Production.ProductInventory where LocationId = 10 group by ProductID, Shelf

-- Question10
select ProductId, Shelf, avg(Quantity) as TheAvg from Production.ProductInventory where Shelf is not NULL group by ProductID, Shelf

-- Question11
select  Color, Class, count(Name) as TheCount, AVG(ListPrice) AvgPrice from Production.Product where Color is not null and Class is not NULL group by Color, Class

-- Question12
select  c.Name Country, s.Name Province
from person.CountryRegion c
JOIN person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode

-- Question13
select  c.Name Country, s.Name Province
from person.CountryRegion c
JOIN person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode
where c.Name in ('Germany','Canada')

Use Northwind
GO

-- Question14
select distinct p.ProductName 
from dbo.Orders o
left join dbo.[Order Details] od on o.OrderId = od.OrderID
left join dbo.Products p on od.ProductId = p.ProductID 
where year(o.OrderDate) > year(getdate())-27  

-- Question15
select top 5 ShipPostalCode Zip_Code, count(ShipPostalCode) Number from dbo.Orders group by ShipPostalCode order by count(ShipPostalCode) desc

-- Question16
select top 5 ShipPostalCode Zip_Code, count(ShipPostalCode) Number from dbo.Orders 
where year(OrderDate) > year(getdate())-27  
group by ShipPostalCode order by count(ShipPostalCode) desc

-- Question17
select City, count(CustomerID) as Number from dbo.Customers group by City

-- Question18
select c.City City, c.Number Number_of_Customers from(
select City, count(CustomerID) as Number from dbo.Customers group by City)  c
where c.Number >2

-- Question19
select c.CompanyName,cast(o.OrderDate as Date)
from dbo.Orders o
left join dbo.Customers c on o.CustomerID = c.CustomerID
where cast(o.OrderDate as Date) > '1998-01-01'

-- Question20
select c.CompanyName,cast(o.OrderDate as Date)
from dbo.Orders o
left join dbo.Customers c on o.CustomerID = c.CustomerID
order by cast(o.OrderDate as Date) desc

-- Question21
select c.CompanyName Name, o.cnt Total
from dbo.Customers c
left join (select count(OrderID) cnt, CustomerID from dbo.Orders group by CustomerID) as o
on o.CustomerID = c.CustomerID

-- Question22
select fin.totl total, fin.CustomerID CID from
(select sum(p.UnitsOnOrder) totl, CustomerID
from dbo.Orders as o
join dbo.[Order Details] as od 
on o.OrderID = od.OrderID
join dbo.Products as p
on od.ProductId = p.ProductID
group by CustomerID) as fin
where fin.totl >100


-- Question23

-- Question24
-- Question25
-- Question26

