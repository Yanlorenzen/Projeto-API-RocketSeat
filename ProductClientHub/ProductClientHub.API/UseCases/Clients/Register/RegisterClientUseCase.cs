using ProductClientHub.Communication.Request;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionBase;

namespace ProductClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseClientJson Execute(RequestClientJson request)
        {
            var validator = new RegisterClientValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                throw new ErrorOnValidationException("ERRO NOS DADOS RECEBIDOS");
            }

            // CONTINUA A REGRA DE NEGOCIO 

            return new ResponseClientJson();
            // Implementation of the use case to register a client
        }
    }
}
