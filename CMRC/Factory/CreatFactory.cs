using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using IDAL;

namespace Factory
{
   public class CreatFactory
    {
        public static ICategories Categories()
        {
            return (ICategories)Assembly.Load("DAL").CreateInstance("DAL.Categories");
        }
        public static ICustomers Customers()
        {
            return (ICustomers)Assembly.Load("DAL").CreateInstance("DAL.Customers");
        }
        public static IOrderDetails OrderDetails()
        {
            return (IOrderDetails)Assembly.Load("DAL").CreateInstance("DAL.OrderDetails");
        }
        public static IOrders Orders()
        {
            return (IOrders)Assembly.Load("DAL").CreateInstance("DAL.Orders");
        }
        public static IProducts Products()
        {
            return (IProducts)Assembly.Load("DAL").CreateInstance("DAL.Products");
        }
        public static IReviews Reviews()
        {
            return (IReviews)Assembly.Load("DAL").CreateInstance("DAL.Reviews");
        }
        public static IShoppingCart ShoppingCart()
        {
            return (IShoppingCart)Assembly.Load("DAL").CreateInstance("DAL.ShoppingCart");
        }
       

    }
}
