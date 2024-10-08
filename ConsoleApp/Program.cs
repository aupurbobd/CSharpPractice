// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;
using System.Text;
using ConsoleApp;

Console.WriteLine("Hello, World!");
Console.WriteLine("I was facing a problem about naming the solution file, I have solved the problem by searching the google.");
Console.WriteLine("I didn't understand how the problem was solved!");
Console.WriteLine("how is not restarting dotnet when file is being changed!");

int code;
code=70;
Console.WriteLine(code*5);
Console.WriteLine("Now I understand how the dotnet watch run command works");
var love="I love you!";

Console.WriteLine(love+5);

Console.WriteLine($"{love} {code*5} times!");
var hate=love.Replace("love","do not hate");
Console.WriteLine($"{hate} Rather {love} {code*100} times!");

StringBuilder newstring = new StringBuilder();
newstring.Append("this is a test string");
Console.WriteLine(newstring);
newstring.Replace("test","good");
Console.WriteLine(newstring);
newstring.Remove(0,5);
Console.WriteLine(newstring);

string[] names=["Jahangir", "Neela", "Wasee", "Zahraa"];
Console.WriteLine(names);
for(int i=0; i<names.Length;i++){
    Console.Write($"{names[i]} ");
}
Console.Write("\n");
foreach(string name in names)
{
    Console.Write($"{name} ");
}
Console.Write("\n");

for(int i=0; i<names.Length;i++){
    if(names[i]=="Neela")
    {
        names[i]="Anjumonowara";
    }
}
//foreach(string name in names)
Console.WriteLine("Use of Linq:");
names.ToList().ForEach((i)=>
{
    Console.Write($"{i} ");
});
Console.Write("\n");

Console.WriteLine("Use of Array:");

//names.ToList().ForEach((i)=>
Array.ForEach(names, i=>
{
    Console.Write($"{i} ");
});
Console.Write("\n");


var moviename="Spiderman";

switch (moviename)
{
    case "Superman":
        Console.WriteLine("My all time favorite!");
        break;
    case "Spiderman":
        Console.WriteLine("I like it");
        break;
    default:
        Console.WriteLine("Not a favorite one");
        break;
        
}

var sportsPerson="Lionel Messi";

var result= sportsPerson switch
{
    "Cristiano Ronaldo"=>"I like Cristiano Ronaldo",
    "Lionel Messi"=>"Lionel Messi is my ultimate favorite player",
    _=>"all are good players"
};
Console.WriteLine(result);


Family son = new Family();
son.Age=9;
son.Name="Abdullahil Wasee";
Console.WriteLine(son.Name);
Console.WriteLine(son.Age);


// FamilyMembers son = new FamilyMembers();

// son.Name="Abdullahil Wasee";
// son.Age=9;
// son.IsStudent=true;

//FamilyMembers girl = new FamilyMembers();
//girl.Name="Zahraa Al Tehzeeb";
// girl.Age=7;
// girl.IsStudent=true;

// Console.WriteLine(girl.Name);
// Console.WriteLine(son.Age);

RealEstate Karankokatu = new()
{
    Address="Karankokatu 4, 53810 Lappeenranta"
};

Console.WriteLine(Karankokatu.Address);