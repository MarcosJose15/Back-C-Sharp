using System;

namespace ExcecoesPersonalizadas3.Entities.Exceptions
{

    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}