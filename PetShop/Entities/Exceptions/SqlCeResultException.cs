using System;

namespace PetShop.Entities.Exceptions
{
    public class SqlCeResultException : Exception
    {
        public override string Message
        {
            get
            {
                return $"A consulta no banco de dados não retornou nenhum valor";
            }
        }
    }
}
