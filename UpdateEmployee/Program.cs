namespace ADO.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepository employeeRepo = new EmployeeRepository();
            EmployeePayroll model = new EmployeePayroll();
            Console.WriteLine("Enter the choice \n 1.AddingEmployee\n 2.UpdateEmployee");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    model.Name = "Rishi";
                    model.Address = "RajivChowk";
                    model.PhoneNumber = 1234565432;
                    model.Salary = 3000000;
                    model.Gender = 'M';

                    employeeRepo.AddEmployee(model);
                    employeeRepo.GetAllEmployees();
                    break;
                case 2:

                    model.BasicSalary = 5000001;
                    model.Name = "Rishi";
                    model.Id = 8;
                    employeeRepo.UpdateEmployee(model);
                    employeeRepo.GetAllEmployees();
                    break;

            }

        }
    }
}