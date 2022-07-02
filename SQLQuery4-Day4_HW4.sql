--Use Northwind database. All questions are based on assumptions described by the Database Diagram sent to you yesterday. When inserting, make up info if necessary. 
--Write query for each step. Do not use IDE. BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE.

--1.      Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.
Create View view_product_order_Jiang
As (
	Select p.ProductID, p.ProductName, Sum(od.Quantity)[TotalQuantity]
	From Products p Join [Order Details] od On p.ProductID = od.ProductID 
	Group By p.ProductID, p.ProductName
)

--2.      Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id as an input and total quantities of order as output parameter.
Create Procedure sp_product_order_quantity_Jiang
@id int,
@totalQuantity int out
As
Begin 
	Select @totalQuantity = Sum(od.Quantity)
	From Products p Join [Order Details] od On p.ProductID = od.ProductID 
	Where p.ProductID = @id
END

Declare @totalQuantity int
Exec sp_product_order_quantity_Jiang 2, @totalQuantity out
	Select @totalQuantity

--3.      Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and top 5 cities that 
--	      ordered most that product combined with the total quantity of that product ordered from that city as output.
Create Procedure sp_product_order_city_Jiang
@pName  varchar(20),
@top5City varchar(20) out,
@totalQuantity int out
As
Begin 
	Select TOP 5 @top5City = o.ShipCity, @totalQuantity = SUM(od.Quantity)
	From Products p Join [Order Details] od On p.ProductID = od.ProductID Join Orders o On od.OrderID = o.OrderID
	Where p.ProductName = @pName 
	Group By o.ShipCity
	Order By SUM(od.Quantity) Desc
END
Begin
	Declare @pName  varchar(20)
	Declare @top5City varchar(20)
	Declare @totalQuantity int
	exec sp_product_order_city_Jiang Ikura, @top5City OUT, @totalQuantity OUT
	Select @pName
End


--4.      Create 2 new tables “people_your_last_name” “city_your_last_name”.
--        City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
--		  People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
--		  Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”.
--        Create a view “Packers_your_name” lists all people from Green Bay. 
--		  If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.

Create Table city_Jiang(
	id int,
	City varchar(55)
)

Insert into city_Jiang Values (1,'Seattle')
Insert into city_Jiang Values (2,'Green Bay')

Select * From city_Jiang

Create Table people_Jiang (
	Id int,
	Name varchar(20),
	City int
)
Insert Into people_Jiang Values (1,'Aaron Rodgers',2)
Insert Into people_Jiang Values (2,'Russell Wilson',1)
Insert Into people_Jiang Values (3,'Jody Nelson',2)

Select * From people_Jiang

Update city_Jiang
Set City = 'Madison'
Where City = 'Seattle'

Create View Packers_Jiang 
As
Select Name From people_Jiang , city_Jiang Where people_Jiang.City = city_Jiang.id AND city_Jiang.City = 'Green Bay'


Drop Table city_Jiang
Drop Table people_Jiang
Drop View Packers_Jiang
--5.      Create a stored procedure “sp_birthday_employees_[you_last_name]” that 
--        creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb. 
--	      (Make a screen shot) drop the table. Employee table should not be affected.
Create Procedure sp_birthday_employees_Jiang
As
Begin
 Create Table birthday_employees_Jiang (
employeeID int,
fullName varchar(50),
birthDate datetime
 )
Insert Into birthday_employees_Jiang
SELECT e.EmployeeID, e.FirstName+' '+e.LastName, e.BirthDate
FROM dbo.Employees e
WHERE MONTH(e.BirthDate)=2
END


--6.      How do you make sure two tables have the same data?
 Select *
 From
    (Select  *
    From table1
    Intersect
    Select *
    From table2)
-- If there is no result set, then two tables have the same data