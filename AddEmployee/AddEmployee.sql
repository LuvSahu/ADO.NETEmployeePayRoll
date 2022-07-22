CREATE PROCEDURE spAddEmployee
@Name nvarchar(200),
@Address nvarchar(200),
@Gender char(1),
@Salary float,
@PhoneNumber bigint
AS
insert into employee_payroll (Name,Address,Gender,Salary,PhoneNumber) values(@Name,@Address,@Gender,@Salary,@PhoneNumber);

