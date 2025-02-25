// Task 7: Fitness Tracker System
// Task: Create a class WorkoutSession with:
// Fields: exerciseType and durationInMinutes.
// Add a method ShowWorkoutDetails().
// In Main(), create and display different workout sessions.

using System;

class WorkoutSession {
    public string ExerciseType ;
    public double DurationInMinutes;


    public WorkoutSession (string exercisetype, double durationinminutes) {
        ExerciseType = exercisetype;
        DurationInMinutes = durationinminutes;
    }
    public void Display () {
        
        Console.WriteLine ($"\nExercise type: {ExerciseType}\nDuration in minute: {DurationInMinutes}\n");
    }
}

class Program {
    static void Main (string[] args) {

        WorkoutSession WorkoutSession1 = new WorkoutSession("XXXX", 3.30);
        WorkoutSession1.Display ();
    }
}