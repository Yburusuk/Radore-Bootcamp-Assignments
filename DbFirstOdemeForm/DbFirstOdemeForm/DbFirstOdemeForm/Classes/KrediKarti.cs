using DbFirstOdemeForm.Interfaces;

namespace DbFirstOdemeForm.Classes
{
    public class KrediKarti : IPayment
    {
        public string Pay(decimal amount)
        {
            string response = "Kredi Kartı ile " + amount + "₺ ödeme yapıldı.";

            return response;
        }
    }
}
