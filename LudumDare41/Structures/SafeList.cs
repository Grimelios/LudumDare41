using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudumDare41.Structures
{
	public class SafeList<T>
	{
		private List<T> mainList;
		private List<T> addList;
		private List<T> removeList;

		public SafeList()
		{
			mainList = new List<T>();
			addList = new List<T>();
			removeList = new List<T>();
		}

		public IEnumerable<T> MainList => mainList;

		public void Add(T item)
		{
			addList.Add(item);
		}

		public void Add(T[] items)
		{
			addList.AddRange(items);
		}

		public void Add(List<T> items)
		{
			addList.AddRange(items);
		}

		public void Remove(T item)
		{
			removeList.Add(item);
		}

		public void Remove(T[] items)
		{
			removeList.AddRange(items);
		}

		public void Remove(List<T> items)
		{
			removeList.AddRange(items);
		}

		public void ProcessChanges()
		{
		}
	}
}
