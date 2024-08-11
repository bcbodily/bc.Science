using System.Numerics;

namespace bc.Science;

public readonly record struct SIMeasurement<T> where T : INumber<T>
{
    /// <summary>
    /// The amount of substance exponent of this value
    /// </summary>
    /// <value></value>
    public int AmountOfSubstanceExponent { get; init; }

    /// <summary>
    /// The electric current exponent of this value
    /// </summary>
    /// <value></value>
    public int ElectricCurrentExponent { get; init; }

    /// <summary>
    /// The length exponent of this value
    /// </summary>
    /// <value></value>
    public int LengthExponent { get; init; }

    /// <summary>
    /// The luminous intensity exponent of this value
    /// </summary>
    /// <value></value>
    public int LuminousIntensityExponent { get; init; }

    /// <summary>
    /// The magnitude in SI base units of this value
    /// </summary>
    /// <value></value>
    public T Magnitude { get; init; }

    /// <summary>
    /// The mass exponent of this value
    /// </summary>
    /// <value></value>
    public int MassExponent { get; init; }

    /// <summary>
    /// The thermodynamic temperature exponent of this value
    /// </summary>
    /// <value></value>
    public int ThermodynamicTemperatureExponent { get; init; }

    /// <summary>
    /// The time exponent of this value
    /// </summary>
    /// <value></value>
    public int TimeExponent { get; init; }

    /// <summary>
    /// Adds one <see cref="SIMeasurement{T}"/> value to another <see cref="SIMeasurement{T}"/> value
    /// </summary>
    /// <param name="lhs">the augend</param>
    /// <param name="rhs">the addend</param>
    /// <returns>the result of adding <paramref name="rhs"/> to <paramref name="lhs"/></returns>
    /// <exception cref="IllegalOperationException">when <paramref name="rhs"/> has different factors than <paramref name="lhs"/>
    public static SIMeasurement<T> operator +(SIMeasurement<T> lhs, SIMeasurement<T> rhs)
    {
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.AmountOfSubstanceExponent, rhs.AmountOfSubstanceExponent, nameof(AmountOfSubstanceExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.ElectricCurrentExponent, rhs.ElectricCurrentExponent, nameof(ElectricCurrentExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.LengthExponent, rhs.LengthExponent, nameof(LengthExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.LuminousIntensityExponent, rhs.LuminousIntensityExponent, nameof(LuminousIntensityExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.MassExponent, rhs.MassExponent, nameof(MassExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.ThermodynamicTemperatureExponent, rhs.ThermodynamicTemperatureExponent, nameof(ThermodynamicTemperatureExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.TimeExponent, rhs.TimeExponent, nameof(TimeExponent));


        return lhs with { Magnitude = lhs.Magnitude + rhs.Magnitude };
    }

    public static SIMeasurement<T> operator -(SIMeasurement<T> lhs, SIMeasurement<T> rhs)
    {
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.AmountOfSubstanceExponent, rhs.AmountOfSubstanceExponent, nameof(AmountOfSubstanceExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.ElectricCurrentExponent, rhs.ElectricCurrentExponent, nameof(ElectricCurrentExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.LengthExponent, rhs.LengthExponent, nameof(LengthExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.LuminousIntensityExponent, rhs.LuminousIntensityExponent, nameof(LuminousIntensityExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.MassExponent, rhs.MassExponent, nameof(MassExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.ThermodynamicTemperatureExponent, rhs.ThermodynamicTemperatureExponent, nameof(ThermodynamicTemperatureExponent));
        ThrowIllegalOperationExceptionIfValuesAreDifferent(lhs.TimeExponent, rhs.TimeExponent, nameof(TimeExponent));

        return lhs with { Magnitude = lhs.Magnitude - rhs.Magnitude };
    }

    public static SIMeasurement<T> operator *(SIMeasurement<T> lhs, SIMeasurement<T> rhs)
    {
        return new SIMeasurement<T>
        {
            Magnitude = lhs.Magnitude * rhs.Magnitude,
            AmountOfSubstanceExponent = lhs.AmountOfSubstanceExponent + rhs.AmountOfSubstanceExponent,
            ElectricCurrentExponent = lhs.ElectricCurrentExponent + rhs.ElectricCurrentExponent,
            LengthExponent = lhs.LengthExponent + rhs.LengthExponent,
            LuminousIntensityExponent = lhs.LuminousIntensityExponent + rhs.LuminousIntensityExponent,
            MassExponent = lhs.MassExponent + rhs.MassExponent,
            ThermodynamicTemperatureExponent = lhs.ThermodynamicTemperatureExponent + rhs.ThermodynamicTemperatureExponent,
            TimeExponent = lhs.TimeExponent + rhs.TimeExponent
        };
    }

    public static SIMeasurement<T> operator /(SIMeasurement<T> lhs, SIMeasurement<T> rhs)
    {
        return new SIMeasurement<T>
        {
            Magnitude = lhs.Magnitude / rhs.Magnitude,
            AmountOfSubstanceExponent = lhs.AmountOfSubstanceExponent - rhs.AmountOfSubstanceExponent,
            ElectricCurrentExponent = lhs.ElectricCurrentExponent - rhs.ElectricCurrentExponent,
            LengthExponent = lhs.LengthExponent - rhs.LengthExponent,
            LuminousIntensityExponent = lhs.LuminousIntensityExponent - rhs.LuminousIntensityExponent,
            ThermodynamicTemperatureExponent = lhs.ThermodynamicTemperatureExponent - rhs.ThermodynamicTemperatureExponent,
            TimeExponent = lhs.TimeExponent - rhs.TimeExponent
        };
    }

    private static void ThrowIllegalOperationExceptionIfValuesAreDifferent(int lhs, int rhs, string nameOfExponent)
    {
        if (lhs != rhs)
        {
            throw new InvalidOperationException($"value must have identical {nameOfExponent} values, but differed; lhs: {lhs}, rhs: {rhs}");
        }
    }
}