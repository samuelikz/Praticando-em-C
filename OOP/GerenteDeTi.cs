﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class GerenteDeTI : Gerente
    {
        public override void Reajustar()
        {
            this.Salario += 2000;
        }
    }
}
