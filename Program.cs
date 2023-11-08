// See https://aka.ms/new-console-template for more information
using lab2.constructions;
using lab2.constructions.Models;
using System;

class Program
{
    static void Main(string[] args)
     {
        // Używając konstruktora z parametrami, tworzymy nowy obiekt klasy Construction
        Construction myConstruction = new Construction(32.0f, 23.0f, 3, 6, "brick");

        // Ustawienie nowej wartości właściwości BuildMaterial
        myConstruction.BuildMaterial = TypeOfMaterial1.Wood;
        var inputParam = new CreateConstructionDto();
        var constr3 = new CreateConstructionDto()
        {
            Height = 23,
            Width = 12,
            Entrances = 1,
            HumanCapacity = 1,
            BuildMaterial = TypeOfMaterial1.Wood
        };
        // Wypisanie kilku właściwości obiektu myConstruction
        Console.WriteLine("Construction Details:");
        Console.WriteLine($"Height: {myConstruction.Height} meters");
        Console.WriteLine($"Width: {myConstruction.Width} meters");
        Console.WriteLine($"Entrances: {myConstruction.Entrances}");
        Console.WriteLine($"Human Capacity: {myConstruction.HumanCapacity}");
        Console.WriteLine($"Build Material: {constr3.BuildMaterial}");
    }

}
