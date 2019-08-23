using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _4_MetodyDelegatyGeneryczne
{
    public static class KolejkaExtensions

    {        
        public static IEnumerable<Twyjscie> Mapuj<T, Twyjscie>(this IKolejka<T> kolejka, Converter<T,Twyjscie> konwerter) 
        {
            return kolejka.Select(i => konwerter(i));
        }

        public static void Drukuj<T>(this IKolejka<T> kolejka, Action<T> wydruk)
        {
            foreach (var item in kolejka)
            {
                wydruk(item);
            }
        }
        
    }
}
