use Assignment4

------1)Factorial
declare @Number int = 5  
declare @Factorial int = 1
declare @Counter int = 1

while @Counter <= @Number
begin
    set @Factorial = @Factorial * @Counter
    set @Counter = @Counter + 1
end

select @Factorial as Factorial

--2)Multiiplication table

create procedure MultiplicationTable
    @num int, 
    @limit int
as
begin
    declare @i int = 1
    while @i <= @limit
    begin
        print cast(@num as varchar) + ' x ' + CAST(@i as varchar) + ' = ' + cast(@num * @i as varchar)
        set @i = @i + 1
    end
end
exec MultiplicationTable @num = 15, @limit = 10



----student mark status
create table student(Sid int primary key not null,
SName varchar(10))

 insert into student values(1,'Jack'),
 (2,'Rithvik'),
 (3,'Jaspreeth'),
 (4,'Praveen'),
 (5,'Bisa'),
 (6,'Suraj')
 select *from student

 create table Marks ( Mid int, Sid int references student (Sid),Score int)
 insert into Marks values(1,1,23),
 (2,6,95),
 (3,4,98),
 (4,2,17),
 (5,3,53),
 (6,5,13)
select*from Marks


create function GetStatus (@Sid int)
returns varchar(10)
as
begin
    declare @status varchar(10)
    declare @score int
    select @score = Score from Marks where Sid = @Sid
    if @score >= 50
        set @status = 'Pass';
    else
        set @status = 'Fail';
    return @status
end

select  S.Sid,S.Sname,M.Score,dbo.GetStatus(S.Sid) as Status from Student S 
join Marks M ON S.Sid = M.Sid order by S.Sid

