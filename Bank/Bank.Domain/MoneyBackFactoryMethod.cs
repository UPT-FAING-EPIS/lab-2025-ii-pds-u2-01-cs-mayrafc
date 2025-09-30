namespace Bank.Domain
{
    /// <summary>
    /// Fábrica concreta que implementa el patrón <c>Factory Method</c> 
    /// para crear instancias de <see cref="MoneyBack"/>.
    /// </summary>
    /// <remarks>
    /// Esta clase encapsula la lógica de creación de la tarjeta de crédito 
    /// <c>MoneyBack</c>, delegando la construcción al método 
    /// <see cref="CreditCardFactoryMethod.MakeProduct"/>.
    /// </remarks>
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Crea una nueva instancia de la tarjeta de crédito <see cref="MoneyBack"/>.
        /// </summary>
        /// <returns>Un objeto de tipo <see cref="ICreditCard"/> representando la tarjeta <c>MoneyBack</c>.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}
