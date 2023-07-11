using System;

public class Budget
{
    // Define attributes for class.
    public List<Data> _datas = new List<Data>();
    // private List<RefundableExpense> _refundableExpenses = new List<RefundableExpense>();
    // private List<Expense> _expenses = new List<Expense>();
    // private List<Income> _incomes = new List<Income>();

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
    public void RefundExpense(int dataNumber)
    {
        // if (_refundableExpenses[dataNumber]._dataType == 4)
        if (_datas[dataNumber]._dataType == 4)
        {
            AddFunds(_datas[dataNumber].GetAmount());
        }
        else
        {
            Console.WriteLine("Sorry, this is not refundable.");
        }
    }

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

    public void ShowRefundableList()
    {   
        Console.Clear();
        Console.WriteLine("Refundable Expenses:");
        int i = 1;
        foreach (Data data in _datas)
        {
            if (data._dataType == 4)
            {
                Console.WriteLine($" {i}. {data.ShowInfo()}");
            }
            i++;
        }
    }
    public void ShowExpensesList()
    {   
        Console.Clear();
        Console.WriteLine("Expenses:");
        int i = 1;
        foreach (Data data in _datas)
        {
            if (data._dataType == 3 || data._dataType == 4 || data._dataType == 5)
            {
                Console.WriteLine($" {i}. {data.ShowInfo()}");
            }
            i++;
        }
    }
    public void ShowIncomesList()
    {   
        Console.Clear();
        Console.WriteLine("Incomes:");
        int i = 1;
        foreach (Data data in _datas)
        {
            if (data._dataType == 1 || data._dataType == 2)
            {
                Console.WriteLine($" {i}. {data.ShowInfo()}");
            }
            i++;    
        }
    }
    public void ShowFullList()
    {   
        Console.Clear();
        Console.WriteLine("Transations:");
        int i = 1;
        foreach (Data data in _datas)
        {
            Console.WriteLine($" {i}. {data.ShowInfo()}");
            i++;
        }
    }
}