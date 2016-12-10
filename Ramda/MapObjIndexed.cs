﻿// <autogenerated>
//   This file was generated by T4 code generator MapObjIndexed.tt.
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
		public static dynamic MapObjIndexed<TTarget, TReturn>(Func<TTarget, TReturn> fn, TTarget obj) {
			return Currying.MapObjIndexed(Delegate(fn), obj);
		}

		public static dynamic MapObjIndexed<TTarget>(RamdaPlaceholder fn, TTarget obj) {
			return Currying.MapObjIndexed(fn, obj);
		}

		public static dynamic MapObjIndexed<TTarget, TReturn>(Func<TTarget, TReturn> fn, RamdaPlaceholder obj = null) {
			return Currying.MapObjIndexed(Delegate(fn), obj);
		}

		public static dynamic MapObjIndexed(dynamic fn, RamdaPlaceholder obj = null) {
			return Currying.MapObjIndexed(fn, obj);
		}

		public static dynamic MapObjIndexed<TTarget>(dynamic fn, TTarget obj) {
			return Currying.MapObjIndexed(fn, obj);
		}

		public static dynamic MapObjIndexed(RamdaPlaceholder fn = null, RamdaPlaceholder obj = null) {
			return Currying.MapObjIndexed(fn, obj);
		}
	}
}