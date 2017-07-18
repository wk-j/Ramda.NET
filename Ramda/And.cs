﻿// <autogenerated>
//   This file was generated by T4 code generator And.tt.
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
		/// Returns `true` if both arguments are `true`; `false` otherwise.
		/// <para />
		/// sig: a -> b -> a | b
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>the first argument if it is falsy, otherwise the second argument.</returns>
		/// <see cref="R.Both"/>
		public static dynamic And(bool a, bool b) {
			return Currying.And(a, b);
		}

		/// <summary>
		/// Returns `true` if both arguments are `true`; `false` otherwise.
		/// <para />
		/// sig: a -> b -> a | b
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>the first argument if it is falsy, otherwise the second argument.</returns>
		/// <see cref="R.Both"/>
		public static dynamic And(RamdaPlaceholder a, bool b) {
			return Currying.And(a, b);
		}

		/// <summary>
		/// Returns `true` if both arguments are `true`; `false` otherwise.
		/// <para />
		/// sig: a -> b -> a | b
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>the first argument if it is falsy, otherwise the second argument.</returns>
		/// <see cref="R.Both"/>
		public static dynamic And(bool a, RamdaPlaceholder b = null) {
			return Currying.And(a, b);
		}

		/// <summary>
		/// Returns `true` if both arguments are `true`; `false` otherwise.
		/// <para />
		/// sig: a -> b -> a | b
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>the first argument if it is falsy, otherwise the second argument.</returns>
		/// <see cref="R.Both"/>
		public static dynamic And(RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.And(a, b);
		}
	}
}