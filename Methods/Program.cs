using Methods;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! I am a new programmer in C#");

RealEstate navanaProbani = new()
{
    Name="Navana Probani Ridgedale",
    Address = "13, Mirpur-11, Dhaka-1216",
    Price=12000000,
    SquareFootage=2280 
};

int sqrftPrice;
sqrftPrice=navanaProbani.CalculatePricePerFoot();
Console.WriteLine(sqrftPrice);
Console.WriteLine(navanaProbani.Name);


int? nullValue = null;
Console.WriteLine(nullValue);
// bool isNull = null;
string str1="null";
Console.WriteLine(str1);

if(str1 is not null)
{
    Console.WriteLine(str1.Length);
}

Console.WriteLine(str1 ?? "no value");
Console.WriteLine(str1 is not null ? "value" : "no value");


