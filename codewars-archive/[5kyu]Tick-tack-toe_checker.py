#https://www.codewars.com/kata/525caa5c1bf619d28c000335/python
def is_solved(board):
    for i in range(3):
        if board[i][0] == board[i][1] == board[i][2] != 0 or board[0][i] == board[1][i] == board[2][i] != 0:
            return board[i][0]

    if board[0][0] == board[1][1] == board[2][2] != 0 or board[0][2] == board[1][1] == board[2][0] != 0:
        return board[1][1]

    for row in board:
        for cell in row:
            if cell == 0:
                return -1
    return 0
