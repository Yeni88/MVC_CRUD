using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        
        [HttpPost]
        public ActionResult GetPRoducts() {
            try
            {
                using (var product_temp = new CRUD_Service.CRUDClient())
                {
                    return Json(product_temp.GetProducts()); 

                }
            }
            catch (Exception x)
            {

                throw;
            }
        }
    }
}