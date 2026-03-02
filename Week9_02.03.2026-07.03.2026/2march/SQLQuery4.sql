create database monidatabase
use monidatabase


create table Employeetb(
EmpId int,EmpName varchar(20),EmpDesg varchar(50),
EmpDOJ datetime,EmpSal int,EmpDept int
)

insert into Employeetb values(101,'krishna','ProjManger',
7-8-2010,45000,10)
insert into Employeetb values(102,'kumari','Manger',
6-8-2010,50000,20)
insert into Employeetb values(103,'Amit','Manger',
7-9-2010,44000,30)
insert into Employeetb values(101,'krishna','ProjManger',
7-5-2010,55000,20)

create Proc SP_DelRec
as
begin
Delete emptb where empno=105
end

drop proc SP_DelRec

create proc sp_DelRecP @Pempno int
as
begin
Delete emptb where empno=@Pempno
end

create proc SPEmp_Insert(@PEmpId int,
@PEmpName varchar(20),@PEmpDesg varchar(50)
,@PEmpDOJ datetime,@PEmpSal int,
@PEmpDept int)
as
Begin
insert into Employeetb values(@PEmpId,
@PEmpName,@PEmpDesg,@PEmpDOJ,@PEmpSal,
@PEmpDept)
end

create proc SPEmp_Update(@PEmpId int,
@PEmpName varchar(20),@PEmpDesg varchar(50),
@PEmpDOJ datetime,@PEmpSal int,@PEmpDept int)
as
begin
update Employeetb set EmpName=@PEmpName,
EmpDesg=@PEmpDesg,EmpDOJ=@PEmpDOJ,
EmpSal=@PEmpSal,EmpDept=@PEmpDept 
where EmpId=@PEmpId
end

drop proc SPEmp_Update

create proc SPEmp_Del @PEmpId int
as
begin
Delete Employeetb where EmpId=@PEmpId
end

create proc SPGetSal (@PEmpId int,
@PEmpSal int output)
as begin
Select @PEmpSal=Empsal from Employeetb 
where EmpId=@PEmpId
End

drop proc SPGetSal

create proc SPGetData @PEmpId int,
@PEmpName varchar(50)Output,
@PEmpDesig varchar(50)Output,
@PEmpDOJ datetime Output,@PEmpSal int Output,
@PEmpDept int Output 
as Begin
select @PEmpName=EmpName,@PEmpDesig=EmpDesig,
@PEmpDOJ=EmpDOJ,@PEmpSal=EmpSal,
@PEmpDept=EmpDept from Employeetb 
where EmpId=@PEmpId
end

drop proc SPGetData


First create store proceudre:-

create proc sp_DelRecP @Pempno int
as
begin
Delete emptb where empno=@Pempno
end


