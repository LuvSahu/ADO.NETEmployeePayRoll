CREATE PROCEDURE [dbo].[spInsertIntoTwoTable]
(
@Name varchar(200),
@Address varchar(200),
@Gender char(1),
@Id INT OUTPUT
)
AS
insert into Employee_Payroll(Name,Address,Gender) values(@Name,@Address,@Gender);

SET @Id=SCOPE_IDENTITY()
         RETURN @Id;