using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDM
{
    class ListProducts
    {
        static void Main(string[] args)
        {
            msdbEntities ctx = new msdbEntities();
            //ctx.Database.Log = Console.WriteLine;

            // Eager load - bring all from products and categories 
            foreach(product p in ctx.products.Include("category"))
            {
                Console.WriteLine( $"{p.ProdName} - {p.category.CatDesc}");
            }
        }
    }
}
