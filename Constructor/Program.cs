using Constructor;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

RealEstate navana = new("Navana Probani", "Mirpur-11, Dhaka-1216");

Console.WriteLine(navana.Name);
navana.Name="Navana Probani Ridgedale";

Console.WriteLine("Updated Name: " + navana.Name);