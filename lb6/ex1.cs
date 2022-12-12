using System;
using System.Collections.Generic;

public class Human
{
    private string lname;
    private int birth_year;
    private string status;  
    
    public Human(string lname, 
                 int birth_year, 
                 string status)
    {
        this.lname = lname;
        this.birth_year = birth_year;
        this.status = status;
    }
    public Human(): this("unknown", 0, "unknown")
    {
        this.lname = "unknown";
        this.birth_year = 0;
        this.status = "unknown";
    }
    public string Lname
    {
        get{return lname;}
        set{lname = value;}
    }
    public int Birth_year
    {
        get{return birth_year;}
        set{birth_year = value;}
    }
    public string Status
    {
        get{return status;}
        set{status = value;}
    }
    public virtual void Info()
    {
        DateTime d = DateTime.Now;
        Console.WriteLine("Возраст: " + (Convert.ToInt32(d.Year)-Birth_year));
    }
    public void About()
    {
        Console.WriteLine("");
        Console.WriteLine("Фамилия: " + Lname);
        Console.WriteLine("Год рождения: " + Birth_year);
        Info();
        Console.WriteLine("Статус: " + Status);
    }
}

public class Student: Human
{
    private int math_ball;
    private int phys_ball;
    private int hist_ball;
    
    public Student(string lname, 
                   int birth_year, 
                   string status, 
                   int math_ball,
                   int phys_ball,
                   int hist_ball): base(lname, birth_year, status)
    {
        this.math_ball = math_ball;
        this.phys_ball = phys_ball;
        this.hist_ball = hist_ball;
    }
    public int Math_ball
    {
        get{return math_ball;}
        set{math_ball = value;}
    }
    public int Phys_ball
    {
        get{return phys_ball;}
        set{phys_ball = value;}
    }
    public int Hist_ball
    {
        get{return hist_ball;}
        set{hist_ball = value;}
    }
    public float AverageBall()
    {
        float sum = Math_ball+Phys_ball+Hist_ball;
        float average = sum/3;
        return average;
    }
    public override void Info()
    {
        int[] balls = new int[] {Math_ball, Phys_ball, Hist_ball};
        int max_ball = 0;
        for (int i=0; i<3; i++)
        {
            if(balls[i]>max_ball) max_ball = balls[i];
        }
        Console.WriteLine("Максимальная оценка: " + max_ball);
    }
}

class AgeSort: IComparer<Human>
{
    public int Compare(Human first, Human second)
    {
        if (first.Birth_year > second.Birth_year) 
        {
            return 1;
        }
        else if (first.Birth_year < second.Birth_year) 
        {
            return -1;
        }
        else 
        {
            return 0;
        }
    }
}

class LnameSort: IComparer<Human>
{
    public int Compare(Human first, Human second)
    {
        if (Convert.ToInt32(first.Lname[0]) > Convert.ToInt32(second.Lname[0])) 
        {
            return 1;
        }
        else if (Convert.ToInt32(first.Lname[0]) < Convert.ToInt32(second.Lname[0])) 
        {
            return -1;
        }
        else 
        {
            return 0;
        }
    }
}

public class Program
{
	public static void Main()
	{
	    Human p1 = new Human("Попов", 2002, "Студент");
	    Human p2 = new Human("Смирнов", 2003, "Студент");
	    Human p3 = new Human("Андронов", 2004, "Студент");
	    Human p4 = new Human("Савичкий", 1990, "Преподаватель");
	    Human p5 = new Human("Громов", 2001, "Студент");
		Human[] people = new Human[] {p1, p2, p3, p4, p5};
	    Array.Sort(people, new AgeSort());
	    foreach(Human p in people)
	    {
	        Console.WriteLine("{0} - {1}", p.Lname, p.Birth_year);
	    }
	    Console.WriteLine("");
	    Array.Sort(people, new LnameSort());
	    foreach(Human p in people)
	    {
	        Console.WriteLine("{0} - {1}", p.Lname, p.Birth_year);
	    }
	    foreach(Human p in people)
	    {
	        p.About();
	    }
	}
}
