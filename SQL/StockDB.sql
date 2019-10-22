CREATE DATABASE SMS
USE SMS

CREATE TABLE Categories(

ID INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(50),
Name VARCHAR(50)
)


Select * FROM Categories 


CREATE TABLE Products
(
ID INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(50),
Name VARCHAR(50),
ReorderLevel INT,
ProductDescription VARCHAR(MAX),
CateogoryID INT REFERENCES Categories (ID),
)

select * from Products where Code=1 AND Name='eew'
select Code,Name,CateogoryID,ReorderLevel from Products where Code=1 OR Name='dgd'

delect table Products


SELECT P.Code as ProductCode, p.Name as ProductName,ReorderLevel,ProductDescription,c.Name as CategoryName
from Products as p Left join Categories as c ON c.ID = p.CateogoryID
SELECT * FROM Products

--viewcreate
CREATE VIEW ProductDetailsView 
AS
SELECT P.Code, p.Name as ProductName,ReorderLevel,p.ProductDescription as [Description],c.Name as Category
from Products as p Left join Categories as c ON c.ID = p.CateogoryID

SELECT * FROM ProductDetailsView


Drop table Products
Delete from Products where ID >3

Select * FROM Products


insert into Products values('1','asa','3','ds','1')

CREATE TABLE Customers(

ID INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(50),
Name VARCHAR(50),
[Address] VARCHAR(50),
Email VARCHAR(50),
Contact VARCHAR(11),
LoyaltyP INT
)

Select * FROM Customers

CREATE TABLE Suppliers(

ID INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(50),
Name VARCHAR(50),
[Address] VARCHAR(50),
Email VARCHAR(50),
Contact VARCHAR(11),
ContactPerson VARCHAR(11) 
)

Select * FROM Suppliers 



CREATE TABLE Purchases(

ID INT IDENTITY(1,1) PRIMARY KEY,
Date VARCHAR(50),
BillNo VARCHAR(50),
CateogoryID INT REFERENCES Categories (ID),
SupplierID INT REFERENCES Suppliers (ID),
ProductID INT REFERENCES Products (ID),
PurchaseQuantity INT,
ExpiredDate VARCHAR(50),
ManuDate VARCHAR(50),
UnitPrice INT,
MRP INT,
Remarks VARCHAR(100)
)

Select * FROM Purchases

DROP TABLE Purchases

CREATE TABLE Sales(

ID INT IDENTITY(1,1) PRIMARY KEY,
Date VARCHAR(50),
CateogoryID INT REFERENCES Categories (ID),
CustomerID INT REFERENCES Customers (ID),
ProductID INT REFERENCES Products (ID),
SaleQuantity INT,
MRP INT
)

Select * FROM Sales

DROP TABLE Sales

CREATE TABLE Orders(

ID INT IDENTITY(1,1) PRIMARY KEY,
OrderDate VARCHAR(50),
DeliveryDate VARCHAR(50),
CateogoryID INT REFERENCES Categories (ID),
SupplierID INT REFERENCES Suppliers (ID),
ProductID INT REFERENCES Products (ID),
OrderQuantity INT,
Remarks VARCHAR(50)
)

Select * FROM Orders

DROP TABLE Orders







