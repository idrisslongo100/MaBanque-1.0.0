using System.Runtime;
using System.Runtime.Remoting;


namespace MaBanque_1._0._0
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
            Application.Run(new Transaction()); // Point d'entr�� de l'application
        }
    }
}