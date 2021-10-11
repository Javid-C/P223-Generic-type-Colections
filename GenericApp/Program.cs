using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericApp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Class Task
			Vehicle vh = new Vehicle();
			Vehicle motorBike = new MotorBike();
			Vehicle car = new Car();

			Vehicle[] vehicles = { vh, motorBike, car };

			//foreach (Vehicle vehicle in vehicles)
			//{
			//	if (vehicle is MotorBike)
			//	{
			//		MotorBike bike = (MotorBike)vehicle;
			//		Console.WriteLine(bike.Chain);
			//	}
			//	else
			//	{
			//		Console.WriteLine("This item can not casting to Motorbike");
			//	}

			//}
			#endregion

			//Non-Generic class

			//Item item = new Item(3);
			//Console.WriteLine(item.Quality.GetType());

			//Item item1 = new Item('B');

			//Console.WriteLine(item1._quality.GetType());

			//Item item2 = new Item("medium");
			//Console.WriteLine(item2._Quality.GetType());

			//Generic Class

			//Item<int> item = new Item<int>(1);
			//Console.WriteLine(item.Quality.GetType());

			Item<char> item1 = new Item<char>('A');
			//Console.WriteLine(item1.Quality.GetType());

			Item<string> item2 = new Item<string>("Super");
			//Console.WriteLine(item2);



			IntList intList = new IntList();

			intList.Add(5);
			intList.Add(15);
			intList.Add(30);
			intList.Add(22);

			Console.WriteLine(intList.Count);

			Console.WriteLine("numbers: ");

			foreach (var num in intList.GetArray())
			{
				Console.WriteLine(num);
			}

			StringList stringList = new StringList();

			stringList.Add("Hello");
			stringList.Add("world");
			stringList.Add("okay");
			stringList.Add("test");

			Console.WriteLine(stringList.Count);

			Console.WriteLine("string items: ");

			foreach (var str in stringList.GetArray())
			{
				Console.WriteLine(str);
			}

			Computer computer = new Computer("Acer", 2000);
			Computer computer1 = new Computer("Asus", 2500);
			Computer computer2 = new Computer("MSI", 2400.43);

			ComputerList computerList = new ComputerList();

			computerList.Add(computer);
			computerList.Add(computer1);
			computerList.Add(computer2);

			Console.WriteLine(computerList.Count);

			Console.WriteLine("computers: ");

			foreach (var comp in computerList.GetArray())
			{
				Console.WriteLine(comp.Model);
			}


			CustomList<int> customIntList = new CustomList<int>();

			customIntList.Add(78);
			customIntList.Add(63);
			customIntList.Add(21);

			Console.WriteLine("Count: ");
			Console.WriteLine(customIntList.Count);

			Console.WriteLine("customList items: ");
			foreach (int num in customIntList.GetArray())
			{
				Console.WriteLine(num);
			}

			CustomList<string> customStringList = new CustomList<string>();

			customStringList.Add("Vusal");
			customStringList.Add("Ahad");

			Console.WriteLine(customStringList.Count);
			Console.WriteLine("customStringList items: ");

			foreach (string str in customStringList.GetArray())
			{
				Console.WriteLine(str);
			}

			CustomList<Computer> customComputerList = new CustomList<Computer>();
			customComputerList.Add(computer);
			customComputerList.Add(computer1);
			customComputerList.Add(computer2);

			Console.WriteLine(customComputerList.Count);

			Console.WriteLine("CustomComputerList items: ");

			foreach (Computer comp in customComputerList.GetArray())
			{
				Console.WriteLine(comp.Price);
			}

			ArrayList arrayList = new ArrayList();
			arrayList.Add(5);
			arrayList.Add("Hasan");
			arrayList.Add(computer);


			ArrayList arrayList1 = new ArrayList();
			arrayList1.Add("Ahad");
			arrayList1.Add("Ismayil");
			arrayList1.Add(43);

			arrayList.AddRange(arrayList1);


			arrayList.Remove(5);
			arrayList.RemoveAt(1);

			foreach (var arraItem in arrayList)
			{
				Console.WriteLine(arraItem);
			}

			SortedList sortedList = new SortedList();
			sortedList.Add(1, "Lala");
			sortedList.Add(2, "Jamal");
			sortedList.Add(3, "Nurxan");

			foreach (DictionaryEntry item in sortedList)
			{
				Console.WriteLine(item.Key);
			}

			Dictionary<int, string> dictionary = new Dictionary<int, string>();

			dictionary.Add(1, "Nurlan");
			dictionary.Add(2, "Suleyman");
			dictionary.Add(3, "Aqshin");
			dictionary.Add(4, "Lala");

			Dictionary<string, string> dictionaryString = new Dictionary<string, string>();

			dictionaryString.Add("Germany", "Koln, Berlin,Frakfurt");
			dictionaryString.Add("Turkey", "Ankara, Istanbul,Urfa");
			dictionaryString.Add("Azerbaijan", "Kurdermir, Vasmoy,Agcebedi");
			//dictionaryString.Add("Azerbaijan", "Baku, Sumgait,Absheron");
			bool result = dictionaryString.TryAdd("Italy", "Kurdermir, Vasmoy,Agcebedi");

			



			//foreach (var item in dictionary)
			//{
			//	Console.WriteLine(item.Key + " " + item.Value);
			//}

			foreach (var item in dictionaryString)
			{
				Console.WriteLine(item.Key + " " +item.Value);
			}

			if (!result)
			{
				Console.WriteLine("You can not enter the same key");
			}
			else
			{
				Console.WriteLine("You successfully added different key to dictionary");
			}

			Queue<string> queue = new Queue<string>();

			queue.Enqueue("Ahad");
			queue.Enqueue("Vusal");
			queue.Enqueue("Suleyman");

			Console.WriteLine("Dequeue : " + queue.Dequeue());


			Console.WriteLine("Peek: "+queue.Peek());

			Console.WriteLine("Queue list: ");

			foreach (var item in queue)
			{
				Console.WriteLine(item);
			}

			Stack stack = new Stack();

			stack.Push("Vusal");
			stack.Push("Hasan");
			stack.Push("Nurlan");
			stack.Push(computer);

			Console.WriteLine("Pop: "+ stack.Pop());


			foreach (var item in stack)
			{
				Console.WriteLine(item);
			}
		}
	}

	#region Class Task
	class Vehicle
	{
		public string Engine = "Test Engine";
	}

	class MotorBike : Vehicle
	{
		public string Chain = "Test Chain";
	}

	class Car : Vehicle
	{
		public string Seat = "Test Seat";
	}
	#endregion
}
