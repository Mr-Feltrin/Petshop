using System;

namespace PetShop.Entities.Exceptions
{
    public class SqlCeQueryException : Exception
    {
        public override string Message
        {
            get
            {
                return "Ocorreu um erro ao executar a ação no banco de dados";
            }
        }
    }
}
