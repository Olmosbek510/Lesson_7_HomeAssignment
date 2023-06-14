using CutsomCar.Enums;

namespace CutsomCar;

public class Brake
{
   public string Name { set; get; }
   public string BrandName { set; get; }
   public EBrakeMaterial Material { set; get; }
   public decimal Price { set; get; }
   public EColor Brk_color { set; get; }

   public Brake(string name, string brandName, EBrakeMaterial material, decimal price, EColor brkColor)
   {
      Name = name;
      BrandName = brandName;
      Material = material;
      Price = price;
      Brk_color = brkColor;
   }

   public void PrintInfo()
   {
      Console.WriteLine($"Brake Details:\n" +
                        $"Name: {Name}\n" +
                        $"Brand Name: {BrandName}\n" +
                        $"Material: {Material}\n" +
                        $"Price: {Price}\n" +
                        $"Color: {Brk_color}");
   }
}