
// Läs in namnet
Console.WriteLine("Hej, vad heter du?");

string name = Console.ReadLine();

Console.WriteLine($"Hej {name} ");

if (name == "Micke")
{
  Console.WriteLine("Vad fin du är idag!");

  Console.WriteLine("Vill du byta grejer?");
  string byta = Console.ReadLine();
  
  if (byta == "ja")
  {

  }
}

// else if (name == "Martin")
// {
//   Console.WriteLine("Uuuuuuursch!");
// }
// else
// {
//   Console.WriteLine("Vad ful du är idag!");
// }

Console.ReadLine();