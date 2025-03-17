using System;
using System.Collections;
using System.Collections.Generic; // Required for List<T>

namespace Assignment2;

internal static class Program
{
    internal static void Main(string [] args) {
        List<Professor> professors = new List<Professor>();
        List<Student> students = new List<Student>();
        Console.WriteLine("Would you like to add a professor or student? 'p', or 's'");
        string createObject = Console.ReadLine();
        
        if (createObject == "p") {
            Console.WriteLine("whats this professors name?");
            string tempName = Console.ReadLine();
            Console.WriteLine("what courses does he teach?");
            string tempCourse = Console.ReadLine(); //possibly make a function/ course object that we can add to an array 
            professors.Add(new Professor(tempName, tempCourse));
        }
        else if (createObject == "s") {
            Console.WriteLine("whats this students name?");
            string tempName = Console.ReadLine();
            Console.WriteLine("what courses he in");//still need to figure out what and how to manage courses
            string tempCourse = Console.ReadLine();
            students.Add(new Student(tempName, tempCourse));
        }
    }

    static void viewAllStudents(Student[] tempArray) { // dislplay's student array
        for (int i = 0; i < tempArray.Length; i++) {
            Console.WriteLine($"iteration: {i}: {tempArray[i]}");
        }
    }
    static void viewAllProfessors(Professor[] tempArray) { // dislplay's professor's array
        for (int i = 0; i < tempArray.Length; i++) {
            Console.WriteLine($"iteration: {i}: {tempArray[i]}");
        }
    }
}