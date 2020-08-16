/// <summary>
/// Represents Food Delivery Employeelogin
/// </summary>
public class Employeelogin
{
    private int _employeeID;
    private string _employeeName;
    private string _password;

    private long _mobileNumber;
    private string _foodStoreID;
    /// <summary>
    /// employeeID details
    /// </summary>
    public int EmployeeID
    {
        set
        {
            if (value >= 10 )
            {
                _employeeID = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return _employeeID;
        }
    }
    
    /// <summary>
    /// EmployeeName details
    /// </summary>
    public string EmployeeName
    {
        set
        {
            if (value.Length >= 10 && value.Length <= 40)
            {
                _employeeName = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return _employeeName;
        }
    }
    /// <summary>
    /// Password details 
    /// </summary>
    public string Password
    {
        set
        {
            if (value.Length >= 8 && value.Length <= 30)
            {
                _password = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
    
        get
        {
            return _password;
        }
    }
    /// <summary>
    /// Mobilenumber details
    /// </summary>
    public long MobileNumber
    {
        set
        {
            if (value <= 10)
            {
                _mobileNumber = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
    }
        get
        {
            return _mobileNumber;
        }
    }
    /// <summary>
    /// FoodStorageid Details
    /// </summary>
    public string FoodStoreID
    {
        set
        {
            if (value.Length <= 20)
            {
                _foodStoreID = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return _foodStoreID;
        }
    }
}

