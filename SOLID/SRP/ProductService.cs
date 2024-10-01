using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    /*
     * Uygulamada ürün nesnesi ile ilgili tüm işleri bu nesne yönetir.
     */
    public class ProductService
    {
        public int CreateNewProduct(string name, decimal price)
        {
            var connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";

            var commanText = "Insert into Products (ProductName, UnitPrice) values (@name,@price)";

            Dictionary<string, object> commandParams = new Dictionary<string, object>();
            commandParams.Add("@name", name);
            commandParams.Add("@price", price);
            DBOperations dbOperations = new DBOperations(connectionString);

            var affectedRows = dbOperations.ExecuteCommand(commanText, commandParams);                  

            return affectedRows;


        }

        public void ChangeProductPrice(int productId, decimal newPrice)
        {

        }

        public bool IsStockAvailable(int productId) => true;


    }
}
