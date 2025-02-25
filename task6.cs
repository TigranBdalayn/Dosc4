// Task 6: Movie Rating System
// Task: Create a class Movie with:
// Private field _rating.
// Add a property Rating that:
// Allows setting a value between 1 and 5.
// Prints a warning if an invalid value is entered.
// In Main(), test the property with valid and invalid values.

using System;

class Movie {

    private int _reting;
    public string Title { get; set; }

    public int Reting {
        get {return _reting;}
        set{
            if (value >= 0 && value <= 5) {
                _reting = value;
            }
            else {
                Console.WriteLine ("\nInvalide reting! Please enter a value between 1 and 5.\n");
            }
        }
    }
    public Movie (string title) {
        Title = title;
        _reting = 0;
    }
    
    public void Display () {
        Console.WriteLine ($"\nMovie: {Title}\nReting: {_reting}/5"); 
    }

}

class Program {
    static void Main (string[] args) {

        Movie Movie1 = new Movie ("Inception");
        Movie1.Reting = 4;
        Movie1.Display();

        Movie Movie2 = new Movie ("Titanic");
        Movie2.Reting = 7;
        Movie2.Display();

        Movie Movie3 = new Movie ("Interstellar");
        Movie3.Reting = 5;
        Movie3.Display();
    }
}


