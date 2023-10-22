using System;

namespace MMT007Utils.Exceptions{
     public class NullListException : Exception {
        public NullListException(){Console.Write(" List Was Found Null");}
        public NullListException(string message) : base(message){}
        public NullListException(string message, Exception innerException) : base(message,innerException){}

    } 
}