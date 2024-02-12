namespace AboutLoader
{
    public class LoadingDataBaseClass
    {
        protected List<string> LoadingData(string DataBasePath)
        {
            List<string> Data = new List<string>();
            using (StreamReader streamReader = new StreamReader(DataBasePath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Data.AddRange(line.Split("//"));
                }
            }

            return Data;
        }
    }
    public class LoadAssetManager : LoadingDataBaseClass, ILoadAssetManager
    {
        string DataBasePath;
        public List<string> LoadStudentsDataBase(string ThisPath)
        {
            DataBasePath = Path.Combine(ThisPath, "DataBase\\StudentsDataBase.txt");
            List<string> StudentsData = base.LoadingData(DataBasePath);
            return StudentsData;
        }

        public List<string> LoadSchoolsDataBase(string ThisPath)
        {
            DataBasePath = Path.Combine(ThisPath, "DataBase\\SchoolsDataBase.txt");
            List<string> SchoolsData = base.LoadingData(DataBasePath);
            return SchoolsData;
        }

        public List<string> LoadSkillsDataBase(string ThisPath)
        {
            DataBasePath = Path.Combine(ThisPath, "DataBase\\SkillsDataBase.txt");
            List<string> SkillsData = base.LoadingData(DataBasePath);
            return SkillsData;
        }

        public List<string> LoadEquipmentsDataBase(string ThisPath)
        {
            DataBasePath = Path.Combine(ThisPath, "DataBase\\EquipmentsDataBase.txt");
            List<string> EquipmentsData = base.LoadingData(DataBasePath);
            return EquipmentsData;
        }
    }
}