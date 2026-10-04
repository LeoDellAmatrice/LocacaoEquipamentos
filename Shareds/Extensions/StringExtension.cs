using System;

namespace LocacaoEquipamentos.Shareds.Extensions
{
    public static class StringExtension
    {
        public static TEnum ObterEnumPelaDescricao<TEnum>(
            this string descricao
        ) where TEnum : struct, Enum
        {
            foreach (TEnum valor in Enum.GetValues(typeof(TEnum)))
            {

                if (string.Equals(

                    valor.GetDescription(),

                    descricao,

                    StringComparison.OrdinalIgnoreCase))

                {

                    return valor;

                }

            }

            throw new ArgumentException($"Nenhum valor de {typeof(TEnum).Name} possui a descrição '{descricao}'.");
        }
    }
}
