using Aplikacja_do_awizacji.Model;

namespace Aplikacja_do_awizacji
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        //ConnectionString do mojego serwera.
        //  Data Source - serwer,
        //  Initial Catalog - baza, która ma byæ u¿ywana (jeœli takiej nie ma to j¹ tworzy),
        //  Integrated Security=True - wygorzystanie uwierzytelniania Windowsowego przy wchodzeniu do bazy
        //  zamiast tego mo¿na podaæ User ID=sa;Password=haslo"
        internal static string ConnectionString =
            "Data Source=LEGION-KJ\\SQLEXPRESS;Initial Catalog=AwizacjeDB;Integrated Security=True;Encrypt=false";
        
        internal static Aplikacja_do_awizacjiDbContext Context = new Aplikacja_do_awizacjiDbContext();
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuView());
            //Application.Run(new LoggingView());
            ////Application.Run(new WorkerMainCopy());
            //Application.Run(new WorkerMeetingsView());
            ////Application.Run(new WorkerAddGuest());
            //Application.Run(new GuestSign_inView());
        }
    }
}