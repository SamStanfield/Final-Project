using System;

class Book{
  public string ISBN{get; set;}
  public string Title{get; set;}
  public string Author{get; set;}
  public string Publishedon{get; set;}
  public string PublishedBy{get; set;}

  public Book(){
    ISBN = "unknown";
    Title = "unknown";
    Author = "unknown";
  }
  
  
  public Book(string ibn, string titl, string Authorinfo)
    {
      ISBN = ibn;
      Title = titl;
      Author = Authorinfo;
      Publishedon = "4/21/2021";
      PublishedBy = "unknown";

      Console.WriteLine(ibn +", " + titl + ",  " +  Authorinfo + ", " + Publishedon + ", " +  PublishedBy);
    }
  
  

    
  

  
}