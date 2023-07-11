using System;

public class Budget
{
    // Define attributes for class.
    public List<Data> _datas = new List<Data>();

    private float _balance = 0;
    private Menu menu = new Menu();
    
    // Make methods for the class.
    public void AddData()
    {   
        int userChoice = menu.DisplayincomeOrExpenseMenu();
        if (userChoice == 1)
        {
            Income data = new Income();
            data.SetAttributes();
            _datas.Add(data);
            AddFunds(data.GetAmount());
        }
        else if (userChoice == 2)
        {
            Wages data = new Wages();
            data.SetAttributes();
            _datas.Add(data);
            AddFunds(data.GetAmount());
        }
        else if (userChoice == 3)
        {
            Expense data = new Expense();
            data.SetAttributes();
            _datas.Add(data);
        }
        else if (userChoice == 4)
        {
            ConsistantExpense data = new ConsistantExpense();
            data.SetAttributes();
            _datas.Add(data);
        }
        else if (userChoice == 5)
        {
            RefundableExpense data = new RefundableExpense();
            data.SetAttributes();
            _datas.Add(data);
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
    public void PayExpense()
    {
        Console.Write($"\r\n Choose an expense to pay: ");
        int tempExpense = int.Parse(Console.ReadLine()) - 1;
        if (_datas[tempExpense]._dataType == 3 || _datas[tempExpense]._dataType == 4 || _datas[tempExpense]._dataType == 5)
        {
            AddFunds(_datas[tempExpense].GetAmount());
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, that was not a valid index.");
        }
    }

    public void Load(string fileName)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _datas.Clear();
            _balance = 0;
            int i = 0;
            foreach (string line in lines)
            {
                if (i == 0)
                {   
                    _balance = float.Parse(line);
                    i++;
                }
                else
                {
                    string[] parts = line.Split("|");
                    if (int.Parse(parts[0]) == 1)
                    {
                    Income data = new Income(line);
                    _datas.Add(data);
                    }
                    else if (int.Parse(parts[0]) == 2)
                    {
                    Wages data = new Wages(line);
                    _datas.Add(data);
                    }
                    else if (int.Parse(parts[0]) == 3)
                    {
                    Expense data = new Expense(line);
                    _datas.Add(data);
                    }
                    else if (int.Parse(parts[0]) == 4)
                    {
                    ConsistantExpense data = new ConsistantExpense(line);
                    _datas.Add(data);
                    }
                    else if (int.Parse(parts[0]) == 5)
                    {
                    RefundableExpense data = new RefundableExpense(line);
                    _datas.Add(data);
                    }
                }
            }
        }
        catch
        {
            Console.WriteLine("We could not find this file.");
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_balance}");
            foreach (Data data in _datas)
            {
                outputFile.WriteLine(data.StringToSave());
            }
        }
    }

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