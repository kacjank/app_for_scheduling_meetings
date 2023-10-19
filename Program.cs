using Aplikacja_do_awizacji.Model;

namespace Aplikacja_do_awizacji
{
    internal static class Program
    {
        internal static string ConnectionString =
            "Data Source=LEGION-KJ\\SQLEXPRESS;Initial Catalog=AwizacjeDB;Integrated Security=True;Encrypt=false";
        
        internal static Aplikacja_do_awizacjiDbContext Context = new Aplikacja_do_awizacjiDbContext();
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuView());
        }
    }
}
