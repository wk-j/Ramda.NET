﻿// <autogenerated>
//   This file was generated by T4 code generator Into.list.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Dynamic;
using System.Collections;
using System.Threading.Tasks;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		/// <summary>
		/// Transforms the items of the list with the transducer and appends thetransformed items to the accumulator using an appropriate iterator functionbased on the accumulator type.The accumulator can be an array, string, object or a transformer. Iterateditems will be appended to arrays and concatenated to strings. Objects willbe merged directly or 2-item arrays will be merged as key, value pairs.The accumulator can also be a transformer object that provides a 2-arityreducing iterator function, step, 0-arity initial value function, init, and1-arity result extraction function result. The step function is used as theiterator function in reduce. The result function is used to convert thefinal accumulator into the return type and in most cases is R.identity. Theinit function is used to provide the initial accumulator.The iteration is performed with R.reduce after initializing the transducer.
		/// <para />
		/// sig: a -> (b -> b) -> [c] -> a
		/// </summary>
		/// <param name="acc">The initial accumulator value.</param>
		/// <param name="xf">The transducer function. Receives a transformer and returns a transformer.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		public static dynamic Into<TSource, TAccumulator>(IList<TAccumulator> acc, Func<ITransformer, ITransformer> xf, IList<TSource> list) {
			return Currying.Into(acc, Delegate(xf), list);
		}

		/// <summary>
		/// Transforms the items of the list with the transducer and appends thetransformed items to the accumulator using an appropriate iterator functionbased on the accumulator type.The accumulator can be an array, string, object or a transformer. Iterateditems will be appended to arrays and concatenated to strings. Objects willbe merged directly or 2-item arrays will be merged as key, value pairs.The accumulator can also be a transformer object that provides a 2-arityreducing iterator function, step, 0-arity initial value function, init, and1-arity result extraction function result. The step function is used as theiterator function in reduce. The result function is used to convert thefinal accumulator into the return type and in most cases is R.identity. Theinit function is used to provide the initial accumulator.The iteration is performed with R.reduce after initializing the transducer.
		/// <para />
		/// sig: a -> (b -> b) -> [c] -> a
		/// </summary>
		/// <param name="acc">The initial accumulator value.</param>
		/// <param name="xf">The transducer function. Receives a transformer and returns a transformer.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		public static dynamic Into<TSource>(RamdaPlaceholder acc, Func<ITransformer, ITransformer> xf, IList<TSource> list) {
			return Currying.Into(acc, Delegate(xf), list);
		}

		/// <summary>
		/// Transforms the items of the list with the transducer and appends thetransformed items to the accumulator using an appropriate iterator functionbased on the accumulator type.The accumulator can be an array, string, object or a transformer. Iterateditems will be appended to arrays and concatenated to strings. Objects willbe merged directly or 2-item arrays will be merged as key, value pairs.The accumulator can also be a transformer object that provides a 2-arityreducing iterator function, step, 0-arity initial value function, init, and1-arity result extraction function result. The step function is used as theiterator function in reduce. The result function is used to convert thefinal accumulator into the return type and in most cases is R.identity. Theinit function is used to provide the initial accumulator.The iteration is performed with R.reduce after initializing the transducer.
		/// <para />
		/// sig: a -> (b -> b) -> [c] -> a
		/// </summary>
		/// <param name="acc">The initial accumulator value.</param>
		/// <param name="xf">The transducer function. Receives a transformer and returns a transformer.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		public static dynamic Into<TSource, TAccumulator>(IList<TAccumulator> acc, RamdaPlaceholder xf, IList<TSource> list) {
			return Currying.Into(acc, xf, list);
		}

		/// <summary>
		/// Transforms the items of the list with the transducer and appends thetransformed items to the accumulator using an appropriate iterator functionbased on the accumulator type.The accumulator can be an array, string, object or a transformer. Iterateditems will be appended to arrays and concatenated to strings. Objects willbe merged directly or 2-item arrays will be merged as key, value pairs.The accumulator can also be a transformer object that provides a 2-arityreducing iterator function, step, 0-arity initial value function, init, and1-arity result extraction function result. The step function is used as theiterator function in reduce. The result function is used to convert thefinal accumulator into the return type and in most cases is R.identity. Theinit function is used to provide the initial accumulator.The iteration is performed with R.reduce after initializing the transducer.
		/// <para />
		/// sig: a -> (b -> b) -> [c] -> a
		/// </summary>
		/// <param name="acc">The initial accumulator value.</param>
		/// <param name="xf">The transducer function. Receives a transformer and returns a transformer.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		public static dynamic Into<TSource>(RamdaPlaceholder acc, dynamic xf, IList<TSource> list) {
			return Currying.Into(acc, Delegate(xf), list);
		}

		/// <summary>
		/// Transforms the items of the list with the transducer and appends thetransformed items to the accumulator using an appropriate iterator functionbased on the accumulator type.The accumulator can be an array, string, object or a transformer. Iterateditems will be appended to arrays and concatenated to strings. Objects willbe merged directly or 2-item arrays will be merged as key, value pairs.The accumulator can also be a transformer object that provides a 2-arityreducing iterator function, step, 0-arity initial value function, init, and1-arity result extraction function result. The step function is used as theiterator function in reduce. The result function is used to convert thefinal accumulator into the return type and in most cases is R.identity. Theinit function is used to provide the initial accumulator.The iteration is performed with R.reduce after initializing the transducer.
		/// <para />
		/// sig: a -> (b -> b) -> [c] -> a
		/// </summary>
		/// <param name="acc">The initial accumulator value.</param>
		/// <param name="xf">The transducer function. Receives a transformer and returns a transformer.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		public static dynamic Into<TSource, TAccumulator>(IList<TAccumulator> acc, dynamic xf, IList<TSource> list) {
			return Currying.Into(acc, Delegate(xf), list);
		}

		/// <summary>
		/// Transforms the items of the list with the transducer and appends thetransformed items to the accumulator using an appropriate iterator functionbased on the accumulator type.The accumulator can be an array, string, object or a transformer. Iterateditems will be appended to arrays and concatenated to strings. Objects willbe merged directly or 2-item arrays will be merged as key, value pairs.The accumulator can also be a transformer object that provides a 2-arityreducing iterator function, step, 0-arity initial value function, init, and1-arity result extraction function result. The step function is used as theiterator function in reduce. The result function is used to convert thefinal accumulator into the return type and in most cases is R.identity. Theinit function is used to provide the initial accumulator.The iteration is performed with R.reduce after initializing the transducer.
		/// <para />
		/// sig: a -> (b -> b) -> [c] -> a
		/// </summary>
		/// <param name="acc">The initial accumulator value.</param>
		/// <param name="xf">The transducer function. Receives a transformer and returns a transformer.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		public static dynamic Into(RamdaPlaceholder acc = null, RamdaPlaceholder xf = null, RamdaPlaceholder list = null) {
			return Currying.Into(acc, xf, list);
		}
	}
}