using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire
{
    static class Extenstion_List
    {
        public static BindingList<T> ToBindingList<T>(this List<T> source)
        {
            return new BindingList<T>(source);
        }
        public static SortableBindingList<T> ToSortableBindingList<T>(this List<T> source) where T : class
        {
            return new SortableBindingList<T>(source);
        }
    }
}
