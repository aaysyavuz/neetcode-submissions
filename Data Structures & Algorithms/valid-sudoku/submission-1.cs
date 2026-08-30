public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < board.Length; i++) {
            HashSet<char> hs = new HashSet<char>();

            for (int j = 0; j < board[i].Length; j++) {
                if (Char.IsDigit(board[i][j])) {
                    if (!hs.Add(board[i][j])) {
                        return false;
                    }
                }
            }
        }

        for (int i = 0; i < board.Length; i++) {
            HashSet<char> hs = new HashSet<char>();

            for (int j = 0; j < board[i].Length; j++) {
                if (Char.IsDigit(board[j][i])) {
                    if (!hs.Add(board[j][i])) {
                        return false;
                    }
                }
            }
        }

        for (int i = 0; i < board.Length; i += 3) {
            for (int j = 0; j < board[i].Length; j += 3) {
                HashSet<char> hs = new HashSet<char>();

                for (int row = 0; row < 3; row++) {
                    for (int col = 0; col < 3; col++) {
                        if (Char.IsDigit(board[i + row][j + col])) {
                            if (!hs.Add(board[i + row][j + col])) {
                                return false;
                            }
                        }
                    }
                }
            }
        }

        return true;
    }
}
