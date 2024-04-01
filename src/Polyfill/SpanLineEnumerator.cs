// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// <auto-generated />

#pragma warning disable

#if FeatureMemory && !NET6_0_OR_GREATER

using Link = System.ComponentModel.DescriptionAttribute;

namespace System.Text;

/// <summary>
/// Enumerates the lines of a <see cref="ReadOnlySpan{Char}"/>.
/// </summary>
/// <remarks>
/// To get an instance of this type, use <see cref="MemoryExtensions.EnumerateLines(ReadOnlySpan{char})"/>.
/// </remarks>
[Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.spanlineenumerator")]
#if PolyPublic
public
#endif
ref struct SpanLineEnumerator
{
    ReadOnlySpan<char> remaining;
    bool isActive;
    ReadOnlySpan<char> newlines = "\r\f\u0085\u2028\u2029\n".AsSpan();

    internal SpanLineEnumerator(ReadOnlySpan<char> buffer)
    {
        remaining = buffer;
        Current = default;
        isActive = true;
    }

    /// <summary>
    /// Gets the line at the current position of the enumerator.
    /// </summary>
    public ReadOnlySpan<char> Current { get; private set; }

    /// <summary>
    /// Returns this instance as an enumerator.
    /// </summary>
    public SpanLineEnumerator GetEnumerator() => this;

    /// <summary>
    /// Advances the enumerator to the next line of the span.
    /// </summary>
    /// <returns>
    /// True if the enumerator successfully advanced to the next line; false if
    /// the enumerator has advanced past the end of the span.
    /// </returns>
    public bool MoveNext()
    {
        if (!isActive)
        {
            // EOF previously reached or enumerator was never initialized
            return false;
        }

        //TODO: revisit when SearchValues is implemented
        var index = remaining.IndexOfAny(newlines);

        if ((uint)index < (uint)remaining.Length)
        {
            var stride = 1;

            if (remaining[index] == '\r' &&
                (uint)(index + 1) < (uint)remaining.Length && remaining[index + 1] == '\n')
            {
                stride = 2;
            }

            Current = remaining[..index];
            remaining = remaining[(index + stride)..];
            return true;
        }

        // We've reached EOF, but we still need to return 'true' for this final
        // iteration so that the caller can query the Current property once more.
        Current = remaining;
        remaining = default;
        isActive = false;
        return true;
    }
}
#endif