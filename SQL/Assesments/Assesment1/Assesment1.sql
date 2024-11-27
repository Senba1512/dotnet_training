create database assesment1
use assesment1
create table Books 
(Book_id int primary key, 
Title varchar(20),
Author varchar(20), 
ISBN bigint unique,
Published_date DateTime)
 

 
insert into books values 
(1,'My First SQL Book','Mary Parker',981483029127,'2012-02-22 12:08:17'), 
(2,'My Second SQL Book','John Mayer',857300923713,'1972-07-03 09:22:45'), 
(3,'My Third SQL Book','Cary Flint',523120967812,'2015-10-18 14:05:44')
 

 
select * from books 

select Title,Author from books where author like '%er'
 

 
create table Reviews 
(Book_id int references books(book_id), 
Reviewer_name varchar(20), 
Content varchar(30), 
Rating int, 
Published_date Datetime)
 

 
insert into reviews values
 
(1,'John Smith','My first review',4,'2017-12-10 05:50:11.1'), 
(2,'John Smith','My second review',5,'2017-10-13 15:05:12.6'), 
(2,'Alice Walker','Another review',1,'2017-10-22 23:47:10')
 

 
select * from reviews
 
select b.title,b.author,r.Reviewer_name from Books b, Reviews r 
where b.book_id = r.book_id group by   b.author,b.title,r.Reviewer_name
 
 -----2nd question------
 
select reviewer_name from reviews group by Reviewer_name having count(Book_id)>1


 


 




  ---------3rd question---------
  create table Customer (Id int,
  Name varchar(20),
  Age int,
  Address varchar(20),
  Salary float)


  insert into Customer values(1,'Ramesh',32,'Ahmedabad',2000.00),
 (2,'Khilan',25,'Delhi',1500.00),
  (3,'Kaushik',23,'Kota',2000.00),
  (4,'Chaitali',23,'Mumbai',6500.00),
  (5,'Hardik',23,'Bhopal',8500.00),
  (6,'Komal',22,'MP',4500.00),
  (7,'Muffy',24,'Indore',10000.00)

  select*from Customer
  select Name From Customer where Address LIKE '%o%'
  ----4th question-----

  create table orders (OID int, Date Datetime, 
Customer_ID int , Amount float)
 
 
insert into orders values 
(102,'2009-10-08',3,3000),
(100,'2009-10-08',3,1500), 
(101,'2009-11-20',2,1560),
(103,'2008-05-20',4,2060)
 
 
select * from orders

select date,count(OID) 'Total customers' from orders 
group by date having count(OID)>1


  ------5th question------
 create table Employee (Id int,
  Name varchar(20),
  Age int,
  Address varchar(20),
  Salary float)
 
   insert into Employee values
   (1,'Ramesh',32,'Ahmedabad',2000.00),
  (2,'Khilan',25,'Delhi',1500.00),
  (3,'Kaushik',23,'Kota',2000.00),
  (4,'Chaitali',23,'Mumbai',6500.00),
  (5,'Hardik',23,'Bhopal',8500.00),
  (6,'Komal',22,'MP',null),
  (7,'Muffy',24,'Indore',null)

  select*from Employee
  select LOWER(Name) AS 'EmployeeName' from Employee where Salary IS NULL;
  
  create table studentdetails(Registerno int Primary key,
  Name varchar(20),
  Age int,
  Qualification varchar(10),
  MobileNo bigint ,
  Mail_id Varchar(30),
  location varchar(20),
  Gender varchar)
  
  insert into studentdetails values 
(2,'Sai',22,'B.E',9952836777,'sai@gmail.com','Chennai','M'),
(3,'Kumar',20,'BSC',7890125648,'kumar@gmail.com','Maduari','M'),
(4,'selvi',22,'B Tech',8904567342,'selvi@gmail.com','salem','F'),
(5,'Naha',25,'M E',7834672310,'Naha@gmail.com','Theni','F'),
(6,'SaiSaran',21,'BA',7890345678,'saran@gmail.com','Maduari','F'),
(7,'Tom',23,'BCA',8901234675,'Tom@gmail.com','Pune','M')

 select* from studentdetails
 select Gender,count(Gender)from studentdetails group by Gender




