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
                if (operation._typeOfMovement == MovementOfAccount.Credited)
                {
                    total += operation._amount;
                }
                else
                {
                    total -= operation._amount;
                }
            }
            return total;
        }
    }
    OperationOnAccount operationOnAccount = new OperationOnAccount();
    // create contructor without parameters
    public Account()
    {
        _operations = new List<OperationOnAccount>();
        _accountOwner = "Unknown";
    }
    // 
    public void Credited( decimal amount)
    {
        operationOnAccount._amount = amount;
        operationOnAccount._typeOfMovement = MovementOfAccount.Credited;
        _operations.Add(operationOnAccount);
    
    }
     public void Debtor( decimal amount)
     {
        operationOnAccount._amount = amount ;
        operationOnAccount._typeOfMovement = MovementOfAccount.Debtor;
         _operations.Add(operationOnAccount);
     }
     
     public void DisplayOperations()
     {
           foreach (OperationOnAccount operation in _operations )
        {
            if (operation._typeOfMovement == MovementOfAccount.Credited)
            {
                Console.Write("\t+");
                Console.WriteLine(operation._amount);
            }
            else
            {
                Console.Write("\t-");
                Console.WriteLine(operation._amount);
            }
        }
     }

      public abstract void DisplayAccountDetails();
}