namespace payments 
{
    public class Banck 
    {
        public virtual int Score { get; set; }

        public virtual int BankCard { get; set; }
        internal Banck(int Score, int BankCard)
        {
            this.Score = Score;
            this.BankCard = BankCard;
        }
    }


    class Client : Banck
    {
        int Score = 0;
        int BankCard = 0;
        int Money;
        public Client(int Score, int BankCard, int Money) : base(Score, BankCard)
        {
            this.Score = Score;
            this.BankCard = BankCard;
            this.Money = Money;
        }

        static void PayOrder(Client client, int PaymentAmount) 
        {
            if (client.Money >= PaymentAmount)
            {
                client.Money = client.Money - PaymentAmount;
            }
            else 
            {
                Console.WriteLine(" Недостаточно средств");
            }
            
        }
        static void PaymentToAnotherAccount() 
        {

        }
    }


}
