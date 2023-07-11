using System;

class Program
{
    static void Main(string[] args)
    {
        // Start by creating a menu and goalData object.
        Budget B = new Budget();
        Menu M = new Menu();

        int userChoice = -1;
        // int dataType = 0;
        while (userChoice != 0)
        {
            Console.WriteLine();

            userChoice = M.DisplayMainMenu();

            if (userChoice == 1)
            {
                B.AddData();
            }
            else if (userChoice == 2)
            {
                Console.WriteLine();
                Console.WriteLine($"Your current balance is: ${B.GetBalance().ToString("n2")}");
            }
            else if (userChoice == 3)
            {
                Console.WriteLine();
                B.ShowIncomesList();
            }
            else if (userChoice == 4)
            {
                Console.WriteLine();
                B.ShowExpensesList();
            }
            else if (userChoice == 5)
            {
                Console.WriteLine();
                B.ShowFullList();
            }
            else if (userChoice == 6)
            {
                Console.WriteLine();
                B.ShowExpensesList();
                B.PayExpense();
            }
            else if (userChoice == 7)
            {
                Console.WriteLine();
                B.ShowRefundableList();
                Console.Write($"\r\n Choose an expense to refund: ");
                int tempExpense = int.Parse(Console.ReadLine()) - 1;
                if (B._datas[tempExpense]._dataType == 5)
                {
                    B.AddFunds(B._datas[tempExpense].GetAmount());
                }
            }
            else if (userChoice == 8)
            {
                Console.Write("Please type a file name: ");
                string fileName = Console.ReadLine();
                B.Save(fileName);
            }
            else if (userChoice == 9)
            {
                Console.Write("Please type a file name: ");
                string fileName = Console.ReadLine();
                B.Load(fileName);
            }
            else if (userChoice == 0)
            {
                Console.WriteLine("\r\nThank you for using the Budget program.");
            }
        }
    }
}