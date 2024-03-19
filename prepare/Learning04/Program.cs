using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new();
        assign1.SetStudentName("Henry Knox");
        assign1.SetTopic("Algebra 2");

        Console.WriteLine(assign1.GetAssignment());

        MathAssignment mathAssign1 = new();
        mathAssign1.SetStudentName("Rosie Knox");
        mathAssign1.SetTopic("Geometry");
        mathAssign1.SetTxtBookSect("1.3");
        mathAssign1.SetProblems("1-7");

        Console.WriteLine(mathAssign1.GetHwList());

        WritingAssignment writeAssign1 = new();
        writeAssign1.SetStudentName("Tori Knox");
        writeAssign1.SetTopic("U.S. History");
        writeAssign1.SetTitle("Life of Rosa Parks");

        Console.WriteLine(writeAssign1.GetWritingInfo());

    }
}