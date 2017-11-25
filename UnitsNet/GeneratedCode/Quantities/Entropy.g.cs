﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Entropy is an important concept in the branch of science known as thermodynamics. The idea of "irreversibility" is central to the understanding of entropy.  It is often said that entropy is an expression of the disorder, or randomness of a system, or of our lack of information about it. Entropy is an extensive property. It has the dimension of energy divided by temperature, which has a unit of joules per kelvin (J/K) in the International System of Units
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Entropy
#else
    public partial struct Entropy : IComparable, IComparable<Entropy>
#endif
    {
        /// <summary>
        ///     Base unit of Entropy.
        /// </summary>
        private readonly double _joulesPerKelvin;

        // Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public Entropy() : this(0)
        {
        }
#endif

        public Entropy(double joulesperkelvin)
        {
            _joulesPerKelvin = Convert.ToDouble(joulesperkelvin);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        Entropy(long joulesperkelvin)
        {
            _joulesPerKelvin = Convert.ToDouble(joulesperkelvin);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        Entropy(decimal joulesperkelvin)
        {
            _joulesPerKelvin = Convert.ToDouble(joulesperkelvin);
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Entropy;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static EntropyUnit BaseUnit
        {
            get { return EntropyUnit.JoulePerKelvin; }
        }

        /// <summary>
        ///     All units of measurement for the Entropy quantity.
        /// </summary>
        public static EntropyUnit[] Units { get; } = Enum.GetValues(typeof(EntropyUnit)).Cast<EntropyUnit>().ToArray();

        /// <summary>
        ///     Get Entropy in CaloriesPerKelvin.
        /// </summary>
        public double CaloriesPerKelvin
        {
            get { return _joulesPerKelvin/4.184; }
        }

        /// <summary>
        ///     Get Entropy in JoulesPerDegreeCelsius.
        /// </summary>
        public double JoulesPerDegreeCelsius
        {
            get { return _joulesPerKelvin; }
        }

        /// <summary>
        ///     Get Entropy in JoulesPerKelvin.
        /// </summary>
        public double JoulesPerKelvin
        {
            get { return _joulesPerKelvin; }
        }

        /// <summary>
        ///     Get Entropy in KilocaloriesPerKelvin.
        /// </summary>
        public double KilocaloriesPerKelvin
        {
            get { return (_joulesPerKelvin/4.184) / 1e3d; }
        }

        /// <summary>
        ///     Get Entropy in KilojoulesPerDegreeCelsius.
        /// </summary>
        public double KilojoulesPerDegreeCelsius
        {
            get { return (_joulesPerKelvin) / 1e3d; }
        }

        /// <summary>
        ///     Get Entropy in KilojoulesPerKelvin.
        /// </summary>
        public double KilojoulesPerKelvin
        {
            get { return (_joulesPerKelvin) / 1e3d; }
        }

        /// <summary>
        ///     Get Entropy in MegajoulesPerKelvin.
        /// </summary>
        public double MegajoulesPerKelvin
        {
            get { return (_joulesPerKelvin) / 1e6d; }
        }

        #endregion

        #region Static

        public static Entropy Zero
        {
            get { return new Entropy(); }
        }

        /// <summary>
        ///     Get Entropy from CaloriesPerKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Entropy FromCaloriesPerKelvin(double caloriesperkelvin)
        {
            double value = (double) caloriesperkelvin;
            return new Entropy(value*4.184);
        }
#else
        public static Entropy FromCaloriesPerKelvin(QuantityValue caloriesperkelvin)
        {
            double value = (double) caloriesperkelvin;
            return new Entropy((value*4.184));
        }
#endif

        /// <summary>
        ///     Get Entropy from JoulesPerDegreeCelsius.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Entropy FromJoulesPerDegreeCelsius(double joulesperdegreecelsius)
        {
            double value = (double) joulesperdegreecelsius;
            return new Entropy(value);
        }
#else
        public static Entropy FromJoulesPerDegreeCelsius(QuantityValue joulesperdegreecelsius)
        {
            double value = (double) joulesperdegreecelsius;
            return new Entropy((value));
        }
#endif

        /// <summary>
        ///     Get Entropy from JoulesPerKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Entropy FromJoulesPerKelvin(double joulesperkelvin)
        {
            double value = (double) joulesperkelvin;
            return new Entropy(value);
        }
#else
        public static Entropy FromJoulesPerKelvin(QuantityValue joulesperkelvin)
        {
            double value = (double) joulesperkelvin;
            return new Entropy((value));
        }
#endif

        /// <summary>
        ///     Get Entropy from KilocaloriesPerKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Entropy FromKilocaloriesPerKelvin(double kilocaloriesperkelvin)
        {
            double value = (double) kilocaloriesperkelvin;
            return new Entropy((value*4.184) * 1e3d);
        }
#else
        public static Entropy FromKilocaloriesPerKelvin(QuantityValue kilocaloriesperkelvin)
        {
            double value = (double) kilocaloriesperkelvin;
            return new Entropy(((value*4.184) * 1e3d));
        }
#endif

        /// <summary>
        ///     Get Entropy from KilojoulesPerDegreeCelsius.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Entropy FromKilojoulesPerDegreeCelsius(double kilojoulesperdegreecelsius)
        {
            double value = (double) kilojoulesperdegreecelsius;
            return new Entropy((value) * 1e3d);
        }
#else
        public static Entropy FromKilojoulesPerDegreeCelsius(QuantityValue kilojoulesperdegreecelsius)
        {
            double value = (double) kilojoulesperdegreecelsius;
            return new Entropy(((value) * 1e3d));
        }
#endif

        /// <summary>
        ///     Get Entropy from KilojoulesPerKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Entropy FromKilojoulesPerKelvin(double kilojoulesperkelvin)
        {
            double value = (double) kilojoulesperkelvin;
            return new Entropy((value) * 1e3d);
        }
#else
        public static Entropy FromKilojoulesPerKelvin(QuantityValue kilojoulesperkelvin)
        {
            double value = (double) kilojoulesperkelvin;
            return new Entropy(((value) * 1e3d));
        }
#endif

        /// <summary>
        ///     Get Entropy from MegajoulesPerKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Entropy FromMegajoulesPerKelvin(double megajoulesperkelvin)
        {
            double value = (double) megajoulesperkelvin;
            return new Entropy((value) * 1e6d);
        }
#else
        public static Entropy FromMegajoulesPerKelvin(QuantityValue megajoulesperkelvin)
        {
            double value = (double) megajoulesperkelvin;
            return new Entropy(((value) * 1e6d));
        }
#endif

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable Entropy from nullable CaloriesPerKelvin.
        /// </summary>
        public static Entropy? FromCaloriesPerKelvin(QuantityValue? caloriesperkelvin)
        {
            if (caloriesperkelvin.HasValue)
            {
                return FromCaloriesPerKelvin(caloriesperkelvin.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Entropy from nullable JoulesPerDegreeCelsius.
        /// </summary>
        public static Entropy? FromJoulesPerDegreeCelsius(QuantityValue? joulesperdegreecelsius)
        {
            if (joulesperdegreecelsius.HasValue)
            {
                return FromJoulesPerDegreeCelsius(joulesperdegreecelsius.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Entropy from nullable JoulesPerKelvin.
        /// </summary>
        public static Entropy? FromJoulesPerKelvin(QuantityValue? joulesperkelvin)
        {
            if (joulesperkelvin.HasValue)
            {
                return FromJoulesPerKelvin(joulesperkelvin.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Entropy from nullable KilocaloriesPerKelvin.
        /// </summary>
        public static Entropy? FromKilocaloriesPerKelvin(QuantityValue? kilocaloriesperkelvin)
        {
            if (kilocaloriesperkelvin.HasValue)
            {
                return FromKilocaloriesPerKelvin(kilocaloriesperkelvin.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Entropy from nullable KilojoulesPerDegreeCelsius.
        /// </summary>
        public static Entropy? FromKilojoulesPerDegreeCelsius(QuantityValue? kilojoulesperdegreecelsius)
        {
            if (kilojoulesperdegreecelsius.HasValue)
            {
                return FromKilojoulesPerDegreeCelsius(kilojoulesperdegreecelsius.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Entropy from nullable KilojoulesPerKelvin.
        /// </summary>
        public static Entropy? FromKilojoulesPerKelvin(QuantityValue? kilojoulesperkelvin)
        {
            if (kilojoulesperkelvin.HasValue)
            {
                return FromKilojoulesPerKelvin(kilojoulesperkelvin.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Entropy from nullable MegajoulesPerKelvin.
        /// </summary>
        public static Entropy? FromMegajoulesPerKelvin(QuantityValue? megajoulesperkelvin)
        {
            if (megajoulesperkelvin.HasValue)
            {
                return FromMegajoulesPerKelvin(megajoulesperkelvin.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="EntropyUnit" /> to <see cref="Entropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Entropy unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Entropy From(double value, EntropyUnit fromUnit)
#else
        public static Entropy From(QuantityValue value, EntropyUnit fromUnit)
#endif
        {
            switch (fromUnit)
            {
                case EntropyUnit.CaloriePerKelvin:
                    return FromCaloriesPerKelvin(value);
                case EntropyUnit.JoulePerDegreeCelsius:
                    return FromJoulesPerDegreeCelsius(value);
                case EntropyUnit.JoulePerKelvin:
                    return FromJoulesPerKelvin(value);
                case EntropyUnit.KilocaloriePerKelvin:
                    return FromKilocaloriesPerKelvin(value);
                case EntropyUnit.KilojoulePerDegreeCelsius:
                    return FromKilojoulesPerDegreeCelsius(value);
                case EntropyUnit.KilojoulePerKelvin:
                    return FromKilojoulesPerKelvin(value);
                case EntropyUnit.MegajoulePerKelvin:
                    return FromMegajoulesPerKelvin(value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="EntropyUnit" /> to <see cref="Entropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Entropy unit value.</returns>
        public static Entropy? From(QuantityValue? value, EntropyUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case EntropyUnit.CaloriePerKelvin:
                    return FromCaloriesPerKelvin(value.Value);
                case EntropyUnit.JoulePerDegreeCelsius:
                    return FromJoulesPerDegreeCelsius(value.Value);
                case EntropyUnit.JoulePerKelvin:
                    return FromJoulesPerKelvin(value.Value);
                case EntropyUnit.KilocaloriePerKelvin:
                    return FromKilocaloriesPerKelvin(value.Value);
                case EntropyUnit.KilojoulePerDegreeCelsius:
                    return FromKilojoulesPerDegreeCelsius(value.Value);
                case EntropyUnit.KilojoulePerKelvin:
                    return FromKilojoulesPerKelvin(value.Value);
                case EntropyUnit.MegajoulePerKelvin:
                    return FromMegajoulesPerKelvin(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(EntropyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(EntropyUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static Entropy operator -(Entropy right)
        {
            return new Entropy(-right._joulesPerKelvin);
        }

        public static Entropy operator +(Entropy left, Entropy right)
        {
            return new Entropy(left._joulesPerKelvin + right._joulesPerKelvin);
        }

        public static Entropy operator -(Entropy left, Entropy right)
        {
            return new Entropy(left._joulesPerKelvin - right._joulesPerKelvin);
        }

        public static Entropy operator *(double left, Entropy right)
        {
            return new Entropy(left*right._joulesPerKelvin);
        }

        public static Entropy operator *(Entropy left, double right)
        {
            return new Entropy(left._joulesPerKelvin*(double)right);
        }

        public static Entropy operator /(Entropy left, double right)
        {
            return new Entropy(left._joulesPerKelvin/(double)right);
        }

        public static double operator /(Entropy left, Entropy right)
        {
            return Convert.ToDouble(left._joulesPerKelvin/right._joulesPerKelvin);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is Entropy)) throw new ArgumentException("Expected type Entropy.", "obj");
            return CompareTo((Entropy) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Entropy other)
        {
            return _joulesPerKelvin.CompareTo(other._joulesPerKelvin);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(Entropy left, Entropy right)
        {
            return left._joulesPerKelvin <= right._joulesPerKelvin;
        }

        public static bool operator >=(Entropy left, Entropy right)
        {
            return left._joulesPerKelvin >= right._joulesPerKelvin;
        }

        public static bool operator <(Entropy left, Entropy right)
        {
            return left._joulesPerKelvin < right._joulesPerKelvin;
        }

        public static bool operator >(Entropy left, Entropy right)
        {
            return left._joulesPerKelvin > right._joulesPerKelvin;
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Entropy left, Entropy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._joulesPerKelvin == right._joulesPerKelvin;
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Entropy left, Entropy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._joulesPerKelvin != right._joulesPerKelvin;
        }
#endif

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _joulesPerKelvin.Equals(((Entropy) obj)._joulesPerKelvin);
        }

        /// <summary>
        ///     Compare equality to another Entropy by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        public bool Equals(Entropy other, Entropy maxError)
        {
            return Math.Abs(_joulesPerKelvin - other._joulesPerKelvin) <= maxError._joulesPerKelvin;
        }

        public override int GetHashCode()
        {
            return _joulesPerKelvin.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(EntropyUnit unit)
        {
            switch (unit)
            {
                case EntropyUnit.CaloriePerKelvin:
                    return CaloriesPerKelvin;
                case EntropyUnit.JoulePerDegreeCelsius:
                    return JoulesPerDegreeCelsius;
                case EntropyUnit.JoulePerKelvin:
                    return JoulesPerKelvin;
                case EntropyUnit.KilocaloriePerKelvin:
                    return KilocaloriesPerKelvin;
                case EntropyUnit.KilojoulePerDegreeCelsius:
                    return KilojoulesPerDegreeCelsius;
                case EntropyUnit.KilojoulePerKelvin:
                    return KilojoulesPerKelvin;
                case EntropyUnit.MegajoulePerKelvin:
                    return MegajoulesPerKelvin;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Entropy Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Entropy Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return QuantityParser.Parse<Entropy, EntropyUnit>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    EntropyUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromJoulesPerKelvin(x.JoulesPerKelvin + y.JoulesPerKelvin));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Entropy result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out Entropy result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(Entropy);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static EntropyUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static EntropyUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static EntropyUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<EntropyUnit>(str.Trim());

            if (unit == EntropyUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized EntropyUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is JoulePerKelvin
        /// </summary>
        public static EntropyUnit ToStringDefaultUnit { get; set; } = EntropyUnit.JoulePerKelvin;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(EntropyUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(EntropyUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(EntropyUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(EntropyUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of Entropy
        /// </summary>
        public static Entropy MaxValue
        {
            get
            {
                return new Entropy(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of Entropy
        /// </summary>
        public static Entropy MinValue
        {
            get
            {
                return new Entropy(double.MinValue);
            }
        }
    }
}
