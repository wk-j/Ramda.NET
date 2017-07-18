﻿// <autogenerated>
//   This file was generated by T4 code generator Add.object.tt.
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
		/// Adds two values.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Number</returns>
		/// <see cref="R.Subtract"/>
		public static dynamic Add(object a, object b) {
			return Currying.Add(a, b);
		}

		/// <summary>
		/// Adds two values.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Number</returns>
		/// <see cref="R.Subtract"/>
		public static dynamic Add(RamdaPlaceholder a, object b) {
			return Currying.Add(a, b);
		}

		/// <summary>
		/// Adds two values.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Number</returns>
		/// <see cref="R.Subtract"/>
		public static dynamic Add(object a, RamdaPlaceholder b = null) {
			return Currying.Add(a, b);
		}
	}
}