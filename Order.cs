using System;
using System.Collections.Generic;
using System.Text;

namespace JoiningDataOOPLab
{
    class Order
    {
        //fields
        private string _customerName;
        private string _item;
        private decimal _price;
        private int _quantity;
        //properties
        public string CustomerName
        {
            get { return this._customerName; }
            set { this._customerName = value; }
        }
        public string Item
        {
            get { return this._item; }
            set { this._item = value; }
        }
        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public int Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }
        //constructor
        public Order(string customerName, string item, decimal price, int quantity)
        {
            this._customerName = customerName;
            this._item = item;
            this._price = price;
            this._quantity = quantity;
        }

        public override string ToString()
        {
            return $"{this._item}";
        }
    }
}
