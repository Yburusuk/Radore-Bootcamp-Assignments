using System.Reflection;
using DbFirstOdemeForm.Interfaces;

namespace DbFirstOdemeForm.Classes
{
    public class PaymentProcessFactory
    {
        public IPayment Create(string className)
        {
            for (int i = 0; i < 3; i++)
            {
                var assembly = Assembly.GetAssembly(typeof(IPayment));

                var newInstance = assembly.CreateInstance("DbFirstOdemeForm.Classes." + className);

                if (newInstance != null)
                {
                    return (IPayment)newInstance;
                }
                System.Threading.Thread.Sleep(100);
            }

            throw new InvalidOperationException("Class not found: " + className);
        }
    }
}
