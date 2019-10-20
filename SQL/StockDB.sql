CREATE DATABASE SMS
USE SMS

CREATE TABLE Categories(

ID INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(50),
Name VARCHAR(50)
)

Select * FROM Categories 

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

CREATE TABLE Products(

ID INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(50),
Name VARCHAR(50),
ReorderLevel INT,
[Description] VARCHAR(100),
Quantity INT,
CateogoryID INT REFERENCES Categories (ID),
PrevUnitPrice INT,
PrevMRP INT
)

Select * FROM Products



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







