using System.Runtime.CompilerServices;

internal class Program
{
	private static int player=0;
	static void Main(string[] args){

		//game board 3x3
		int size=3;
		char[,] board = new char[size,size];

		//GAME LOOP
		while (true)
		{
			//clear console and render the game board
			Console.Clear();
			Render.PrintBoard(board);

			//prompt player
			Console.WriteLine($"Player {(player%2)+1}'s turn ");
			//get cordinates from player and checks if the cell is null
			(int x,int y) = Player.GetCordinates(board);
			char move = (player%2==0)? 'X':'O';
			board[x,y]=move;
			player++;
			
			//check for a winner
			if (GameLogic.CheckWin(board, move))
			{
				Console.WriteLine($"Player {(--player%2)+1} has won!");
				break;
			}
			//check for draw
			if (GameLogic.IsDraw(board))
			{
				Console.WriteLine("Its a draw!");
				break;
			}
		}
	}
}
