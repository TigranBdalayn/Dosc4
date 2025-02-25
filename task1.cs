// Task 1: Student Management System
// Task: Create a class Student with:
// Fields: name, studentID, and gradeLevel.
// Add a method ShowStudentInfo() to display the details.
// In Main(), create a few Student objects and display their details.

class Student {
    static int _studentInstanceCount = 0;
    string _studentName;
    string _studentId;
    int _studentGradeLevel;

    public string StudentName {
        get {return _studentName;}
        set {_studentName = value;}
    }
    public string StudentId {
        get {return _studentId;}
        set {_studentId = value;}
    }

    public int GradeLevel {
        get {return _studentGradeLevel;}
        set {_studentGradeLevel = value;}
    }

    public Student () {
        ++_studentInstanceCount;
        Console.Write ("Please Enter The Name ");
        string name = Console.ReadLine ();
        Console.Write ("Please Enter the Grade ");
        int grade = int.Parse(Console.ReadLine());
        _studentName = name;
        _studentGradeLevel = grade;
        
        if (_studentInstanceCount < 10) {
            _studentId = $"000{_studentInstanceCount}";
        } else if (_studentInstanceCount < 100) {
        _studentId = $"00{_studentInstanceCount}";
        } else if (_studentInstanceCount < 1000) {
            _studentId = $"0{_studentInstanceCount}";
        } else {
            _studentId = $"{_studentInstanceCount}";
        }
    }


    public void ShowStudent () {

        Console.WriteLine ($"Name: {_studentName}\nId: {_studentId}\nGrade Level: {_studentGradeLevel}\n------------------------------");
    }
    
}


class Program {
    public static void Main (string[] args) {

        Student[] student = new Student[3];
        for (int i = 0; i < student.Length; ++i) {
            student[i] = new Student();
            //student[i].ShowStudent();
        }
        for (int i = 0; i < student.Length; ++i) {
        
            student[i].ShowStudent();
        }

    }
}