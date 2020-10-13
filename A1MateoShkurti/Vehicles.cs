using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace A1MateoShkurti
{
    class Vehicles
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _rentalPrice;
        public double RentalPrice
        {
            get { return _rentalPrice; }
            set { _rentalPrice = value; }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private string _type;
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _isAvailable="YES";
        public String IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        public Vehicles(long id, string name, double rentalPrice, string category, string type)
        {
            Id = id;
            Name = name;
            RentalPrice = rentalPrice;
            Category = category;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Id,10} || "+
                $" { Name,31} || " +
                $" { RentalPrice,20:C} || " +
                $" { Category,10} || " +
                $" {Type,10} || " +
                $" {IsAvailable,10}";
        }

    }
}
