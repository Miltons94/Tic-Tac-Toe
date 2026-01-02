internal class Program{
    static void Main(string[] args){

        char[,] board = new char[3,3];

        while (true)
        {
            //get x value (row)
            Console.WriteLine("Enter the x cordinate of your move (0-2): ");
            if (!int.TryParse(Console.ReadLine(), out int x) || x > 2 || x < 0)
            {
                Console.WriteLine("Please enter a valid move between 0-2: ");
                continue;
            }

            //get y value (column)
            Console.WriteLine("Enter the y cordinate of your move (0-2): ");
            if(!int.TryParse(Console.ReadLine(),out int y) || y > 2 || y < 0)
            {
                Console.WriteLine("Please enter a valid move between 0-2: ");
                continue;
            }
            
            if(!char.TryParse(Console.ReadLine()?[0].ToString(),out char move))
            {
                Console.WriteLine("Please enter a valid move ( O or X ): ");
                continue;
            }
            
            if(board[x,y]=='\0') board[x,y] = move;
            else
            {
                Console.WriteLine("Cell is already filled, try another!");
            }

            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    Console.WriteLine(board[i,j]);
                }
            }
            if(Array.TrueForAll(board.Cast<char>().ToArray(),c => c != '\0'))
            {
                Console.WriteLine("Game Over!");
                break;
            }
        }
    }
}
