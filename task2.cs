// Task 2: Flight Reservation System
// Task: Create a class FlightTicket with:
// Fields: passengerName, flightNumber, and seatNumber.
// Add a constructor to initialize these fields.
// In Main(), create a few tickets and print the details.

using System;

class FlightTicket {
    string _flightTicketPassengerName;
    int _flightTicketFlightNumber;
    int _flightTicketSeatNumber;


public string PassengerName {
    get {return _flightTicketPassengerName;}
    set {_flightTicketPassengerName = value;}
}

public int FlightNumber {
    get {return _flightTicketFlightNumber;}
    set {_flightTicketFlightNumber = value;}
}
public int SeatNumber {
    get {return _flightTicketSeatNumber;}
    set {_flightTicketSeatNumber = value;}
}

public FlightTicket(string passengername, int flightnumber, int seatnumber) {
    _flightTicketPassengerName = passengername;
    _flightTicketFlightNumber = flightnumber;
    _flightTicketSeatNumber = seatnumber;
}
public void Display () {

    Console.WriteLine ($"Passanger Name: {_flightTicketPassengerName} ");
    Console.WriteLine ($"Flight Number: {_flightTicketFlightNumber}");
    Console.WriteLine ($"Seat Number: {_flightTicketSeatNumber}\n");

}
}
class Program {
    static void Main (string[] args) {


        FlightTicket[] FlightTickets = new FlightTicket [3];
        FlightTickets [0] = new FlightTicket ("Tigran", 1, 2);
        FlightTickets [1] = new FlightTicket ("Gagik", 3, 4);
        FlightTickets [2] = new FlightTicket ("Arman", 5 , 6);

        for (int i = 0; i < FlightTickets.Length; ++i) {
            FlightTickets [i].Display ();
        }
    }
}