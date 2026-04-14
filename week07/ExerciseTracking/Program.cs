using System;

class Program
{
     static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 4.8)); // km
        activities.Add(new Cycling("04 Nov 2022", 45, 20)); // kph
        activities.Add(new Swimming("05 Nov 2022", 40, 30)); // laps

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}