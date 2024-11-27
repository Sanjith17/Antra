
-- Question 1
select ProductID, Name, Color, ListPrice from Production.Product

-- Quuestion 2

select ProductID, Name, Color, ListPrice from Production.Product where ListPrice <> 0

-- Question 3

select ProductID, Name, Color, ListPrice from Production.Product where Color is null

-- Question 4

select ProductID, Name, Color, ListPrice from Production.Product where Color is not null

--Question 5

select ProductID, Name, Color, ListPrice from Production.Product where Color is not null and ListPrice > 0

-- Question 6

select Name + Color as NameColor from Production.Product where Color is not null

-- Question 7

select top 6 'Name: '+ Name + ' -- Color:' + Color from Production.Product where Color is not NULL

-- Question 8

select ProductID, Name from Production.Product where ProductID BETWEEN 400 and 500

-- Question 9

select ProductID, Name, Color from Production.Product where Color in ('Black', 'Blue')

-- Question 10

select ProductID, Name, Color from Production.Product  where Name LIKE 'S%'

-- Question 11

select top 6 Name, ListPrice from Production.Product where Name like 'S%' order by Name

--Question 12

select top 6 Name, ListPrice from Production.Product where Name like '[S,A]%' order by Name

-- Question 13

select Name, ListPrice from Production.Product where Name like 'SPO[^K]%' order by Name

-- Question 14

select distinct Color from Production.Product order by Color desc

