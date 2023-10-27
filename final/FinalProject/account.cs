using System;

public abstract class Account
{
    private List<OperationOnAccount> _operations;
    private string _accountOwner;

    // create the getters and setters of attributes
    public List<OperationOnAccount> GetOperations()
    {
        return _operations;
    }
    public void SetOperations(List<OperationOnAccount> operations)
    {
        _operations = operations;
    }
    public string GetAccountOwner()
    {
        return _accountOwner;
    }
    public void SetAccountOwner(string owner)
    {
        _accountOwner = owner;
    }
     
    // Here, it's a read-only property only the getter is set. 
    public virtual decimal _balance
    {
        get
        {
            decimal total = 0;
            foreach (OperationOnAccount operation in _operations)
            {
                if (operation._typeOfMovement == MovementOfAccount.Credit)
                {
                    total += operation._amount;
                    
                }
                if (operation._typeOfMovement == MovementOfAccount.Debit)
                {
                    total -= operation._amount;
                    
                }
   

            }
            return total;
        }
        
    }
    
   
    // create contructor without parameters
    public Account()
    {
        _operations = new List<OperationOnAccount>();
        _accountOwner = "Unknown";
    }
    // 
    public void Credited( decimal amount)
    {
        OperationOnAccount operationOnAccount = new OperationOnAccount { _amount=amount, _typeOfMovement = MovementOfAccount.Credit};
        _operations.Add(operationOnAccount);
        
    
    }
     public void Debtor( decimal amount)
     {
       OperationOnAccount operationOnAccount = new OperationOnAccount { _amount=amount, _typeOfMovement = MovementOfAccount.Debit};
         _operations.Add(operationOnAccount);
     }

    

    public void DisplayOperations()
     {
        List<string> opertionDone = new List<string>();
           foreach (OperationOnAccount operation in _operations )
        {
            if (operation._typeOfMovement == MovementOfAccount.Credit)
            {
                // Console.Write("\t+");
                // Console.WriteLine(operation._amount);
                opertionDone.Add($"\t+{operation._amount}");
                
            }
            if (operation._typeOfMovement == MovementOfAccount.Debit)
            {
                // Console.Write("\t-");
                // Console.WriteLine(operation._amount);
                opertionDone.Add($"\t-{operation._amount}");
                
            }
            
        }
        foreach (string listoperation in opertionDone)
        {
            Console.WriteLine(listoperation);
        }
        
     }

      public abstract void DisplayAccountDetails();
}