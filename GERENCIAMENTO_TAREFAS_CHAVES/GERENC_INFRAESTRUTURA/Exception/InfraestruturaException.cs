using System;


namespace GERENC_INFRAESTRUTURA.Exception
{
    public class InfraestruturaException : System.Exception 
    {

        public InfraestruturaException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
