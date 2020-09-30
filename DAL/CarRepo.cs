﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class CarRepo: BaseRepo<Car> {
        public CarRepo() : base("Bikes", "Cars") {
        }
    }
}