using sphere.src.dist.backend;
using sphere.src.utils.keyutil;
using sphere.src.utils.mouseutil;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace sphere
{
    public partial class SphereMain : Form
    {
        public Thread macroThread = new Thread(doWork);
        public Thread rcsThread = new Thread(doWork2);
        public SphereMain()
        {
            InitializeComponent();

            macroThread.SetApartmentState(ApartmentState.STA);
            macroThread.Start();
            rcsThread.SetApartmentState(ApartmentState.STA);
            rcsThread.Start();
        }

        [STAThread]
        static void doWork()
        {
            while (true)
            {
                if (parser.getValueOf(configuration.EditMacro))
                {
                    if (Keyboard.IsKeyDown(configuration.EditMacroStart))
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            key.press(configuration.EditBind);
                            mouse.click(1);
                        }
                    }
                }

                if (parser.getValueOf(configuration.PrefireMacro))
                {
                    if (Keyboard.IsKeyDown(configuration.PrefireMacroStart))
                    {
                        mouse.click(1);
                        key.press(configuration.WallBind);
                        mouse.click(1);
                        if (parser.getValueOf(configuration.ExitBuilding))
                        {
                            key.press(configuration.PickBind);
                        }
                    }
                }
            }
        }

        [STAThread]
        static void doWork2()
        {
            while (true)
            {
                Thread.Sleep(7);
                if (parser.getValueOf(configuration.RCS))
                {
                    if (Keyboard.IsKeyDown(configuration.RCSMacroStart))
                    {
                        mouse.moverel(0, configuration.RCSStrenght);
                    }
                }
            }
        }



        private async void loginpage_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {

            string mess4= e.TryGetWebMessageAsString();
            await parser.ParseContext(mess4);
        }

        private async void loginpage_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            // ;3
            await loginpage.CoreWebView2.ExecuteScriptAsync("window.external = { invoke: function(arg) { window.chrome.webview.postMessage(arg); } };");
        }

        private async void SphereMain_Load(object sender, EventArgs e)
        {
            await loginpage.EnsureCoreWebView2Async(null);

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\dependencies\\html\\";
            string htmlFilePath = Path.Combine(baseDirectory, "mainview.html");
            loginpage.Source = new Uri(htmlFilePath);
            loginpage.CoreWebView2InitializationCompleted += loginpage_CoreWebView2InitializationCompleted;
            loginpage.WebMessageReceived += loginpage_WebMessageReceived;
        }

        private void loginpage_Click(object sender, EventArgs e)
        {

        }

        private void SphereMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            macroThread.Abort();
            rcsThread.Abort();
        }
    }
}
