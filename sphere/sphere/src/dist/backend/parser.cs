using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace sphere.src.dist.backend
{
    internal class parser
    {
        public static async Task ParseContext(string ctx)
        {
            if (string.IsNullOrEmpty(ctx)) { MessageBox.Show("Invalid context given to parser? Did you modify the source?"); }
            if (ctx.Contains("editmacro:")) { var value = ctx.Replace("editmacro", ""); configuration.EditMacro = value; }
            if (ctx.Contains("prefiremacro:")) { var value = ctx.Replace("prefiremacro", ""); configuration.PrefireMacro = value; }
            if (ctx.Contains("exitbuilding:")) { var value = ctx.Replace("exitbuilding", ""); configuration.ExitBuilding = value; }
            if (ctx.Contains("rcs:")) { var value = ctx.Replace("rcs", ""); configuration.RCS = value; }
            if (ctx.Contains("rcsStrenght:")) { var value = ctx.Replace("rcsStrenght:", ""); configuration.RCSStrenght = Convert.ToInt32(value); }
            if (ctx.Contains("pickbind:")) { var value = ctx.Replace("pickbind:", ""); configuration.PickBind = value; }
            if (ctx.Contains("wallbind:")) { var value = ctx.Replace("wallbind:", ""); configuration.WallBind = value; }
            if (ctx.Contains("editbind:")) { var value = ctx.Replace("editbind:", ""); configuration.EditBind = value; }
            if (ctx.Contains("editstart:")) { var value = ctx.Replace("editstart:", ""); configuration.EditMacroStart = cstk(value); }
            if (ctx.Contains("prefirestart:")) { var value = ctx.Replace("prefirestart:", ""); configuration.PrefireMacroStart = cstk(value); }
            if (ctx.Contains("rcsstart:")) { var value = ctx.Replace("rcsstart:", ""); configuration.RCSMacroStart = cstk(value); }
            if (ctx.Contains("saveconfig")) { configmanager.writeconfig(); }
            if (ctx.Contains("loadconfig")) { configmanager.loadconfig(); }
            if (ctx.Contains("selfdestruct")) { destructor.destroy(); }


            await Task.Delay(1);
        }

        public static Key cstk(string keyString)
        {
            if (Enum.TryParse<Key>(keyString, out Key result))
            {
                return result;
            }
            else
            {
                // If parsing fails we should return None. (This will be bad)
                return Key.None;
            }
        }

        public static bool getValueOf(string x)
        {
            if (x.Contains("true"))
            {
                return true;
            }

            return false;
        }
    }
}
