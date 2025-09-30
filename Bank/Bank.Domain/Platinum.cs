namespace Bank.Domain
{
    /// <summary>
    /// Representa una tarjeta de crédito de tipo <c>Platinum Plus</c>.
    /// </summary>
    /// <remarks>
    /// Implementa la interfaz <see cref="ICreditCard"/> proporcionando
    /// detalles específicos como el tipo de tarjeta, el límite de crédito
    /// y el cargo anual correspondiente.
    /// </remarks>
    public class Platinum : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de la tarjeta de crédito.
        /// </summary>
        /// <returns>
        /// Una cadena que representa el tipo de tarjeta: <c>"Platinum Plus"</c>.
        /// </returns>
        public string GetCardType()
        {
            return "Platinum Plus";
        }

        /// <summary>
        /// Obtiene el límite de crédito asignado a la tarjeta.
        /// </summary>
        /// <returns>
        /// Un valor entero que representa el límite de crédito (35,000).
        /// </returns>
        public int GetCreditLimit()
        {
            return 35000;
        }

        /// <summary>
        /// Obtiene el cargo anual de la tarjeta.
        /// </summary>
        /// <returns>
        /// Un valor entero que representa el cargo anual (2,000).
        /// </returns>
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
