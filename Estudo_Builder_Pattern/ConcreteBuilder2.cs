﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Builder_Pattern
{
    public class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
