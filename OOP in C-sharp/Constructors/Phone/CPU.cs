namespace Constructors;

public class CPU
{
   public DateOnly ReleaseDate { set; get; }
   public string Name { set; get; }
   public string B_name { set; get; }
   public int CountCore { set; get; }
   public double Frequency { set; get; }

   //default
   public CPU(){}
  
   //Constructor
   public CPU(DateOnly releaseDate, string name, string bName, int countCore, double frequency)
   {
      ReleaseDate = releaseDate;
      Name = name ?? throw new ArgumentNullException(nameof(name));
      B_name = bName ?? throw new ArgumentNullException(nameof(bName));
      CountCore = countCore;
      Frequency = frequency;
   }

   public void PrintInfo()
   {
      Console.WriteLine($"\nCPU INFO\n" +
                        $"Release Date: {ReleaseDate}\n" +
                        $"Name: {Name}\n" +
                        $"Brand Name: {B_name}\n" +
                        $"Count Core: {CountCore}\n" +
                        $"Frequency: {Frequency}\n");
   }
}