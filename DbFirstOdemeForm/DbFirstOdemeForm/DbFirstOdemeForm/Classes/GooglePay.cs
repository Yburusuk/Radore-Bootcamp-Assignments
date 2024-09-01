using DbFirstOdemeForm.Interfaces;

namespace DbFirstOdemeForm.Classes
{
    public class GooglePay : IPayment
    {
        public string Pay(decimal amount)
        {
            string response = "Google Pay ile " + amount + "₺ ödeme yapıldı.";

            return response;
        }
    }
}
