using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDM
{
    class ListCategories
    {
        static void Main(string[] args)
        {
            msdbEntities ctx = new msdbEntities();
            // ctx.Database.Log = Console.WriteLine;

            foreach(var cat in ctx.categories)
            {
                Console.WriteLine("****" + cat.CatDesc +  "*******");
                // Get all products for category cat 
                foreach(var p in cat.products)
                {
                    Console.WriteLine(p.ProdName);
                }

            }

        }
    }
}
