using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        // Initialize a sample Course object
        Course _course = new Course
        {
            Title = "Asp.net",
            Fees = 30000,
            Teacher = new Instructor
            {
                Name = "Jalaluddin",
                PresentAddress = new Address
                {
                    Street = "101",
                    City = "Dhaka",
                    Country = "Bangladesh"
                },
                PermanentAddress = new Address
                {
                    Street = "102",
                    City = "Rangpur",
                    Country = "Bangladesh"
                }
            },
            StartDate = new DateTime(2022, 12, 1),
            Tests = new List<AdmissionTest>
            {
                new AdmissionTest
                {
                    StartDateTime = new DateTime(2022, 10, 3, 9, 9, 9),
                    EndDateTime = new DateTime(2022, 10, 3, 11, 11, 11),
                    TestFees = 100
                },
                new AdmissionTest
                {
                    StartDateTime = new DateTime(2022, 11, 3, 9, 9, 9),
                    EndDateTime = new DateTime(2022, 11, 3, 10, 10, 10),
                    TestFees = 150
                }
            },
            Tags = new string[] { "C#", "HTML", "CSS" }
        };

        // Extract and print information from the object
        PrintObjectInfo(_course, 0);
    }

    private static void PrintObjectInfo(object obj, int indent)
    {
        if (obj == null) return;

        Type type = obj.GetType();
        string indentString = new string(' ', indent * 2);

        Console.WriteLine($"{indentString}Type: {type.Name}");

        // Get properties
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            if (property.GetIndexParameters().Length > 0)
            {
                // Skip indexed properties
                continue;
            }

            object value = property.GetValue(obj);
            if (value == null)
            {
                Console.WriteLine($"{indentString}  Property: {property.Name} = null");
            }
            else if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string) || property.PropertyType == typeof(DateTime) || property.PropertyType.IsValueType)
            {
                Console.WriteLine($"{indentString}  Property: {property.Name} = {value}");
            }
            else if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
            {
                Console.WriteLine($"{indentString}  Property: {property.Name} (Collection)");
                foreach (var item in (IEnumerable)value)
                {
                    PrintObjectInfo(item, indent + 2);
                }
            }
            else
            {
                Console.WriteLine($"{indentString}  Property: {property.Name} (Complex Type)");
                PrintObjectInfo(value, indent + 2);
            }
        }
    }
}

public class Course
{
    public string Title { get; set; }
    public Instructor Teacher { get; set; }
    public List<Topic> Topics { get; set; }
    public double Fees { get; set; }
    public List<AdmissionTest> Tests { get; set; }
    public string[] Tags { get; set; }
    public DateTime? StartDate { get; set; }
}

public class AdmissionTest
{
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public double TestFees { get; set; }
}

public class Topic
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Session> Sessions { get; set; }
}

public class Session
{
    public int DurationInHour { get; set; }
    public string LearningObjective { get; set; }
}

public class Instructor
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Address PresentAddress { get; set; }
    public Address PermanentAddress { get; set; }
    public List<Phone> PhoneNumbers { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}

public class Phone
{
    public string Number { get; set; }
    public string Extension { get; set; }
    public string CountryCode { get; set; }
}
