﻿// <autogenerated>
//   This file was generated by T4 code generator UncurryN.tt.
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
		/// Returns a function of arity `n` from a (manually) curried function.
		/// <para />
		/// sig: Number -> (a -> b) -> (a -> c)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to uncurry.</param>
		/// <returns>A new function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic UncurryN(int length, Delegate fn) {
			return Currying.UncurryN(length, Delegate(fn));
		}

		/// <summary>
		/// Returns a function of arity `n` from a (manually) curried function.
		/// <para />
		/// sig: Number -> (a -> b) -> (a -> c)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to uncurry.</param>
		/// <returns>A new function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic UncurryN(RamdaPlaceholder length, Delegate fn) {
			return Currying.UncurryN(length, Delegate(fn));
		}

		/// <summary>
		/// Returns a function of arity `n` from a (manually) curried function.
		/// <para />
		/// sig: Number -> (a -> b) -> (a -> c)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to uncurry.</param>
		/// <returns>A new function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic UncurryN(int length, RamdaPlaceholder fn = null) {
			return Currying.UncurryN(length, fn);
		}

		/// <summary>
		/// Returns a function of arity `n` from a (manually) curried function.
		/// <para />
		/// sig: Number -> (a -> b) -> (a -> c)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to uncurry.</param>
		/// <returns>A new function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic UncurryN(RamdaPlaceholder length, dynamic fn) {
			return Currying.UncurryN(length, Delegate(fn));
		}

		/// <summary>
		/// Returns a function of arity `n` from a (manually) curried function.
		/// <para />
		/// sig: Number -> (a -> b) -> (a -> c)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to uncurry.</param>
		/// <returns>A new function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic UncurryN(int length, dynamic fn) {
			return Currying.UncurryN(length, Delegate(fn));
		}

		/// <summary>
		/// Returns a function of arity `n` from a (manually) curried function.
		/// <para />
		/// sig: Number -> (a -> b) -> (a -> c)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to uncurry.</param>
		/// <returns>A new function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic UncurryN(RamdaPlaceholder length = null, RamdaPlaceholder fn = null) {
			return Currying.UncurryN(length, fn);
		}
	}
}