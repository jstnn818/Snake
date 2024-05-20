public class Player
{
	public int[] position = [10, 25];

	public Player()
	{
	}

	public bool Move(ConsoleKey key, int rows, int cols)
	{
		int r = position[0];
		int c = position[1];

		if ((Control)key == Control.Up)
		{
			r -= 1;
		}
		else if ((Control)key == Control.Down)
		{
			r += 1;
		}
		else if ((Control)key == Control.Left)
		{
			c -= 1;
		}
		else
		{
			c += 1;
		}
		if (r <= 0 || c <= 0 || r >= rows - 1 || c >= cols - 1)
		{
			return false;
		}
		position = [r, c];
		return true;
	}
}
