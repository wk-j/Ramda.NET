﻿// <autogenerated>
//   This file was generated by T4 code generator Converge.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Converge(Delegate after, IList<Delegate> functions) {
			return Currying.Converge(after, functions);
		}

		public static dynamic Converge(RamdaPlaceholder after, IList<Delegate> functions) {
			return Currying.Converge(after, functions);
		}

		public static dynamic Converge(Delegate after, RamdaPlaceholder functions = null) {
			return Currying.Converge(after, functions);
		}

		public static dynamic Converge(dynamic after, RamdaPlaceholder functions = null) {
			return Currying.Converge(after, functions);
		}

		public static dynamic Converge(dynamic after, IList<Delegate> functions) {
			return Currying.Converge(after, functions);
		}

		public static dynamic Converge(RamdaPlaceholder after = null, RamdaPlaceholder functions = null) {
			return Currying.Converge(after, functions);
		}
	}
}