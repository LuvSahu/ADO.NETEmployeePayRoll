namespace ADO.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepository employeeRepo = new EmployeeRepository();
            EmployeePayroll model = new EmployeePayroll();

            model.Name = "Rishi";
            model.Address = "Rajiv Chowk";
            model.PhoneNumber = 1234565432;
            model.Salary = 3000000;
            model.Gender = 'M';
            employeeRepo.AddEmployee(model);
            employeeRepo.GetAllEmployees();

            employeeRepo.GetAllEmployees();


        }

        }
    }