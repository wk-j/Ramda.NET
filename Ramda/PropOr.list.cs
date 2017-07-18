﻿// <autogenerated>
//   This file was generated by T4 code generator PropOr.list.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Dynamic;
using System.Collections;
using System.Threading.Tasks;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		/// <summary>
		/// If the given, non-null object has an own property with the specified name,returns the value of that property. Otherwise returns the provided defaultvalue.
		/// <para />
		/// sig: a -> String -> Object -> a
		/// </summary>
		/// <param name="val">The default value.</param>
		/// <param name="p">The name of the property to return.</param>
		/// <param name="obj">The object to query.</param>
		/// <returns>The value of given property of the supplied object or the default value.</returns>
		public static dynamic PropOr<TValue, TTarget>(TValue val, IList<int> p, TTarget obj) {
			return Currying.PropOr(val, p, obj);
		}

		/// <summary>
		/// If the given, non-null object has an own property with the specified name,returns the value of that property. Otherwise returns the provided defaultvalue.
		/// <para />
		/// sig: a -> String -> Object -> a
		/// </summary>
		/// <param name="val">The default value.</param>
		/// <param name="p">The name of the property to return.</param>
		/// <param name="obj">The object to query.</param>
		/// <returns>The value of given property of the supplied object or the default value.</returns>
		public static dynamic PropOr<TTarget>(RamdaPlaceholder val, IList<int> p, TTarget obj) where TTarget : IList {
			return Currying.PropOr(val, p, obj);
		}

		/// <summary>
		/// If the given, non-null object has an own property with the specified name,returns the value of that property. Otherwise returns the provided defaultvalue.
		/// <para />
		/// sig: a -> String -> Object -> a
		/// </summary>
		/// <param name="val">The default value.</param>
		/// <param name="p">The name of the property to return.</param>
		/// <param name="obj">The object to query.</param>
		/// <returns>The value of given property of the supplied object or the default value.</returns>
		public static dynamic PropOr<TValue>(TValue val, IList<int> p, RamdaPlaceholder obj = null) {
			return Currying.PropOr(val, p, obj);
		}
	}
}