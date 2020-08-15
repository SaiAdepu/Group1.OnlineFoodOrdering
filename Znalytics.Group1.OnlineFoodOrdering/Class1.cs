/// <summary>
/// Represents Food Delivery Employeelogin
/// </summary>
public class Employeelogin
{
    private int _employeeID;
    private string _password;
    private string _employeeName;
    private long _mobileNumber;
    private string _foodStoreID;
    /// <summary>
    /// employeeID details
    /// </summary>
    public void SetEmployeeID(int value)
    {
        _employeeID = value;
    }

    public int GetEmployeeID()
    {
        return _employeeID;
    }
    /// <summary>
    /// Password details 
    /// </summary>
    public void SetPassword(string value)
    {
        _password = value;
    }
    public string GetPassword()
    {
        return _password;
    }
    /// <summary>
    /// EmployeeName details
    /// </summary>
    public void SetEmployeeName(string value)
    {
        _employeeName = value;
    }
    public string GetEmployeeName()
    {
        return _employeeName;
    }
    /// <summary>
    /// Mobilenumber details
    /// </summary>
    public void SetMobileNumber(long value)
    {
        _mobileNumber = value;
    }
    public long GetMobileNumber()
    {
        return _mobileNumber;
    }
    /// <summary>
    /// FoodStorageid Details
    /// </summary>
    public void SetFoodStoreID(string value)
    {
        _foodStoreID = value;
    }
    public string GetFoodStoreID()
    {
        return _foodStoreID;
    }
}

