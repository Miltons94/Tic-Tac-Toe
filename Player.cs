internal class Player
{
   
   //get cordinates
   public static (int,int) GetCordinates(char[,] board)
   {
      while (true)
      {
         //get x cordinate
         Console.WriteLine("Enter the X cordinate (0-2): ");
         if(!int.TryParse(Console.ReadLine(),out int x) || x < 0 || x > 2)
         {
            Console.WriteLine("Enter a valid X cordinate between (0-2): ");
            continue;
         }

         //get y cordinate
         Console.WriteLine("Enter the Y cordinate (0-2): ");
         if(!int.TryParse(Console.ReadLine(),out int y)||y < 0 || y > 2)
         {
            Console.WriteLine("Enter a valid y cordinate between (0-2): ");
            continue;
         }

         //check if cell with specified cordinates is empty
         if (!Cell.IsEmpty(board, x, y))
         {
            Console.WriteLine("The specified cell is already filled!, try another cell!");
            continue;
         }
         else
         {
            return (x,y);
         }   
      } 
   }
}