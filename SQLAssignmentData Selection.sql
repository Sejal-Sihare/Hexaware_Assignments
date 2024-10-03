create  database practice;
use practice;
create table Customers (CustomerId int primary key,Firstname varchar(50), Lastname varchar(50),City varchar(50),State varchar(50));
Create table Products ( ProductId int primary key, Productname varchar(50),Listprice int,Modelyear int, CategoryId int);
Create table Orders(OrderId int primary key, CustomerId int,Orderdate date,foreign key(CustomerId) references Customers(CustomerId));
 insert into Customers values(1,'Sejal','Sihare','Mandla','M.P'),(2,'Mrunali','Rajkule','Pune','Maharastra'),(3,'Vinay','Solanki','Pune','Maharastra'),
 (4,'kavya','Rajpoot','Kanpur','U.P');

 insert into Products values(10,'earphones',1000,2014,1),(20,'Keyboard',2000,2018,2),(30,'earpods',1000,2019,3),(40,'Charger',1000,2014,4);
 insert into Orders values(100,1,'2024-09-18'),(200,2,'2024-09-14'),(300,3,'2024-09-15'),(400,4,'2024-09-18');


 --1
  select * from Customers order by Firstname desc;
  --2,
   select Firstname,Lastname,City from Customers order by City,Firstname;
   --3
   select * from Products order by Listprice  desc offset 0 rows fetch next 3 rows only;
   --4
    select * from Products where Listprice>300 and Modelyear = 2018;
	--5
	 select * from Products where Listprice>300 or Modelyear = 2018;
	 --6
	 select * from Products where Listprice between 1899 and 1999.99;
	 --7
	  select * from Products where Listprice in(299.99,466.99,489.99);
	 --8
	   select * from Customers where Lastname like '[A-C]%';
	 --9
	    select * from Customers where Firstname  not like 'A%';
     --10
	 select State,count(State),City,count(City) from Customers  group by State,City;
	 --11
	 select  CustomerId ,count(OrderId)  as numberofOrders from Orders group by CustomerID ,year(Orderdate);
	 --12
	 select  ProductId  Max(Listprice) as max_price ,Min(Listprice) as min_price from 
	 Products group by ProductId having Max(Listprice)<=4000 and Min(Listprice)>=500;
