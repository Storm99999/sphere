using Newtonsoft.Json;
using System.IO;

namespace sphere.src.dist.backend
{
    internal class configmanager
    {
        public static void writeconfig()
        {
            var savefile = new
            {
                EditBind = configuration.EditBind,
                EditMacro = configuration.EditMacro,
                PrefireMacro = configuration.PrefireMacro,
                ExitBuilding = configuration.ExitBuilding,
                RCS = configuration.RCS,
                RCSStrenght = configuration.RCSStrenght,
                PickBind = configuration.PickBind,
                WallBind = configuration.WallBind,
                EditMacroStart = configuration.EditMacroStart.ToString(),
                PrefireMacroStart = configuration.PrefireMacroStart.ToString(),
                RCSMacroStart = configuration.RCSMacroStart.ToString(),
            };

            string valid_json = JsonConvert.SerializeObject(savefile);
            File.WriteAllText("config.json", valid_json);
        }

        public static void loadconfig()
        {
            string filename = "config.json";


            configuration.EditBind = jsonprovider.GetResult(filename, "EditBind");
            configuration.EditMacro = jsonprovider.GetResult(filename, "EditMacro");
            configuration.PrefireMacro = jsonprovider.GetResult(filename, "PrefireMacro");
            configuration.ExitBuilding = jsonprovider.GetResult(filename, "ExitBuilding");
            configuration.RCS = jsonprovider.GetResult(filename, "RCS");
            configuration.RCSStrenght = int.Parse(jsonprovider.GetResult(filename, "RCSStrenght"));
            configuration.PickBind = jsonprovider.GetResult(filename, "PickBind");
            configuration.WallBind = jsonprovider.GetResult(filename, "WallBind");
            configuration.EditMacroStart = parser.cstk(jsonprovider.GetResult(filename, "EditMacroStart"));
            configuration.PrefireMacroStart = parser.cstk(jsonprovider.GetResult(filename, "PrefireMacroStart"));
            configuration.RCSMacroStart = parser.cstk(jsonprovider.GetResult(filename, "RCSMacroStart"));

        }
    }
}
