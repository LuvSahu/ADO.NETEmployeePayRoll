CREATE PROCEDURE spDeleteEmployee
@Name varchar(200),
@ID int
As
delete from employee_payroll where ID=@ID and Name=@Name;

Exec spDeleteEmployee 'Shubham',7;