namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int FromAccount { get; set; }
        public int AccountTarget { get; set; }
        public decimal TransferAmount { get; set; }
    }
}