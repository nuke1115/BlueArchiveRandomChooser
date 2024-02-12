
namespace AboutConsole
{
    
    public class ConsolePrintManager<T> : IConsolePrintManager<T>
    {
        public void ConsoleLinePrint()
        {
            Console.WriteLine();
            Console.Write("명령어 입력>");
        }
        public void ConsoleResultPrint(T Result)
        {
            if (!Equals(Result,"결과 출력 불가"))
            {
                Console.WriteLine();
                Console.WriteLine($"결과: {Result}");
                Console.WriteLine();
            }
        }
    }

    public class InputManager : IInputManager
    {
        public string[] GetCommandInput()
        {
            string[] Command = Console.ReadLine().Split(" ");
            Console.WriteLine();
            return Command;
        }
    }
}