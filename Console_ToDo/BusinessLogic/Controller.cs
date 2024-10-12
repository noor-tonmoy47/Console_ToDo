using Console_ToDo.DataAccess;
using Console_ToDo.DataAccess.Entity;

namespace Console_ToDo.BusinessLogic
{
    internal class Controller
    {

        private static Controller instance;

        private DBConnection db;
        private Controller()
        {
            db = DBConnection.GetInstance();
        }

        public static Controller GetInstance()
        {
            if (instance == null)
            {
                return new Controller();
            }
            else
            {
                return instance;
            }
        }


        public void RegisterUser(string userName)
        {

            var user = new Users
            {
                UserName = userName
            };

            db.AddUser(user);
        }

        public void CreateNewTask(string content)
        {

        }
    }
}
