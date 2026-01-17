
internal class GameLogic
{

   // function to check for win
   public static bool CheckWin(char[,] board,char lastMove)
   {
      for(int i = 0; i < board.GetLength(0); i++)
      {
         if((board[i,0]==lastMove && board[i,1]==lastMove && board[i,2]==lastMove)|| //check rows
            (board[0,i]==lastMove && board[1,i]==lastMove && board[2,i]==lastMove)|| //check columns
            (board[0,2]==lastMove && board[1,1]==lastMove && board[2,0]==lastMove)|| //check right diagonal
            (board[0,0]==lastMove && board[1,1]==lastMove && board[2, 2] == lastMove))//check left diagonal
         {
            return true;
         } 
      }
      return false;
   }

   //function to check for a draw
   public static bool IsDraw(char[,] board){
      return Array.TrueForAll(board.Cast<char>().ToArray(), c => c!='\0');
   }
}