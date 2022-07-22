namespace ADO.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepository employeeRepo = new EmployeeRepository();
            //EmployeePayroll model = new EmployeePayroll();
            employeeRepo.GetAllEmployees();


        }

        }
    }