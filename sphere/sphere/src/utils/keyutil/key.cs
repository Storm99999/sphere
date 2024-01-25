using System.Windows.Forms;

namespace sphere.src.utils.keyutil
{
    internal class key
    {
        public static void press(string key)
        {
            SendKeys.SendWait(key);
        }
    }
}
