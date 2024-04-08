using System;
class Time
{
    public int Hour { get; set; }// Година
    public int Minute { get; set; }// Хвилина

    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
    }
    public override bool Equals(object obj)// Перевизначення методу Equals для порівняння об'єктів класу Time
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Time other = (Time)obj;
        return Hour == other.Hour && Minute == other.Minute;
    }
    public override int GetHashCode()// Перевизначення методу GetHashCode для отримання хеш-коду об'єкту
    {
        return Tuple.Create(Hour, Minute).GetHashCode();
    }
    public override string ToString()// Перевизначення методу ToString для отримання рядкового представлення об'єкту
    {
        return $"Час: {Hour}:{Minute}";
    }
}
class Day
{
    public Time CurrentTime { get; set; }// Поточний час
    public Day(Time currentTime)
    {
        CurrentTime = currentTime;
    }
    public void PrintCurrentTime()// Метод для виведення поточного часу у консоль
    {
        Console.WriteLine(CurrentTime.ToString());
    }
    public string CalculateTimeOfDay()// Метод для визначення часу доби на основі поточного часу
    {
        if (CurrentTime.Hour >= 5 && CurrentTime.Hour < 12)
        {
            return "Ранок";
        }
        else if (CurrentTime.Hour >= 12 && CurrentTime.Hour < 18)
        {
            return "День";
        }
        else if (CurrentTime.Hour >= 18 && CurrentTime.Hour < 22)
        {
            return "Вечір";
        }
        else
        {
            return "Ніч";
        }
    }
}