using Constructors.Enums;

namespace Constructors;

public class MobilePhone
{
   public string B_name { set; get; }
   public string Name { set; get; }
   public double Size { set; get; }
   public int Weight { set; get; }
   public bool isNew { set; get; }
   public bool isWaterProof { set; get; }
   public int Memory{ set; get; }
   public int Ram { set; get; }
   public Ecolor color { set; get; }
   public CPU Cpu { set; get; }
   public GPU Gpu { set; get; }
   public OS Os { set; get; }
   public Screen Screen { set; get; }

   //default
   public MobilePhone(){}

   //Constuctor
   public MobilePhone(string bName, string name, double size, int weight, bool isNew, bool isWaterProof, int memory,int ram, Ecolor color)
   {
      B_name = bName;
      Name = name;
      Size = size;
      Weight = weight;
      this.isNew = isNew;
      this.isWaterProof = isWaterProof;
      Memory = memory;
      Ram = ram;
      this.color = color;
   }

   public void PrintInfo()
   {
      Console.WriteLine($"\nBrand Name: {B_name}\n" +
                        $"Name: {Name}\n" +
                        $"Size: {Size}\n" +
                        $"Weight: {Weight}grams\n" +
                        $"Is New: {isNew}\n" +
                        $"Is WaterProof: {isWaterProof}\n" +
                        $"Color: {color}\n" +
                        $"Memory: {Memory}\n" +
                        $"Ram: {Ram}\n");
      if(Cpu is not null)Cpu.PrintInfo();
      if(Gpu is not null)Gpu.PrintInfo();
      if(Os is not null) Os.PrintInfo();
      if(Screen is not null)Screen.PrintInfo();
   }
   
}