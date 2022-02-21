using System;
using System.Collections.Generic;

using System.Text.RegularExpressions;
namespace PS.Domaine
{
public class Provider:concept {
    public int id{get;set;}
    public string Username {get;set;}=string.Empty;
    public string Email {get;set;}=string.Empty;
    public string Password { get{
                 return Password;
               }
             set{
                 if(value.Length<=20 && value.Length>=5 )
                    Password=value;
                    else
                    Console.WriteLine("error");
                }}
                
    public string ConfirmPassword 
            {
              get;set;
            }=string.Empty;
    public DateTime creation_date{get;set;} 
    public bool isApproved{get;set;}
     public virtual IList<Product>?Products{get;set;}
     public override void GetDetails()
     {

     }
     public static void setisApproved(Provider p)
     {
         if(p.Password==p.ConfirmPassword)
         {
             p.isApproved=true;
         }
     }
     public static void setisApproved(string confirmedpassword,string password,bool b=false )
     {
       if(password==confirmedpassword)
       {

           b=true;
       }
     }
     public bool login(string e,string p)
     {
         if(Email==e && Password==p)
         {
            return true;
         }
         else 
            return false;
     }
      public bool login(string e,string p,string u)
     {
         //base.login(e,p);
           if(Email==e && Password==p && Username==u)
         {
            return true;
         }
         else 
            return false;
     }
     

}
}