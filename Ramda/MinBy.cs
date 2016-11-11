﻿// <autogenerated>
//   This file was generated by T4 code generator MinBy.tt.
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
		public static dynamic MinBy<TArg>(Func<TArg, TArg> f, TArg a, TArg b) {
			return Currying.MinBy(new DelegateDecorator(f), a, b);
		}

		public static dynamic MinBy<TArg>(RamdaPlaceholder f, TArg a, TArg b) {
			return Currying.MinBy(f, a, b);
		}

		public static dynamic MinBy<TArg>(Func<TArg, TArg> f, RamdaPlaceholder a, TArg b) {
			return Currying.MinBy(new DelegateDecorator(f), a, b);
		}

		public static dynamic MinBy<TArg>(Func<TArg, TArg> f, TArg a, RamdaPlaceholder b = null) {
			return Currying.MinBy(new DelegateDecorator(f), a, b);
		}

		public static dynamic MinBy<TArg>(Func<TArg, TArg> f, RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.MinBy(new DelegateDecorator(f), a, b);
		}

		public static dynamic MinBy<TArg>(dynamic f, RamdaPlaceholder a, TArg b) {
			return Currying.MinBy(f, a, b);
		}

		public static dynamic MinBy<TArg>(dynamic f, TArg a, RamdaPlaceholder b = null) {
			return Currying.MinBy(f, a, b);
		}

		public static dynamic MinBy(dynamic f, RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.MinBy(f, a, b);
		}

		public static dynamic MinBy<TArg>(dynamic f, TArg a, TArg b) {
			return Currying.MinBy(f, a, b);
		}

		public static dynamic MinBy(RamdaPlaceholder f = null, RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.MinBy(f, a, b);
		}
	}
}