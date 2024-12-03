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

-- Question8 (took reference from solution)
select top 5 od.ProductID, avg(UnitPrice) AvgPrice, (select top 1 City from dbo.Customers c join dbo.Orders o on o.CustomerID = c.CustomerID  
                                                        join dbo.[Order Details] od1 on od1.OrderID = o.OrderID where od.ProductID = od1.ProductID 
                                                        group by City order by sum(Quantity) desc) City
from dbo.[Order Details] od
group by od.ProductID
-- Question9
-- a
select City from dbo.Employees where City not in (select ShipCity from dbo.Orders)
-- b 
select City from dbo.Employees
EXCEPT
select ShipCity from dbo.Orders

-- Question10

select top 1 e.City from dbo.Employees e join  dbo.Orders o on e.EmployeeID = o.EmployeeID group by e.EmployeeID, e.City 
having e.City in (
select top 1 e.City from dbo.Orders o join dbo.[Order Details] od on o.OrderID = od.OrderID join dbo.Employees e on o.EmployeeID=e.EmployeeID
 group by e.City, e.EmployeeID order by sum(od.Quantity) desc    
)order by count(o.OrderID) desc

-- Question11 Find total with count(*) and find unique with count(distinct). Now you will know if there are anty duplicate rows present in the table
-- Now, if count of a row is greater than 1, then delete the excess of the rows


