using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_IoC_DependencyInjection
{
    class BurgerOrderWithDI
    {
        private IBurgerVendor _burgerVendor;

        public BurgerOrderWithDI(IBurgerVendor burgerVendor)
        {
            this._burgerVendor = burgerVendor;
        }

        public void PrepareBurger()
        {
            _burgerVendor.PreppareBurger();
        }
    }
}
