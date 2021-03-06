﻿// <autogenerated>
//   This file was generated by T4 code generator Unless.tt.
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
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg, TReturn>(Func<TArg, bool> pred, Func<TArg, TReturn> whenFalseFn, TArg x) {
			return Currying.Unless(Delegate(pred), Delegate(whenFalseFn), x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg, TReturn>(RamdaPlaceholder pred, Func<TArg, TReturn> whenFalseFn, TArg x) {
			return Currying.Unless(pred, Delegate(whenFalseFn), x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg>(Func<TArg, bool> pred, RamdaPlaceholder whenFalseFn, TArg x) {
			return Currying.Unless(Delegate(pred), whenFalseFn, x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg, TReturn>(Func<TArg, bool> pred, Func<TArg, TReturn> whenFalseFn, RamdaPlaceholder x = null) {
			return Currying.Unless(Delegate(pred), Delegate(whenFalseFn), x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg>(Func<TArg, bool> pred, RamdaPlaceholder whenFalseFn = null, RamdaPlaceholder x = null) {
			return Currying.Unless(Delegate(pred), whenFalseFn, x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg>(RamdaPlaceholder pred, dynamic whenFalseFn, TArg x) {
			return Currying.Unless(pred, Delegate(whenFalseFn), x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg>(dynamic pred, RamdaPlaceholder whenFalseFn, TArg x) {
			return Currying.Unless(Delegate(pred), whenFalseFn, x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless(dynamic pred, dynamic whenFalseFn, RamdaPlaceholder x = null) {
			return Currying.Unless(Delegate(pred), Delegate(whenFalseFn), x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless(dynamic pred, RamdaPlaceholder whenFalseFn = null, RamdaPlaceholder x = null) {
			return Currying.Unless(Delegate(pred), whenFalseFn, x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg, TReturn>(dynamic pred, Func<TArg, TReturn> whenFalseFn, TArg x) {
			return Currying.Unless(Delegate(pred), Delegate(whenFalseFn), x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg>(Func<TArg, bool> pred, dynamic whenFalseFn, TArg x) {
			return Currying.Unless(Delegate(pred), Delegate(whenFalseFn), x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless<TArg>(dynamic pred, dynamic whenFalseFn, TArg x) {
			return Currying.Unless(Delegate(pred), Delegate(whenFalseFn), x);
		}

		/// <summary>
		/// Tests the final argument by passing it to the given predicate function. Ifthe predicate is not satisfied, the function will return the result ofcalling the `whenFalseFn` function with the same argument. If the predicateis satisfied, the argument is returned as is.
		/// <para />
		/// sig: (a -> Boolean) -> (a -> a) -> a -> a
		/// </summary>
		/// <param name="pred">A predicate function</param>
		/// <param name="whenFalseFn">A function to invoke when the `pred` evaluates         to a falsy value.</param>
		/// <param name="x">An object to test with the `pred` function and         pass to `whenFalseFn` if necessary.</param>
		/// <returns>Either `x` or the result of applying `x` to `whenFalseFn`.</returns>
		/// <see cref="R.IfElse"/>
		/// <see cref="R.When"/>
		public static dynamic Unless(RamdaPlaceholder pred = null, RamdaPlaceholder whenFalseFn = null, RamdaPlaceholder x = null) {
			return Currying.Unless(pred, whenFalseFn, x);
		}
	}
}