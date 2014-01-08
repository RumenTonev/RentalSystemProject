namespace RentalSystem.Repository
{
    using System;
    
        public class NoEntriesFoundException : Exception
        {
            public NoEntriesFoundException()
            {
            }

            public NoEntriesFoundException(string message)
                : base(message)
            {

            }

            public NoEntriesFoundException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
}
