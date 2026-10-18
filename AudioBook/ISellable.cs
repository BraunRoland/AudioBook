using System;
using System.Collections.Generic;
using System.Text;

namespace AudioBook
{
    internal interface ISellable
    {
        public int GetPrice();
        public string GetProductName();
    }
}
