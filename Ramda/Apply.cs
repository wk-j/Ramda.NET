﻿// <autogenerated>
//   This file was generated by T4 code generator Apply.tt.
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
		public static dynamic Apply(Delegate fn, object[] args) {
			return Currying.Apply(new DelegateDecorator(fn), args);
		}

		public static dynamic Apply(RamdaPlaceholder fn, object[] args) {
			return Currying.Apply(fn, args);
		}

		public static dynamic Apply(Delegate fn, RamdaPlaceholder args = null) {
			return Currying.Apply(new DelegateDecorator(fn), args);
		}

		public static dynamic Apply(dynamic fn, RamdaPlaceholder args = null) {
			return Currying.Apply(fn, args);
		}

		public static dynamic Apply(dynamic fn, object[] args) {
			return Currying.Apply(fn, args);
		}

		public static dynamic Apply(RamdaPlaceholder fn = null, RamdaPlaceholder args = null) {
			return Currying.Apply(fn, args);
		}
	}
}