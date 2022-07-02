Use Northwind
go
--1.      List all cities that have both Employees and Customers.
Select Distinct e.city
From Employees e
Where e.City in (
	Select c.city
	From Customers c
	)
	--- no sub-query
Select Distinct e.city
From Employees e join Customers c on e.City = c.City

--2.      List all cities that have Customers but no Employee.

--	a.      Use sub-query
Select Distinct c.city
From Customers c
Where c.City not in (
	Select e.city
	From Employees e
)

--	b.      Do not use sub-query
Select Distinct city
From Customers
Except
Select Distinct City
From Employees

--3.      List all products and their total order quantities throughout all orders.
Select p.ProductName, Sum(od.Quantity)[total quantities]
From Products p Left join [Order Details] od on p.ProductID = od.ProductID
Group by  p.ProductName

--4.      List all Customer Cities and total products ordered by that city.
Select c.city, Sum(od.Quantity)[total quantities]
From Customers c Left Join Orders o on c.CustomerID = o.CustomerID Join [Order Details] od on o.OrderID = od.OrderID
Group by c.City

--5.      List all Customer Cities that have at least two customers.
--	a.      Use union
Select c.City
From Customers c
Except
Select c.City
From Customers c
Group By c.City
Having count(*)=1

--	b.      Use sub-query and no union

SELECT DISTINCT City
FROM Customers
WHERE City IN (
	SELECT City
	FROM Customers
	GROUP BY City
	HAVING COUNT(*) >= 2)

--6.      List all Customer Cities that have ordered at least two different kinds of products.

With OrderProduct(cID, oID,numProduct)
as
(	SELECT o.CustomerID, od.OrderID, count(od.ProductID)[kindsOfProduct]
	FROM Orders o Join [Order Details] od on  o.OrderID = od.OrderID
	Group by o.CustomerID, od.OrderID
	Having count(od.ProductID)>2
)

Select Distinct c.City
From Customers c JOIN OrderProduct op  on c.CustomerId = op.cID


--7.      List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
Select Distinct c.CustomerID,c.ContactName
From Customers c join  Orders o on c.CustomerID = o.CustomerID
where c.City != o.ShipCity


--8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
Select Top 5 od.ProductID, SUM(od.Quantity)[TotalQuantity],AVG(od.UnitPrice*(1-od.Discount))[AveProductPrice],o.ShipCity
From [Order Details] od join Orders o on od.OrderID = o.OrderID
Group by od.ProductID,o.ShipCity
Order by SUM(od.Quantity) desc


--9.      List all cities that have never ordered something but we have employees there.
--	a.      Use sub-query
Select e.City
From Employees e
Where e.City not in (
	Select o.ShipCity
	From Orders o 
)
--	b.      Do not use sub-query
Select e.City
From Employees e
Except
Select o.ShipCity
From Orders o 

--10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, 
--and also the city of most total quantity of products ordered from. (tip: join  sub-query)


Select t1.city
From(
select top 1 count(o.orderID) as 'num_orders'
, e.City
from Orders o
left join Employees e on (e.EmployeeID = o.EmployeeID)
group by o.EmployeeID, e.City
order by num_orders desc) t1

Intersect

Select t2.ShipCity
From(
select top 1 sum(od.Quantity) as 'total_order'
, o.ShipCity
from .[Order Details] od
left join Orders o on (o.OrderID = od.OrderID)

group by o.ShipCity
order by total_order desc) t2


--11. How do you remove the duplicates record of a table?
With CTE 
As (Select *,R=RANK() OVER (Order By Cols)
From [tableName])
 
Delect CTE
Where R IN 
(Select R 
 From CTE 
 Group By R 
 Having COUNT(*)>1)