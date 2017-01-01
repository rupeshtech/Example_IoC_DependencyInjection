using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_IoC_DependencyInjection
{
    public class BurgerOrderWithOutDI
    {
        private IBurgerVendor _burgerVendor;

        public BurgerOrderWithOutDI(string burgerVendorType)
        {
            if (burgerVendorType == "BurgerKing")
                _burgerVendor = new BergerKing();
            else
                _burgerVendor = new McDonalds();
        }

        public void PrepareBurger()
        {
            _burgerVendor.PreppareBurger();
        }
    }
}
