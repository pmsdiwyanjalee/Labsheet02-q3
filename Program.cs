using System;

class TemperatureTracker
{
    private double[] temperatures;

    public TemperatureTracker()
    {
        temperatures = new double[7];
    }

    public void AddTemperature(int day, double temperature)
    {
        if (day >= 1 && day <= 7)
        {
            temperatures[day - 1] = temperature;
        }
        else
        {
            Console.WriteLine("Invalid day. Please enter a day between 1 and 7.");
        }
    }

    public void DisplayWeeklyReport()
    {
        Console.WriteLine("Weekly Temperature Report:");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TemperatureTracker tracker = new TemperatureTracker();

        for (int day = 1; day <= 7; day++)
        {
            Console.Write($"Enter temperature for day {day}: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            tracker.AddTemperature(day, temperature);
        }

        tracker.DisplayWeeklyReport();
    }
}
