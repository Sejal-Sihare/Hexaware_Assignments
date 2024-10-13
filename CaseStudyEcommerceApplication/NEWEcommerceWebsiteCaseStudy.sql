
use  NewEcommerceApplication;
create table Customers( Customer_ID int primary key, Name varchar(50), Email varchar(50), Password varchar(50));
create table Products( Product_ID int primary key, Product_name varchar(50), Price varchar(50),  Description varchar(50), StockQuantity int);
create table Cart( Cart_ID int primary key, Customer_ID int, Product_ID int, Quantity int,
foreign key(Customer_ID) references Customers(Customer_ID) on delete cascade on update cascade,foreign key(Product_ID) references Products(Product_ID) on delete cascade on update cascade);
create table Orders( Order_ID int primary key, Customer_ID int,OrderDate date, TotalPrice int, ShippingAddress varchar(50),
foreign key(Customer_ID) references Customers(Customer_ID) on delete cascade on update cascade);
create table OrderItems( Order_Item_ID int primary key, Order_ID int,Product_ID int, QuantityOfOrderItems int,
foreign key(Order_ID) references Orders(Order_ID) on delete cascade on update cascade,foreign key(Product_ID) references Products(Product_ID) on delete cascade on update cascade);


insert into Customers(Customer_ID, Name , Email, Password)
VALUES (01, 'Agam', 'ar@gmail.com', 'ABC'),
(02, 'chandrika', 'ChandraN@gmail.com', 'XYX'),
(03, 'Deepak', 'deepak@gmail.com', 'AAA'),
(04, 'Deepika',  'dpal@gmail.com', 'QQQ'),
(05, 'Eshita',  'sharmae@gmail.com', '222t'),
(06, 'Garima', 'chatriji@gmail.com', 'ppp'),
(07, 'Harsh',  'hShivhare@gmail.com', '&&g'),
(08, 'Komal',  'komalll@gmail.com', 'A9S'),
(09, 'Sejal', 'siharese@gmail.com', 'TTT'),
(10, 'Teena',  'ahujateena@gmail.com', 'SSS');

insert into Products(Product_ID ,Product_name , Price,Description ,StockQuantity) values
(001, 'Ultra X pro laptop', 22000,'Electronic Gadget',100),
(002, 'Gaming Mouse', 1200,'Electronic Gadget',200),
(003, 'Titan Keyboard', 2200,'Electronic Gadget',40),
(004, 'Bluetooth Speaker', 2200,'Electronic Gadget',50),
(005, 'Noise ancelling Headphones', 2000,'Electronic Gadget Headphones',50),
(006, 'Pro Webcam', 2000,'Electronic Gadget',67),
(007, 'Powercore 20000 Power Bank', 4000,'Electronic Gadget',45),
(008, 'LED Bulb', 240,'Electronic Gadget',44),
(009, 'Rapid Charger', 2000,'Laptop Gadget',87),
(010, 'Earpods', 2000,'Electronic Gadget',67);

insert into Cart values(100,1,1,1),(200,2,2,2),(300,3,3,1),(400,4,4,2)
,(500,5,5,1),(600,6,6,2),(700,7,7,1),(800,8,8,1),(900,9,9,4),(1000,10,10,3);


insert into Orders values(10,1,'2024-09-10',22000,'street9 Chennai'),(20,2,'2024-09-13',2400,'street6 Mumbai'),
(30,3,'2024-09-15',2200,'Kanpur'),(40,4,'2024-09-18',4400,'Nagpur'),(50,5,'2024-09-16',2000,'Pune'),
(60,6,'2024-09-11',4000,'Indore'),(70,7,'2024-09-19',4000,'Kanpur'),(80,8,'2024-09-10',240,'Delhi'),
(90,9,'2024-09-20',8000,'Nanital'),(100,10,'2024-09-16',8000,'Shimla');


insert into OrderItems  values(101,10,1,1),(102,20,2,2),(103,30,3,1),(104,40,4,2),(105,50,5,1),
(106,60,6,2),(107,70,7,1),(108,80,8,1),(109,90,9,4),(110,100,10,3);

select * from Customers;
select * from Products;
select * from Cart;