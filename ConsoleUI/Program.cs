using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Newtonsoft.Json;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             BrandManager middleCategoryManager = new BrandManager(new EfBrandDal());
            var result = middleCategoryManager.GetAll();
            if (result.Success == true)
            {
                foreach (var category in middleCategoryManager.GetAll().Data)
                {
                    Console.WriteLine(category.Name.ToString());
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
    
}
//CategoryManagerTest();
    //MiddleCategoryManagerTest();
    /*SubCategoryManager subCategoryManager = new SubCategoryManager(new EfSubCategory());
    var result = subCategoryManager.GetSubCategoryDetails();
    if (result.Success == true)
    {
        foreach (var category in subCategoryManager.GetSubCategoryDetails().Data)
        {
            Console.WriteLine("Kategori: " + category.CategoryName + ", Orta Kategori:" +
                              category.MiddleCategoryName + ", Alt Kategori:" + category.SubCategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }*/
    //private static void MiddleCategoryManagerTest()
    //{
    //MiddleCategoryManager middleCategoryManager = new MiddleCategoryManager(new EfMiddleCategory());
    //var result = middleCategoryManager.GetMiddleCategoryDetails();
    //    if (result.Success == true)
    //{
    //    foreach (var category in middleCategoryManager.GetMiddleCategoryDetails().Data)
    //    {
    //        Console.WriteLine(category.MiddleCategoryName + " , " + category.CategoryName);
    //    }
    //}
    //else
    //{
    //    Console.WriteLine(result.Message);
    //}
    //}

    //private static void CategoryManagerTest()
    //{
    //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    //    foreach (var category in categoryManager.GetAll().Data)
    //{
    //    Console.WriteLine(category.CategoryName);
    //}
    //}



        