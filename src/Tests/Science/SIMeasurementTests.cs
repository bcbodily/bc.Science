namespace bc.Science;

/// <summary>
/// Unit tests for <see cref="SIMeasurement{T}"/>
/// </summary>
[TestClass]
public class SIUnitTests
{
    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}.AmountOfSubstanceExponent"/> initializer
    /// properly assigns the specified value to <see cref="SIMeasurement{T}.AmountOfSubstanceExponent"/>
    /// </summary>
    /// <param name="exponent">the test value to assign to the <see cref="SIMeasurement{T}.AmountOfSubstanceExponent"/> initializer</param>
    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    public void AmountOfSubstanceExponent_INIT__assigns_to_AmountOfSubstanceExponent(int exponent)
    {
        var si = new SIMeasurement<int>
        {
            AmountOfSubstanceExponent = exponent
        };

        var actual = si.AmountOfSubstanceExponent;
        var expected = exponent;

        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}.ElectricCurrentExponent"/> initializer
    /// properly assigns the specified value to <see cref="SIMeasurement{T}.ElectricCurrentExponent"/>
    /// </summary>
    /// <param name="exponent">the test value to assign to the <see cref="SIMeasurement{T}.ElectricCurrentExponent"/> initializer</param>
    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    public void ElectricCurrentExponent_INIT__assigns_to_ElectricCurrentExponent(int exponent)
    {
        var si = new SIMeasurement<int>
        {
            ElectricCurrentExponent = exponent
        };

        var actual = si.ElectricCurrentExponent;
        var expected = exponent;

        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}.LengthExponent"/> initializer
    /// properly assigns the specified value to <see cref="SIMeasurement{T}.LengthExponent"/>
    /// </summary>
    /// <param name="exponent">the test value to assign to the <see cref="SIMeasurement{T}.LengthExponent"/> initializer</param>
    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    public void LengthExponent_INIT__assigns_to_LengthExponent(int exponent)
    {
        var si = new SIMeasurement<int>
        {
            LengthExponent = exponent
        };

        var actual = si.LengthExponent;
        var expected = exponent;

        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}.LuminousIntensityExponent"/> initializer
    /// properly assigns the specified value to <see cref="SIMeasurement{T}.LuminousIntensityExponent"/>
    /// </summary>
    /// <param name="exponent">the test value to assign to the <see cref="SIMeasurement{T}.LuminousIntensityExponent"/> initializer</param>
    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    public void LuminousIntensityExponent_INIT__assigns_to_LuminousIntensityExponent(int exponent)
    {
        var si = new SIMeasurement<int>
        {
            LuminousIntensityExponent = exponent
        };

        var actual = si.LuminousIntensityExponent;
        var expected = exponent;

        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}.Magnitude"/> initializer
    /// properly assigns the specified value to <see cref="SIMeasurement{T}.Magnitude"/>
    /// </summary>
    /// <param name="Exponent">the test value to assign to the <see cref="SIMeasurement{T}.Magnitude"/> initializer</param>
    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    public void Magnitude_INIT__assigns_to_Magnitude(int Exponent)
    {
        var si = new SIMeasurement<int>
        {
            Magnitude = Exponent
        };

        var actual = si.Magnitude;
        var expected = Exponent;

        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}.MassExponent"/> initializer
    /// properly assigns the specified value to <see cref="SIMeasurement{T}.MassExponent"/>
    /// </summary>
    /// <param name="exponent">the test value to assign to the <see cref="SIMeasurement{T}.MassExponent"/> initializer</param>
    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    public void MassExponent_INIT__assigns_to_MassExponent(int exponent)
    {
        var si = new SIMeasurement<int>
        {
            MassExponent = exponent
        };

        var actual = si.MassExponent;
        var expected = exponent;

        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}.ThermodynamicTemperatureExponent"/> initializer
    /// properly assigns the specified value to <see cref="SIMeasurement{T}.ThermodynamicTemperatureExponent"/>
    /// </summary>
    /// <param name="exponent">the test value to assign to the <see cref="SIMeasurement{T}.ThermodynamicTemperatureExponent"/> initializer</param>
    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    public void ThermodynamicTemperatureExponent_INIT__assigns_to_ThermodynamicTemperatureExponent(int exponent)
    {
        var si = new SIMeasurement<int>
        {
            ThermodynamicTemperatureExponent = exponent
        };

        var actual = si.ThermodynamicTemperatureExponent;
        var expected = exponent;

        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}.TimeExponent"/> initializer
    /// properly assigns the specified value to <see cref="SIMeasurement{T}.TimeExponent"/>
    /// </summary>
    /// <param name="exponent">the test value to assign to the <see cref="SIMeasurement{T}.TimeExponent"/> initializer</param>
    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    public void TimeExponent_INIT__assigns_to_TimeExponent(int exponent)
    {
        var si = new SIMeasurement<int>
        {
            TimeExponent = exponent
        };

        var actual = si.TimeExponent;
        var expected = exponent;

        Assert.AreEqual(expected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the componets of both arguments are the same,
    /// properly returns a <see cref="SIMeasurement{T}"/>
    /// for which <see cref="SIMeasurement{T}.Magnitude"/> is equal to the sum of the argument magnitudes
    /// </summary>
    /// <param name="magnitude1">the magnitude to assign to the first argument</param>
    /// <param name="magnitude2">the magnitude to assign to the second argument</param>
    [TestMethod]
    [DataRow(1, 2, 3, 4, 5, 6, 7, 1, 3)]
    [DataRow(7, 6, 5, 4, 3, 2, 1, -2, 9)]
    public void OPERATOR_ADD__when_components_are_same__then_result_AmountOfSubstanceExponent_is_the_same(
        int amountOfSubstanceExponent,
        int electricCurrentExponent,
        int lengthExponent,
        int luminousIntensityExponent,
        int massExponent,
        int thermodynamicTemperatureExponent,
        int timeExponent,
        decimal magnitude1,
        decimal magnitude2)
    {
        var si1 = new SIMeasurement<decimal>
        {
            AmountOfSubstanceExponent = amountOfSubstanceExponent,
            ElectricCurrentExponent = electricCurrentExponent,
            LengthExponent = lengthExponent,
            LuminousIntensityExponent = luminousIntensityExponent,
            MassExponent = massExponent,
            ThermodynamicTemperatureExponent = thermodynamicTemperatureExponent,
            TimeExponent = timeExponent,
            Magnitude = magnitude1
        };

        var si2 = new SIMeasurement<decimal>
        {
            AmountOfSubstanceExponent = amountOfSubstanceExponent,
            ElectricCurrentExponent = electricCurrentExponent,
            LengthExponent = lengthExponent,
            LuminousIntensityExponent = luminousIntensityExponent,
            MassExponent = massExponent,
            ThermodynamicTemperatureExponent = thermodynamicTemperatureExponent,
            TimeExponent = timeExponent,
            Magnitude = magnitude2
        };

        Assert.AreEqual(si2.AmountOfSubstanceExponent, si1.AmountOfSubstanceExponent);
        Assert.AreEqual(si2.ElectricCurrentExponent, si1.ElectricCurrentExponent);
        Assert.AreEqual(si2.LengthExponent, si1.LengthExponent);
        Assert.AreEqual(si2.LuminousIntensityExponent, si1.LuminousIntensityExponent);
        Assert.AreEqual(si2.MassExponent, si1.MassExponent);
        Assert.AreEqual(si2.ThermodynamicTemperatureExponent, si1.ThermodynamicTemperatureExponent);
        Assert.AreEqual(si2.TimeExponent, si1.TimeExponent);

        var actual = (si1 + si2).AmountOfSubstanceExponent;
        var excpected = si1.AmountOfSubstanceExponent;

        Assert.AreEqual(excpected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the componets of both arguments are the same,
    /// properly returns a <see cref="SIMeasurement{T}"/>
    /// for which <see cref="SIMeasurement{T}.Magnitude"/> is equal to the sum of the argument magnitudes
    /// </summary>
    /// <param name="magnitude1">the magnitude to assign to the first argument</param>
    /// <param name="magnitude2">the magnitude to assign to the second argument</param>
    [TestMethod]
    [DataRow(1, 2, 3, 4, 5, 6, 7, 1, 3)]
    [DataRow(7, 6, 5, 4, 3, 2, 1, -2, 9)]
    public void OPERATOR_ADD__when_components_are_same__then_result_Magnitude_is_equal_to_sum_of_Magnitudes(
        int amountOfSubstanceExponent,
        int electricCurrentExponent,
        int lengthExponent,
        int luminousIntensityExponent,
        int massExponent,
        int thermodynamicTemperatureExponent,
        int timeExponent,
        decimal magnitude1,
        decimal magnitude2)
    {
        var si1 = new SIMeasurement<decimal>
        {
            AmountOfSubstanceExponent = amountOfSubstanceExponent,
            ElectricCurrentExponent = electricCurrentExponent,
            LengthExponent = lengthExponent,
            LuminousIntensityExponent = luminousIntensityExponent,
            MassExponent = massExponent,
            ThermodynamicTemperatureExponent = thermodynamicTemperatureExponent,
            TimeExponent = timeExponent,
            Magnitude = magnitude1
        };

        var si2 = new SIMeasurement<decimal>
        {
            AmountOfSubstanceExponent = amountOfSubstanceExponent,
            ElectricCurrentExponent = electricCurrentExponent,
            LengthExponent = lengthExponent,
            LuminousIntensityExponent = luminousIntensityExponent,
            MassExponent = massExponent,
            ThermodynamicTemperatureExponent = thermodynamicTemperatureExponent,
            TimeExponent = timeExponent,
            Magnitude = magnitude2
        };

        Assert.AreEqual(si2.AmountOfSubstanceExponent, si1.AmountOfSubstanceExponent);
        Assert.AreEqual(si2.ElectricCurrentExponent, si1.ElectricCurrentExponent);
        Assert.AreEqual(si2.LengthExponent, si1.LengthExponent);
        Assert.AreEqual(si2.LuminousIntensityExponent, si1.LuminousIntensityExponent);
        Assert.AreEqual(si2.MassExponent, si1.MassExponent);
        Assert.AreEqual(si2.ThermodynamicTemperatureExponent, si1.ThermodynamicTemperatureExponent);
        Assert.AreEqual(si2.TimeExponent, si1.TimeExponent);

        var actual = (si1 + si2).Magnitude;
        var excpected = magnitude1 + magnitude2;

        Assert.AreEqual(excpected, actual);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the <see cref="SIMeasurement{T}.AmountOfSubstanceExponent"/> values for the addends are not equal,
    /// properly throws <see cref="InvalidOperationException"/>
    /// </summary>
    [TestMethod]
    public void OPERATOR_ADD__when_AmountOfSubstance_is_different__then_throws_InvalidOperationException()
    {
        var si1 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            AmountOfSubstanceExponent = 1
        };

        var si2 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            AmountOfSubstanceExponent = 2
        };

        Assert.IsTrue(si1.AmountOfSubstanceExponent != si2.AmountOfSubstanceExponent);

        Assert.ThrowsException<InvalidOperationException>(() =>
            si1 + si2
        );
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the <see cref="SIMeasurement{T}.ElectricCurrentExponent"/> values for the addends are not equal,
    /// properly throws <see cref="InvalidOperationException"/>
    /// </summary>
    [TestMethod]
    public void OPERATOR_ADD__when_ElectricCurrentExponent_is_different__then_throws_InvalidOperationException()
    {
        var si1 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            ElectricCurrentExponent = 1
        };

        var si2 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            ElectricCurrentExponent = 2
        };

        Assert.IsTrue(si1.ElectricCurrentExponent != si2.ElectricCurrentExponent);

        Assert.ThrowsException<InvalidOperationException>(() =>
            si1 + si2
        );
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the <see cref="SIMeasurement{T}.LengthExponent"/> values for the addends are not equal,
    /// properly throws <see cref="InvalidOperationException"/>
    /// </summary>
    [TestMethod]
    public void OPERATOR_ADD__when_LengthExponent_is_different__then_throws_InvalidOperationException()
    {
        var si1 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            LengthExponent = 1
        };

        var si2 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            LengthExponent = 2
        };

        Assert.IsTrue(si1.LengthExponent != si2.LengthExponent);

        Assert.ThrowsException<InvalidOperationException>(() =>
            si1 + si2
        );
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the <see cref="SIMeasurement{T}.LuminousIntensityExponent"/> values for the addends are not equal,
    /// properly throws <see cref="InvalidOperationException"/>
    /// </summary>
    [TestMethod]
    public void OPERATOR_ADD__when_LuminousIntensityExponent_is_different__then_throws_InvalidOperationException()
    {
        var si1 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            LuminousIntensityExponent = 1
        };

        var si2 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            LuminousIntensityExponent = 2
        };

        Assert.IsTrue(si1.LuminousIntensityExponent != si2.LuminousIntensityExponent);

        Assert.ThrowsException<InvalidOperationException>(() =>
            si1 + si2
        );
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the <see cref="SIMeasurement{T}.MassExponent"/> values for the addends are not equal,
    /// properly throws <see cref="InvalidOperationException"/>
    /// </summary>
    [TestMethod]
    public void OPERATOR_ADD__when_MassExponent_is_different__then_throws_InvalidOperationException()
    {
        var si1 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            MassExponent = 1
        };

        var si2 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            MassExponent = 2
        };

        Assert.IsTrue(si1.MassExponent != si2.MassExponent);

        Assert.ThrowsException<InvalidOperationException>(() =>
            si1 + si2
        );
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the <see cref="SIMeasurement{T}.ThermodynamicTemperatureExponent"/> values for the addends are not equal,
    /// properly throws <see cref="InvalidOperationException"/>
    /// </summary>
    [TestMethod]
    public void OPERATOR_ADD__when_ThermodynamicTemperatureExponent_is_different__then_throws_InvalidOperationException()
    {
        var si1 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            ThermodynamicTemperatureExponent = 1
        };

        var si2 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            ThermodynamicTemperatureExponent = 2
        };

        Assert.IsTrue(si1.ThermodynamicTemperatureExponent != si2.ThermodynamicTemperatureExponent);

        Assert.ThrowsException<InvalidOperationException>(() =>
            si1 + si2
        );
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>+</c> operator,
    /// when the <see cref="SIMeasurement{T}.TimeExponent"/> values for the addends are not equal,
    /// properly throws <see cref="InvalidOperationException"/>
    /// </summary>
    [TestMethod]
    public void OPERATOR_ADD__when_TimeExponent_is_different__then_throws_InvalidOperationException()
    {
        var si1 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            TimeExponent = 1
        };

        var si2 = new SIMeasurement<float>
        {
            Magnitude = 1.0f,
            TimeExponent = 2
        };

        Assert.IsTrue(si1.TimeExponent != si2.TimeExponent);

        Assert.ThrowsException<InvalidOperationException>(() =>
            si1 + si2
        );
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>*</c> operator
    /// properly returns a result for which the value of <see cref="SIMeasurement{T}.AmountOfSubstanceExponent"/>
    /// is equal to the sum of the <see cref="SIMeasurement{T}.AmountOfSubstanceExponent"/> values of the operands
    /// </summary>
    /// <param name="exponent1">the test value to assigned to the first <see cref="SIMeasurement{T}.AmountOfSubstanceExponent"/> value</param>
    /// <param name="exponent2">the test value to assigned to the second <see cref="SIMeasurement{T}.AmountOfSubstanceExponent"/> value</param>
    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(-1, -1)]
    [DataRow(-1, 2)]
    [DataRow(2, 2)]
    public void OPERATOR_MULTIPLY__result_AmountOfSubstanceExponent_is_equal_to_sum_of_AmountOfSubstanceExponent(int exponent1, int exponent2)
    {
        var si1 = new SIMeasurement<float> { AmountOfSubstanceExponent = exponent1 };
        var si2 = new SIMeasurement<float> { AmountOfSubstanceExponent = exponent2 };

        var acutal = (si1 * si2).AmountOfSubstanceExponent;
        var expected = exponent1 + exponent2;

        Assert.AreEqual(expected, acutal);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>*</c> operator
    /// properly returns a result for which the value of <see cref="SIMeasurement{T}.ElectricCurrentExponent"/>
    /// is equal to the sum of the <see cref="SIMeasurement{T}.ElectricCurrentExponent"/> values of the operands
    /// </summary>
    /// <param name="exponent1">the test value to assigned to the first <see cref="SIMeasurement{T}.ElectricCurrentExponent"/> value</param>
    /// <param name="exponent2">the test value to assigned to the second <see cref="SIMeasurement{T}.ElectricCurrentExponent"/> value</param>
    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(-1, -1)]
    [DataRow(-1, 2)]
    [DataRow(2, 2)]
    public void OPERATOR_MULTIPLY__result_ElectricCurrentExponent_is_equal_to_sum_of_ElectricCurrentExponent(int exponent1, int exponent2)
    {
        var si1 = new SIMeasurement<float> { ElectricCurrentExponent = exponent1 };
        var si2 = new SIMeasurement<float> { ElectricCurrentExponent = exponent2 };

        var acutal = (si1 * si2).ElectricCurrentExponent;
        var expected = exponent1 + exponent2;

        Assert.AreEqual(expected, acutal);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>*</c> operator
    /// properly returns a result for which the value of <see cref="SIMeasurement{T}.LengthExponent"/>
    /// is equal to the sum of the <see cref="SIMeasurement{T}.LengthExponent"/> values of the operands
    /// </summary>
    /// <param name="exponent1">the test value to assigned to the first <see cref="SIMeasurement{T}.LengthExponent"/> value</param>
    /// <param name="exponent2">the test value to assigned to the second <see cref="SIMeasurement{T}.LengthExponent"/> value</param>
    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(-1, -1)]
    [DataRow(-1, 2)]
    [DataRow(2, 2)]
    public void OPERATOR_MULTIPLY__result_LengthExponent_is_equal_to_sum_of_LengthExponent(int exponent1, int exponent2)
    {
        var si1 = new SIMeasurement<float> { LengthExponent = exponent1 };
        var si2 = new SIMeasurement<float> { LengthExponent = exponent2 };

        var acutal = (si1 * si2).LengthExponent;
        var expected = exponent1 + exponent2;

        Assert.AreEqual(expected, acutal);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>*</c> operator
    /// properly returns a result for which the value of <see cref="SIMeasurement{T}.LuminousIntensityExponent"/>
    /// is equal to the sum of the <see cref="SIMeasurement{T}.LuminousIntensityExponent"/> values of the operands
    /// </summary>
    /// <param name="exponent1">the test value to assigned to the first <see cref="SIMeasurement{T}.LuminousIntensityExponent"/> value</param>
    /// <param name="exponent2">the test value to assigned to the second <see cref="SIMeasurement{T}.LuminousIntensityExponent"/> value</param>
    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(-1, -1)]
    [DataRow(-1, 2)]
    [DataRow(2, 2)]
    public void OPERATOR_MULTIPLY__result_LuminousIntensityExponent_is_equal_to_sum_of_LuminousIntensityExponent(int exponent1, int exponent2)
    {
        var si1 = new SIMeasurement<float> { LuminousIntensityExponent = exponent1 };
        var si2 = new SIMeasurement<float> { LuminousIntensityExponent = exponent2 };

        var acutal = (si1 * si2).LuminousIntensityExponent;
        var expected = exponent1 + exponent2;

        Assert.AreEqual(expected, acutal);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>*</c> operator
    /// properly returns a result for which the value of <see cref="SIMeasurement{T}.MassExponent"/>
    /// is equal to the sum of the <see cref="SIMeasurement{T}.MassExponent"/> values of the operands
    /// </summary>
    /// <param name="exponent1">the test value to assigned to the first <see cref="SIMeasurement{T}.MassExponent"/> value</param>
    /// <param name="exponent2">the test value to assigned to the second <see cref="SIMeasurement{T}.MassExponent"/> value</param>
    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(-1, -1)]
    [DataRow(-1, 2)]
    [DataRow(2, 2)]
    public void OPERATOR_MULTIPLY__result_MassExponent_is_equal_to_sum_of_MassExponent(int exponent1, int exponent2)
    {
        var si1 = new SIMeasurement<float> { MassExponent = exponent1 };
        var si2 = new SIMeasurement<float> { MassExponent = exponent2 };

        var acutal = (si1 * si2).MassExponent;
        var expected = exponent1 + exponent2;

        Assert.AreEqual(expected, acutal);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>*</c> operator
    /// properly returns a result for which the value of <see cref="SIMeasurement{T}.ThermodynamicTemperatureExponent"/>
    /// is equal to the sum of the <see cref="SIMeasurement{T}.ThermodynamicTemperatureExponent"/> values of the operands
    /// </summary>
    /// <param name="exponent1">the test value to assigned to the first <see cref="SIMeasurement{T}.ThermodynamicTemperatureExponent"/> value</param>
    /// <param name="exponent2">the test value to assigned to the second <see cref="SIMeasurement{T}.ThermodynamicTemperatureExponent"/> value</param>
    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(-1, -1)]
    [DataRow(-1, 2)]
    [DataRow(2, 2)]
    public void OPERATOR_MULTIPLY__result_ThermodynamicTemperatureExponent_is_equal_to_sum_of_ThermodynamicTemperatureExponent(int exponent1, int exponent2)
    {
        var si1 = new SIMeasurement<float> { ThermodynamicTemperatureExponent = exponent1 };
        var si2 = new SIMeasurement<float> { ThermodynamicTemperatureExponent = exponent2 };

        var acutal = (si1 * si2).ThermodynamicTemperatureExponent;
        var expected = exponent1 + exponent2;

        Assert.AreEqual(expected, acutal);
    }

    /// <summary>
    /// Verifies the <see cref="SIMeasurement{T}"/> <c>*</c> operator
    /// properly returns a result for which the value of <see cref="SIMeasurement{T}.TimeExponent"/>
    /// is equal to the sum of the <see cref="SIMeasurement{T}.TimeExponent"/> values of the operands
    /// </summary>
    /// <param name="exponent1">the test value to assigned to the first <see cref="SIMeasurement{T}.TimeExponent"/> value</param>
    /// <param name="exponent2">the test value to assigned to the second <see cref="SIMeasurement{T}.TimeExponent"/> value</param>
    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(-1, -1)]
    [DataRow(-1, 2)]
    [DataRow(2, 2)]
    public void OPERATOR_MULTIPLY__result_TimeExponent_is_equal_to_sum_of_TimeExponents(int exponent1, int exponent2)
    {
        var si1 = new SIMeasurement<float> { TimeExponent = exponent1 };
        var si2 = new SIMeasurement<float> { TimeExponent = exponent2 };

        var acutal = (si1 * si2).TimeExponent;
        var expected = exponent1 + exponent2;

        Assert.AreEqual(expected, acutal);
    }
}