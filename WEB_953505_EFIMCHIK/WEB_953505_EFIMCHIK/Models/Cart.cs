using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953505_EFIMCHIK.Entities;

namespace WEB_953505_EFIMCHIK.Models
{
    public class Cart
    {
        public Dictionary<int, CartItem> Items { get; set; }
        public Cart()
        {
            Items = new Dictionary<int, CartItem>();
        }
        public virtual int Count
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity);
            }
        }

        public virtual int Price
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity *
                (int)item.Value.Auto.Price);
            }
        }

        public virtual void AddToCart(Auto auto)
        {

            if (Items.ContainsKey(auto.AutoId))
                Items[auto.AutoId].Quantity++;
            else
                Items.Add(auto.AutoId, new CartItem
                {
                    Auto = auto,
                    Quantity = 1
                });
        }

        public virtual void RemoveFromCart(int id)
        {
            Items.Remove(id);
        }

        public virtual void ClearAll()
        {
            Items.Clear();
        }
    }
    public class CartItem
    {
        public Auto Auto { get; set; }
        public int Quantity { get; set; }
    }
}
