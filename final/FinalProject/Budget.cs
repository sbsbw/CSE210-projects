using System;

public class Budget
{
    // Define attributes for class.
    private List<Data> _datas = new List<Data>();
    private float _balance = 0;
    private Menu menu = new Menu();
    
    // Make methods for the class.
    public void AddData()
    {   
        int userChoice = menu.DisplayincomeOrExpenseMenu();
        if (userChoice == 1)
        {
            Income income = new Income();
            _datas.Add(income);
            AddFunds(income.GetAmount());
        }
        // else if (userChoice == 2)
        // {
        //     Wages wage = new Wage();
        //     _datas.Add(income);
        // }
        else if (userChoice == 3)
        {
            Expense expense = new Expense();
            _datas.Add(expense);
            AddFunds(expense.GetAmount());
        }
    }

    public float GetBalance()
    {
        return _balance;
    }
    public void AddFunds(float amount)
    {
        _balance = _balance + amount;
    }
    
    // public void CompleteGoal(int goalNumber)
    // {
    //     // Goal tempGoal = _goals[goalNumber];
    //     AddPoints(_goals[goalNumber - 1].Complete());
    // }

    // public void Load(string fileName)
    // {
    //     try
    //     {
    //         string[] lines = System.IO.File.ReadAllLines(fileName);
    //         _goals.Clear();
    //         _totalXP = 0;
    //         int i = 0;
    //         foreach (string line in lines)
    //         {
    //             if (i == 0)
    //             {   
    //                 _totalXP = int.Parse(line);
    //                 i++;
    //             }
    //             else
    //             {
    //                 string[] parts = line.Split("|");
    //                 if (int.Parse(parts[0]) == 1)
    //                 {
    //                 SimpleGoal goal = new SimpleGoal(line);
    //                 _goals.Add(goal);
    //                 }
    //                 else if (int.Parse(parts[0]) == 2)
    //                 {
    //                 EternalGoal goal = new EternalGoal(line);
    //                 _goals.Add(goal);
    //                 }
    //                 else if (int.Parse(parts[0]) == 3)
    //                 {
    //                 ChecklistGoal goal = new ChecklistGoal(line);
    //                 _goals.Add(goal);
    //                 }
    //             }
    //         }
    //     }
    //     catch
    //     {
    //         Console.WriteLine("We could not find this file.");
    //     }

    // }
    // public void Save(string fileName)
    // {
    //     using (StreamWriter outputFile = new StreamWriter(fileName))
    //     {
    //         outputFile.WriteLine($"{_totalXP}");
    //         foreach (Goal goal in _goals)
    //         {
    //             outputFile.WriteLine(goal.ToSavedString());
    //         }
    //     }
    // }

    // public void ShowGoals()
    // {   
    //     Console.Clear();
    //     Console.WriteLine("The goals are:");
    //     int i = 1;
    //     foreach (Goal goal in _goals)
    //     {
    //         Console.WriteLine($" {i}. {goal.ConvertToString()}");
    //         i++;
    //     }
    // }
}