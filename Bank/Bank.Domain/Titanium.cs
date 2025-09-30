namespace Bank.Domain
{
    /// <summary>
    /// Representa una tarjeta de crédito del tipo <c>Titanium Edge</c>.
    /// </summary>
    /// <remarks>
    /// Implementa la interfaz <see cref="ICreditCard"/> proporcionando
    /// los detalles específicos de la tarjeta Titanium: tipo, límite de crédito
    /// y cargo anual.
    /// </remarks>
    public class Titanium : ICreditCard
    {
        /// <summary>
        /// Obtiene el nombre del tipo de tarjeta.
        /// </summary>
        /// <returns>
        /// Una cadena con el valor <c>"Titanium Edge"</c>.
        /// </returns>
        public string GetCardType()
        {
            return "Titanium Edge";
        }

        /// <summary>
        /// Obtiene el límite de crédito asignado a la tarjeta Titanium.
        /// </summary>
        /// <returns>
        /// Un número entero que representa el límite de crédito: <c>25000</c>.
        /// </returns>
        public int GetCreditLimit()
        {
            return 25000;
        }

        /// <summary>
        /// Obtiene el cargo anual asociado a la tarjeta Titanium.
        /// </summary>
        /// <returns>
        /// Un número entero que representa el cargo anual: <c>1500</c>.
        /// </returns>
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
