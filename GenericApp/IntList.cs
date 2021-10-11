using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApp
{
	class IntList
	{
		private int[] arr;

		public IntList()
		{
			arr = new int[0];
		}

		public void Add(int num)
		{
			Array.Resize(ref arr, arr.Length + 1);
			arr[arr.Length - 1] = num;
		}

		public int[] GetArray()
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
