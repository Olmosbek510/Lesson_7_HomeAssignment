using CutsomCar.Enums;

namespace CutsomCar;

public class MyCar
{
   public string Name { set; get; }
   public string BrandName { set; get; }
   public int Year { set; get; }
   public int Mileage { set; get; }
   public EColor color { set; get; }
   public bool IsNew { set; get; }
   public bool IsCrashed { set; get; }
   public int TopSpeed { set; get; }
   public Brake brake { set; get; }
   public Engine engine { set; get; }
   public Tires tires { set; get; }

   ///default
   public MyCar(){}
   
   public MyCar(string name, string brandName, int year,string color, int mileage, bool isNew, bool isCrashed, int topSpeed)
   {
      Name = name;
      BrandName = brandName;
      Year = year;
      color = color;
      Mileage = mileage;
      IsNew = isNew;
      IsCrashed = isCrashed;
      TopSpeed = topSpeed;
   }

   public void PrintInfo()
   {
      Console.WriteLine($"Name: {Name}\n" +
                        $"Brand Name: {BrandName}\n" +
                        $"Year: {Year}\n" +
                        $"Color: {color}\n" +
                        $"Mileage: {Mileage}\n" +
                        $"Is New: {IsNew}\n" +
                        $"Is Crashed: {IsCrashed}\n" +
                        $"Top Speed: {TopSpeed}\n");
      if(brake is not null)brake.PrintInfo();
      if(tires is not null)tires.PrintInfo();
      if(engine is not null)engine.PrintInfo();
   }
}