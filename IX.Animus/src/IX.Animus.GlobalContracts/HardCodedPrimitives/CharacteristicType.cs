namespace IX.Animus.GlobalContracts.HardCodedPrimitives
{
    /// <summary>
    /// Characteristic types, from a mathematical perspective.
    /// </summary>
    public enum CharacteristicType
    {
        /// <summary>
        /// Accumulation characteristic. This characteristic starts from a specified value and accumulates according to various formulas.
        /// </summary>
        Accumulation,

        /// <summary>
        /// Store characteristic. This characteristic starts from a maximum value and decreases.
        /// </summary>
        Store,

        /// <summary>
        /// Fixed characteristic. This characteristic has a fixed value, and can be influenced by effects.
        /// </summary>
        Fixed
    }
}
