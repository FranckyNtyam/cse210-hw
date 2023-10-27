using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my final project");
        /* As stated in the text, the objective of my application is to handle bank customer accounts and publish all relevant information about those accounts simultaneously.
       1- My program asks the name of the customer account owner in the beginning. 
       2. After the name is given, a customer's account menu with all of his bank accounts that have been subscribed to appears.
       3. You were prompted to select the account you want to use. Operations may credit or debit a selected account.
       4- You can choose 4 to print all of his account's details and information at once.
       5- It's quite easy to end the application by selecting 5. I'm thrilled to have a better understanding of programming with class. I will continue to improve my the application by adding save method in the class AccountManager.
       Thank you so much brother Chad For all your advices.
       */ 

        AccountManager  accountManager = new AccountManager();

        accountManager.Star();

       
    }
}