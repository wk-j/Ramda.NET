﻿// <autogenerated>
//   This file was generated by T4 code generator Lt.double.tt.
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
		/// Returns `true` if the first argument is less than the second; `false`otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Gt"/>
		public static dynamic Lt(double a, double b) {
			return Currying.Lt(a, b);
		}

		/// <summary>
		/// Returns `true` if the first argument is less than the second; `false`otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Gt"/>
		public static dynamic Lt(RamdaPlaceholder a, double b) {
			return Currying.Lt(a, b);
		}

		/// <summary>
		/// Returns `true` if the first argument is less than the second; `false`otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Gt"/>
		public static dynamic Lt(double a, RamdaPlaceholder b = null) {
			return Currying.Lt(a, b);
		}

		/// <summary>
		/// Returns `true` if the first argument is less than the second; `false`otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Gt"/>
		public static dynamic Lt(RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.Lt(a, b);
		}
	}
}