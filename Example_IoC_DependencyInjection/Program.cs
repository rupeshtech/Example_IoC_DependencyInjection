using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_IoC_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Without Dependency Injection
            var buregrOrderWithOutDependencyInjection = new BurgerOrderWithOutDI("BurgerKing");
            buregrOrderWithOutDependencyInjection.PrepareBurger();

            var anotherBuregrOrderWithOutDependencyInjection = new BurgerOrderWithOutDI("McDonald");
            anotherBuregrOrderWithOutDependencyInjection.PrepareBurger();

            // With Dependency Injection
            IBurgerVendor burgerKing = new BergerKing();
            var buregrOrderWithDependencyInjection = new BurgerOrderWithDI(burgerKing);
            buregrOrderWithDependencyInjection.PrepareBurger();

            IBurgerVendor mcDonald = new McDonalds();
            var anotherBuregrOrderWithDependencyInjection = new BurgerOrderWithDI(mcDonald);
            anotherBuregrOrderWithDependencyInjection.PrepareBurger();

            Console.ReadLine();
        }
    }



    public interface IBurgerVendor
    {
        void PreppareBurger();
    }

    public class McDonalds : IBurgerVendor
    {
        public void PreppareBurger()
        {
            Console.WriteLine($"Burger from McDonald");
            // prepare Burger from McDonald;
        }
    }

    public  class BergerKing:IBurgerVendor
    {
        public void PreppareBurger()
        {
            Console.WriteLine($"Burger from Burgerking");
            // prepare burger from burger king
        }
    }
}
