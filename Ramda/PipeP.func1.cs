﻿// <autogenerated>
//   This file was generated by T4 code generator PipeP.func1.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
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
		/// Performs left-to-right composition of one or more Promise-returningfunctions. The leftmost function may have any arity; the remaining functionsmust be unary.
		/// <para />
		/// sig: ((a -> Promise b), (b -> Promise c), ..., (y -> Promise z)) -> (a -> Promise z)
		/// </summary>
		/// <param name="functions">first</param>
		/// <returns>Function</returns>
		/// <see cref="R.ComposeP"/>
		public static dynamic PipeP(params Func<dynamic, Task<dynamic>>[] functions) {
			return Currying.PipeP(functions);
		}
	}
}