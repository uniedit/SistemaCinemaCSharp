using Npgsql;

namespace SistemaCinema {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new Acesso());
        }

        
    }
}
