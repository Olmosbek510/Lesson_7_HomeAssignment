namespace CutsomCar;

public class Engine
{
   public string Name { set; get; }
   public string BrandName { set; get; }
   public DateTime RelaseDate { set; get; }
   public double Size { set; get; }
   public int HorsePower { set; get; }
   public int CylinderCount { set; get; }

   public Engine(string name, string brandName, DateTime relaseDate, double size, int horsePower, int cylinderCount)
   {
      Name = name;
      BrandName = brandName;
      RelaseDate = relaseDate;
      Size = size;
      HorsePower = horsePower;
      CylinderCount = cylinderCount;
   }

   public void PrintInfo()
   {
      Console.WriteLine($"Engine Details: \n" +
                        $"Name: {Name}\n" +
                        $"Brand Name: {BrandName}\n" +
                        $"Release date: {RelaseDate}\n" +
                        $"Size: {Size}\n" +
                        $"Horse Power: {HorsePower}\n" +
                        $"Cylinder Count: {CylinderCount}\n");
   }
}