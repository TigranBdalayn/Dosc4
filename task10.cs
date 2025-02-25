// Task 10: Simulating Course Enrollment
// Task: Create a class Course with:
// Fields: courseName, instructor, and maxStudents.
// Use a constructor to initialize these fields.
// Add a method ShowCourseDetails().
// In Main(), create a few courses and display their details.



using System;



class Course {
    public string CourseName ;
    public string Instructor ;
    public int  MaxStudents;

    public Course (string coursename , string instructor, int maxstudents) {
        CourseName = coursename ;
        Instructor = instructor ;
        MaxStudents = maxstudents ;
    }
    public void ShowCourseDetails () {
        Console.WriteLine ($"\nCours Name: {CourseName}\nInstructor: {Instructor}\nMax Student: {MaxStudents}\n");
    }
}
class Program {
    static void Main (string[] args) {

        Course C = new Course ("X", "Y", 1);
        C.ShowCourseDetails();
    }
}