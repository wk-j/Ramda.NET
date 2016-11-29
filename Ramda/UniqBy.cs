﻿// <autogenerated>
//   This file was generated by T4 code generator UniqBy.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic UniqBy<TSource, TReturn>(Func<TSource, TReturn> fn, IList<TSource> list) {
			return Currying.UniqBy(new DelegateDecorator(fn), list);
		}

		public static dynamic UniqBy<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.UniqBy(fn, list);
		}

		public static dynamic UniqBy<TSource, TReturn>(Func<TSource, TReturn> fn, RamdaPlaceholder list = null) {
			return Currying.UniqBy(new DelegateDecorator(fn), list);
		}

		public static dynamic UniqBy(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.UniqBy(fn, list);
		}

		public static dynamic UniqBy<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.UniqBy(fn, list);
		}

		public static dynamic UniqBy(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.UniqBy(fn, list);
		}
	}
}