using System;
namespace Alaa;

  

                                                                                  // Person Class
public  class  Person{
    public string Name;
    public int Age;
    public Person (string name,int age){
        Name=name;
        Age=age;
    }
    public virtual void Print(){
      Console.WriteLine($"My name is {Name} , my age is {Age} ");
    }
}
                                                                      // Student Class
public class Student : Person{
public int Year;
public float Gpa;
public Student(string name,int age,int year,float gpa):base(name,age){
    Year=year;
    Gpa=gpa;
}
public override void Print(){
    Console.WriteLine($"My name is {Name} , my age is {Age} , my gpa is {Gpa} ");
}
}
                                                                       // Staff class
public class Staff : Person{
  public double Salary;
  public int JoinYear;
  public Staff(string name,int age,double salary,int joinyear) : base(name,age){
    Salary = salary;
    JoinYear = joinyear;
  }
  public override void Print(){
     Console.WriteLine($"My name is {Name} , my age is {Age} , my salary is {Salary} ");
  }
}


// Database Class
class Database{
    public int _currentIndex;
     public Person [] People = new Person[10] ;
    public void AddStudent(Student student){
        People [_currentIndex++] = student;
    }
    public void AddStaff(Staff staff){
      People[_currentIndex++]=staff;
    }

    public void AddPerson(Person person){
People[_currentIndex++]=person;
    }
    public void PrintAll(){
      foreach(var i in People){
      
        i?.Print();
      }
    }
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
    var database=new Database();
    while(true){
Console.Write("Enter 1 to add student , 2 to add staff, 3 to add a person , 4 to print out all people in people array : ");
 var x=Convert.ToInt32(Console.ReadLine());
 switch(x){
case 1:

Console.Write("Name : ");
var name1=Console.ReadLine();
Console.Write("Age : ");
var age1=Convert.ToInt32(Console.ReadLine());
Console.Write("Year : ");
var year1=Convert.ToInt32(Console.ReadLine());
Console.Write("Gpa : ");
 var gpa1=Convert.ToSingle(Console.ReadLine());
 var student = new Student(name1,age1,year1,gpa1);
 database.AddStudent(student);

 break;

 case 2:
 Console.Write("Name : ");
var name2=Console.ReadLine();
Console.Write("Age : ");
var age2=Convert.ToInt32(Console.ReadLine());
Console.Write("Salary : ");
var salary2=Convert.ToDouble(Console.ReadLine());
Console.Write("JoinYear : ");
var joinyear2=Convert.ToInt32(Console.ReadLine());
var staff = new Staff(name2,age2,salary2,joinyear2);
database.AddStaff(staff);

 break;
 case 3:
Console.Write("Name : ");
var name3=Console.ReadLine();
Console.Write("Age : ");
var age3=Convert.ToInt32(Console.ReadLine());
Console.Write("Year : ");
var person = new Person(name3,age3);
database.AddPerson(person);
 break;

 case 4:
 database.PrintAll();
 Console.WriteLine("");
 break;
    } }}
}


