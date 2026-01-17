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
			Render.PrintBoard(board);

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
}
