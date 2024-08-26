using System.Reflection;

namespace ZorunlulukAttribute;

public class ZorunlulukKontrolu
{
    public static bool Dogrula(object dogrulanacakNesne)
    {
        Type dogrulanacakTur =  dogrulanacakNesne.GetType();
        
        FieldInfo[]  dogrulanacakAlanlar    = dogrulanacakTur.GetFields(BindingFlags.Instance | BindingFlags.Public);
        
        foreach(FieldInfo dogrulancakAlan in dogrulanacakAlanlar)
        {
            object[] zorunluAlanOznitelikleri= dogrulancakAlan.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
            
            if(zorunluAlanOznitelikleri.Length!=0)
            {
                string alanDegeri = dogrulancakAlan.GetValue(dogrulanacakNesne) as string;
                
                if (string.IsNullOrEmpty(alanDegeri))
                { 
                    return false;
                }
            }
        }
        return true;
    }
}