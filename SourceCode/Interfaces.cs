public interface ICommandManager
{
    object CommandRunner(string[] Command, Dictionary<string, List<string>> LoadedDataBases, Dictionary<string, ushort> LoadedDatasCount);
}

public interface IConsolePrintManager<T>
{
    void ConsoleLinePrint();
    void ConsoleResultPrint(T Result);

}

public interface IResultManager
{
    string GetSelectedNumberInfo(ushort SelectedNumber, List<string> SelectedDataBase);
}


public interface IInputManager
{
    string[] GetCommandInput();
}

public interface ILoadAssetManager
{
    List<string> LoadStudentsDataBase(string ThisPath);
    List<string> LoadSchoolsDataBase(string ThisPath);
    List<string> LoadSkillsDataBase(string ThisPath);
    List<string> LoadEquipmentsDataBase(string ThisPath);
}

public interface IRandomManager
{
    ushort GetRandomStudentNumber(ushort StudentsCount);
    byte GetRandomSchoolNumber(ushort SchoolsCount);
    byte GetRandomSkillNumber(byte SkillsCount);
    byte GetRandomEquipmentNumber(byte EquipmentsCount);
}

public interface IProgramTermination
{
    void ProgramTermination();
}