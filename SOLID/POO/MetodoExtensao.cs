namespace SOLID.POO
{
    public static class MetodoExtensao
    {
        // Método de extensão - nesse caso, estou extendendo de string (this string...)
        public static string CapsLockPrimeiraLetra(this string valor)
        {
            if (valor.Length > 0)
            {
                char[] array = valor.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }

            return valor;
        }

    }
}
