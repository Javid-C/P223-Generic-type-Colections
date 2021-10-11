using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApp
{
	class Computer
	{
		public int Barcode;
		public string Model;
		public double Price;
		public static int count=1;

		public Computer(string model,double price)
		{
			Barcode = count;
			Model = model;
			Price = price;
			count++;
		}
	}
}
