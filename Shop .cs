using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularCustomer
{
    public class Shop
    {
        private ObservableCollection<Item> _products = new();


        public void Add(string name, int id)
        {
            var item = new Item
            {
                Name = name,
                Id = id
            };
            _products.Add(item);
        }



        public void Remove(int id)
        {
            var item = _products.First(Item => Item.Id == id);
            if (item != null)
            {
                _products.Remove(item);
            }
        }
        public void ChangeItem()
        {
            _products.CollectionChanged += OnItemChanged;
        }

        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            var collection = (ObservableCollection<Item>)sender;
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Товар \"{Form(e.NewItems)}\" появился в продаже");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Товар \"{Form(e.OldItems)}\" был снят с продажи");
                    break;
            }
        }

        private static string Form (IList values)
        {
            var a = new Item[values.Count];
            values.CopyTo(a, 0);
            var str = new StringBuilder();
            foreach (var item in a)
            {
                str .Append($"{item.Name}");
            }
            return str.ToString();
        }
       
    }
}
