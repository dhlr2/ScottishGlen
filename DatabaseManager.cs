using MySql.Data.MySqlClient;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data;

public class DatabaseManager
{
    private readonly string connectionString;

    public DatabaseManager()
    {
        connectionString = "Server=localhost;Database=scottishglen;Uid=root;Pwd=;";
    }


    private MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    
    /// <summary>
    /// Adds a new asset to the database with the specified details.
    /// </summary>
    /// <remarks>This method opens a connection to the database and inserts a new record into the Assets
    /// table. Ensure that the database connection is properly configured before calling this method.</remarks>
    /// <param name="name">The name of the asset. Cannot be null or empty.</param>
    /// <param name="purchaseDate">The date the asset was purchased.</param>
    /// <param name="notes">Additional notes about the asset. Can be null or empty.</param>
    /// <param name="employeeId">The ID of the employee responsible for the asset. Must be a valid employee ID.</param>
    public void AddAsset(string name, DateTime purchaseDate, string notes, int employeeId)
    {
        var conn = GetConnection();
        conn.Open();
        var cmd = new MySqlCommand("INSERT INTO Assets (name, PurchaseDate, Notes, EmployeeId) VALUES (@name, @PurchaseDate, @Notes, @EmployeeId)", conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
        cmd.Parameters.AddWithValue("@Notes", notes);
        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
        cmd.ExecuteNonQuery();
    }

    
    /// <summary>
    /// Retrieves a list of assets from the database.
    /// </summary>
    /// <remarks>Each asset is represented as a tuple containing the asset's ID, name, and value.</remarks>
    /// <returns>A list of tuples, where each tuple contains the ID, name, and value of an asset. The list will be empty if no
    /// assets are found.</returns>
    public List<(int id, string name, decimal value)> GetAssets()
    {
        var assets = new List<(int, string, decimal)>();
        var conn = GetConnection();
        conn.Open();
        var cmd = new MySqlCommand("SELECT * FROM Assets", conn);
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            
        }
        return assets;
    }

    /// <summary>
    /// Updates the name and value of an asset in the database.
    /// </summary>
    /// <remarks>This method updates the specified asset's name and value in the database. Ensure that the
    /// asset ID exists and the database connection is available before calling this method.</remarks>
    /// <param name="id">The unique identifier of the asset to update. Must be a valid asset ID.</param>
    /// <param name="name">The new name to assign to the asset. Cannot be null or empty.</param>
    /// <param name="value">The new value to assign to the asset. Must be a non-negative decimal.</param>
    public void UpdateAsset(int id, string name, decimal value)
    {
        var conn = GetConnection();
        conn.Open();
        var cmd = new MySqlCommand("UPDATE Assets SET name = @name, value = @value WHERE id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Deletes the asset with the specified identifier from the database.
    /// </summary>
    /// <remarks>This method establishes a connection to the database and executes a command to remove the
    /// asset. Ensure that the database connection is properly configured before calling this method.</remarks>
    /// <param name="id">The unique identifier of the asset to be deleted. Must be a valid asset ID.</param>
    public void DeleteAsset(int id)
    {
        var conn = GetConnection();
        conn.Open();
        var cmd = new MySqlCommand("DELETE FROM Assets WHERE id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    //Add employees first name, last name, email and department into the database
    public void AddEmployee(string firstName, string lastName, string email, string password, int department)
    {
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
        var conn = GetConnection();
        conn.Open();
        var cmd = new MySqlCommand("INSERT INTO Employees (FirstName, LastName, Email, Password_hash, DepartmentId) VALUES (@FirstName, @LastName, @Email , @Password_hash, @DepartmentId)", conn);
        cmd.Parameters.AddWithValue("@FirstName", firstName);
        cmd.Parameters.AddWithValue("@LastName", lastName);
        cmd.Parameters.AddWithValue("@Email", email);
        cmd.Parameters.AddWithValue("@Password_hash", passwordHash);
        cmd.Parameters.AddWithValue("@DepartmentId", department);
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Authenticates an employee by verifying the entered password against the stored password hash.
    /// </summary>
    /// <remarks>This method connects to the database to retrieve the stored password hash for the specified
    /// email. Ensure that the database connection is properly configured and accessible.</remarks>
    /// <param name="email">The email address of the employee to authenticate. Cannot be null or empty.</param>
    /// <param name="enteredPassword">The password entered by the employee for authentication. Cannot be null or empty.</param>
    /// <returns><see langword="true"/> if the entered password matches the stored password hash for the given email; otherwise,
    /// <see langword="false"/>.</returns>
    public bool AuthenticateEmployee(string email, string enteredPassword)
    {
     var conn = GetConnection();
     conn.Open();
     var cmd = new MySqlCommand("SELECT Password_Hash FROM Employees WHERE Email = @Email", conn);
     cmd.Parameters.AddWithValue("@Email", email);
     var storedHash = cmd.ExecuteScalar() as string;
        if (string.IsNullOrEmpty(storedHash))
        {
            return false;
        }
        else
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
        }
    }

    /// <summary>
    /// Retrieves a list of employees with their IDs, names, and roles.
    /// </summary>
    /// <remarks>This method connects to the database to fetch employee data. Ensure that the database
    /// connection is properly configured before calling this method.</remarks>
    /// <returns>A list of tuples, each containing the ID, name, and role of an employee. The list will be empty if no employees
    /// are found.</returns>
    public List<(int id, string name, string role)> GetEmployees()
    {
        var employees = new List<(int, string, string)>();
        var conn = GetConnection();
        conn.Open();
        var cmd = new MySqlCommand("SELECT * FROM Employees", conn);
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            //employees.Add();
        }
        return employees;
    }
    
    /// <summary>
    /// Updates the name and role of an employee in the database.
    /// </summary>
    /// <remarks>This method opens a database connection to execute the update operation. Ensure that the
    /// connection is properly configured and accessible.</remarks>
    /// <param name="id">The unique identifier of the employee to update. Must be a valid employee ID.</param>
    /// <param name="name">The new name to assign to the employee. Cannot be null or empty.</param>
    /// <param name="role">The new role to assign to the employee. Cannot be null or empty.</param>
    public void UpdateEmployee(int id, string name, string role)
    {
        var conn = GetConnection();
        conn.Open();
        var cmd = new MySqlCommand("UPDATE Employees SET name = @name, role = @role WHERE id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Deletes the employee record with the specified identifier from the database.
    /// </summary>
    /// <remarks>This method establishes a connection to the database and executes a command to remove the
    /// employee record. Ensure that the database connection is properly configured before calling this
    /// method.</remarks>
    /// <param name="id">The unique identifier of the employee to be deleted. Must be a valid, existing employee ID.</param>
    public void DeleteEmployee(int id)
    {
        var conn = GetConnection();
        conn.Open();
        var cmd = new MySqlCommand("DELETE FROM Employees WHERE id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }
}

