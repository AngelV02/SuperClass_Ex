using System;

// Create a class called Person
class Person
{
    // Define properties for first name and last name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Define a void method to say the person's name
    public void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}

// Create another class called Employee, inheriting from Person
class Employee : Person
{
    // Add a property for employee ID
    public int Id { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student"
        Employee employee = new Employee
        {
            FirstName = "Sample",
            LastName = "Student"
        };

        // Call the superclass method SayName() on the Employee object to display the full name
        employee.SayName();

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
