// <auto-generated />
#pragma warning disable

namespace Polyfills;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Link = System.ComponentModel.DescriptionAttribute;

static partial class Polyfill
{
#if FeatureMemory && (!NETSTANDARD2_1_OR_GREATER && !NETCOREAPP2_1_OR_GREATER)

    /// <summary>
    /// Copies the characters from a specified segment of this instance to a destination Char span.
    /// </summary>
    /// <param name="sourceIndex">The starting position in this instance where characters will be copied from. The index is zero-based.</param>
    /// <param name="destination">The writable span where characters will be copied.</param>
    /// <param name="count">The number of characters to be copied.</param>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.copyto#system-text-stringbuilder-copyto(system-int32-system-span((system-char))-system-int32)")]
    public static void CopyTo(
        this StringBuilder target,
        int sourceIndex,
        Span<char> destination,
        int count)
    {
        var destinationIndex = 0;
        while (true)
        {
            if (sourceIndex == target.Length)
            {
                break;
            }

            if (destinationIndex == count)
            {
                break;
            }

            destination[destinationIndex] = target[sourceIndex];
            destinationIndex++;
            sourceIndex++;
        }
    }

    /// <summary>
    /// Appends the string representation of a specified read-only character span to this instance.
    /// </summary>
    /// <param name="value">The read-only character span to append.</param>
    /// <returns>A reference to this instance after the append operation is completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-readonlyspan((system-char)))")]
    public static StringBuilder Append(this StringBuilder target, ReadOnlySpan<char> value)
    {
        if (value.Length <= 0)
        {
            return target;
        }

#if AllowUnsafeBlocks
        unsafe
        {
            fixed (char* valueChars = value)
            {
                target.Append(valueChars, value.Length);
            }
        }
#else
        target.Append(value.ToString());
#endif
        return target;
    }

    /// <summary>
    /// Returns a value indicating whether the characters in this instance are equal to the characters in a specified
    /// read-only character span.
    /// </summary>
    /// <param name="span">The character span to compare with the current instance.</param>
    /// <remarks>
    /// The Equals method performs an ordinal comparison to determine whether the characters in the current instance
    /// and span are equal.
    /// </remarks>
    /// <returns>true if the characters in this instance and span are the same; otherwise, false.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.equals#system-text-stringbuilder-equals(system-readonlyspan((system-char)))")]
    public static bool Equals(this StringBuilder target, ReadOnlySpan<char> span)
    {
        if (target.Length != span.Length)
        {
            return false;
        }

        for (var index = 0; index < target.Length; index++)
        {
            var ch1 = target[index];
            var ch2 = span[index];
            if (ch1 != ch2)
            {
                return false;
            }
        }

        return true;
    }

#endif

#if FeatureMemory && !NET6_0_OR_GREATER
    /// <summary>Appends the specified interpolated string to this instance.</summary>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder Append(
        StringBuilder target,
        [InterpolatedStringHandlerArgument(nameof(target))]
        ref AppendInterpolatedStringHandler handler) => target;

    /// <summary>Appends the specified interpolated string to this instance.</summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-iformatprovider-system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder Append(
        StringBuilder target,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(target), nameof(provider))]
        ref AppendInterpolatedStringHandler handler) => target;

    /// <summary>Appends the specified interpolated string followed by the default line terminator to the end of the current StringBuilder object.</summary>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline#system-text-stringbuilder-appendline(system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder AppendLine(
        StringBuilder target,
        [InterpolatedStringHandlerArgument(nameof(target))]
        ref AppendInterpolatedStringHandler handler) =>
        target.AppendLine();

    /// <summary>Appends the specified interpolated string followed by the default line terminator to the end of the current StringBuilder object.</summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline#system-text-stringbuilder-appendline(system-iformatprovider-system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder AppendLine(
        StringBuilder target,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(target), nameof(provider))]
        ref AppendInterpolatedStringHandler handler) =>
        target.AppendLine();

#elif NET6_0_OR_GREATER

    /// <summary>Appends the specified interpolated string to this instance.</summary>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder Append(
        StringBuilder target,
        [InterpolatedStringHandlerArgument(nameof(target))] ref StringBuilder.AppendInterpolatedStringHandler handler) =>
        target.Append(ref handler);

    /// <summary>Appends the specified interpolated string to this instance.</summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-iformatprovider-system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder Append(
        StringBuilder target,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(target), nameof(provider))] ref StringBuilder.AppendInterpolatedStringHandler handler) =>
        target.Append(provider, ref handler);

    /// <summary>Appends the specified interpolated string followed by the default line terminator to the end of the current StringBuilder object.</summary>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline#system-text-stringbuilder-appendline(system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder AppendLine(
        StringBuilder target,
        [InterpolatedStringHandlerArgument(nameof(target))] ref StringBuilder.AppendInterpolatedStringHandler handler) =>
        target.AppendLine(ref handler);

    /// <summary>Appends the specified interpolated string followed by the default line terminator to the end of the current StringBuilder object.</summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline#system-text-stringbuilder-appendline(system-iformatprovider-system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder AppendLine(
        StringBuilder target,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(target), nameof(provider))] ref StringBuilder.AppendInterpolatedStringHandler handler) =>
        target.AppendLine(provider, ref handler);
#endif

#if NETSTANDARD2_0|| NETFRAMEWORK

    /// <summary>Concatenates the strings of the provided array, using the specified separator between each string, then appends the result to the current instance of the string builder.</summary>
    /// <param name="separator">The string to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">An array that contains the strings to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin#system-text-stringbuilder-appendjoin(system-string-system-string())")]
    public static StringBuilder AppendJoin(
        this StringBuilder target,
        string separator,
        params string[] values) =>
        target.Append(string.Join(separator, values));

    /// <summary>Concatenates the string representations of the elements in the provided array of objects, using the specified separator between each member, then appends the result to the current instance of the string builder.</summary>
    /// <param name="separator">The string to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">An array that contains the strings to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin#system-text-stringbuilder-appendjoin(system-string-system-object())")]
    public static StringBuilder AppendJoin(
        this StringBuilder target,
        string separator,
        params Object[] values) =>
        target.Append(string.Join(separator, values));

    /// <summary>Concatenates the strings of the provided array, using the specified char separator between each string, then appends the result to the current instance of the string builder.</summary>
    /// <param name="separator">The character to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">An array that contains the strings to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin#system-text-stringbuilder-appendjoin(system-char-system-string())")]
    public static StringBuilder AppendJoin(
        this StringBuilder target,
        char separator,
        params string[] values) =>
        target.Append(string.Join(separator.ToString(), values));

    /// <summary>Concatenates the string representations of the elements in the provided array of objects, using the specified char separator between each member, then appends the result to the current instance of the string builder.</summary>
    /// <param name="separator">The character to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">An array that contains the strings to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin#system-text-stringbuilder-appendjoin(system-char-system-object())")]
    public static StringBuilder AppendJoin(
        this StringBuilder target,
        char separator,
        params object[] values) =>
        target.Append(string.Join(separator.ToString(), values));

    /// <summary>Concatenates and appends the members of a collection, using the specified char separator between each member.</summary>
    /// <param name="separator">The character to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">A collection that contains the objects to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin#system-text-stringbuilder-appendjoin-1(system-char-system-collections-generic-ienumerable((-0)))")]
    public static StringBuilder AppendJoin<T>(
        this StringBuilder target,
        char separator,
        params T[] values) =>
        target.Append(string.Join(separator.ToString(), values));

    /// <summary>Concatenates and appends the members of a collection, using the specified char separator between each member.</summary>
    /// <param name="separator">The string to use as a separator. separator is included in the concatenated and appended strings only if values has more than one element.</param>
    /// <param name="values">A collection that contains the objects to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin#system-text-stringbuilder-appendjoin-1(system-string-system-collections-generic-ienumerable((-0)))")]
    public static StringBuilder AppendJoin<T>(
        this StringBuilder target,
        string separator,
        params T[] values) =>
        target.Append(string.Join(separator.ToString(), values));

#endif

#if !NET9_0_OR_GREATER && FeatureMemory
    /// <summary>
    /// Replaces all instances of one string with another in part of this builder.
    /// </summary>
    /// <param name="oldValue">The string to replace.</param>
    /// <param name="newValue">The string to replace <paramref name="oldValue"/> with.</param>
    /// <param name="startIndex">The index to start in this builder.</param>
    /// <param name="count">The number of characters to read in this builder.</param>
    /// <remarks>
    /// If <paramref name="newValue"/> is <c>null</c>, instances of <paramref name="oldValue"/> are removed from this builder.
    /// </remarks>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.replace#system-text-stringbuilder-replace(system-readonlyspan((system-char))-system-readonlyspan((system-char)))")]
    public static StringBuilder Replace(this StringBuilder target, ReadOnlySpan<char> oldValue, ReadOnlySpan<char> newValue) =>
        target.Replace(oldValue.ToString(), newValue.ToString());

    /// <summary>
    /// Replaces all instances of one read-only character span with another in part of this builder.
    /// </summary>
    /// <param name="oldValue">The read-only character span to replace.</param>
    /// <param name="newValue">The read-only character span to replace <paramref name="oldValue"/> with.</param>
    /// <param name="startIndex">The index to start in this builder.</param>
    /// <param name="count">The number of characters to read in this builder.</param>
    /// <remarks>
    /// If <paramref name="newValue"/> is empty, instances of <paramref name="oldValue"/> are removed from this builder.
    /// </remarks>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.replace#system-text-stringbuilder-replace(system-char-system-char-system-int32-system-int32)")]
    public static StringBuilder Replace(this StringBuilder target, ReadOnlySpan<char> oldValue, ReadOnlySpan<char> newValue, int startIndex, int count) =>
        target.Replace(oldValue.ToString(), newValue.ToString(), startIndex, count);
#endif

#if !NET6_0_OR_GREATER && FeatureMemory

    static FieldInfo chunkCharsField = GetStringBuilderField("m_ChunkChars");
    static FieldInfo chunkPreviousField = GetStringBuilderField("m_ChunkPrevious");
    static FieldInfo chunkLengthField = GetStringBuilderField("m_ChunkLength");

    static FieldInfo GetStringBuilderField(string name)
    {
        var field = typeof(StringBuilder).GetField(name, BindingFlags.Instance | BindingFlags.NonPublic);
        if (field != null)
        {
            return field;
        }

        throw new($"Expected to find field '{name}' on StringBuilder");
    }

    static int GetChunkLength(StringBuilder stringBuilder) =>
        (int) chunkLengthField.GetValue(stringBuilder)!;

    static char[] GetChunkChars(StringBuilder stringBuilder) =>
        (char[]) chunkCharsField.GetValue(stringBuilder)!;

    static StringBuilder? GetChunkPrevious(StringBuilder stringBuilder) =>
        (StringBuilder?) chunkPreviousField.GetValue(stringBuilder);

    /// <summary>
    /// GetChunks returns ChunkEnumerator that follows the IEnumerable pattern and
    /// thus can be used in a C# 'foreach' statements to retrieve the data in the StringBuilder
    /// as chunks (ReadOnlyMemory) of characters.  An example use is:
    ///
    ///      foreach (ReadOnlyMemory&lt;char&gt; chunk in sb.GetChunks())
    ///         foreach (char c in chunk.Span)
    ///             { /* operation on c }
    ///
    /// It is undefined what happens if the StringBuilder is modified while the chunk
    /// enumeration is incomplete.  StringBuilder is also not thread-safe, so operating
    /// on it with concurrent threads is illegal.  Finally the ReadOnlyMemory chunks returned
    /// are NOT guaranteed to remain unchanged if the StringBuilder is modified, so do
    /// not cache them for later use either.  This API's purpose is efficiently extracting
    /// the data of a CONSTANT StringBuilder.
    ///
    /// Creating a ReadOnlySpan from a ReadOnlyMemory  (the .Span property) is expensive
    /// compared to the fetching of the character, so create a local variable for the SPAN
    /// if you need to use it in a nested for statement.  For example
    ///
    ///    foreach (ReadOnlyMemory&lt;char&gt; chunk in sb.GetChunks())
    ///    {
    ///         var span = chunk.Span;
    ///         for (int i = 0; i &lt; span.Length; i++)
    ///             { /* operation on span[i] */ }
    ///    }
    /// </summary>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.getchunks")]
    public static ChunkEnumerator GetChunks(this StringBuilder target) =>
        new(target);

    /// <summary>
    /// ChunkEnumerator supports both the IEnumerable and IEnumerator pattern so foreach
    /// works (see GetChunks).  It needs to be public (so the compiler can use it
    /// when building a foreach statement) but users typically don't use it explicitly.
    /// (which is why it is a nested type).
    /// </summary>
    public struct ChunkEnumerator
    {
        // The first Stringbuilder chunk (which is the end of the logical string)
        StringBuilder _firstChunk;

        // The chunk that this enumerator is currently returning (Current).
        StringBuilder? _currentChunk;

        // Only used for long string builders with many chunks (see constructor)
        ManyChunkInfo? _manyChunks;

        // Only here to make foreach work
        /// <summary>
        /// Implement IEnumerable.GetEnumerator() to return  'this' as the IEnumerator
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChunkEnumerator GetEnumerator() =>
            this;

        /// <summary>
        /// Implements the IEnumerator pattern.
        /// </summary>
        public bool MoveNext()
        {
            if (_currentChunk == _firstChunk)
            {
                return false;
            }

            if (_manyChunks != null)
            {
                return _manyChunks.MoveNext(ref _currentChunk);
            }

            var next = _firstChunk;
            while (true)
            {
                var chunkPrevious = GetChunkPrevious(next);
                if (chunkPrevious == _currentChunk)
                {
                    break;
                }

                next = chunkPrevious;
            }

            _currentChunk = next;
            return true;
        }

        /// <summary>
        /// Implements the IEnumerator pattern.
        /// </summary>
        public ReadOnlyMemory<char> Current
        {
            get
            {
                if (_currentChunk == null)
                {
                    throw new InvalidOperationException("Enumeration operation cant happen");
                }

                return new ReadOnlyMemory<char>(GetChunkChars(_currentChunk), 0, GetChunkLength(_currentChunk));
            }
        }

        internal ChunkEnumerator(StringBuilder builder)
        {
            _firstChunk = builder;
            // MoveNext will find the last chunk if we do this.
            _currentChunk = null;
            _manyChunks = null;

            // There is a performance-vs-allocation tradeoff.   Because the chunks
            // are a linked list with each chunk pointing to its PREDECESSOR, walking
            // the list FORWARD is not efficient.   If there are few chunks (< 8) we
            // simply scan from the start each time, and tolerate the N*N behavior.
            // However above this size, we allocate an array to hold reference to all
            // the chunks and we can be efficient for large N.
            var chunkCount = ChunkCount(builder);
            if (8 < chunkCount)
            {
                _manyChunks = new ManyChunkInfo(builder, chunkCount);
            }
        }

        static int ChunkCount(StringBuilder? builder)
        {
            var ret = 0;
            while (builder != null)
            {
                ret++;
                builder = GetChunkPrevious(builder);
            }

            return ret;
        }

        /// <summary>
        /// Used to hold all the chunks indexes when you have many chunks.
        /// </summary>
        class ManyChunkInfo
        {
            // These are in normal order (first chunk first)
            StringBuilder[] _chunks;
            int _chunkPos;

            public bool MoveNext(ref StringBuilder? current)
            {
                int pos = ++_chunkPos;
                if (_chunks.Length <= pos)
                {
                    return false;
                }

                current = _chunks[pos];
                return true;
            }

            public ManyChunkInfo(StringBuilder? builder, int chunkCount)
            {
                _chunks = new StringBuilder[chunkCount];
                while (0 <= --chunkCount)
                {
                    _chunks[chunkCount] = builder;
                    builder = GetChunkPrevious(builder);
                }

                _chunkPos = -1;
            }
        }
    }
#endif
}