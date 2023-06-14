namespace Constructors;

public class GPU
{
   public string B_name { set; get; }
   public string Name { set; get; }
   public double Frequency { set; get; }
   public int CoreCount { set; get; }

   public GPU(string bName, string name, double frequency, int coreCount)
   {
      B_name = bName;
      Name = name;
      Frequency = frequency;
      CoreCount = coreCount;
   }

   public void PrintInfo()
   {
      Console.WriteLine($"Gpu details\nName: {Name}\n" +
                        $"Brand Name: {B_name}\n" +
                        $"Frequency: {Frequency}\n" +
                        $"Core Count: {CoreCount}\n");
   }
}