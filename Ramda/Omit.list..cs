﻿// <autogenerated>
//   This file was generated by T4 code generator Omit.list..tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Omit<TTarget>(IList<string> names, TTarget obj) {
			return Currying.Omit(names, obj);
		}

		public static dynamic Omit<TTarget>(RamdaPlaceholder names, TTarget obj) {
			return Currying.Omit(names, obj);
		}

		public static dynamic Omit(IList<string> names, RamdaPlaceholder obj = null) {
			return Currying.Omit(names, obj);
		}

		public static dynamic Omit(RamdaPlaceholder names = null, RamdaPlaceholder obj = null) {
			return Currying.Omit(names, obj);
		}
	}
}