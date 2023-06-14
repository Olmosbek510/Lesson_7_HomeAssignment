using Constructors.Enums;

namespace Constructors;

public class Screen
{
   public string B_name { set; get; }
   public string Name { set; get; }
   public int Frequency { set; get; }
   public EScreen Type { set; get; }
   public string Protection { set; get; }

   public Screen(string bName, string name, int frequency, EScreen type, string protection)
   {
      B_name = bName;
      Name = name;
      Frequency = frequency;
      Type = type;
      Protection = protection;
   }

   public void PrintInfo()
   {
      Console.WriteLine("\nScreen details \n" +
                        $"Name: {Name}\n" +
                        $"Brand Name: {B_name}\n" +
                        $"Frequency: {Frequency}\n" +
                        $"Type: {Type}\n" +
                        $"Protection: {Protection}\n");
   }
}