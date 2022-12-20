using System;
namespace Alaa;
public  class Person{
public string Name;
public int Age;

public Person(string name,int age){    //constructor

Name=name;
Age=age;
}
public virtual void Print(){
Console.WriteLine("my name is {Name},my age is {Age}");
}


public class Student:Person{
    public int Year;
    public float Gpa;
    public Student(string name,int age,int year,float gpa): base(name,age){

      Year=year;
      Gpa=gpa;
    }
    public override void Print(){
        Console.WriteLine("My name is "+Name+" , My age is "+Age+" , my gpa is "+Gpa);
    }
}


public  class Database{
    private int _currentIndex;
    private int _countIndex;
    public Person[] People=new Person [50];
    public void AddStudent(Student student){
        People [_currentIndex++]=student;
    }
    public void Addstaff(Staff staff){
        People[_countIndex++]=staff;
    }
    public void printAll(){
        foreach(var i in People){
            i?.Print();
        }
    }
    public void AddPerson(Person person){
        People[_currentIndex++]=person;
    }
}


public class Staff:Person{
    public double Salary;
    public int JoinYear;

    public Staff(string name,int age,double salary,int joinyear):
    base(name,age){


       JoinYear=joinyear;
       Salary=salary;
    }

    public override void Print(){
        Console.WriteLine("my name is {Name} , my age is {Age} , my salary is {Salary}");
    }
}





public class Program{
    private static void main(){


var database=new Database();

while(true){


int x;
Console.Write("Enter 1 to add student , 2 to add staff, 3 to add a person , 4 to print out all people in people array");
x=Convert.ToInt32(Console.ReadLine());
switch(x){
    case 1:
Console.Write("Name : ");
var name=Console.ReadLine();
Console.Write("Age : ");
var age=Convert.ToInt32(Console.ReadLine());
Console.Write("Year : ");
var year=Convert.ToInt32(Console.ReadLine());
Console.Write("Gpa : ");
 var gpa=Convert.ToSingle(Console.ReadLine());
var student=new Student(name,age,year,gpa);
    
    database.AddStudent(student);
    break;
    case 2:
var name1=Console.ReadLine();
Console.Write("Age : ");
var age1=Convert.ToInt32(Console.ReadLine());
Console.Write("Year : ");
var salary=Convert.ToInt32(Console.ReadLine());
Console.Write("Gpa : ");
var joinyear=Convert.ToInt32(Console.ReadLine());

    var staff=new Staff(name1,age1,salary,joinyear);
    database.Addstaff(staff);
    break;
    case 3:

    Console.Write("Name : ");
var name3=Console.ReadLine();
Console.Write("Age : ");
var age3=Convert.ToInt32(Console.ReadLine());
var person=new Person(name3,age3);
database.AddPerson(person);
break;
    case 4:
    database.printAll();
    break;
    default:
    return;
}
}
    }

    }

