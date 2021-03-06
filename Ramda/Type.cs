﻿// <autogenerated>
//   This file was generated by T4 code generator Type.tt.
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
		/// Gives a single-word string description of the (native) type of a value,returning such answers as 'Object', 'Number', 'Array', or 'Null'. Does notattempt to distinguish user Object types any further, reporting them all as'Object'.
		/// <para />
		/// sig: (* -> {*}) -> String
		/// </summary>
		/// <param name="val">The value to test</param>
		/// <returns>String</returns>
		public static dynamic Type<TTarget>(TTarget val) {
			return Currying.Type(val);
		}

		/// <summary>
		/// Gives a single-word string description of the (native) type of a value,returning such answers as 'Object', 'Number', 'Array', or 'Null'. Does notattempt to distinguish user Object types any further, reporting them all as'Object'.
		/// <para />
		/// sig: (* -> {*}) -> String
		/// </summary>
		/// <param name="val">The value to test</param>
		/// <returns>String</returns>
		public static dynamic Type(RamdaPlaceholder val = null) {
			return Currying.Type(val);
		}
	}
}