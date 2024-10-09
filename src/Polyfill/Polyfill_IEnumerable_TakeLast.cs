// <auto-generated />
#pragma warning disable

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Polyfills;

using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Link = System.ComponentModel.DescriptionAttribute;

static partial class Polyfill
{

#if NETSTANDARD2_0 || NETFRAMEWORK

    /// <summary>
    /// Returns a new enumerable collection that contains the last count elements from source.
    /// </summary>
    /// <param name="source">An enumerable collection instance.</param>
    /// <param name="count">The number of elements to take from the end of the collection.</param>
    /// <typeparam name="TSource">The type of the elements in the enumerable collection.</typeparam>
    /// <returns>A new enumerable collection that contains the last count elements from source.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.takelast")]
    public static IEnumerable<TSource> TakeLast<TSource>(this IEnumerable<TSource> source, int count)
    {
        if (count <= 0 || IsEmptyArray(source))
        {
            return [];
        }

        return TakeRangeFromEndIterator(
            source,
            isStartIndexFromEnd: true, startIndex: count,
            isEndIndexFromEnd: true, endIndex: 0);
    }
#endif
}