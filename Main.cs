using System; 

public class Program {

  public static void Main(string[] args) {
      Console.WriteLine("Enter side length number 1:");
      int side1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter side length number 2:");
      int side2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter side length number 3:");
      int side3 = Convert.ToInt32(Console.ReadLine());
      if ((side1 + side2) > side3 && (side2 + side3) > side1 && (side3 + side1) > side2)
      {
        Console.WriteLine("Triangle can be formed.");
        if(side1 == side2 && side2 == side3)
        {
          Console.WriteLine("The triangle is Equilateral.");
        }
        else if(side1 != side2 && side2 != side3 && side3 != side1)
        {
          Console.WriteLine("The triangle is Scalene."); 
        }
        else
        {
          Console.WriteLine("The triangle is Isoceles.");
        }
      }
      else Console.WriteLine("Triangle cannot be formed.");
    
  }
}