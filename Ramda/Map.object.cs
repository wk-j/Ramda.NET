﻿// <autogenerated>
//   This file was generated by T4 code generator Map.object.tt.
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
		public static dynamic Map<TSource, TReturn>(Func<TSource, TReturn> fn, object list) {
			return Currying.Map(new DelegateDecorator(fn), list);
		}

		public static dynamic Map(RamdaPlaceholder fn, object list) {
			return Currying.Map(fn, list);
		}

		public static dynamic Map(dynamic fn, object list) {
			return Currying.Map(fn, list);
		}
	}
}