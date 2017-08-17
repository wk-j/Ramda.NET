﻿// <autogenerated>
//   This file was generated by T4 code generator Match.regex.tt.
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
		/// Tests a regular expression against a String. Note that this function willreturn an empty array when there are no matches. This differs from[`String.prototype.match`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/match)which returns `null` when there are no matches.
		/// <para />
		/// sig: RegExp -> String -> [String | Undefined]
		/// </summary>
		/// <param name="rx">A regular expression.</param>
		/// <param name="str">The string to match against</param>
		/// <returns>The list of matches or empty array.</returns>
		/// <see cref="R.Test"/>
		public static dynamic Match(Regex rx, string str) {
			return Currying.Match(rx, str);
		}

		/// <summary>
		/// Tests a regular expression against a String. Note that this function willreturn an empty array when there are no matches. This differs from[`String.prototype.match`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/match)which returns `null` when there are no matches.
		/// <para />
		/// sig: RegExp -> String -> [String | Undefined]
		/// </summary>
		/// <param name="rx">A regular expression.</param>
		/// <param name="str">The string to match against</param>
		/// <returns>The list of matches or empty array.</returns>
		/// <see cref="R.Test"/>
		public static dynamic Match(RamdaPlaceholder rx, string str) {
			return Currying.Match(rx, str);
		}

		/// <summary>
		/// Tests a regular expression against a String. Note that this function willreturn an empty array when there are no matches. This differs from[`String.prototype.match`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/match)which returns `null` when there are no matches.
		/// <para />
		/// sig: RegExp -> String -> [String | Undefined]
		/// </summary>
		/// <param name="rx">A regular expression.</param>
		/// <param name="str">The string to match against</param>
		/// <returns>The list of matches or empty array.</returns>
		/// <see cref="R.Test"/>
		public static dynamic Match(Regex rx, RamdaPlaceholder str = null) {
			return Currying.Match(rx, str);
		}

		/// <summary>
		/// Tests a regular expression against a String. Note that this function willreturn an empty array when there are no matches. This differs from[`String.prototype.match`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/match)which returns `null` when there are no matches.
		/// <para />
		/// sig: RegExp -> String -> [String | Undefined]
		/// </summary>
		/// <param name="rx">A regular expression.</param>
		/// <param name="str">The string to match against</param>
		/// <returns>The list of matches or empty array.</returns>
		/// <see cref="R.Test"/>
		public static dynamic Match(RamdaPlaceholder rx = null, RamdaPlaceholder str = null) {
			return Currying.Match(rx, str);
		}
	}
}