using System;
using Models;
using Interfaces;
using Services;
namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            var apartment = new Apartment();
            var applianceManager = new ApplianceManager(apartment);
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Додати прилад");
                Console.WriteLine("2. Включити прилад");
                Console.WriteLine("3. Вiдключити прилад");
                Console.WriteLine("4. Розрахувати загальну потужнiсть");
                Console.WriteLine("5. Вийти");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введiть назву приладу:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введiть потужнiсть приладу:");
                        double power = Convert.ToDouble(Console.ReadLine());
                        applianceManager.AddAppliance(new Fridge(name, power));
                        break;
                    case "2":
                        Console.WriteLine("Введiть назву приладу, який хочете включити:");
                        string nameToPlugIn = Console.ReadLine();
                        applianceManager.PlugInAppliance(nameToPlugIn);
                        break;
                    case "3":
                        Console.WriteLine("Введiть назву приладу, який хочете вiдключити:");
                        string nameToUnplug = Console.ReadLine();
                        applianceManager.UnplugAppliance(nameToUnplug);
                        break;
                    case "4":
                        Console.WriteLine($"Загальна потужнiсть: {apartment.CalculateTotalPower()}");
                        break;
                    case "5":
                        exit = true;
                        break;
                }
            }
        }
    }
}