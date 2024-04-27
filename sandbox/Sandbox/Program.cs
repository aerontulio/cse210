using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {   
        Student student1 = new Student("Aeron", "Tulio", "4th", "Psychology", "Freud", 98, 99);
        student1.introduceSelf();
        student1.evaluateGrade();

        Student s2 = new Student("Aira", "Tulio", "1st", "Nursing", "Dorothea", 97, 98);
        s2.introduceSelf();
        s2.evaluateGrade();
    }

} 