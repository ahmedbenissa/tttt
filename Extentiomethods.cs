using PS.Domaine;
namespace ExtentionMethods{
    public static class MyExtensions
    { 
        public static String Upper(String str)
        {
           return str.ToUpper();
        }
        public static Boolean InCategory(Product p,category c)
        {
            var query= (from product in  c.Products where product.productId==p.productId select product  ).ToList();
           if(query.Count()>0)
              return true;
            else 
              return false;
        }
    }

}