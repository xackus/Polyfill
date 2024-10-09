// <auto-generated />
#pragma warning disable

namespace Polyfills;

using System;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using Link = System.ComponentModel.DescriptionAttribute;

[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
#if PolyPublic
public
#endif
static class EnumPolyfill
{
    /// <summary>
    /// Retrieves an array of the values of the constants in a specified enumeration type.
    /// </summary>
    /// <returns>An array that contains the values of the constants in TEnum.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.getvalues")]
    public static TEnum[] GetValues<TEnum>()
        where TEnum : struct, Enum
    {
#if NETCOREAPPX || NETFRAMEWORK || NETSTANDARD
        var values = Enum.GetValues(typeof(TEnum));
        var result = new TEnum[values.Length];
        Array.Copy(values, result, values.Length);
        return result;
#else
        return Enum.GetValues<TEnum>();
#endif
    }

    /// <summary>Returns a <see cref="bool"/> telling whether a given integral value exists in a specified enumeration.</summary>
    /// <typeparam name="TEnum">The type of the enumeration.</typeparam>
    /// <param name="value">The value in <typeparamref name="TEnum"/>.</param>
    /// <returns><see langword="true"/> if a given integral value exists in a specified enumeration; <see langword="false"/>, otherwise.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.isdefined#system-enum-isdefined-1(-0)")]
    public static bool IsDefined<TEnum> (TEnum value)
        where TEnum : struct, Enum =>
#if NET5_0_OR_GREATER
        Enum.IsDefined<TEnum>(value);
#else
        Enum.IsDefined(typeof(TEnum), value);
#endif

    /// <summary>
    /// Retrieves an array of the names of the constants in a specified enumeration type.
    /// </summary>
    /// <returns>A string array of the names of the constants in TEnum.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.getnames")]
    public static string[] GetNames<TEnum>()
        where TEnum : struct, Enum =>
#if NETCOREAPPX || NETFRAMEWORK || NETSTANDARD
        Enum.GetNames(typeof(TEnum));
#else
        Enum.GetNames<TEnum>();
#endif

    /// <summary>
    /// Converts the string representation of the name or numeric value of one or more enumerated constants specified by TEnum to an equivalent enumerated object.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.parse#system-enum-parse-1(system-string-system-boolean)")]
    public static TEnum Parse<TEnum>(string value)
        where TEnum : struct, Enum =>
#if NETFRAMEWORK || NETSTANDARD
        (TEnum)Enum.Parse(typeof(TEnum), value);
#else
        Enum.Parse<TEnum>(value);
#endif

    /// <summary>
    /// Converts the string representation of the name or numeric value of one or more enumerated constants specified by TEnum to an equivalent enumerated object.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.parse#system-enum-parse-1(system-string-system-boolean)")]
    public static TEnum Parse<TEnum>(string value, bool ignoreCase)
        where TEnum : struct, Enum =>
#if NETFRAMEWORK || NETSTANDARD
        (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
#else
        Enum.Parse<TEnum>(value, ignoreCase);
#endif

#if FeatureMemory

    /// <summary>
    /// Converts the span of characters representation of the name or numeric value of one or more enumerated constants specified by TEnum to an equivalent enumerated object.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.parse#system-enum-parse-1(system-readonlyspan((system-char)))")]
    public static TEnum Parse<TEnum>(ReadOnlySpan<char> value)
        where TEnum : struct, Enum =>
#if NET6_0_OR_GREATER
        Enum.Parse<TEnum>(value);
#else
        (TEnum)Enum.Parse(typeof(TEnum), value.ToString());
#endif

    /// <summary>
    /// Converts the span of characters representation of the name or numeric value of one or more enumerated constants specified by TEnum to an equivalent enumerated object.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.parse#system-enum-parse-1(system-readonlyspan((system-char))-system-boolean)")]
    public static TEnum Parse<TEnum>(ReadOnlySpan<char> value, bool ignoreCase)
        where TEnum : struct, Enum =>
#if NET6_0_OR_GREATER
        Enum.Parse<TEnum>(value, ignoreCase);
#else
        (TEnum)Enum.Parse(typeof(TEnum), value.ToString(), ignoreCase);
#endif

    /// <summary>
    /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.tryparse#system-enum-tryparse-1(system-readonlyspan((system-char))-0@)")]
    public static bool TryParse<TEnum>(ReadOnlySpan<char> value, out TEnum result)
        where TEnum : struct, Enum =>
#if NET6_0_OR_GREATER
        Enum.TryParse<TEnum>(value, out result);
#else
        Enum.TryParse<TEnum>(value.ToString(), out result);
#endif

    /// <summary>
    /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object. A parameter specifies whether the operation is case-sensitive. The return value indicates whether the conversion succeeded.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.enum.tryparse#system-enum-tryparse-1(system-readonlyspan((system-char))-system-boolean-0@)")]
    public static bool TryParse<TEnum>(ReadOnlySpan<char> value, bool ignoreCase, out TEnum result)
        where TEnum : struct, Enum =>
#if NET6_0_OR_GREATER
        Enum.TryParse<TEnum>(value, ignoreCase, out result);
#else
        Enum.TryParse<TEnum>(value.ToString(), ignoreCase, out result);
#endif
#endif
}