﻿// <autogenerated>
//   This file was generated by T4 code generator LiftN.tt.
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
		public static dynamic LiftN(int n, Delegate fn) {
			return Currying.LiftN(n, fn);
		}

		public static dynamic LiftN(RamdaPlaceholder n, Delegate fn) {
			return Currying.LiftN(n, fn);
		}

		public static dynamic LiftN(int n, RamdaPlaceholder fn = null) {
			return Currying.LiftN(n, fn);
		}

		public static dynamic LiftN(RamdaPlaceholder n, dynamic fn) {
			return Currying.LiftN(n, fn);
		}

		public static dynamic LiftN(int n, dynamic fn) {
			return Currying.LiftN(n, fn);
		}

		public static dynamic LiftN(RamdaPlaceholder n = null, RamdaPlaceholder fn = null) {
			return Currying.LiftN(n, fn);
		}
	}
}