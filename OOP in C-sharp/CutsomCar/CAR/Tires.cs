namespace CutsomCar;

public class Tires
{
  public string Name { set; get; }
  public string BrandName { set; get; }
  public string Material { set; get; }
  public int Size { set; get; }

  public Tires(string name, string brandName, string material, int size)
  {
    Name = name;
    BrandName = brandName;
    Material = material;
    this.Size = size;
  }

  public void PrintInfo()
  {
    Console.WriteLine($"Tire Details: \n" +
                      $"Name: {Name}\n" +
                      $"Brand Name: {BrandName}\n" +
                      $"Material: {Material}\n" +
                      $"Size: {Size}\n");
  }
  
}