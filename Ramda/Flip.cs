﻿// <autogenerated>
//   This file was generated by T4 code generator Flip.tt.
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
		public static dynamic Flip(Delegate fn) {
			return Currying.Flip(fn);
		}

		public static dynamic Flip(RamdaPlaceholder fn = null) {
			return Currying.Flip(fn);
		}

		public static dynamic Flip(dynamic fn) {
			return Currying.Flip(fn);
		}
	}
}