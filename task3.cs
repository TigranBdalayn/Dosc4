// Task 3: File Download Simulation
// Task: Create a class FileDownload with:
// Constructor that prints "Download started".
// Add a destructor that prints "Download completed".
// In Main(), create an object inside a method and observe when the destructor is called.

using System;


class FileDownload {
    public FileDownload () {
        Console.WriteLine ("\nDownload started\n");
    }
    ~FileDownload () {
        Console.WriteLine ("\nDowbload completed\n");
    }

}
class Program {
    static void StartDownload () {
        FileDownload file = new FileDownload (); 

        
    }
    public static void Main (string[] args) {

        StartDownload ();
        GC.Collect ();
        GC.WaitForPendingFinalizers ();



    }

    
}