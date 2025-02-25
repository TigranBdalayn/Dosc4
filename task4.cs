// ask 4: Weather Forecast System
// Task: Create a class WeatherReport with:
// Fields: temperature, humidity, and weatherCondition.
// In Main(), create an array of WeatherReport objects for different cities and display the reports.

using System;
class WeatherReport {
    public int Temperature { get; set; }
    int Humidity { get; set; }
    string WeatherCondition { get; set; }

    public WeatherReport (int temperature, int humidity, string weatherCondition) {
        Temperature = temperature;
        Humidity = humidity;
        WeatherCondition = weatherCondition;   
    }

    public void Display () {
        Console.WriteLine ($"Temperatur: {Temperature}\nHumidity: {Humidity}\nWeatherCondition: {WeatherCondition}\n");
    }
} 


class Program {
    static void Main (string[] args) {

        WeatherReport[] WeatherReports = new WeatherReport[3];
        WeatherReports[0] = new WeatherReport (1, 2, "XX");
        WeatherReports[1] = new WeatherReport (3, 4, "YY");
        WeatherReports[2] = new WeatherReport (5, 6, "ZZ");

        for (int i = 0; i < WeatherReports.Length; ++i) {
            WeatherReports[i].Display ();
        }
        

    }
}