using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApp
{
	class Item<T>
	{
		public T Quality;

		public Item(T quality)
		{
			Quality = quality;
		}

		//public override string ToString()
		//{
		//	return Quality.ToString();
		//}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
