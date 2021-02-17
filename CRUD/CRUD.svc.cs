using Dapper;
using MVC_CRUD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRUD" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CRUD.svc or CRUD.svc.cs at the Solution Explorer and start debugging.
    public class CRUD : ICRUD
    {
        public List<Product> GetProducts()
        {
            ConnectionDB ConnectionManagerInstance = new ConnectionDB();
            using (IDbConnection connection = ConnectionManagerInstance.GetConnection("ConnDB"))
            {
                var resultado = connection.Query<Product, Supplier, Category, Product>(
                     "sp_ShowAllProducts",
                     (p, s, c) =>
                     {
                         p.supplier = s;
                         p.category = c;
                         return p;
                     },
                     splitOn: "SupplierID,CategoryID",
                     commandType: CommandType.StoredProcedure);
                return resultado.ToList<Product>();

            }
        }
    }
}
