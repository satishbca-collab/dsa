public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        IList<IList<string>> result = new List<IList<string>>();
        char[,] board = new char[n,n];
        for(int i = 0; i < n; i++){
            for(int j = 0; j  < n; j++){
                board[i,j] = '.';
            }
        }
        helper(result, board, 0);
        return result;
    }

    private void helper(IList<IList<string>> result, char[,] board, int row){
        if(row == board.GetLength(0)){
            result.Add(construct(board));
            return;
        }

        for(int col = 0; col < board.GetLength(1); col++){
            if(isSafe(board, row, col)){
                board[row,col] = 'Q';
                helper(result, board, row+1);
                board[row,col] = '.';
            }
        }
    }

    private bool isSafe(char[,] board, int row, int col){
        for (int i = 0; i < row; i++)
            if (board[i, col] == 'Q')
                return false;
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 'Q')
                return false;
        for (int i = row - 1, j = col + 1; i >= 0 && j < board.GetLength(1); i--, j++)
            if (board[i, j] == 'Q')
                return false;
        return true;
    }

    private IList<string> construct(char[,] board){
        IList<string> result = new List<string>();
        for(int i = 0; i < board.GetLength(0); i++){
            string s = string.Empty;
            for(int j = 0; j < board.GetLength(1); j++){
                s+= board[i,j];
            }
            result.Add(s);
        }
        return result;
    }

    
}