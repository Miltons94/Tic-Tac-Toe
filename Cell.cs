internal class Cell
{
   //this function returns true if the specified cell is empty
   public static bool IsEmpty(char[,] board,int x,int y) => board[x,y]=='\0';
}