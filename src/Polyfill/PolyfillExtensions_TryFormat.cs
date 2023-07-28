
#pragma warning disable

// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantAttributeSuffix

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using Link = System.ComponentModel.DescriptionAttribute;

static partial class PolyfillExtensions
{
    #if MEMORYREFERENCED && (NETFRAMEWORK || NETSTANDARD || NETCOREAPP2X)

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.sbyte.tryformat")]
    public static bool TryFormat(
        this sbyte target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.byte.tryformat")]
    public static bool TryFormat(this byte target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.int16.tryformat")]
    public static bool TryFormat(this short target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.uint16.tryformat")]
    public static bool TryFormat(this ushort target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryformat")]
    public static bool TryFormat(this int target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.uint32.tryformat")]
    public static bool TryFormat(this uint target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.int64.tryformat")]
    public static bool TryFormat(this long target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.uint64.tryformat")]
    public static bool TryFormat(this ulong target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.single.tryformat")]
    public static bool TryFormat(this float target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.double.tryformat")]
    public static bool TryFormat(this double target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.decimal.tryformat")]
    public static bool TryFormat(this decimal target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.boolean.tryformat")]
    public static bool TryFormat(this bool target, Span<char> destination, out int charsWritten)
    {
        var result = target.ToString();
        return CopyToSpan(destination, out charsWritten, result);
    }
#endif

#if (MEMORYREFERENCED && (NETFRAMEWORK || NETSTANDARD || NETCOREAPP2X)) || NET6_0
    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset.tryformat")]
    public static bool TryFormat(this DateTimeOffset target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tryformat")]
    public static bool TryFormat(this DateTime target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

#endif
#if NET6_0_OR_GREATER

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.dateonly.tryformat")]
    public static bool TryFormat(this DateOnly target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.timeonly.tryformat")]
    public static bool TryFormat(this TimeOnly target, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default)
    {
        string result;

        if (format.Length == 0)
        {
            result = target.ToString(provider);
        }
        else
        {
            result = target.ToString(format.ToString(), provider);
        }

        return CopyToSpan(destination, out charsWritten, result);
    }
#endif

#if NET6_0_OR_GREATER || (MEMORYREFERENCED && (NETFRAMEWORK || NETSTANDARD || NETCOREAPP2X))
    static bool CopyToSpan(Span<char> destination, out int charsWritten, string result)
    {
        if (result.Length == 0)
        {
            charsWritten = 0;
            return true;
        }

        charsWritten = result.Length;
        return result.TryCopyTo(destination);
    }
#endif
}