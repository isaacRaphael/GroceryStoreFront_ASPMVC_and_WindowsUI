using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Core;
using Store.Core.DataAccess;
using Store.Core.Services;

namespace GroceryStoreFrront
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var ProductRepo = new ProductRepository();

            Application.Run(new Form2(new PopulateProductService(ProductRepo), new LoginService(new LoginRepository()),new AddProdToDbService(ProductRepo)));

            //Application.Run(new Grocery_store(new Store.Core.Store()));
        }
    }
}
