namespace Bank.Domain
{
    /// <summary>
    /// Implementación del patrón <c>Factory Method</c> para crear instancias de la tarjeta <see cref="Titanium"/>.
    /// </summary>
    /// <remarks>
    /// Esta clase hereda de <see cref="CreditCardFactoryMethod"/> y sobrescribe el método
    /// <see cref="MakeProduct"/> para devolver una instancia de <see cref="Titanium"/>.
    /// </remarks>
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Crea y devuelve una instancia de la tarjeta de crédito <see cref="Titanium"/>.
        /// </summary>
        /// <returns>
        /// Una instancia de <see cref="ICreditCard"/> correspondiente a <see cref="Titanium"/>.
        /// </returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}
