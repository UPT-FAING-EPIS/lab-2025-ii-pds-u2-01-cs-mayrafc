namespace Bank.Domain
{
    /// <summary>
    /// Representa una tarjeta de crédito del tipo <c>MoneyBack</c>.
    /// </summary>
    /// <remarks>
    /// La tarjeta <c>MoneyBack</c> ofrece un límite de crédito estándar y un cargo anual bajo,
    /// siendo una opción adecuada para clientes que buscan recompensas por compras.
    /// </remarks>
    public class MoneyBack : ICreditCard
    {
        /// <summary>
        /// Obtiene el nombre del tipo de tarjeta de crédito.
        /// </summary>
        /// <returns>La cadena <c>"MoneyBack"</c>.</returns>
        public string GetCardType()
        {
            return "MoneyBack";
        }

        /// <summary>
        /// Obtiene el límite de crédito asociado a la tarjeta <c>MoneyBack</c>.
        /// </summary>
        /// <returns>Un valor entero fijo de <c>15000</c>.</returns>
        public int GetCreditLimit()
        {
            return 15000;
        }

        /// <summary>
        /// Obtiene el cargo anual de la tarjeta <c>MoneyBack</c>.
        /// </summary>
        /// <returns>Un valor entero fijo de <c>500</c>.</returns>
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
