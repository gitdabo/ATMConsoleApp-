


internal class Program
{
    
    private static void Main(string[] args)
    {

        
        string userDone;
        string fullName;


        do
        {

            

            fullName = Mainmenu();

            int wrongPinCount = 0;

            AccountLogin("", wrongPinCount);

            TransactionMenu();


            string userInput = Console.ReadLine();

            double defaultBalance = 10000;

            double totalWithdrawal = 0;

            double currentBalance;

            


            if (userInput == "1")
            {
                CheckBalance(defaultBalance, totalWithdrawal);

            }

            else if (userInput == "2")
            {
                Withdraw(defaultBalance);
            }

            else if (userInput == "3")
            {
                ChangePin();
            }


            else if (userInput == "4")
            {
                
                break;
            }


            else
            {
                Console.WriteLine("Please enter a valid option");
            }




            Console.WriteLine(  );
            Console.Write(  "Do you wish to exit ? (Y/N) : ");
            userDone = Console.ReadLine();

             


        } while (userDone.ToLower() != "y");




       
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(  "Thanks {0}, for banking with us.", fullName );


    }

   


    private static void ChangePin()
    {
       
    }

    private static void Withdraw( double defaultBalance )
    {
        Console.Clear();
        DisplayMessage("Select number to corresponding amount");
        DisplayMessage("-------------------------------------");
        Console.WriteLine();
        DisplayMessage("1) N1,000 \n2) N5,000 \n3) N10,000 \n4) Exit");
        Console.WriteLine();

        string userInput = Console.ReadLine();

        ProcessWithdrawal(userInput, defaultBalance);

        Console.WriteLine(  );
    }

    private static void ProcessWithdrawal(string userInput, double defaultBalance)
    {
        if (userInput == "1")
        {
            double balance = defaultBalance - 1000;
            Console.Clear();
            Console.WriteLine(  );
            DisplayMessage("Withdrawal successful! Your balance is {0:N}.", balance);

        }

        if (userInput == "2") 
        {
            double balance = defaultBalance - 5000;
            Console.Clear();
            Console.WriteLine(  );
            DisplayMessage("Withdrawal successful! Your balance is {0:N}.", balance);

        }


        if (userInput == "3")
        {
            double balance = defaultBalance - 10000;
            Console.Clear();
            Console.WriteLine(  );
            DisplayMessage("Withdrawal successful! Your balance is {0:N}.", balance);

        }

    }

    private static void  CheckBalance(double defaultBal, double totalWithdrawal)
    {
        Console.Clear();
        double balance = defaultBal - totalWithdrawal;
        Console.WriteLine(  );
        DisplayMessage("Your account balance is N{0:N}", balance);
        Console.WriteLine();
        
        
    }

    private static void DisplayMessage(string message, double balance)
    {
        Console.WriteLine(message,balance);
    }

    public static void DisplayMessage (string message)
    {
        Console.WriteLine (message);
    }

   
    public static string Mainmenu()
    {

        Customer user = new Customer();

        Console.Clear();
        DisplayMessage("***United Bank of Africa***");
        DisplayMessage("----------------------------");

        Console.WriteLine();

        Console.Write("Please enter your firstname: ");
        user.FirstName = Console.ReadLine();
        
        Console.Write("Please enter your lastname: ");
        user.LastName = Console.ReadLine();
        
        string fullName = user.FirstName + " " + user.LastName;
        

        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Hello {0} {1}, welcome to United Bank of Africa.", user.FirstName, user.LastName);
        Console.WriteLine();

        return fullName;

    }


    public static void AccountLogin(string pin , int wrongPinCount)
    {
        do
        {

            wrongPinCount++;

            if (wrongPinCount < 2)
            {
                Console.Write("Please enter your 4 digit Pin: ");
                pin = Console.ReadLine();

            }

            else
            {
                Console.Beep();
                Console.Clear();
                DisplayMessage("!!! Wrong Pin !!!");
                Console.WriteLine();
                Console.Write("Please enter your 4 digit Pin: ");
                pin = Console.ReadLine();
            }



        } while (pin != "0000");

    }


    private static void TransactionMenu()
    {
        Console.Clear();
        DisplayMessage("Please choose an option");
        DisplayMessage("------------------------");
        Console.WriteLine();
        DisplayMessage("1) Check Balance \n2) Withdraw \n3) Change Pin \n4) Exit");
        Console.WriteLine();
    }




}



public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
















