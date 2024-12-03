USE Northwind
GO

-- Question1
select City
from dbo.Employees
INTERSECT
select City
from dbo.Customers

-- Question2
--a
select distinct City from dbo.Customers where City not in (select distinct City from dbo.Employees)
--b 
select distinct City from dbo.Customers
EXCEPT
select distinct City from dbo.Employees

-- Question3
select p.ProductName, sum(p.UnitsOnOrder) TotalUnits
from dbo.Orders o
left join dbo.[Order Details] od on od.OrderID = o.OrderID
join dbo.Products p on p.ProductID = od.ProductID
group by p.ProductName

-- Question4
select c.City City, sum(od.Quantity) ProductQuantity
from dbo.Customers c
left join dbo.Orders o on o.CustomerID = c.CustomerID
left join dbo.[Order Details] od on o.OrderID = od.OrderID
group by c.City

-- Question5
select City, count(CustomerID) from dbo.Customers group by City having count(CustomerID) > 1

-- Question6
select c.City, count(distinct od.ProductID ) from dbo.Orders o
join dbo.[Order Details] od on o.OrderID = od.OrderID
join dbo.Customers c on o.CustomerID = c.CustomerID
group by c.City
having count(distinct od.ProductID) > 1

-- Question7
select distinct c.CompanyName, c.City, o.ShipCity from dbo.Orders o
join dbo.[Order Details] od on o.OrderID = od.OrderID
join dbo.Customers c on o.CustomerID = c.CustomerID
where c.City <> o.ShipCity

-- Question8

-- Question9
-- Question10

-- Question11
