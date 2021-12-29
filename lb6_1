using System;
using System.Collections.Generic;

public class Human
{
    private string lname;   // Фамилия
    private int birth_year; // Год рождения
    private string status;  // Статус
    
    // Конструктор с параметрами
    public Human(string lname, 
                 int birth_year, 
                 string status)
    {
        this.lname = lname;
        this.birth_year = birth_year;
        this.status = status;
    }
    // Конструктор без параметров
    public Human(): this("unknown", 0, "unknown")
    {
        this.lname = "unknown";
        this.birth_year = 0;
        this.status = "unknown";
    }
    // Свойство для фамилии
    public string Lname
    {
        get{return lname;}
        set{lname = value;}
    }
    // Свойство для года рождения
    public int Birth_year
    {
        get{return birth_year;}
        set{birth_year = value;}
    }
    // Свойство для статуса
    public string Status
    {
        get{return status;}
        set{status = value;}
    }
    // Виртуальный метод
    public virtual void Info()
    {
        DateTime d = DateTime.Now;
        Console.WriteLine("Возраст: " + (Convert.ToInt32(d.Year)-Birth_year));
    }
    // Метод вывода информации
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
    private int math_ball;  // Оценка по математике
    private int phys_ball;  // Оценка по физике
    private int hist_ball;  // Оценка по истории
    
    // Конструктор с параметрами
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
    // Свойство для оценки по математике
    public int Math_ball
    {
        get{return math_ball;}
        set{math_ball = value;}
    }
    //С войство для оценки по физике
    public int Phys_ball
    {
        get{return phys_ball;}
        set{phys_ball = value;}
    }
    // Свойство для оценки по истории
    public int Hist_ball
    {
        get{return hist_ball;}
        set{hist_ball = value;}
    }
    // Метод для подсчета среднего бала
    public float AverageBall()
    {
        float sum = Math_ball+Phys_ball+Hist_ball;
        float average = sum/3;
        return average;
    }
    // Переопределение метода для возврата максимальной оценки
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
	    Human p1 = new Human("Петров", 2002, "Студент");
	    Human p2 = new Human("Иванов", 2003, "Студент");
	    Human p3 = new Human("Андреев", 2004, "Студент");
	    Human p4 = new Human("Соколов", 1990, "Преподаватель");
	    Human p5 = new Human("Денисов", 2001, "Студент");
		Human[] people = new Human[] {p1, p2, p3, p4, p5};
	    Array.Sort(people, new AgeSort());
	    // Сортировка по возрасту
	    foreach(Human p in people)
	    {
	        Console.WriteLine("{0} - {1}", p.Lname, p.Birth_year);
	    }
	    Console.WriteLine("");
	    // Сортировка по фамилии
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
