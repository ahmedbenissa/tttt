using System;
using System.Collections.Generic;
namespace PS.Domaine
{
    public class chemical:Product{
        public string city{get;set;}=string.Empty;
        public string labname{get;set;}=string.Empty;
        public string streetaddress{get;set;}=string.Empty;
        public override void GetmyType()
     {
         Console.WriteLine("Chemical");
     }
        
    }
}