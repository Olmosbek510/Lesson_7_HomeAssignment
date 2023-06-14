using System.Text;
using System.Threading.Tasks;
namespace Objects_and_classes
{
	class Book
	{
		//Class attributes
		public string Title;
		public string author;
		public int pages;
	}
	class Car
	{
		public string name, brand, model,color;
		public int year, milage, engine_size,number_of_seats;
		//Constructors
		public Car(string name)
		{
			Console.WriteLine(name);
		}
	}
}

