using System;

namespace banking
{
    class Program
    {
        private static AccountHolder currentUser;

        /// <summary>
        /// Initialises the program's global state by populating the currentUser
        /// field with a dummy object.
        /// </summary>
        private static void InitialiseProgram()
        {
            currentUser = new AccountHolder(1234, "John", "Smith");
        }

        /// <summary>
        /// Executes the program.
        /// </summary>
        private static void ExecuteProgram()
        {
            BankingMenuHandler.ExecuteBankingMenu(currentUser);
        }

        static void Main(string[] args)
        {
            InitialiseProgram();
            ExecuteProgram();
        }
    }
}
