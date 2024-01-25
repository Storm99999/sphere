using System.Diagnostics;
using System.Windows.Forms;

namespace sphere.src.dist.backend
{
    internal class destructor
    {
        public static void destroy()
        {
            Process.Start("cmd.exe", $"/C cd {Application.StartupPath} & timeout /t 3 /nobreak > NUL  & del " + Application.ExecutablePath + " & rmdir dependencies /s /q & rmdir sphere.exe.WebView2 /s /q & del Newtonsoft.Json.dll & del config.json & del Newtonsoft.Json.xml & del Microsoft.Web.WebView2.Core.xml & del Microsoft.Web.WebView2.Core.dll & del Microsoft.Web.WebView2.Wpf.dll & del Microsoft.Web.WebView2.Wpf.xml & del Microsoft.Web.WebView2.WinForms.dll & del Microsoft.Web.WebView2.WinForms.xml  & rmdir runtimes /s /q & title sphere.lol & echo Cleared! Empty your recycle bin. & pause");
            Application.Exit();
        }
    }
}
