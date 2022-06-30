use AdventureWorks2019
--1.How many products can you find in the Production.Product table?
Select * From Production.Product
Select count(p.ProductID)[NumberOfProduct]
From Production.Product p

--2.Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
--The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
Select count(distinct(p.ProductSubcategoryID))[numberOfProducts]
From Production.Product p
where p.ProductSubcategoryID is not null

--3.How many Products reside in each SubCategory? Write a query to display the results with the following titles.
Select p.ProductSubcategoryID, count(p.ProductSubcategoryID)[numberOfProducts]
From Production.Product p
where p.ProductSubcategoryID is not null
Group by p.ProductSubcategoryID

--4.How many products that do not have a product subcategory.
Select p.ProductSubcategoryID,count(*)[numberOfProducts]
From Production.Product p
where p.ProductSubcategoryID is null
Group by p.ProductSubcategoryID

--5.Write a query to list the sum of products quantity in the Production.ProductInventory table.
Select pp.ProductID, sum(pp.Quantity)[sum of products quantity]
From Production.ProductInventory pp
Group By pp.ProductID


--6.Write a query to list the sum of products in the Production.ProductInventory table 
--and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
Select pp.ProductID, sum(pp.Quantity)[TheSum]
From Production.ProductInventory pp
Where pp.LocationID = 40
Group By pp.ProductID
having sum(pp.Quantity)<100


--7.Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 
--and limit the result to include just summarized quantities less than 100
Select pp.Shelf,pp.ProductID,sum(pp.Quantity)[TheSum]
From Production.ProductInventory pp
Where pp.LocationID = 40
Group By pp.Shelf,pp.ProductID
having sum(pp.Quantity)<100

--8.Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
Select pp.LocationID,AVG(pp.Quantity)[average quantity]
From Production.ProductInventory pp
where pp.LocationID =10
Group By pp.LocationID

--9.Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
Select pp.ProductID,pp.Shelf,AVG(pp.Quantity)[TheAve]
From Production.ProductInventory pp
Group By pp.ProductID, pp.Shelf
Order By pp.ProductID

--10.Write query to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
Select pp.ProductID,pp.Shelf,AVG(pp.Quantity)[TheAve]
From Production.ProductInventory pp
Where pp.Shelf != 'N/A'
Group By pp.ProductID, pp.Shelf
Order By pp.ProductID

--11.List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. 
--Exclude the rows where Color or Class are null.
Select p.Color,p.Class, Count(*)[TheCount],AVG(p.ListPrice)[AvePrive]
From Production.Product p
Where not (p.Class is null OR p.Color is null )
Group By p.Class,p.Color
--Joins
--12.Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables.
--Join them and produce a result set similar to the following.
Select pc.Name[Country], ps.Name[Province]
From person.CountryRegion pc inner join person. StateProvince ps on pc.CountryRegionCode = ps.CountryRegionCode

--13.Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
--Join them and produce a result set similar to the following.
Select pc.Name[Country], ps.Name[Province]
From person.CountryRegion pc inner join person. StateProvince ps on pc.CountryRegionCode = ps.CountryRegionCode
Where pc.Name ='Germany' OR pc.Name = 'Canada'

--Using Northwnd Database: (Use aliases for all the Joins)
Use Northwind
go
--14.  List all Products that has been sold at least once in last 25 years.
Select p.ProductName
From Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID
Where o.OrderDate >= DATEADD(YEAR,-25,getDate())
Group by p.ProductName
Order by p.ProductName

--15.  List top 5 locations (Zip Code) where the products sold most.
Select TOP 5  p.ProductName,o.ShipPostalCode, COUNT(o.ShipPostalCode)[Quantity]
From Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID
Where o.ShipPostalCode IS NOT NULL
Group By p.ProductName,o.ShipPostalCode
Order By COUNT(o.ShipPostalCode) desc

--16.  List top 5 locations (Zip Code) where the products sold most in last 25 years.
Select TOP 5  p.ProductName,o.ShipPostalCode, COUNT(o.ShipPostalCode)[Quantity]
From Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID
Where o.OrderDate >= DATEADD(YEAR,-25,getDate())
Group By p.ProductName,o.ShipPostalCode
Order By COUNT(o.ShipPostalCode) desc

--17.  List all city names and number of customers in that city.     
Select City, Count(Distinct CustomerID) [number of customers]
From Customers
Group by City

--18.  List city names which have more than 2 customers, and number of customers in that city
Select City, Count(Distinct CustomerID) [number of customers]
From Customers
Group by City
Having Count(*)>2

--19.  List the names of customers who placed orders after 1/1/98 with order date.
Select Distinct c.ContactName, o.OrderDate
From Customers c join Orders o on c.CustomerID = o.CustomerID
Where o.OrderDate > '01-01-1998'

--20.  List the names of all customers with most recent order dates
Select c.ContactName, o.OrderDate
From Customers c join Orders o on c.CustomerID = o.CustomerID
Group by c.ContactName,o.OrderDate
Order by o.OrderDate desc

--21.  Display the names of all customers along with the  count of products they bought
Select c.ContactName, Count(Distinct od.ProductID)[NumerOfProducts]
From Customers c join Orders o on c.CustomerID = o.CustomerID Join [Order Details] od on o.OrderID = od.OrderID  
Group by c.ContactName

--22.  Display the customer ids who bought more than 100 Products with count of products.
Select c.CustomerID, Count(Distinct od.ProductID)[NumerOfProducts]
From Customers c join Orders o on c.CustomerID = o.CustomerID Join [Order Details] od on o.OrderID = od.OrderID  
Group by c.CustomerID
Having Count(Distinct od.ProductID) > 100

--23.  List all of the possible ways that suppliers can ship their products. Display the results as below
Select Suppliers.CompanyName[Supplier Company Name], Shippers.CompanyName[Shipping Company Name] 
From Suppliers Cross Join Shippers

--24.  Display the products order each day. Show Order date and Product Name.
Select o.OrderDate, p.ProductName
From Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID

--25.  Displays pairs of employees who have the same job title.

With LimitedEmpCTE(EmpId, FullName, Title)
As(
Select EmployeeId, FirstName + ' ' + LastName [Full Name], Title
From Employees
)

Select l1.FullName,l2.FullName, l1.Title
From LimitedEmpCTE l1 inner Join LimitedEmpCTE l2  on l1.Title = l2.Title
Where l1.FullName != l2.FullName

--26.  Display all the Managers who have more than 2 employees reporting to them.
SELECT E2.FirstName + ' ' + E2.LastName[FullName]
FROM Employees E1 JOIN Employees E2 ON E1.ReportsTo = E2.EmployeeID
GROUP BY E2.FirstName, E2.LastName
HAVING COUNT(E2.EmployeeID) > 2

--27.  Display the customers and suppliers by city. The results should have the following columns
Select c.City, c.CompanyName[Name],c.ContactName[Contact Name], 'Customers' as Type
From Customers c
Union
Select s.City, s.CompanyName as "Name",s.ContactName as "Contact Name", 'Suppliers' as Type
From Suppliers s