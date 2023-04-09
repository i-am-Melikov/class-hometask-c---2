using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;


internal class Student
    {
    public string Name="Mustafa";
    public string SurName="Melikov";
    public string Group="p234";
    public double Point=67;
    public bool isGraduated=true;
    
 

   

    public void GetFullName()

    {
        Console.WriteLine(Name + " " + SurName + " ");
    }
    public void GetFullInfo()
    {
        if (Point > 80)
        {
            isGraduated = true;
        }
        else
        {
            isGraduated= false;
        }
        if (isGraduated)
        {
            Console.WriteLine(Name + " " + SurName + " " + Group + " " + Point + " " + "Telebe mezun olub!");
        }
        else
        {
            Console.WriteLine(Name + " " + SurName + " " + Group + " " + Point + " " + "Telebe mezun olmuyub");
        }
        if (isGraduated == false && Point > 80)
        {
            Console.WriteLine("Telebe tekrar imtahan vermeye haqq qazanib");
        }
        if (isGraduated == false && Point < 81)
        {
            Console.WriteLine("Telebenin ikinci imtahana girish haqqi yoxdur");
        }
    }

    public Student(string name, string surname, string group, double point, bool isgraduated)
    {
        Name = name;
        SurName = surname;
        Group = group;
        Point = point;
        isGraduated = isgraduated;

    }

    }
