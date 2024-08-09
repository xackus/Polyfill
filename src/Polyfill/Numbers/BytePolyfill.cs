// <auto-generated />
#pragma warning disable

// ReSharper disable RedundantUsingDirective
// ReSharper disable PartialTypeWithSinglePart

namespace Polyfills;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using Link = System.ComponentModel.DescriptionAttribute;

[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
#if PolyPublic
public
#endif
static partial class BytePolyfill
{
    /// <summary>
    /// Tries to parse a string into a value.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.byte.tryparse#system-byte-tryparse(system-string-system-iformatprovider-system-byte@)")]
    public static bool TryParse(string? target, IFormatProvider? provider, out byte result) =>
#if !NET7_0_OR_GREATER
        byte.TryParse(target, NumberStyles.Integer, provider, out result);
#else
        byte.TryParse(target, provider, out result);
#endif

#if FeatureMemory
    /// <summary>
    /// Tries to parse a span of UTF-8 characters into a value.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.byte.tryparse#system-byte-tryparse(system-readonlyspan((system-byte))-system-iformatprovider-system-byte@)")]
    public static bool TryParse(ReadOnlySpan<byte> target, IFormatProvider? provider, out byte result) =>
#if !NET8_0_OR_GREATER
        byte.TryParse(Encoding.UTF8.GetString(target.ToArray()), NumberStyles.Integer, provider, out result);
#else
        byte.TryParse(target, provider, out result);
#endif

    /// <summary>
    /// Converts the span representation of a number in a specified style and culture-specific format to its byte equivalent. A return value indicates whether the conversion succeeded.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.byte.tryparse#system-byte-tryparse(system-readonlyspan((system-char))-system-byte@)")]
    public static bool TryParse(ReadOnlySpan<char> target, out byte result) =>
#if NETCOREAPP2_0 || NETFRAMEWORK || NETSTANDARD2_0
        byte.TryParse(target.ToString(), out result);
#else
        byte.TryParse(target, out result);
#endif

    /// <summary>
    /// Tries to parse a span of characters into a value.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.byte.tryparse#system-byte-tryparse(system-readonlyspan((system-char))-system-iformatprovider-system-byte@)")]
    public static bool TryParse(ReadOnlySpan<char> target, IFormatProvider? provider, out byte result) =>
#if !NET7_0_OR_GREATER
        byte.TryParse(target.ToString(), NumberStyles.Integer, provider, out result);
#else
        byte.TryParse(target, provider, out result);
#endif

    /// <summary>
    /// Tries to parse a span of UTF-8 characters into a value.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.byte.tryparse#system-byte-tryparse(system-readonlyspan((system-byte))-system-globalization-numberstyles-system-iformatprovider-system-byte@)")]
    public static bool TryParse(ReadOnlySpan<byte> target, NumberStyles style, IFormatProvider? provider, out byte result) =>
#if !NET8_0_OR_GREATER
        byte.TryParse(Encoding.UTF8.GetString(target.ToArray()), style, provider, out result);
#else
        byte.TryParse(target, style, provider, out result);
#endif

    /// <summary>
    /// Tries to convert a UTF-8 character span containing the string representation of a number to its byte equivalent.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.byte.tryparse#system-byte-tryparse(system-readonlyspan((system-char))-system-globalization-numberstyles-system-iformatprovider-system-byte@)")]
    public static bool TryParse(ReadOnlySpan<byte> target, out byte result) =>
#if !NET8_0_OR_GREATER
        byte.TryParse(Encoding.UTF8.GetString(target.ToArray()), NumberStyles.Integer, null, out result);
#else
        byte.TryParse(target, out result);
#endif

    /// <summary>
    /// Converts the span representation of a number in a specified style and culture-specific format to its byte equivalent. A return value indicates whether the conversion succeeded.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.byte.tryparse#system-byte-tryparse(system-readonlyspan((system-char))-system-globalization-numberstyles-system-iformatprovider-system-byte@)")]
    public static bool TryParse(ReadOnlySpan<char> target, NumberStyles style, IFormatProvider? provider, out byte result) =>
#if NETCOREAPP2_0 || NETSTANDARD2_0 || NETFRAMEWORK
        byte.TryParse(target.ToString(), style, provider, out result);
#else
        byte.TryParse(target, style, provider, out result);
#endif
#endif
}