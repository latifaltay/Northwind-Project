﻿// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();

//CategoryTest();



static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    //foreach (var product in productManager.GetByUnitPrice(50, 100))
    //{
    //    Console.WriteLine(product.ProductName);
    //}


    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + " / " + product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}