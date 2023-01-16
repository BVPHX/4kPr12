using System;
using System.Collections.Generic;
using System.Text;

namespace Pr12
{
    public class Abonent
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Abonent()
        {
            
        }
        public Abonent(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
    }
}
