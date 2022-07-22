CREATE PROCEDURE spUpdateEmployee
---ALTER PROCEDURE spUpdateEmployee
@Name varchar(200),
@Id int,
@BasicSalary float
As
update employee_payroll set BasicSalary=@BasicSalary where Id=@Id and Name=@Name;

Exec spUpdateEmployee 'Rishi',8,5000001;