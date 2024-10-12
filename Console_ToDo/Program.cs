using Console_ToDo.Presentation;
namespace Console_ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uI = UserInteraction.GetInstance();
            uI.Start();
        }
    }
}
