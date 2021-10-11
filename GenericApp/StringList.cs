using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApp
{
	class StringList
	{
		private string[] arr;

		public StringList()
		{
			arr = new string[0];
		}

		public void Add(string num)
		{
			Array.Resize(ref arr, arr.Length + 1);
			arr[arr.Length - 1] = num;
		}

		public string[] GetArray()
		{
			return arr;
		}

		public int Count
		{
			get
			{
				return arr.Length;
			}
		}
	}
}
