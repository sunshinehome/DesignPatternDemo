﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class OperationAdd : Operation
    {
        public OperationAdd() : base() { }

        public OperationAdd(double n1, double n2) : base(n1, n2)
        {
        }

        public override double GetResult()
        {
            return Number1 + Number2;
        }
    }

}
