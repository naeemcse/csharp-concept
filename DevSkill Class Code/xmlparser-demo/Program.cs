using System.Reflection;
using xmlparser_demo;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;
using System;

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
        //XmlCreator(_course);

        StringBuilder xml = new StringBuilder();
        XmlCreator(_course, xml);
        Console.WriteLine(xml.ToString());

    }




    /*
    public static void XmlCreator(object obj)
    {
        if (obj == null) return;
        StringBuilder xml = new StringBuilder();

        Type type = obj.GetType();
        if (type == null) return;
        xml.Append("<"+type.Name+">");


        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {

            if (property.GetIndexParameters().Length > 0)
            {
                // Skip indexed properties

                continue;
            }
            object? value = property.GetValue(obj);

            xml.Append("<" + property.Name + ">");
            if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string) || property.PropertyType == typeof(DateTime) || property.PropertyType.IsValueType)
                xml.Append(value);
            else if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
            {
                if (value != null)
                {
                    foreach (var item in (IEnumerable)value)
                    {
                        XmlCreator(item);
                    }
                }
            }
            else
            {
                XmlCreator(value);

            }

            xml.Append("</" + property.Name + ">");


        }

        xml.Append("</" + type.Name + ">");



        Console.WriteLine(xml);
    }

    int t1 = 0 ,t2 = 0 ;
    public static void XmlCreator(object obj, StringBuilder xml = null)
    {
        if (obj == null) return;

        if (xml == null)
        {
            xml = new StringBuilder();
        }

        Type type = obj.GetType();
      
        xml.Append("<" + type.Name + ">");

        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            if (property.GetIndexParameters().Length > 0)
            {
                // Skip indexed properties
                continue;
            }

            object value = property.GetValue(obj);
            xml.Append("<" + property.Name + ">");

            if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string) || property.PropertyType == typeof(DateTime) || property.PropertyType.IsValueType)
            {
                xml.Append(value);
            }
            else if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
            {
                if (value != null)
                {
                    foreach (var item in (IEnumerable)value)
                    {
                        XmlCreator(item, xml);
                    }
                }
            }
            else
            {
                XmlCreator(value, xml);
            }

            xml.Append("</" + property.Name + ">");
        }

        xml.Append("</" + type.Name + ">");

        if (xml.Length > 0)
        {
            //Console.WriteLine(xml.ToString());
        }
    }
    */

    public static void XmlCreator(object obj, StringBuilder xml = null, bool isRoot = true)
    {
        if (obj == null) return;

        if (xml == null)
        {
            xml = new StringBuilder();
        }

        Type type = obj.GetType();

        if (isRoot)
        {
            xml.Append("<" + type.Name + ">");
        }

        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
          
            object value = property.GetValue(obj);
            xml.Append("<" + property.Name + ">");

            if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string) || property.PropertyType == typeof(DateTime) || property.PropertyType.IsValueType)
            {
                xml.Append(value);
            }
            else if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
            {
                if (value != null)
                {
                   
                    foreach (var item in (IEnumerable)value)
                    {
                        if (item is string)
                        {
                            xml.Append("<String>");
                            xml.Append(item);
                            xml.Append("</String>");
                        }
                        else
                        {
                            xml.Append("<" + item.GetType().Name + ">");
                            XmlCreator(item, xml, false);
                            xml.Append("</" + item.GetType().Name + ">");
                        }
                    }            
                }
            }
            else
            {
                XmlCreator(value, xml, false);
            }

            xml.Append("</" + property.Name + ">");
        }

        if (isRoot)
        {
            xml.Append("</" + type.Name + ">");
        }
    }

    // Genetate xml manually 
    private static void GenerateXml(object obj)
    {

        Assembly a = Assembly.GetExecutingAssembly();
        Type[] types = a.GetTypes();
        foreach (Type t in types)
        {
            Console.WriteLine(t.Name);
            Type type =  t.GetType();
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method: " + method.Name);
            }
        }


        

    }
     


    private static string SerializeToXml<T>(T obj)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        using (StringWriter textWriter = new StringWriter())
        {
            xmlSerializer.Serialize(textWriter, obj);
            return textWriter.ToString();
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