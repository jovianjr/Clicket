namespace Clicket
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());

           /* Movie @movie = new Movie();
            Event @event = new Event();
            Action action = new Action();

            action.getList(movie);
            action.getList(@event);*/
        }
    }
}