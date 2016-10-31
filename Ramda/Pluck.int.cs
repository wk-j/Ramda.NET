﻿// <autogenerated>
//   This file was generated by T4 code generator Pluck.int.tt.
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
		public static dynamic Pluck<TSource>(int key, IEnumerable<TSource> list) {
			return Currying.Pluck(key, list);
		}

		public static dynamic Pluck<TSource>(RamdaPlaceholder key, IEnumerable<TSource> list) {
			return Currying.Pluck(key, list);
		}

		public static dynamic Pluck(int key, RamdaPlaceholder list = null) {
			return Currying.Pluck(key, list);
		}

		public static dynamic Pluck(RamdaPlaceholder key = null, RamdaPlaceholder list = null) {
			return Currying.Pluck(key, list);
		}
	}
}