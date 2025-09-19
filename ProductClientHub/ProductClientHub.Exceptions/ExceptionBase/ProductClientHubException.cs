namespace ProductClientHub.Exceptions.ExceptionBase
{
    public abstract class ProductClientHubException : SystemException
    {
        public ProductClientHubException(string errorMensage) : base(errorMensage)
        {
        }
    }
}
