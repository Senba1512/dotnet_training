create database Assesment2

use Assesment2

create  table Dept(Deptno int Primary key,
Dname varchar(40),
loc varchar(40))
 
create table Emp(Empno int primary key,
Ename varchar(20) not null,
Job varchar(20),
MGR_Id int,
HireDate Date, 
Sal float,
Comm int,
Deptno  int foreign key references Dept(Deptno))
 
 
insert into Dept values(10,'Accounting','New York'),
(20,'Research','Dallas'),
(30,'Sales','Chicago'),
(40,'Operations','Boston')
 
 
insert into Emp values
(7369,'SMITH','CLERK',7902,'17-Dec-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)
 
 
select*from Dept
select*from Emp


--1.Display birthday
select datename(weekday,'2002-12-15')as 'Day of week'


--2.Display age in days
select datediff(day,'2002-12-15',getdate()) as 'Age in days'

--3.Employee details those who joined before 5 years from the current month

select* from Emp where HireDate < DateAdd(year,-5,getdate())and
Month(HireDate)=month(Getdate())

--4  single Transaction
begin transaction
create table Employees (
    empno INT PRIMARY KEY,
    ename VARCHAR(20),
    sal FLOAT,
    doj DATE)
--insert 3 records
INSERT INTO Employees (empno, ename, sal, doj) VALUES
(1, 'Senba', 5000, '2024-10-16'),
(2, 'Yuva', 5500, '2023-09-10'),
(3, 'Sowmiya', 4500, '2024-08-15')

-- Update second row's salary with 15% increment 
update Employees 
set sal = sal * 1.15 
where empno = 2

-- Delete first row
delete from Employees where empno = 1

-- Re-insert the deleted row with the updated salary
Insert into Employees (empno, ename, sal, doj) VALUES (1, 'Senba', 5000, '2024-10-16')

-- Commit the transaction
commit

select * from Employees

--5
create function CalculateBonus (@DeptNo int, @Salary decimal(10, 2))
returns decimal(10, 2)
as
begin
    declare @Bonus decimal(10, 2);
    if @DeptNo = 10
        set @Bonus = @Salary * 0.15;
    else if @DeptNo = 20
        set @Bonus = @Salary * 0.20;
    else
        set @Bonus = @Salary * 0.05;
    return @Bonus;
end
--a. For Deptno 10 employees 15% of sal as bonus.

select ename, sal, dbo.CalculateBonus(deptno, sal) as bonus from Emp where deptno = 10
 
--b. For Deptno 20 employees  20% of sal as bonus

select ename, sal, dbo.CalculateBonus(deptno, sal) as bonus from Emp where deptno = 20
 
--c  For Others employees 5% of sal as bonus
select ename, sal, dbo.CalculateBonus(deptno, sal) as bonus from Emp where deptno not in (10, 20)
 


--6. Create a procedure to update the salary of employee by 500 whose dept name is Sales and current salary is below 1500
create or alter proc sp_updatesal
as
begin
  update em set em.sal=em.sal+500 from Emp em join Dept dt on em.Deptno=dt.Deptno where dt.Dname='Sales' and em.Sal<1500
  end

  exec sp_updatesal
  select*from Emp
  ---Employee allen and martin salary is updated from 1250 to 1750

