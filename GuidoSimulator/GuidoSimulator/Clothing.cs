﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    public class Clothing : Item
    {
        public Clothing(int id, String name, String description, decimal price, Image image, ItemEffect itemEffect) : base(id, name, description, price, image, itemEffect)
        {

        }
    }
}