class Render
{
   //method to render game board to the console
   public static void PrintBoard(char[,] board)
   {
      //write column heads
		for(int col = 0; col < board.GetLength(1); ++col)
		{
			Console.Write($"\t{col}");
		}
		Console.WriteLine();
		//outer loop for printing rows
		for(int x = 0; x < board.GetLength(0); x++)
		{
			//show row num
			Console.Write($"{x}\t");	
			//for printing columns
			for(int y = 0; y < board.GetLength(1); y++)
			{
				//check if cell is null or not
				if (board[x, y] != '\0')
				{
					Console.Write($"{board[x,y]}\t");
				}
				else
				{
					Console.Write("?\t");
				}
			}
			Console.WriteLine();
		}
   }
}