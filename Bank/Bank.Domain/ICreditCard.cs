namespace Bank.Domain
{
    /// <summary>
    /// Define el contrato base que deben implementar todas las tarjetas de crédito.
    /// </summary>
    /// <remarks>
    /// Cada tarjeta de crédito concreta debe especificar su tipo, límite de crédito y cargo anual.
    /// Este contrato asegura que todas las implementaciones expongan la misma funcionalidad mínima.
    /// </remarks>
    public interface ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta de crédito.
        /// </summary>
        /// <returns>Una cadena con el nombre o tipo de la tarjeta.</returns>
        string GetCardType();

        /// <summary>
        /// Obtiene el límite de crédito asociado a la tarjeta.
        /// </summary>
        /// <returns>Un número entero que representa el límite de crédito.</returns>
        int GetCreditLimit();

        /// <summary>
        /// Obtiene el cargo anual de mantenimiento de la tarjeta.
        /// </summary>
        /// <returns>Un número entero con el valor del cargo anual.</returns>
        int GetAnnualCharge();
    }
}
