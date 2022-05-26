// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Globalization;

class Program
{
  static void Main(string[] args)
  {
    string date = "Jan 20,2019";
    CultureInfo info = new CultureInfo("en-Us");
    DateTime conDate = DateTime.Parse(date, info);
    Console.WriteLine(conDate);
    Console.ReadLine();
  }
}