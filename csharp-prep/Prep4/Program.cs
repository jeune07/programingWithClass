using System;
class Program
{
  static void Main(string[] args)
    {
      Assigments assigments= new Assigments("John", "C#");
      Console.WriteLine(assigments.GetSommary());

      MathAssigment mathAssigment = new MathAssigment("jeune", "C#", "1.", "1-10");


WrittindAssigment writtindAssigment = new WrittindAssigment("jeune", "C#", "1.");

      Console.WriteLine(mathAssigment.GetHomeWorkList());
      Console.WriteLine(writtindAssigment.information());
        
    }
}



