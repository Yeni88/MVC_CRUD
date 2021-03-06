﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_CRUD.Entities.Models;

namespace CRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRUD" in both code and config file together.
    [ServiceContract]
    public interface ICRUD
    {
        [OperationContract]
        List<ProductEntity> GetProducts();

        [OperationContract]
        List<CategoryEntity> GetCategories();

        [OperationContract]
        List<SupplierEntity> GetSuppliers();

        [OperationContract]
        ProductEntity AddProducts(ProductEntity product);

        [OperationContract]
        ProductEntity DeleteProducts(int? ID);

        [OperationContract]
        ProductEntity UpdateProducts(ProductEntity product);

        [OperationContract]
        ProductEntity ConsultProducts(int? Id);

    }
}
