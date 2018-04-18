using System;

namespace LudumDare41
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
	        using (MainGame game = new MainGame())
	        {
				game.Run();
	        }
        }
    }
}
