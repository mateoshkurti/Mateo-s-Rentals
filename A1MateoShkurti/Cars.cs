using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace A1MateoShkurti
{
    class Cars:Vehicles
    {
        public Cars(long id, string name, double rentalPrice, string category, string type) : base(id, name, rentalPrice, category, type)
        {
            
        }
    }
}
