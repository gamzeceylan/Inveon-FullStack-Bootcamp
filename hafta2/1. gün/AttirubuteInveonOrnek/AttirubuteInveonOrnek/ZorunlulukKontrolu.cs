using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttirubuteInveonOrnek
{
    public static class ZorunlulukKontrolu
    {
        public static bool Dogrula(object dogrulanacakNesne)
        {
            // reflection
            Type dogrulanacakTur = dogrulanacakNesne.GetType();
            // field bilgileri
            FieldInfo[] dogrulanacakTurAlanlari = dogrulanacakTur.GetFields(BindingFlags.Instance | BindingFlags.Public);
            foreach(FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                // her fieldin içince custom attribute var mı 
                
                object[] zorunluAlanOznitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if(zorunluAlanOznitelikleri.Length !=0)
                {
                    // attribute tipini öğrenmeye çalışıyoruz
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakNesne) as string;
                    if(string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
