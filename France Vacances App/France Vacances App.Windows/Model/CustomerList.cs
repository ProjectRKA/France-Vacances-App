using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Model
{
    class CustomerList
    {
        private string x; //username and password connected by magic to textboxes
        private string y;

        List<Customer> list;

        public CustomerList()
        {
            list = new List<Customer>();
        }

        public void Register()
        {
            list.Add(new Customer(x, y));
        }


    }
}