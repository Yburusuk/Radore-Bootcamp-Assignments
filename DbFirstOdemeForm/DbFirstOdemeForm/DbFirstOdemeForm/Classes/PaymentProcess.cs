using DbFirstOdemeForm.Interfaces;

namespace DbFirstOdemeForm.Classes
{
    public class PaymentProcess
    {
        public IPayment iPayment;

        public PaymentProcess(IPayment iPayment)
        {
            this.iPayment = iPayment;
        }

        public string DoPay(decimal amount)
        {
            return iPayment.Pay(amount);
        }
    }
}
