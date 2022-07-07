using System.Globalization;
namespace Desafio
{
    public class Account
    {
        private string _name;
        public int NumAccount{get; private set;}
        public double DepositedAmount {get; private set;}
        public Account(){}
        public Account(int numAccount, string name, double depositeAmount)
        {
            _name = name;
            NumAccount = numAccount;
            Deposite(depositeAmount);
        }
        public Account(string name, int numAccount) : this(){}
        public string Name{
            get {return _name;}
            set {
                if(value != null && value.Length > 3){
                    _name = value;
                }
            }
        }
        public double Deposite(double depositeAmount)
        {
            return DepositedAmount += depositeAmount;
        }
        public double Balance(double depositeAmount)
        {
            return DepositedAmount -= depositeAmount + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
            + NumAccount
            +" , "
            +"Titular: "
            +_name
            +" , "
            + "Saldo: "+ DepositedAmount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}