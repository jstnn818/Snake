public class Board
{
	private char[,] gameboard = new char[20, 50];
	private Player player = new Player();

	public Board()
	{
		InitBoard();
	}

	private void InitBoard()
	{
		for(int r = 0; r < gameboard.GetLength(0); r++)
		{
			for(int c = 0; c < gameboard.GetLength(1); c++)
			{
                gameboard[r, c] = ' ';
                if (r == 0 ||  c == 0 || r == gameboard.GetLength(0) - 1 || c == gameboard.GetLength(1) - 1)
				{
					gameboard[r, c] = '#';
				}
			}
		}
	}

	private void SetBoard()
	{
		int r = player.position[0];
		int c = player.position[1];
		gameboard[r, c] = '@';
	}

	public void PrintBoard()
	{
        for (int i = 0; i < gameboard.GetLength(0); i++)
        {
            for (int j = 0; j < gameboard.GetLength(1); j++)
            {
                Console.Write(gameboard[i, j]);
            }
            Console.WriteLine();
        }
    }

	public void Run()
	{
        ConsoleKeyInfo keyInfo;
		bool playerAlive = true;
        do
		{
            Console.Clear();
			SetBoard();
            PrintBoard();
            keyInfo = Console.ReadKey(true);
			if ((Control)keyInfo.Key == Control.Up || (Control)keyInfo.Key == Control.Down || 
				(Control)keyInfo.Key == Control.Left || (Control)keyInfo.Key == Control.Right)
			{
				int r = player.position[0];
				int c = player.position[1];
                playerAlive = player.Move(keyInfo.Key, gameboard.GetLength(0), gameboard.GetLength(1));
				gameboard[r, c] = ' ';
			}

        } while (playerAlive && keyInfo.Key != ConsoleKey.Escape);
    }
}
