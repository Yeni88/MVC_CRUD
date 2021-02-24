using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD.Entities.Models;


namespace MVC_CRUD.Controllers
{
public class ProductController : Controller
{
    // GET: Product

    /// <summary>
    /// GET PRODUCTS
    /// </summary>
    /// <returns>
    /// ActionResult
    /// </returns>
    [HttpPost]
    public ActionResult GetProducts()
    {
        try
        {
            using (var product_temp = new CRUD_Service.CRUDClient())
            {
                //var get = product_temp.GetProducts();
                return Json(product_temp.GetProducts());

            }
        }
        catch (Exception x)
        {

            throw;
        }
    }

    /// <summary>
    /// GET CATEGORIES 
    /// </summary>
    /// <returns>
    /// ActionResult
    /// </returns>
    [HttpPost]
    public ActionResult GetCategories()
    {
        try
        {
            using (var cat = new CRUD_Service.CRUDClient())
            {
                return Json(cat.GetCategories());
            }
        }
        catch (Exception x)
        {

            throw new Exception(x.Message);
        }
    }

    /// <summary>
    /// GET SUPPLIERS
    /// </summary>
    /// <returns>
    /// ActionResult
    /// </returns>
    public ActionResult GetSuppliers()
    {
        try
        {
            using (var supp = new CRUD_Service.CRUDClient())
            {
                return Json(supp.GetSuppliers());
            }
        }
        catch (Exception x)
        {

            throw new Exception(x.Message);
        }
    }

    /// <summary>
    /// ADDPRODUCTS
    /// </summary>
    /// <param name="product"></param>
    /// <returns>
    /// ActionResult
    /// </returns>
    [HttpPost]
    public ActionResult AddProducts(ProductEntity product)
    {
        try
        {
            using (var product_temp = new CRUD_Service.CRUDClient())
            {
                return Json(product_temp.AddProducts(product));

            }
        }
        catch (Exception x)
        {

            throw new Exception(x.Message);
        }
    }
    /// <summary>
    /// Descontinuar productos
    /// </summary>
    /// <param name="ID"></param>
    /// <returns>ActionResult</returns>
    [HttpPost]
    public ActionResult DeleteProducts([Microsoft.AspNetCore.Mvc.FromBody] int? ProductID)
    {
        try
        {
            using (var product_temp = new CRUD_Service.CRUDClient())
            {
                return Json(product_temp.DeleteProducts(ProductID));

            }
        }
        catch (Exception x)
        {
            throw new Exception(x.Message);
        }
    }

    /// <summary>
    /// Update Products
    /// </summary>
    /// <param name="product"></param>
    /// <returns>ActionResult</returns>
    [HttpPost]
    public ActionResult UpdateProducts(ProductEntity product)
    {
        try
        {
            using (var product_temp = new CRUD_Service.CRUDClient())
            {
                return Json(product_temp.UpdateProducts(product));

            }
        }
        catch (Exception x)
        {

            throw new Exception(x.Message);
        }
}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult ConsultProducts([Microsoft.AspNetCore.Mvc.FromBody] int? ProductID)
    {
        try
        {
            using (var product_temp = new CRUD_Service.CRUDClient())
            {
                return Json(product_temp.ConsultProducts(ProductID));

            }
        }
        catch (Exception x)
        {

            throw new Exception(x.Message);
        }
    }
    }
    }