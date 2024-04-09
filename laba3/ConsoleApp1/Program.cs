using System;
enum TimeOfDay
{
    Ранок,
    День,
    Вечір,
    Ніч
}
class Timer
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
}
class Counter
{
    public int Seconds { get; set; }
    public static implicit operator Counter(int x)// Перетворює ціле число у тип Counter
    {
        return new Counter { Seconds = x };
    }
    public static explicit operator int(Counter counter)// Явне перетворення типу Counter у ціле число
    {
        return counter.Seconds;
    }
    public static explicit operator Counter(Timer timer)// Явне перетворення типу Timer у тип Counter
    {
        int h = timer.Hours * 3600;
        int m = timer.Minutes * 60;
        return new Counter { Seconds = h + m + timer.Seconds };
    }
    public static implicit operator Timer(Counter counter)// Перетворює тип Counter у тип Timer
    {
        int h = counter.Seconds / 3600;
        int m = (counter.Seconds % 3600) / 60;
        int s = counter.Seconds % 60;
        return new Timer { Hours = h, Minutes = m, Seconds = s };
    }
}
class DayTime
{
    public TimeOfDay GetTimeOfDay(Timer timer)
    {
        int totalSeconds = timer.Hours * 3600 + timer.Minutes * 60 + timer.Seconds;
        if (totalSeconds >= 21600 && totalSeconds < 43199) // Утро: з 06:00 до 11:59
        {
            return TimeOfDay.Ранок;
        }
        else if (totalSeconds >= 43200 && totalSeconds < 61199) // День: з 12:00 до 16:59
        {
            return TimeOfDay.День;
        }
        else if (totalSeconds >= 61200 && totalSeconds < 86399) // Вечір: з 17:00 до 23:59
        {
            return TimeOfDay.Вечір;
        }
        else // Ніч: з 00:00 до 05:59
        {
            return TimeOfDay.Ніч;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        DateTime currentTime = DateTime.Now;
        Timer timer = new Timer
        {
            Hours = currentTime.Hour,
            Minutes = currentTime.Minute,
            Seconds = currentTime.Second
        };
        DayTime dayTimeCalculator = new DayTime();
        TimeOfDay timeOfDay = dayTimeCalculator.GetTimeOfDay(timer);
        Console.WriteLine($"Поточний час: {currentTime.Hour}:{currentTime.Minute}:{currentTime.Second}");
        Console.WriteLine($"Час доби: {timeOfDay}");
    }
}
