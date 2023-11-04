#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA2241 // Provide correct arguments to formatting methods
#pragma warning disable IDE0090 // New expression can be simplified
#pragma warning disable IDE0057 // Substring can be simplified

namespace AxonicaFalls
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AxonicaFallsTray());
        }
    }
}