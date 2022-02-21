namespace PS.Domaine
{
    public class category{
      public int categoryId{get;set;}
      public string categoryName{get;set;}=string.Empty;
      public IList<Product>?Products{get;set;}
     
      

    }
}