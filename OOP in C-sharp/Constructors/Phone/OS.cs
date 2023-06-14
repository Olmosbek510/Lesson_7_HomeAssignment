namespace Constructors;

public class OS
{
   public string B_name { set; get; }
   public string Name { set; get; }
   public DateTime ReleaseDate { set; get; }

   public OS(string bName, string name, DateTime releaseDate)
   {
      B_name = bName;
      Name = name;
      ReleaseDate = releaseDate;
   }

   public void PrintInfo()
   {
      Console.WriteLine($"OS details\n" +
                        $"Name: {Name}\n" +
                        $"Brand Name: {B_name}\n" +
                        $"Release date: {ReleaseDate}\n");
   }
}