﻿
namespace AlexCrome.Telligent.TableOfContents
{
	public class HierarchyItem<T>
	{
		public HierarchyItem(T item)
		{
			Item = item;
			Children = new HierarchyCollection<Heading>();
		}

		public T Item { get; }
        public HierarchyCollection<Heading> Children { get; }
    }


}
