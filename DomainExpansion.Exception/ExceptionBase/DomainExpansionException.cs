namespace DomainExpansion.Exception.ExceptionBase
{
    public abstract class DomainExpansionException : SystemException
    { 
        protected DomainExpansionException(string message) : base(message)
        {

        }

        public abstract int StatusCode { get; }
        public abstract List<string> GetErrors();
    }
}
