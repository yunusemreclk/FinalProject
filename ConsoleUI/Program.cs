using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();
//CategoryManager CategoryManager = new CategoryManager(new EfCategoryDal());
//foreach (var category in CategoryManager.GetAll().Data)
//{
//    Console.WriteLine(category.CategoryName);
//}
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetails();
    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " /" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}
//ProductManager productManager=new ProductManager(new EfProductDal());
//foreach (var p in productManager.GetAll().Data)

//    Console.WriteLine(p.ProductName);