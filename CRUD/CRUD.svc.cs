﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_CRUD.Entities.Models;

namespace CRUD
{
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRUD" in code, svc and config file together.
// NOTE: In order to launch WCF Test Client for testing this service, please select CRUD.svc or CRUD.svc.cs at the Solution Explorer and start debugging.
    
public class CRUD : ICRUD
{

    /// <summary>
    /// GET PRODUCTS
    /// </summary>
    /// <returns>
    /// List ProductEntity
    /// </returns>
    public List<ProductEntity> GetProducts()
    {
        try
        {
            ConnectionDB ConnectionManagerInstance = new ConnectionDB();
            using (IDbConnection connection = ConnectionManagerInstance.GetConnection("ConnDB"))
            {
                var resultadoGP = connection.Query<ProductEntity, SupplierEntity, CategoryEntity, ProductEntity>(
                        "sp_ShowAllProducts",
                        (p, s, c) =>
                        {
                            p.Supplier = s;
                            p.Category = c;
                            return p;
                        },
                        splitOn: "SupplierID,CategoryID",
                        commandType: CommandType.StoredProcedure).ToList<ProductEntity>();

                return resultadoGP;

            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
          
    }
       
    /// <summary>
    /// ADD PRODUCTS
    /// </summary>
    /// <param name="product"></param>
    /// <returns>
    /// Product
    /// </returns>
    public ProductEntity AddProducts(ProductEntity product){
        try
        {
            ConnectionDB ConnectionManagerInstance = new ConnectionDB();
            using (IDbConnection connection = ConnectionManagerInstance.GetConnection("ConnDB"))
            {
                var resultadAP = connection.QuerySingleOrDefault<ProductEntity>("sp_addNewProducts",

                    param: new
                    {
                        product.ProductName,
                        product.SupplierID,
                        product.CategoryID,
                        product.QuantityPerUnit,
                        product.UnitPrice,
                        product.UnitsInStock,
                        product.UnitsOnOrder,
                        product.ReorderLevel,
                        product.Discontinued
                    },
                        commandType: CommandType.StoredProcedure);

                return resultadAP;
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
            
    }

    /// <summary>
    /// GET CATEGORIES
    /// </summary>
    /// <returns>
    /// List CategoryEntity
    /// </returns>
    public List<CategoryEntity> GetCategories()
    {
        try
        {
            ConnectionDB connection = new ConnectionDB();
            using (IDbConnection conn = connection.GetConnection("ConnDB")) {

                var resultadoGP = conn.Query<CategoryEntity>(
                        "sp_ShowCategories",
                        commandType: CommandType.StoredProcedure).ToList<CategoryEntity>();

                return resultadoGP;
                
            }
        }
        catch (Exception ex)
        {

            throw new Exception (ex.Message);
        }
    }

    /// <summary>
    /// GET SUPPLIER
    /// </summary>
    /// <returns>
    /// List SupplierEntity
    /// </returns>
    public List<SupplierEntity> GetSuppliers()
    {
        try
        {
            ConnectionDB connection = new ConnectionDB();
            using (IDbConnection conn = connection.GetConnection("ConnDB"))
            {

                var resultadoGS = conn.Query<SupplierEntity>(
                        "sp_ShowSuppliers",
                        commandType: CommandType.StoredProcedure).ToList<SupplierEntity>();

                return resultadoGS;

            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }
    
    /// <summary>
    /// DELETE PRODUCTS
    /// </summary>
    /// <param name="ID"></param>
    /// <returns>Product Identity</returns>
    public ProductEntity DeleteProducts(int? ID)
    {
        try
        {

            ConnectionDB ConnectionManagerInstance = new ConnectionDB();
            using (IDbConnection connection = ConnectionManagerInstance.GetConnection("ConnDB"))
            {
                var resultadAP = connection.QuerySingleOrDefault<ProductEntity>("sp_DiscontinuedProduct",

                    param: new
                    {
                        @ProductID_s = ID,
                        Disc = 0
                    },
                        commandType: CommandType.StoredProcedure);

                return resultadAP;
                }
            }
        catch (Exception ex)
        {

            throw new Exception (ex.Message);
        }
    }

    /// <summary>
    /// Update Products
    /// </summary>
    /// <param name="product"></param>
    /// <returns>ProductEntity</returns>
    public ProductEntity UpdateProducts(ProductEntity product)
    {
        try
        {
            ConnectionDB ConnectionManagerInstance = new ConnectionDB();
            using (IDbConnection connection = ConnectionManagerInstance.GetConnection("ConnDB"))
            {
                var resultadUP = connection.QuerySingleOrDefault<ProductEntity>("sp_UpdateProduct",

                    param: new
                    {
                        ProductID  = product.ProductID,
                        ProductName = product.ProductName,
                        SupplierID = product.SupplierID,
                        CategoryID = product.CategoryID,
                        UnitPrice = product.UnitPrice
                    },
                        commandType: CommandType.StoredProcedure);

                return resultadUP;
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }
        
    /// <summary>
    /// Consult Products
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>ProductEntity</returns>
    public ProductEntity ConsultProducts(int? Id)
    {
        try
        {
            ConnectionDB ConnectionManagerInstance = new ConnectionDB();
            using (IDbConnection connection = ConnectionManagerInstance.GetConnection("ConnDB"))
            {
                var resultadCP = connection.QuerySingleOrDefault<ProductEntity>("sp_consultProduct",

                    param: new
                    {
                        index = Id
                    },
                        commandType: CommandType.StoredProcedure);

                return resultadCP;
            }

        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }
}
}
