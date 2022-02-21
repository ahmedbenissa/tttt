using System.Linq;
using System.Collections.Generic;
namespace PS.Domaine
{
 
 public class Management{
     public List<Provider> Providers =new List<Provider>();
      public List<Product> Products =new List<Product>();
      public List<Product> list =new List<Product>();
    
  public List<Provider> getproviderbyname (String name){
     return (from prv in Providers where prv.Username.Contains(name) select prv ).ToList();
   }
 public  void retrieveproductsbyProvider(int id)
   {
      
       var results= (from prv in Providers where prv.id==id select prv);
      Console.WriteLine(results.ToList()[0].Products.Count());
      
   }
  public Provider getProviderById(int id){
       return (from prv in Providers where prv.id==id select prv).Last();
   }
  public List<Product> GetChemicalProducts(double price)
   {
       return (from product in Products where product is chemical && product.price>price  
       select product).ToList();
   }
   public List<Product> Get5ChemicalProducts(double price)
   {
    var q= (from product in Products where product is chemical && product.price>price  
       select product).ToList();
        List<Product> list =new List<Product>();
        list.Add(q[0]);
        list.Add(q[1]);
        list.Add(q[2]);
        list.Add(q[3]);
        list.Add(q[4]);
       return list; 

   }
 public  List<Product> GetProducts(double price){
       return (from prd in Products where  prd.price>price select prd).Skip(2).ToList();
   }
public   double GetAveragePrice(){
       return (from prd in Products select prd.price).Average();
   }
 public  Product GetMaxPrice(){
       var result=(from p in Products select p.price).Max();
     return (from prd in Products where prd.price==result select prd).ToList()[0];
          
   }
public   Product GetMinPrice()
   {
       return (from prd in Products orderby prd.price select prd).ToList()[0];
   }
 public  int GetCountProducts(String city)
   {
    return (from prd in Products where prd is chemical && ((chemical)prd).city==city select prd)
    .ToList().Count();
   }
 public  List <Product>GetChemicalCity(){
       return (from prd in Products  where prd is chemical orderby ((chemical)prd).city select prd)
       .ToList();
   }
   public  List <Product>GetgroupbyChemicalCity(){
         
         var results= from prd in Products where prd is chemical group prd by ((chemical)prd).city ;
        foreach (var cityGroup in results)
{
    Console.WriteLine("city Group: {0}", cityGroup .Key); //Each group has a key 
             
    foreach(Product p in cityGroup) // Each group has inner collection
        {Console.WriteLine("product Name: {0}", p.name);
        list.Add(p);}
}
           return list;

     }
    
 }
}