// <auto-generated />
#pragma warning disable

namespace Polyfills;

using System;
using System.Collections.Generic;
using Link = System.ComponentModel.DescriptionAttribute;
using System.Linq;

static partial class Polyfill
{

#if !NET6_0_OR_GREATER

    /// <summary>Returns the minimum value in a generic sequence.</summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
    /// <param name="source">A sequence of values to determine the minimum value of.</param>
    /// <param name="comparer">The <see cref="IComparer{T}" /> to compare values.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">No object in <paramref name="source" /> implements the <see cref="System.IComparable" /> or <see cref="System.IComparable{T}" /> interface.</exception>
    /// <remarks>
    /// <para>If type <typeparamref name="TSource" /> implements <see cref="System.IComparable{T}" />, the <see cref="Min{T}(IEnumerable{T})" /> method uses that implementation to compare values. Otherwise, if type <typeparamref name="TSource" /> implements <see cref="System.IComparable" />, that implementation is used to compare values.</para>
    /// <para>If <typeparamref name="TSource" /> is a reference type and the source sequence is empty or contains only values that are <see langword="null" />, this method returns <see langword="null" />.</para>
    /// <para>In Visual Basic query expression syntax, an `Aggregate Into Min()` clause translates to an invocation of <see cref="O:Enumerable.Min" />.</para>
    /// </remarks>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min?view=net-8.0#system-linq-enumerable-min-1(system-collections-generic-ienumerable((-0))-system-collections-generic-icomparer((-0)))")]
    public static TSource? Min<TSource>(
        this IEnumerable<TSource> target,
        IComparer<TSource>? comparer) =>
        target
            .OrderBy(_ => _, comparer)
            .FirstOrDefault();

#endif

}