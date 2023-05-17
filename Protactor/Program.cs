using Protractor.Utilities;
namespace Protractor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = Utilities.Globals.strGetDirectory;
            Utilities.Globals.stringConn = ConnectionDB.xml_conn(path);
            string conn = Utilities.Globals.stringConn;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}