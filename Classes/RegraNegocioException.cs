using System;

namespace LocacaoEquipamentos.Classes
{
    public class RegraNegocioException : Exception
    {
        public RegraNegocioException(string mensagem) : base(mensagem) {}
    }
}
