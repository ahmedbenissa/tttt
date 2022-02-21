
namespace PS.Domaine
{
    class Program
    {  /* public int quantity {get; set;}
    public double price {get; set;}
    public int productId {get; set;}
    public string Description {get; set;}=string.Empty;
    public DateTime DateProd {get; set;}
    public virtual category?catg{get;set;}
     public virtual IList<Provider>?Providers{get;set;}*/
        static void Main(string[] args)
        {   
          Management m=new Management();
          
            var P = new Product {
              name="p",
              price=250,
              productId=1,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/02/06)
            };
            var P1 = new Product {
              name="p1",
              price=850,
              productId=10,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/02/06)
            };
            var P2 = new Product {
              name="p2",
              price=50,
              productId=20,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/02/06)
            };
            var P3 = new Product {
              name="p3",
              price=450,
              productId=30,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/02/06)
            };
            var bio=new bio{
                name="bio1",
              price=250,
              productId=1,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/02/06),
              herbs="marijuana"

            };
            var bio2=new bio{
                name="bio2",
              price=150,
              productId=1,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/02/06),
              herbs="marijuana"

            };
            var chemical01= new chemical{
                name="chemical01",
              price=150,
              productId=19,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/05/06),
              city="Toronto",
              labname="lab01",
              streetaddress="a1"
             
            };
             var chemical02= new chemical{
                name="chemical02",
              price=150,
              productId=9,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/05/06),
              city="Toronto",
              labname="lab01",
              streetaddress="a2"
             
            };
              var chemical03= new chemical{
                name="chemical04",
              price=150,
              productId=9,
              Description="this is a godamn product",
              DateProd=new DateTime(2020/05/06),
              city="Boston",
              labname="lab00",
              streetaddress="a2"
             
            };
            var prvd=new Provider
            {
                id=1,
                Username="provider1",
                Email="pr1@gmail.com",
                
            };
            prvd.Products=new List<Product>() {P,bio,bio2,P1,P2,P3,chemical01,chemical02,chemical03};
            m.Providers.Add(prvd);
            m.Products.Add(P);
            m.Products.Add(P1);
            m.Products.Add(P2);
            m.Products.Add(P3);
            m.Products.Add(chemical01);
            m.Products.Add(chemical02);
            m.Products.Add(chemical03);
            P.Providers=new List<Provider>(){prvd};
            P1.Providers=new List<Provider>(){prvd};

            double d=m.GetAveragePrice();
            Product prd= m.GetMaxPrice();
            Product prd0= m.GetMinPrice();
            m.retrieveproductsbyProvider(1);
            List<Product> l=m.GetChemicalCity();
            m.GetgroupbyChemicalCity();
            Console.WriteLine(l.Count());
            
  Console.WriteLine(bio.name+bio.price+bio.Description+bio.DateProd+"herbs="+bio.herbs+""+ prvd.Products.Count());
            prvd.Products.Count();
            Console.WriteLine(d+"**********"+prd.name+"*************"+prd0.name+"******"+m.GetCountProducts("Boston"));
        }
    }
   
}