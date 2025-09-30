namespace Bank.Domain
{
    /// <summary>
    /// Implementa el patrón <c>Factory</c> centralizando la creación de objetos <see cref="ICreditCard"/>.
    /// </summary>
    /// <remarks>
    /// Esta clase evita que los clientes creen instancias de tarjetas de crédito directamente.
    /// Sin embargo, mantiene el uso de estructuras condicionales (<c>if-else</c>) para determinar qué producto crear.
    /// Para escenarios más complejos y extensibles se recomienda el uso del patrón <c>Factory Method</c>.
    /// </remarks>
    public class CreditCardFactory
    {
        /// <summary>
        /// Retorna una nueva instancia de <see cref="ICreditCard"/> en función del tipo solicitado.
        /// </summary>
        /// <param name="cardType">El nombre del tipo de tarjeta: <c>MoneyBack</c>, <c>Titanium</c> o <c>Platinum</c>.</param>
        /// <returns>
        /// Una instancia de <see cref="ICreditCard"/> correspondiente al tipo indicado, 
        /// o <c>null</c> si el tipo de tarjeta no es reconocido.
        /// </returns>
        public static ICreditCard? GetCreditCard(string cardType)
        {
            ICreditCard? cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            return cardDetails;
        }
    }
}
