// <auto-generated />
#pragma warning disable

namespace Polyfills;

#if PolyGuard

using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#if PolyPublic
public
#endif

static partial class Guard
{
    public static void NotEmpty(string? value, [CallerArgumentExpression("value")] string argumentName = "")
    {
        if (value is null)
        {
            return;
        }

        if (value.Length == 0)
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }
    }

#if FeatureMemory

    public static void NotEmpty<T>(ReadOnlySpan<T> value, [CallerArgumentExpression("value")] string argumentName = "")
    {
        if (value.Length == 0)
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }
    }

    public static void NotEmpty<T>(Span<T> value, [CallerArgumentExpression("value")] string argumentName = "")
    {
        if (value.Length == 0)
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }
    }

    public static void NotEmpty<T>(Memory<T>? value, [CallerArgumentExpression("value")] string argumentName = "")
    {
        if (value is null)
        {
            return;
        }

        if (value.Value.Length == 0)
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }
    }

    public static void NotEmpty<T>(Memory<T> value, [CallerArgumentExpression("value")] string argumentName = "")
    {
        if (value.Length == 0)
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }
    }

    public static void NotEmpty<T>(ReadOnlyMemory<T>? value, [CallerArgumentExpression("value")] string argumentName = "")
    {
        if (value is null)
        {
            return;
        }

        if (value.Value.Length == 0)
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }
    }

    public static void NotEmpty<T>(ReadOnlyMemory<T> value, [CallerArgumentExpression("value")] string argumentName = "")
    {
        if (value.Length == 0)
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }
    }

#endif

    public static void NotEmpty<T>(
        [NotNull] T? value,
        [CallerArgumentExpression("value")] string argumentName = "")
        where T : IEnumerable
    {
        if (value is null)
        {
            return;
        }

        if (value is ICollection<T> {Count: 0})
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }

        if (value is ICollection {Count: 0})
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }

        if (value is IReadOnlyCollection<T> {Count: 0})
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }

        if (value is T[] {Length: 0})
        {
            throw new ArgumentException("Argument cannot be empty.", argumentName);
        }

        var enumerator = value.GetEnumerator();
        try
        {
            if (!enumerator.MoveNext())
            {
                throw new ArgumentException("Argument cannot be empty.", argumentName);
            }
        }
        finally
        {
            if (enumerator is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}
#endif