using System;
using System.Collections.Generic;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int age { get; set; }
}
class Program
{
    static List<Employee> employees = new List<Employee>();
    static int idcount = 1;
    public static void Main(string[] args)
    {
       

        while (true)
        {
            Console.WriteLine("\n=== Employee Manager ===");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Show Employee");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");
            
            int ch = Convert.ToInt32(Console.ReadLine());   

        switch(ch)
            {
                case 1:
                    Addemployee();
                    break;
                case 2:
                    showEmployees(); 
                    break;
                case 3:
                    UpdateEmployee();
                    break;
                case 4:
                    DeleteData();
                    break;
                case 5: return;
                default: break;
            }
        }
    }
    static void Addemployee()
    {
        Console.WriteLine("Enter emplyee name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter emplyee age");
        int age = Convert.ToInt32(Console.ReadLine());

        Employee emp = new Employee
        {
           Id = idcount++,
           Name = name,
           age = age
        };
        employees.Add(emp);
        Console.WriteLine("Employee Added !!");
    }
    static void showEmployees()
    {
        Console.WriteLine("Employees Data");
        
        if(employees.Count == 0)
        {
            Console.WriteLine("No employees to show.");
            return;
        }
            

        foreach (var em in employees)
        {
            Console.WriteLine($"ID: {em.Id} | Name: {em.Name} | Age: {em.age}");
        }
    
    }
    static void UpdateEmployee()
    {
        Console.WriteLine("Enter employee ID to update: ");


        if (int.TryParse(Console.ReadLine(),out int Id))
        {
         var emp=employees.Find(e => e.Id == Id);
            if (emp != null)
            {
                Console.WriteLine($"Enter new name for {emp.Name}:");
                emp.Name = Console.ReadLine();

                Console.WriteLine($"Enter new age for {emp.age}:");
                emp.age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Employee updated.");
            }
            else
            {
                Console.WriteLine(" employee not found.");
            }
        }
    }
    static void DeleteData()
    {
        Console.WriteLine("Enter Employee ID to delete");

        if(int.TryParse(Console.ReadLine(), out int Id))
        {
            var empid = employees.Find(e => e.Id == Id);

            if (empid != null)
            {
                employees.Remove(empid);
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("❌ employee not found.");
            }
        }
    }
}
