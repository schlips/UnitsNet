﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
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
    ///     The Electric Potential of a system known to use Alternating Current.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class ElectricPotentialAc
#else
    public partial struct ElectricPotentialAc : IComparable, IComparable<ElectricPotentialAc>
#endif
    {
        /// <summary>
        ///     Base unit of ElectricPotentialAc.
        /// </summary>
        private readonly double _voltsAc;

		// Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public ElectricPotentialAc() : this(0)
        {
        }
#endif

        public ElectricPotentialAc(double voltsac)
        {
            _voltsAc = Convert.ToDouble(voltsac);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        ElectricPotentialAc(long voltsac)
        {
            _voltsAc = Convert.ToDouble(voltsac);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        ElectricPotentialAc(decimal voltsac)
        {
            _voltsAc = Convert.ToDouble(voltsac);
        }

        #region Properties

		/// <summary>
		///     The <see cref="QuantityType" /> of this quantity.
		/// </summary>
        public static QuantityType QuantityType => QuantityType.ElectricPotentialAc;

		/// <summary>
		///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
		/// </summary>
        public static ElectricPotentialAcUnit BaseUnit
        {
            get { return ElectricPotentialAcUnit.VoltAc; }
        }

        /// <summary>
        ///     All units of measurement for the ElectricPotentialAc quantity.
        /// </summary>
        public static ElectricPotentialAcUnit[] Units { get; } = Enum.GetValues(typeof(ElectricPotentialAcUnit)).Cast<ElectricPotentialAcUnit>().ToArray();

        /// <summary>
        ///     Get ElectricPotentialAc in KilovoltsAc.
        /// </summary>
        public double KilovoltsAc
        {
            get { return (_voltsAc) / 1e3d; }
        }

        /// <summary>
        ///     Get ElectricPotentialAc in MegavoltsAc.
        /// </summary>
        public double MegavoltsAc
        {
            get { return (_voltsAc) / 1e6d; }
        }

        /// <summary>
        ///     Get ElectricPotentialAc in MicrovoltsAc.
        /// </summary>
        public double MicrovoltsAc
        {
            get { return (_voltsAc) / 1e-6d; }
        }

        /// <summary>
        ///     Get ElectricPotentialAc in MillivoltsAc.
        /// </summary>
        public double MillivoltsAc
        {
            get { return (_voltsAc) / 1e-3d; }
        }

        /// <summary>
        ///     Get ElectricPotentialAc in VoltsAc.
        /// </summary>
        public double VoltsAc
        {
            get { return _voltsAc; }
        }

        #endregion

        #region Static

        public static ElectricPotentialAc Zero
        {
            get { return new ElectricPotentialAc(); }
        }

        /// <summary>
        ///     Get ElectricPotentialAc from KilovoltsAc.
        /// </summary>
        public static ElectricPotentialAc FromKilovoltsAc(double kilovoltsac)
        {
            return new ElectricPotentialAc((kilovoltsac) * 1e3d);
        }

        /// <summary>
        ///     Get ElectricPotentialAc from MegavoltsAc.
        /// </summary>
        public static ElectricPotentialAc FromMegavoltsAc(double megavoltsac)
        {
            return new ElectricPotentialAc((megavoltsac) * 1e6d);
        }

        /// <summary>
        ///     Get ElectricPotentialAc from MicrovoltsAc.
        /// </summary>
        public static ElectricPotentialAc FromMicrovoltsAc(double microvoltsac)
        {
            return new ElectricPotentialAc((microvoltsac) * 1e-6d);
        }

        /// <summary>
        ///     Get ElectricPotentialAc from MillivoltsAc.
        /// </summary>
        public static ElectricPotentialAc FromMillivoltsAc(double millivoltsac)
        {
            return new ElectricPotentialAc((millivoltsac) * 1e-3d);
        }

        /// <summary>
        ///     Get ElectricPotentialAc from VoltsAc.
        /// </summary>
        public static ElectricPotentialAc FromVoltsAc(double voltsac)
        {
            return new ElectricPotentialAc(voltsac);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable ElectricPotentialAc from nullable KilovoltsAc.
        /// </summary>
        public static ElectricPotentialAc? FromKilovoltsAc(double? kilovoltsac)
        {
            if (kilovoltsac.HasValue)
            {
                return FromKilovoltsAc(kilovoltsac.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ElectricPotentialAc from nullable MegavoltsAc.
        /// </summary>
        public static ElectricPotentialAc? FromMegavoltsAc(double? megavoltsac)
        {
            if (megavoltsac.HasValue)
            {
                return FromMegavoltsAc(megavoltsac.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ElectricPotentialAc from nullable MicrovoltsAc.
        /// </summary>
        public static ElectricPotentialAc? FromMicrovoltsAc(double? microvoltsac)
        {
            if (microvoltsac.HasValue)
            {
                return FromMicrovoltsAc(microvoltsac.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ElectricPotentialAc from nullable MillivoltsAc.
        /// </summary>
        public static ElectricPotentialAc? FromMillivoltsAc(double? millivoltsac)
        {
            if (millivoltsac.HasValue)
            {
                return FromMillivoltsAc(millivoltsac.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ElectricPotentialAc from nullable VoltsAc.
        /// </summary>
        public static ElectricPotentialAc? FromVoltsAc(double? voltsac)
        {
            if (voltsac.HasValue)
            {
                return FromVoltsAc(voltsac.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricPotentialAcUnit" /> to <see cref="ElectricPotentialAc" />.
        /// </summary>
        /// <param name="val">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricPotentialAc unit value.</returns>
        public static ElectricPotentialAc From(double val, ElectricPotentialAcUnit fromUnit)
        {
            switch (fromUnit)
            {
                case ElectricPotentialAcUnit.KilovoltAc:
                    return FromKilovoltsAc(val);
                case ElectricPotentialAcUnit.MegavoltAc:
                    return FromMegavoltsAc(val);
                case ElectricPotentialAcUnit.MicrovoltAc:
                    return FromMicrovoltsAc(val);
                case ElectricPotentialAcUnit.MillivoltAc:
                    return FromMillivoltsAc(val);
                case ElectricPotentialAcUnit.VoltAc:
                    return FromVoltsAc(val);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricPotentialAcUnit" /> to <see cref="ElectricPotentialAc" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricPotentialAc unit value.</returns>
        public static ElectricPotentialAc? From(double? value, ElectricPotentialAcUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case ElectricPotentialAcUnit.KilovoltAc:
                    return FromKilovoltsAc(value.Value);
                case ElectricPotentialAcUnit.MegavoltAc:
                    return FromMegavoltsAc(value.Value);
                case ElectricPotentialAcUnit.MicrovoltAc:
                    return FromMicrovoltsAc(value.Value);
                case ElectricPotentialAcUnit.MillivoltAc:
                    return FromMillivoltsAc(value.Value);
                case ElectricPotentialAcUnit.VoltAc:
                    return FromVoltsAc(value.Value);

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
        public static string GetAbbreviation(ElectricPotentialAcUnit unit)
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
        public static string GetAbbreviation(ElectricPotentialAcUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static ElectricPotentialAc operator -(ElectricPotentialAc right)
        {
            return new ElectricPotentialAc(-right._voltsAc);
        }

        public static ElectricPotentialAc operator +(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            return new ElectricPotentialAc(left._voltsAc + right._voltsAc);
        }

        public static ElectricPotentialAc operator -(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            return new ElectricPotentialAc(left._voltsAc - right._voltsAc);
        }

        public static ElectricPotentialAc operator *(double left, ElectricPotentialAc right)
        {
            return new ElectricPotentialAc(left*right._voltsAc);
        }

        public static ElectricPotentialAc operator *(ElectricPotentialAc left, double right)
        {
            return new ElectricPotentialAc(left._voltsAc*(double)right);
        }

        public static ElectricPotentialAc operator /(ElectricPotentialAc left, double right)
        {
            return new ElectricPotentialAc(left._voltsAc/(double)right);
        }

        public static double operator /(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            return Convert.ToDouble(left._voltsAc/right._voltsAc);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is ElectricPotentialAc)) throw new ArgumentException("Expected type ElectricPotentialAc.", "obj");
            return CompareTo((ElectricPotentialAc) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(ElectricPotentialAc other)
        {
            return _voltsAc.CompareTo(other._voltsAc);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            return left._voltsAc <= right._voltsAc;
        }

        public static bool operator >=(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            return left._voltsAc >= right._voltsAc;
        }

        public static bool operator <(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            return left._voltsAc < right._voltsAc;
        }

        public static bool operator >(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            return left._voltsAc > right._voltsAc;
        }

        public static bool operator ==(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._voltsAc == right._voltsAc;
        }

        public static bool operator !=(ElectricPotentialAc left, ElectricPotentialAc right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._voltsAc != right._voltsAc;
        }
#endif

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _voltsAc.Equals(((ElectricPotentialAc) obj)._voltsAc);
        }

        public override int GetHashCode()
        {
            return _voltsAc.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(ElectricPotentialAcUnit unit)
        {
            switch (unit)
            {
                case ElectricPotentialAcUnit.KilovoltAc:
                    return KilovoltsAc;
                case ElectricPotentialAcUnit.MegavoltAc:
                    return MegavoltsAc;
                case ElectricPotentialAcUnit.MicrovoltAc:
                    return MicrovoltsAc;
                case ElectricPotentialAcUnit.MillivoltAc:
                    return MillivoltsAc;
                case ElectricPotentialAcUnit.VoltAc:
                    return VoltsAc;

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
        public static ElectricPotentialAc Parse(string str)
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
        public static ElectricPotentialAc Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return QuantityParser.Parse<ElectricPotentialAc, ElectricPotentialAcUnit>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    ElectricPotentialAcUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromVoltsAc(x.VoltsAc + y.VoltsAc));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ElectricPotentialAc result)
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
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out ElectricPotentialAc result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(ElectricPotentialAc);
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
        public static ElectricPotentialAcUnit ParseUnit(string str)
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
        public static ElectricPotentialAcUnit ParseUnit(string str, [CanBeNull] string cultureName)
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
        static ElectricPotentialAcUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<ElectricPotentialAcUnit>(str.Trim());

            if (unit == ElectricPotentialAcUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ElectricPotentialAcUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is VoltAc
        /// </summary>
        public static ElectricPotentialAcUnit ToStringDefaultUnit { get; set; } = ElectricPotentialAcUnit.VoltAc;

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
        public string ToString(ElectricPotentialAcUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(ElectricPotentialAcUnit unit, [CanBeNull] Culture culture)
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
        public string ToString(ElectricPotentialAcUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
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
        public string ToString(ElectricPotentialAcUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
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
        /// Represents the largest possible value of ElectricPotentialAc
        /// </summary>
        public static ElectricPotentialAc MaxValue
        {
            get
            {
                return new ElectricPotentialAc(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of ElectricPotentialAc
        /// </summary>
        public static ElectricPotentialAc MinValue
        {
            get
            {
                return new ElectricPotentialAc(double.MinValue);
            }
        }
    }
}
