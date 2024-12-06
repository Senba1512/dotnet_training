create database Assignment5

use Assignment5


create table Emp(Empno int primary key,
Ename varchar(20) not null,
Job varchar(20),
MGR_Id int,
HireDate Date, 
Sal float,
Comm int,
Deptno  int)

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

select*from Emp
--1)
create or alter procedure sp_Payslip 
    @EmpID int
as
begin
    declare @Salary decimal(10, 2)
    declare @HRA decimal(10, 2)
    declare @DA decimal(10, 2)
    declare @PF decimal(10, 2)
    declare @IT decimal(10, 2)
    declare @Deductions decimal(10, 2)
    declare @GrossSalary decimal(10, 2)
    declare @NetSalary decimal(10, 2)

    select @Salary = Sal from Emp where Empno = @EmpID

   
    set @HRA = @Salary * 0.10      -- HRA = 10% of Salary
    set @DA = @Salary * 0.20       -- DA = 20% of Salary
    set @PF = @Salary * 0.08       -- PF = 8% of Salary
    set @IT = @Salary * 0.05       -- IT = 5% of Salary
   
    set @Deductions = @PF + @IT
    set @GrossSalary = @Salary + @HRA + @DA
    set @NetSalary = @GrossSalary - @Deductions
 


    print '           Payslip Details          '
    print 'Employee ID: ' + cast(@EmpID as varchar(10))
    print 'Salary: ' + cast(@Salary as varchar(10))
    print 'HRA (10%): ' + cast(@HRA as varchar(10))
    print 'DA (20%): ' + cast(@DA as varchar(10))
    print 'PF (8%): ' + cast(@PF as varchar(10))
    print 'IT (5%): ' + cast(@IT as varchar(10))
    print 'Deductions (PF + IT): ' + CAST(@Deductions as varchar(10))
    print 'Gross Salary: ' + CAST(@GrossSalary as varchar(10))
    print 'Net Salary: ' + CAST(@NetSalary as varchar(10))
    
end
exec sp_Payslip @EmpID = 7369


--2)
create table Holiday (
    holiday_date date primary key,
    holiday_name varchar(100)
)
 
 
insert into Holiday (holiday_date, holiday_name) values
    ('2024-08-15', 'Independence Day'),
    ('2024-01-26', 'Republic Holiday'),
    ('2024-12-25', 'Christmas'),
    ('2025-01-01', 'New Year'),
	('2024-01-15','Pongal')

 
 
CREATE or alter TRIGGER RestrictManipulationOnHolidays
ON Emp
for insert,update,delete
as
BEGIN
    DECLARE @holiday_name VARCHAR(20);
	declare @current_date date = cast(getdate() as date)
    SELECT @holiday_name =holiday_name
    FROM Holidays
    WHERE holiday_date = @current_date;
    IF @holiday_name IS NOT NULL
	begin
        raiserror('Data manipulation is restricted due to %s',16,1, @holiday_name)
		rollback transaction
    END 
END
update Emp set ename='Rama' where EmpNo=7369
select * from emp


