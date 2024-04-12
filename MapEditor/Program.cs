using System;

namespace MapEditor
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            LevelEditor form = new LevelEditor();
            
            form.game = new Game1(
            form.pctSurface.Handle,
            form,
            form.pctSurface);
            form.Show();
            form.game.Run();
        }

    }
#endif
}
