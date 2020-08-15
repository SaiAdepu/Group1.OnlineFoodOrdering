class Program10
{
    static void Main()
    {
        Employeelogin f = new Employeelogin();

        System.Console.WriteLine("enter the employeelogin details");

        System.Console.WriteLine("enter the employeeID");
        f.SetEmployeeID(int.Parse(System.Console.ReadLine()));

        System.Console.WriteLine("enter the Password");
        f.SetPassword(System.Console.ReadLine());

        System.Console.WriteLine("enter the EmployeeName");
        f.SetEmployeeName(System.Console.ReadLine());

        System.Console.WriteLine("enter the MobileNumber");
        f.SetMobileNumber(System.Convert.ToInt64(System.Console.ReadLine()));

        System.Console.WriteLine("enter the Food storeid ");
        f.SetFoodStoreID(System.Console.ReadLine());
        ///enter the details
        System.Console.WriteLine("enter the EmployeeName" + f.GetEmployeeID());
        System.Console.WriteLine("enter the Password" + f.GetPassword());
        System.Console.WriteLine("enter the EmployeeName" + f.GetEmployeeName());
        System.Console.WriteLine("enter the MobileNumber" + f.GetMobileNumber());
        System.Console.WriteLine("enter the Food storeid " + f.GetFoodStoreID());

    }
}


