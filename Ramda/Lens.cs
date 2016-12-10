﻿// <autogenerated>
//   This file was generated by T4 code generator Lens.tt.
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
		public static dynamic Lens(Delegate getter, Delegate setter) {
			return Currying.Lens(Delegate(getter), Delegate(setter));
		}

		public static dynamic Lens(RamdaPlaceholder getter, Delegate setter) {
			return Currying.Lens(getter, Delegate(setter));
		}

		public static dynamic Lens(Delegate getter, RamdaPlaceholder setter = null) {
			return Currying.Lens(Delegate(getter), setter);
		}

		public static dynamic Lens(RamdaPlaceholder getter, dynamic setter) {
			return Currying.Lens(getter, setter);
		}

		public static dynamic Lens(dynamic getter, RamdaPlaceholder setter = null) {
			return Currying.Lens(getter, setter);
		}

		public static dynamic Lens(dynamic getter, Delegate setter) {
			return Currying.Lens(getter, setter);
		}

		public static dynamic Lens(Delegate getter, dynamic setter) {
			return Currying.Lens(getter, setter);
		}

		public static dynamic Lens(RamdaPlaceholder getter = null, RamdaPlaceholder setter = null) {
			return Currying.Lens(getter, setter);
		}
	}
}