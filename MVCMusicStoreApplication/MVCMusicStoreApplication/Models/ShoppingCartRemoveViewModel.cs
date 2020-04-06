using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStoreApplication.Models
{
    public class ShoppingCartRemoveViewModel
    {
        public int DeleteId;

        public decimal CartTotal;

        public int ItemCount;

        public string Message;

        public static implicit operator ShoppingCartRemoveViewModel(ShoppingCartViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}