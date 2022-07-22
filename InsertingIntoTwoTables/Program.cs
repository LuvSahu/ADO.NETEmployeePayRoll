namespace ADO.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepository employeeRepo = new EmployeeRepository();
            EmployeePayroll model = new EmployeePayroll();
            Console.WriteLine("Enter the choice \n 1.AddingEmployee\n" +
                " 2.UpdateEmployee\n 3.DeletingTheEmployee\n 4.InsertIntoTwoTables");
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

                case 3:
                    model.Name = "Shubham";
                    model.Id = 7;
                    employeeRepo.DeleteEmployee(model);
                    employeeRepo.GetAllEmployees();
                    break;

                case 4:
                    model.Name = "Luv";
                    model.Gender = 'M';
                    model.Address = "Berlin";
                    employeeRepo.InsertIntoTwoTables(model);
                    employeeRepo.GetAllEmployees();
                    break;

            }

        }
    }
}