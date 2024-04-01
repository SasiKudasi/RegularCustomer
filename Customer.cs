using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer
{
    public class Customer
    {
        public void OnItemChanged(Shop shop)
        {
            shop.ChangeItem();
        }        
    }
}
