create database Assesment3
use Assesment3

create table CourseDetails(
    C_id varchar(10) primary key,
    C_Name varchar(30),
    Start__date date,
    End__date date,
    Fee int
)
 
insert into CourseDetails (C_id, C_Name, Start__date, End__date, Fee)values
('DV004', 'DataVisualization', '2018-03-01','2018-04-15',15000),
('DN003','DotNet', '2018-02-01','2018-02-28', 15000),
('JA002','AdvancedJava', '2018-01-02', '2018-01-20',10000),
('JC001', 'CoreJava', '2018-01-02','2018-01-12', 3000)
 
select * from CourseDetails
 
----1
 
create function Duration_in_Days(@start_date DATE, @end_date DATE)
returns int
as
begin
    return datediff(day, @start_date, @end_date)
end
 
SELECT dbo.Duration_in_Days('2018-03-01','2018-04-15') as Total_Days


--2

create table course_Info (
    C_Name VARCHAR(50),
    Start_Date DATE
)
 Drop table course_info
create trigger Datainsert
on CourseDetails
after insert
as
begin
    insert into course_info (C_Name, Start_Date)
    select C_Name, Start__date
    from inserted
end
 

insert into COURSEDETAILS(C_id, C_Name, Start__date, End__date, Fee) VALUES ('AI100', 'AI', '2024-10-11', '2024-12-10', 11000)

select * from course_info


---3
CREATE TABLE Products_Details (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,  
    ProductName VARCHAR(55) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    DiscountedPrice AS (Price - (Price * 0.1)) 
)
select * from Products_Details
create proc Insert_ProdDetails
    @ProductName varchar(55),
    @Price decimal(10, 2),
    @GeneratedProductId int output,
    @DiscountedPrice decimal(10, 2) output
as
begin
    declare @InsertedProducts table (ProductId int)
    insert into Products_Details (ProductName, Price)
    output INSERTED.ProductId into @InsertedProducts
    values(@ProductName, @Price)
    select @GeneratedProductId = ProductId FROM @InsertedProducts
    ser @DiscountedPrice = @Price - (@Price * 0.1)
end

 

declare @GeneratedProductId int, @DiscountedPrice decimal(10, 2)
 
exec Insert_ProdDetails
    @ProductName = 'TV',
    @Price = 35000,
    @GeneratedProductId = @GeneratedProductId output,
    @DiscountedPrice = @DiscountedPrice output


 

 