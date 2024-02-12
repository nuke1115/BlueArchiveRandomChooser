using System;
using System.Data;
using System.IO;
using AboutCommand;
using AboutConsole;
using AboutLoader;

namespace BlueArchiveRandomChooser
{
    internal class Program : IProgramTermination
    {
        private static bool Running = true;
        private object Result;
        private ushort StudentsCount;
        private ushort SchoolsCount;
        private ushort SkillsCount;
        private ushort EquipmentsCount;
        private List<string> StudentsData;
        private List<string> SchoolsData;
        private List<string> SkillsData;
        private List<string> EquipmentsData;
        private Dictionary<string, List<string>> LoadedDataBases = new Dictionary<string, List<string>>();
        private Dictionary<string, ushort> LoadedDatasCount = new Dictionary<string, ushort>();
        
        

        private IInputManager InputManager = new InputManager();
        private IConsolePrintManager<object> ConsolePrintManager = new ConsolePrintManager<object>();
        private ILoadAssetManager loadAssetManager = new LoadAssetManager();
        private ICommandManager commandManager = new CommandManager();
        private string ThisPath = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf("\\BlueArchiveRandomChooser\\") + "\\BlueArchiveRandomChooser\\".Length);

        static void Main()
        {
            Program program = new Program();
            program.Initializer();
            program.Start();
        }

        private void Start()
        {
            string[] Command;
            while (Running)
            {
                ConsolePrintManager.ConsoleLinePrint();
                Command = InputManager.GetCommandInput();
                Result = commandManager.CommandRunner(Command,LoadedDataBases,LoadedDatasCount);
                ConsolePrintManager.ConsoleResultPrint(Result);
            }
        }

        private void Initializer()
        {
            StudentsData = loadAssetManager.LoadStudentsDataBase(ThisPath);
            SchoolsData = loadAssetManager.LoadSchoolsDataBase(ThisPath);
            SkillsData = loadAssetManager.LoadSkillsDataBase(ThisPath);
            EquipmentsData = loadAssetManager.LoadEquipmentsDataBase(ThisPath);

            StudentsCount = (ushort)StudentsData.Count();
            SchoolsCount = (ushort)SchoolsData.Count();
            SkillsCount = (byte)SkillsData.Count();
            EquipmentsCount = (byte)EquipmentsData.Count();

            LoadedDataBases.Add("StudentsData",StudentsData);
            LoadedDataBases.Add("SchoolsData", SchoolsData);
            LoadedDataBases.Add("SkillsData", SkillsData);
            LoadedDataBases.Add("EquipmentsData", EquipmentsData);

            LoadedDatasCount.Add("StudentsCount", StudentsCount);
            LoadedDatasCount.Add("SchoolsCount", SchoolsCount);
            LoadedDatasCount.Add("SkillsCount", SkillsCount);
            LoadedDatasCount.Add("EquipmentsCount", EquipmentsCount);

            Console.Title = "BlueArchive Random Chooser v1.0";
        }

        public void ProgramTermination()
        {
            Running = false;
        }
    }
}
