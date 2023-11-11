using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

/*Q1.Create Console Appplication for Bank Of Baroda.
Create a  abstract class Account having member
a. Id [Let your application generate id, it is readonly]
b.Name[write getter, setter Method Give Validation Length of  name can not be less then 2 and greater then 15]
c.Balance[write getter, setter, you can not set value  outside class other than child class]
It has two methods
1. public abstract withdraw(double amt);
2. public void Deposit(double amt) { }
This method will increase amount in balance.
Create two child class SavingAccount and CurrentAccount.
In CurrentAccount user can have negative balance.
In SavingAccount minimum balance of 1000 need to maintain. Declare const double  minbala=1000
When use withdraw money they should get SMS and EMAIL about new balance and amount withdrawn.
 When you run application it should display name of bank. 
Create List of Account class and store child Object.
Do transaction and ensure user can not withdraw more then the balance. Also ensure it maintain minimum balance of 1000 in Saving Account.
In SavingAccount write public static double Payinterest(Employee e) this method will return interest amount  and increase the balance  If data is in-validation then your application should throw exception
 Your application should allow you to create only 5 object.
Your application should handle all exception.
Write user Define Exception for insufficient balance[If user try to withdraw more then minbalance in Saving Account] This class will print user name and transaction detail in a file.
In Account class Create event. When use withdraw money it should send SMS and E-mail [Complete Publisher subscriber design pattern]
*/

namespace Bank_Application
{
     public delegate  void wd(Double amt,Double bal,String Name);
    abstract class Account
    {
        public static event wd wdevent;
        static int Id=0;
        String Name;
        Double Balance;int id;

        static Account()
        {
            Console.WriteLine("Welcome to Bank Of Baroda");
            Subscriber.AddMethods();
        }
        public Account(String Name, Double Balance)
        {
            if (Id > 4)
                throw new Exception("Capacity Full");
            else
            id= ++Id;
            NAME = Name;
            BALANCE = Balance;
        }
        public int ID { get { return id; } }
        public String NAME 
        {  
            set {
                if (value.Length > 2 && value.Length < 15)
                {
                    Name = value;
                }
                else throw new Exception("Invalid Name please enter character more than 2 and less than 15");
                }
            get { return Name; } 
        }
        protected Double BALANCE { set { Balance = value; } get { return Balance; } }
        public void Onwithdraw(Double amt, Double bal, String Name)
        {
            
            if (wdevent != null)
            {
                wdevent(amt, bal, Name);
            }
        }
       public abstract void withdraw(double amt);
        public void Deposit(double amt) 
        {
            Balance = Balance+ amt;
        }
        public void ShowBal()
        { 
            Console.WriteLine( NAME+" Balance=" +BALANCE);
        }
        


    }

    internal class Program
    {

        static void Main(string[] args)
        {
            List<Account> acc;
            try
            {
                
                   acc= new List<Account>();
                acc.Add(new SavingAccount("yash",10000));
                acc.Add(new SavingAccount("Akshay", 20000));
                acc.Add(new SavingAccount("Sushil", 30000));
                acc.Add(new SavingAccount("Shubham", 10000));
               foreach(Account ac in acc)
                {
                    Console.WriteLine(ac);
                }
                Account a = new SavingAccount("y", 1000); 


            }
            catch (Exception e) 
            { Console.WriteLine(e); }
        }
    }
}