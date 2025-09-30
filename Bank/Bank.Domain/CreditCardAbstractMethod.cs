namespace Bank.Domain
{
    /// <summary>
    /// Clase abstracta que define el Factory Method para la creación de objetos <see cref="ICreditCard"/>.
    /// </summary>
    /// <remarks>
    /// El patrón Factory Method permite delegar la creación de objetos a las subclases concretas,
    /// evitando así el uso de condicionales en la lógica del cliente y favoreciendo la extensibilidad.
    /// </remarks>
    public abstract class CreditCardFactoryMethod
    {
        /// <summary>
        /// Método abstracto que debe ser implementado por las fábricas concretas 
        /// para instanciar un objeto de tipo <see cref="ICreditCard"/>.
        /// </summary>
        /// <returns>Una nueva instancia de <see cref="ICreditCard"/>.</returns>
        protected abstract ICreditCard MakeProduct();

        /// <summary>
        /// Método que utiliza el <c>Factory Method</c> definido en las subclases
        /// para crear y retornar un objeto de tarjeta de crédito.
        /// </summary>
        /// <remarks>
        /// El creador puede incluir lógica de negocio adicional que dependa del producto
        /// generado, pero no es responsable de instanciar directamente el objeto.
        /// </remarks>
        /// <returns>Una nueva instancia válida de <see cref="ICreditCard"/>.</returns>
        public ICreditCard CreateProduct()
        {
            ICreditCard creditCard = this.MakeProduct();
            return creditCard;
        }
    }
}
