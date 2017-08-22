using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class ItemIdComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            return x.ItemId - y.ItemId;
        }
    }


    class Item //: IComparable<Item>
    {
        public int ItemId {get; set;}
        public string Name {get; set;}
        public int Price {get; set;}

        //public int CompareTo(Item item)
        //{
        //    return ItemIdComparer - Item.ItemId;
        //}
    }

    class List2
    {
            static void Main(string[] args)
            {
                List<Item> listitem = new List<Item>();
                listitem.Add(new ClassDemo.Item {ItemId = 100, Name = "Mobile", Price = 123});

                listitem.Add(new ClassDemo.Item {ItemId = 50, Name = "laptop", Price = 2345});

                listitem.Add(new ClassDemo.Item {ItemId = 400, Name = "mouse", Price =567});

		//obj need to be created
                ItemIdComparer comp = new ItemIdComparer();
                listitem.Sort(comp);
                //listitem.Sort();

                foreach (var item in listitem)
	            {
		           Console.WriteLine(item.ItemId + " " + item.Name + " " + item.Price);
	            }
            }
    }
}
