﻿/// <summary>
/// Represents Food Delivery Employeelogin
/// </summary>
public class Employeelogin
{
    private int _employeeID;
    private string _firstName;
    private string _lastName;
    private string _password;
    private string _confirmPassword;
    private long _mobileNumber;
    private string _foodStoreID;

    /// <summary>
    /// employeeID details
    /// </summary>
    public int EmployeeID
    {
        set
        {
            if (value >=4)
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
    /// first name
    public string FirstName
    {
        set
        {
            if (value.Length >= 4 && value.Length <= 20)
            {
               _firstName = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return _firstName;
        }
    }
    /// <summary>
    /// lastname details
    /// </summary>
    public string LastName
    {
        set
        {
            if (value.Length >=4 && value.Length <= 20)
            {
                _lastName = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return _lastName;
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
    /// Confirm password
    /// </summary>
    public string ConfirmPassword
    {
        set
        {
            if (value.Length >= 8 && value.Length <= 30)
            {
                _confirmPassword = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }

        get
        {
            return
                _confirmPassword;
        }
    }

    /// <summary>
    /// Mobilenumber details
    /// </summary>
    public long MobileNumber
    {
        set
        {
            if (value <= 11)
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
