using System.Collections.Generic;
using System;
using MMT007Utils.Exceptions;
using System.Collections.ObjectModel;
using UnityEngine;

namespace MMT007Utils{
    public static class ListUtils{
        public static T GetFromEnd<T>(List<T> list, int toIndex){
            if (list == null){throw new NullListException();}
            if (list.Count == 0){throw new IndexOutOfRangeException("List Did Not Contain Any Objexts");}

            return list[list.Count - toIndex];
        }
        public static T GetFromEnd<T>(ReadOnlyCollection<T> roc,int toIndex){
            if (roc == null){throw new NullListException();}
            if (roc.Count == 0){throw new IndexOutOfRangeException("List Did Not Contain Any Objexts");}

            return roc[roc.Count - toIndex];
        }
        public static T GetFromEnd<T>(T[] tl,int toIndex){
            if (tl == null){throw new NullListException();}
            if (tl.Length == 0){throw new IndexOutOfRangeException("List Did Not Contain Any Objexts");}

            return tl[tl.Length - toIndex];
        }
    }
}