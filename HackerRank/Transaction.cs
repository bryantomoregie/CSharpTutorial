using System;


public class Transaction {
    
    
public int Amount { get; set; }
public bool Credit { get; set; }
public string Category { get; set; }

public Transaction(int amount, bool credit, string category)
{
    Amount = amount;
    Credit = credit;
    Category = category;
}

}