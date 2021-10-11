using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApp
{
	class CustomList<T> /* where T: struct*/
	{
		private T[] arr;

		public CustomList()
		{
			arr = new T[0];
		}

		public void Add(T item)
		{
			Array.Resize(ref arr, arr.Length + 1);
			arr[arr.Length - 1] = item;
		}

		public T[] GetArray()
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
