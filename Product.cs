using System;
using System.Collections.Generic;
namespace PS.Domaine
{
public class Product:concept {
    public string name {get; set;} =string.Empty;
    
    public int quantity {get; set;}
    public double price {get; set;}
    public int productId {get; set;}
    public string Description {get; set;}=string.Empty;
    public DateTime DateProd {get; set;}
    public virtual category?catg{get;set;}
     public virtual IList<Provider>?Providers{get;set;}
     public virtual void GetmyType()
     {
         
     }
     public override void GetDetails()
     {
         
     }

}
}