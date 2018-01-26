namespace Amica.Models
{
    /// <summary>
    /// Payment date options.
    /// </summary>
    public enum PaymentDate
    {
        /// <summary>
        /// At document date
        /// </summary>
        DocumentDate = 1,
        /// <summary>
        /// At end of month
        /// </summary>
        EndOfMonth = 2,
        /// <summary>
        /// At explicit date
        /// </summary>
        Explicit = 3
    }
}