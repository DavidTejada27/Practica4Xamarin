﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4Xamarin.Model
{
   public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number) 
        {
            Name = name;
            Number = number;
        }

        public Contact()
        {
        }
    }
}
