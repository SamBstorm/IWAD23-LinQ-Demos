using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MethodeExtension
{
    internal static class ListExtension
    {
        internal static List<T> Filtre<T>(this List<T> list, Func<T, bool> fonctionFiltre)
        {
            List<T> result = new List<T>();

            foreach (T item in list)
            {
                if (fonctionFiltre(item)) result.Add(item);
            }

            return result;
        }

        internal static List<TConvert> Convertir<T,TConvert> (this List<T> list, Func<T, TConvert> fonctionConvertion)
        {
            List<TConvert> result = new List<TConvert>();
            foreach (T item in list)
            {
                result.Add(fonctionConvertion(item));
            }
            return result;
        }
    }
}
