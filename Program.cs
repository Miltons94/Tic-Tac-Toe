using System.Runtime.CompilerServices;

internal class Program
{
	private int player=0;
	static void Main(string[] args){

		//game board 3x3
		int size=3;
		char[,] board = new char[size,size];

		while (true)
		{
			//clear console and render the game board
			Console.Clear();
			RenderBoard(board);

			//get cordinates from player
			(int x,int y) = Player.GetCordinates(board);
			char move = Player.GetSymbol();
			if (Cell.IsEmpty(board, x, y))	// reduntant if. (always true) :D
			{
				board[x,y]=move;
			}

			//check for a winner
			if (GameLogic.CheckWin(board, move))
			{
				Console.WriteLine($"Player {move} has won!");
				break;
			}
			
			if (GameLogic.IsDraw(board))
			{
				Console.WriteLine("Its a draw!");
				break;
			}
		}
	}

	//function to render Board 
	static void RenderBoard(char[,] board)
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
