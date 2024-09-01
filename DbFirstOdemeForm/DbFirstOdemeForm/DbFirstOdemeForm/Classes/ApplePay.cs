using DbFirstOdemeForm.Interfaces;

namespace DbFirstOdemeForm.Classes
{
    public class ApplePay : IPayment
    {
        public string Pay(decimal amount)
        {
            string response = "Apple Pay ile " + amount + "₺ ödeme yapıldı.";

            return response;
        }
    }
}