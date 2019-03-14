using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Builder_Pattern
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
