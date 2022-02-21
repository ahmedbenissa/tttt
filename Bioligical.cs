using System;
using System.Collections.Generic;
namespace PS.Domaine
{
public class bio:Product {
    
    public string herbs{get;set;}=string.Empty;
        public override void GetmyType()
     {
         Console.WriteLine("Bioligical");
     }
        
}
}