// Task 5: Smartwatch Step Counter
// Task: Create a class Smartwatch with:
// Fields: ownerName and stepCount.
// Add methods AddSteps(int steps) and ShowSteps().
// In Main(), create a smartwatch object, simulate adding steps, and display the total.

using System;

class SmartWatch {
    
    public string OwnerName;
    int StepCount;

    public SmartWatch (string ownername, int stepcount) {
        OwnerName = ownername;
        StepCount = stepcount;
    }  

    public void Display () {
        Console.WriteLine ($"\nOwener Name:  {OwnerName}\nStepCount: {StepCount}\n");

    }

    public void AddSteps (int steps) {
        StepCount += steps;
    }
}

class Program {
    static void Main (string [] args) {

        SmartWatch Watch = new SmartWatch ("Tigran", 15);
        Watch.AddSteps (10);
        Watch.Display ();
        



    }
}