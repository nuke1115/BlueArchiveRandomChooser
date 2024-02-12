using BlueArchiveRandomChooser;

public class RandomManager : IRandomManager
{
    Random random = new Random();
    public ushort GetRandomStudentNumber(ushort StudentsCount)
    {
        ushort SelectedStudentsIDNumber;

        SelectedStudentsIDNumber = (ushort)random.Next(1, StudentsCount + 1);

        return SelectedStudentsIDNumber;
    }
    public byte GetRandomSchoolNumber(ushort SchoolsCount)
    {
        byte SelectedSchoolNumber;

        SelectedSchoolNumber = (byte)random.Next(1, SchoolsCount + 1);

        return SelectedSchoolNumber;
    }
    public byte GetRandomSkillNumber(byte SkillsCount)
    {
        byte SelectedSkillNumber;

        SelectedSkillNumber = (byte)random.Next(1, SkillsCount + 1);

        return SelectedSkillNumber;
    }
    public byte GetRandomEquipmentNumber(byte EquipmentsCount)
    {
        byte SelectedEquipmentNumber;

        SelectedEquipmentNumber = (byte)random.Next(1, EquipmentsCount + 1);

        return SelectedEquipmentNumber;
    }
}

public class ResultManager : IResultManager
{
    public string GetSelectedNumberInfo(ushort SelectedNumber, List<string> SelectedDataBase)
    {
        string SelectedNumbersInfo = SelectedDataBase[SelectedNumber - 1];
        return SelectedNumbersInfo;
    }
}

namespace AboutCommand
{
    public class CommandManager : ICommandManager
    {
        public object CommandRunner(string[] Command, Dictionary<string, List<string>> LoadedDataBases, Dictionary<string, ushort> LoadedDatasCount)
        {
            IRandomManager RandomManager = new RandomManager();
            IResultManager resultManager = new ResultManager();
            IProgramTermination programTermination = new Program();

            switch (Command[0])
            {
                case "Exit" or "exit" or "종료":
                    programTermination.ProgramTermination();
                    Console.WriteLine("프로그램을 종료합니다");
                    break;
                case "Random" or "random" or "추첨" or "선택" when Command.Length >= 2:
                    ushort SelectedNumber;
                    string SelectedNumberInfo;
                    switch (Command[1])
                    {
                        case "Student" or "student" or "학생" :
                            SelectedNumber = RandomManager.GetRandomStudentNumber(LoadedDatasCount["StudentsCount"]);
                            SelectedNumberInfo = resultManager.GetSelectedNumberInfo(SelectedNumber, LoadedDataBases["StudentsData"]);
                            return SelectedNumberInfo;
                        case "School" or "school" or "학교" or "학원":
                            SelectedNumber = RandomManager.GetRandomSchoolNumber(LoadedDatasCount["SchoolsCount"]);
                            SelectedNumberInfo = resultManager.GetSelectedNumberInfo(SelectedNumber, LoadedDataBases["SchoolsData"]);
                            return SelectedNumberInfo;
                        case "Skill" or "skill" or "스킬":
                            SelectedNumber = RandomManager.GetRandomSkillNumber((byte)LoadedDatasCount["SkillsCount"]);
                            SelectedNumberInfo = resultManager.GetSelectedNumberInfo(SelectedNumber, LoadedDataBases["SkillsData"]);
                            return SelectedNumberInfo;
                        case "Equipment" or "equipment" or "장비":
                            SelectedNumber = RandomManager.GetRandomEquipmentNumber((byte)LoadedDatasCount["EquipmentsCount"]);
                            SelectedNumberInfo = resultManager.GetSelectedNumberInfo(SelectedNumber, LoadedDataBases["EquipmentsData"]);
                            return SelectedNumberInfo;
                    }
                    Console.WriteLine("명령어 구문이 잘못되었거나, 명령어가 목록에 없습니다");
                    Console.WriteLine("Help 또는 ?를 입력해주세요");
                    break;
                case "Help" or "help" or "?" or "도움말" or "도움!":
                    bool IsThePhraseInvalid = false;

                    if (Command.Length == 1)
                    {
                        Console.WriteLine("명령어 종류");
                        Console.WriteLine("Clear");
                        Console.WriteLine("Random");
                        Console.WriteLine("Help");
                        Console.WriteLine("Exit");
                        break;
                    }
                    if (Command.Length >= 2)
                    {
                        switch (Command[1])
                        {
                            case "Random" or "random" or "추첨" or "선택":
                                Console.WriteLine("사용법: Random 랜덤선택조건");
                                Console.WriteLine("랜덤선택조건에 지정한 요소 1개를 랜덤으로 출력해준다");
                                Console.WriteLine("==================================================");
                                Console.WriteLine("랜덤선택조건");
                                Console.WriteLine("Student : 학생 1명을 선택한다");
                                Console.WriteLine("School : 학원 1개를 선택한다");
                                Console.WriteLine("Skill : 스킬 4개(EX, 기본, 강화, 서브) 중 1개를 선택한다");
                                Console.WriteLine("Equipment : 장비 1개를 선택한다");
                                Console.WriteLine("==================================================");
                                Console.WriteLine("사용 가능한 명령어 입력 목록 (명령어)");
                                Console.WriteLine("Random / random / 추첨 / 선택");
                                Console.WriteLine("==================================================");
                                Console.WriteLine("사용 가능한 명령어 입력 목록 (인자)");
                                Console.WriteLine("Student / student / 학생");
                                Console.WriteLine("School / school / 학교 / 학원");
                                Console.WriteLine("Skill / skill / 스킬");
                                Console.WriteLine("Equipment / equipment / 장비");
                                break;
                            case "Help" or "help" or "?" or "도움말" or "도움!":
                                Console.WriteLine("사용법: Help 명령어");
                                Console.WriteLine("명령어의 사용법을 알려준다");
                                Console.WriteLine("==================================================");
                                Console.WriteLine("사용 가능한 명령어 입력 목록 (명령어)");
                                Console.WriteLine("Help / help / ? / 도움말 / 도움!");
                                Console.WriteLine("==================================================");
                                Console.WriteLine("사용 가능한 명령어 입력 목록 (인자)");
                                Console.WriteLine("Random / Help / Clear / Exit");
                                break;
                            case "Exit" or "exit" or "종료":
                                Console.WriteLine("사용법: Exit");
                                Console.WriteLine("프로그램을 종료한다");
                                Console.WriteLine("==================================================");
                                Console.WriteLine("사용 가능한 명령어 입력 목록");
                                Console.WriteLine("Exit / exit / 종료");
                                break;
                            case "Clear" or "clear" or "기록_정리":
                                Console.WriteLine("사용법: Clear");
                                Console.WriteLine("콘솔창 기록을 정리한다");
                                Console.WriteLine("==================================================");
                                Console.WriteLine("사용 가능한 명령어 입력 목록");
                                Console.WriteLine("Clear / clear / 기록_정리");
                                break;
                            default:
                                IsThePhraseInvalid = true;
                                break;
                        }
                    }
                    if (IsThePhraseInvalid)
                    {
                        Console.WriteLine("명령어 구문이 잘못되었거나, 명령어가 목록에 없습니다");
                        Console.WriteLine("Help 또는 ?를 입력해주세요");
                    }
                    break;
                case "Clear" or "clear" or "기록_정리":
                    var CursorCordinationTemp = Console.GetCursorPosition();
                    Console.SetCursorPosition(0, 0);
                    for (int i = 0; i <= CursorCordinationTemp.Top; i++)
                    {
                        Console.WriteLine("ㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤㅤ");
                    }
                    Console.SetCursorPosition(0,0);
                    Console.WriteLine("기록 청소 완료");
                    break;

                default:
                    Console.WriteLine("명령어 구문이 잘못되었거나, 명령어가 목록에 없습니다");
                    Console.WriteLine("Help 또는 ?를 입력해주세요");
                    break;
            }
            return "결과 출력 불가";
        }
    }
}