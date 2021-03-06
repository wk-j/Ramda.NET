﻿using System;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Reflection;
using System.Collections;
using static Ramda.NET.R;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Ramda.NET.ReflectionExtensions;
using System.Threading.Tasks;

namespace Ramda.NET
{
    internal static partial class Currying
    {
        internal static AwaitableDynamicDelegate AwaitableDelegate(Delegate fn) {
            return new AwaitableDynamicDelegate(fn);
        }

        internal static DynamicDelegate Delegate(Func<object[], object> fn, int? length = null) {
            return new DelegateDecorator(fn, length);
        }

        internal static DynamicDelegate Delegate(object context, Delegate fn, int? length = null) {
            var @delegate = fn.Method.CreateDelegate(context);

            return Delegate((object[] arguments) => @delegate.Invoke(arguments), length);
        }

        internal static DynamicDelegate Delegate(Func<object> fn) {
            return new DelegateDecorator(fn);
        }

        internal static DynamicDelegate Delegate(Func<object, object> fn) {
            return new DelegateDecorator(fn);
        }

        internal static DynamicDelegate Delegate(Func<object, object, object> fn) {
            return new DelegateDecorator(fn);
        }

        internal static DynamicDelegate Delegate(Func<object, object, object, object> fn) {
            return new DelegateDecorator(fn);
        }

        internal static DynamicDelegate Delegate(dynamic fn) {
            return DelegateN(fn);
        }

        internal static DynamicDelegate NullableDelegate(dynamic fn) {
            if (((object)fn).IsNull()) {
                return fn;
            }

            return Delegate(fn);
        }

        internal static DynamicDelegate DelegateN(dynamic fn, int? length = null) {
            Type type = fn.GetType();

            if (type.TypeIsDelegate()) {
                return new DelegateDecorator((Delegate)fn, length);
            }

            return fn;
        }

        internal static DynamicDelegate PromiseDelegateN(dynamic fn, int? length = null) {
            return new PromiseLikeDynamicDelegate((AwaitableDynamicDelegate)fn);
        }

        private static dynamic ComplementInternal(DynamicDelegate fn) {
            return Delegate((object[] arguments) => !fn.DynamicInvoke<bool>(arguments));
        }

        private static bool ContainsWith(Func<object, object, bool> predicate, object x, IList list) {
            foreach (var item in list) {
                if (predicate(x, item)) {
                    return true;
                }
            }

            return false;
        }

        private static IList FilterInternal(Func<object, bool> fn, IList list) {
            var result = new ArrayList();

            foreach (var item in list) {
                if (fn(item)) {
                    result.Add(item.IsNull() ? R.@null : item);
                }
            }

            return result.ToArray<Array>();
        }

        internal static IReduced ForceReduced(object x) => new ReducedImpl(x);

        internal static TValue IdentityInternal<TValue>(TValue x) => x;

        private static object[] MapInternal(dynamic fn, IList functor) {
            return MapInternal(obj => Delegate(fn).DynamicInvoke(obj), functor);
        }

        private static object[] MapInternal(Func<object, object> fn, IList functor) {
            var idx = 0;
            var len = functor.Count;
            var result = new object[len];

            while (idx < len) {
                result[idx] = fn(functor[idx]) ?? R.@null;
                idx += 1;
            }

            return result;
        }

        private static Array OfInternal(object x) {
            var type = x.GetType();
            var list = type.CreateNewList<IList>();

            list.Insert(0, x);

            return list.ToArray<Array>();
        }

        private static DynamicDelegate PipeInternal(dynamic f, dynamic g) {
            return Delegate((object[] arguments) => g.DynamicInvoke(new[] { f.DynamicInvoke(arguments) }));
        }

        private static AwaitableDynamicDelegate PipePInternal(dynamic f, dynamic g) {
            return new AwaitableDynamicDelegate(async (object[] arguments) => {
                return await g.DynamicInvoke(new[] { await f.DynamicInvoke(arguments) });
            });
        }

        internal static IReduced ReducedInternal(object x) {
            var reduced = x as IReduced;

            return reduced.IsNotNull() && reduced.Reduced ? reduced : new ReducedImpl(x);
        }

        private static IList ApertureInternal(int length, IList list) {
            var idx = 0;
            var limit = list.Count - (length - 1);
            IList acc = null;

            limit = limit >= 0 ? limit : 0;
            acc = list.IsArray() ? (IList)new object[limit] : new List<object>(limit);

            while (idx < limit) {
                acc[idx] = list.Slice(idx, idx + length);
                idx += 1;
            }

            return acc;
        }

        private static object Assign(params object[] objectN) {
            return ObjectAssigner.Assign(new ExpandoObject(), objectN);
        }

        private static object Assign(IList list) {
            return ObjectAssigner.Assign(new ExpandoObject(), list.Cast<object>().ToArray());
        }

        private static Curry1 CheckForMethod1(string methodName, dynamic fn) {
            return Curry1<IEnumerable, IEnumerable>(list => CheckForMethodN(methodName, fn, list));
        }

        private static Func<object, object, object> CheckForMethod2(string methodName, dynamic fn) {
            return new Func<object, object, object>((arg1, arg2) => CheckForMethodN(methodName, fn, arg1, arg2));
        }

        private static Func<TArg1, TArg2, TArg3, TResult> CheckForMethod3<TArg1, TArg2, TArg3, TResult>(string methodName, Func<TArg1, TArg2, TArg3, TResult> fn) {
            return (arg1, arg2, arg3) => (TResult)CheckForMethodN(methodName, Delegate(fn), arg1, arg2, arg3);
        }

        private static object CheckForMethodN(string methodName, dynamic fn, params object[] arguments) {
            object obj;
            Delegate member;
            var invokeFn = false;
            var length = arguments.Length;

            if (length == 0) {
                return fn(new object[0]);
            }

            obj = arguments[length - 1];
            member = obj.Member(methodName) as Delegate;
            invokeFn = member.IsNull() || !member.IsFunction();

            if (invokeFn || obj.IsList()) {
                return Delegate(fn).DynamicInvoke(arguments);
            }

            return member.InvokeNative((object[])arguments.Slice(0, length - 1));
        }

        private static Func<object, object> Dispatchable1(string[] methodNames, dynamic xf, dynamic fn) {
            return new Func<object, object>(arg => {
                return Dispatchable(methodNames, xf, fn, Arguments(arg));
            });
        }

        private static DynamicDelegate Dispatchable2(string[] methodName, dynamic xf, Delegate fn) {
            return Dispatchable2(methodName, xf, new DelegateDecorator(fn));
        }

        private static DynamicDelegate Dispatchable2(string[] methodNames, dynamic xf, DynamicDelegate fn) {
            return Delegate(new Func<object, object, object>((arg1, arg2) => Dispatchable(methodNames, xf, fn, Arguments(arg1, arg2))));
        }

        private static DynamicDelegate Dispatchable4(string[] methodNames, dynamic xf, dynamic fn) {
            return Delegate(new Func<dynamic, dynamic, dynamic, dynamic, dynamic>((arg1, arg2, arg3, arg4) => {
                return Dispatchable(methodNames, xf, fn, Arguments(arg1, arg2, arg3, arg4));
            }));
        }

        private static object Dispatchable(string[] methodNames, dynamic xf, dynamic fn, IList arguments) {
            object obj;
            object[] args = null;

            if (arguments.Count == 0) {
                return fn.DynamicInvoke();
            }

            args = arguments.Cast<object>().Take(arguments.Count >= 2 ? arguments.Count - 1 : 0).ToArray();
            obj = arguments[arguments.Count - 1];

            if (!obj.IsList()) {
                var idx = 0;

                while (idx < methodNames.Length) {
                    var member = obj.Member(methodNames[idx]) as Delegate;

                    if (member.IsNotNull()) {
                        return member.InvokeNative(args);
                    }

                    idx += 1;
                }

                if (obj is ITransformer) {
                    var transformer = xf.DynamicInvoke(args);

                    return transformer(obj);
                }
            }

            return fn.DynamicInvoke(arguments.ToArray<object[]>());
        }

        private static IList DropLastWhileInternal(dynamic pred, IList list) {
            var idx = list.Count - 1;
            DynamicDelegate dynamicDelegate = Delegate(pred);

            while (idx >= 0 && dynamicDelegate.DynamicInvoke<bool>(list[idx])) {
                idx -= 1;
            }

            return list.Slice(0, idx + 1);
        }

        private readonly static dynamic XAll = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XAll((o => f(o)), xf)));

        private readonly static dynamic XAny = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XAny((o => f(o)), xf)));

        private readonly static dynamic XAperture = Curry2(new Func<int, ITransformer, ITransformer>((n, xf) => new XAperture(n, xf)));

        private readonly static dynamic XDrop = Curry2(new Func<int, ITransformer, ITransformer>((n, xf) => new XDrop(n, xf)));

        private readonly static dynamic XDropLast = Curry2(new Func<int, ITransformer, ITransformer>((n, xf) => new XDropLast(n, xf)));

        private readonly static dynamic XDropRepeatsWith = Curry2(new Func<dynamic, ITransformer, ITransformer>((pred, xf) => new XDropRepeatsWith(pred, xf)));

        private readonly static dynamic XDropWhile = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XDropWhile(f, xf)));

        private readonly static dynamic XFilter = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XFilter(f, xf)));

        private readonly static dynamic XFind = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XFind(f, xf)));

        private readonly static dynamic XFindIndex = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XFindIndex(f, xf)));

        private readonly static dynamic XFindLast = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XFindLast(f, xf)));

        private readonly static dynamic XFindLastIndex = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XFindLastIndex(f, xf)));

        private readonly static dynamic XMap = Curry2(new Func<dynamic, ITransformer, ITransformer>((f, xf) => new XMap(f, xf)));

        private readonly static dynamic XReduceBy = CurryNInternal(4, new object[0], new Func<dynamic, object, dynamic, ITransformer, ITransformer>((valueFn, valueAcc, keyFn, xf) => {
            return new XReduceBy(valueFn, valueAcc, keyFn, xf);
        }));

        private readonly static dynamic XTake = Curry2(new Func<int, ITransformer, ITransformer>((n, xf) => new XTake(n, xf)));

        private readonly static dynamic XTakeWhile = Curry2(new Func<DynamicDelegate, ITransformer, ITransformer>((f, xf) => new XTakeWhile(f, xf)));

        private readonly static dynamic XDropLastWhile = Curry2(new Func<DynamicDelegate, ITransformer, ITransformer>((f, xf) => new XDropLstWhile(f, xf)));

        private readonly static dynamic XChain = Curry2(new Func<dynamic, ITransformer, object>((f, xf) => Map(f, new XFlatCat(xf))));

        internal class ComparerFactory : IComparer
        {
            private Func<object, object, int> comparator;

            internal ComparerFactory(Func<object, object, int> comparator) {
                this.comparator = comparator;
            }

            public int Compare(object x, object y) {
                return comparator(x, y);
            }
        }

        private static object FindInternal(int from, int indexerAcc, Func<int, bool> loopPredicate, Func<object, bool> fn, IList list) {
            var idx = from;

            while (loopPredicate(idx)) {
                if (fn(list[idx])) {
                    return list[idx];
                }

                idx += indexerAcc;
            }

            return null;
        }

        private static int FindIndexInternal(int from, int indexerAcc, Func<int, bool> loopPredicate, Func<object, bool> fn, IList list) {
            var idx = from;

            while (loopPredicate(idx)) {
                if (fn(list[idx])) {
                    return idx;
                }

                idx += indexerAcc;
            }

            return -1;
        }

        private static object InternalIfElse(dynamic condition, dynamic onTrue, dynamic onFalse, params object[] arguments) {
            return condition.DynamicInvoke(arguments) ? onTrue.DynamicInvoke(arguments) : onFalse.DynamicInvoke(arguments);
        }

        private static object InternalEvolve(object transformationsObj, object target) {
            IDictionary<string, object> result = new ExpandoObject();
            var transformations = transformationsObj.ToMemberDictionary();

            foreach (var keyValue in target.ToMemberDictionary()) {
                object transformation;
                var key = keyValue.Key;
                var value = keyValue.Value;

                if (transformations.TryGetValue(key, out transformation)) {
                    if (transformation.IsNotNull()) {
                        if (transformation.IsFunction()) {
                            result[key] = Delegate(transformation).DynamicInvoke(value);
                            continue;
                        }
                        else if (!value.IsPrimitive()) {
                            if (!transformation.IsDictionary()) {
                                transformation = transformation.ToMemberDictionary();
                            }

                            result[key] = InternalEvolve((IDictionary<string, object>)transformation, value);
                            continue;
                        }
                    }
                }

                result[key] = value;
            }

            return result;
        }

        private static object InternalDissocPath(IList path, object obj) {
            switch (path.Count) {
                case 0:
                    return obj;
                case 1:
                    return Dissoc(path[0], obj);
                default:
                    var head = (string)path[0];
                    var tail = path.Slice(1);
                    var headValue = obj.Member(head);

                    return headValue.IsNull() ? obj : Assoc(head, InternalDissocPath(tail, headValue), obj);
            }
        }

        private static bool AllOrAny(dynamic fn, IList list, bool returnValue) {
            foreach (var item in list) {
                if (fn(item) == returnValue) {
                    return returnValue;
                }
            }

            return !returnValue;
        }

        private static IDictionary<string, object> PickIntrenal(IList names, object obj, bool setIfNull = false) {
            IDictionary<string, object> result = new ExpandoObject();

            foreach (var name in names) {
                object member;

                if (!TryGetMember(name, obj, out member) && !setIfNull) {
                    continue;
                }

                result[name.ToString()] = member;
            }

            return result;
        }

        private static IList SortInternal(IList list, IComparer comparer) {
            if (list.IsArray()) {
                Array.Sort((Array)list, comparer);

                return list;
            }

            var array = list.ToArray<Array>();
            Array.Sort(array, comparer);

            return array.CreateNewList(array);
        }

        private static IList TakeWhileInternal(int from, int indexerAcc, Func<int, bool> loopPredicate, DynamicDelegate fn, IList list, Func<int, int> sliceFrom, Func<int, int> sliceTo) {
            var idx = from;

            while (loopPredicate(idx) && fn.DynamicInvoke<bool>(list[idx])) {
                idx += indexerAcc;
            }

            return list.Slice(sliceFrom(idx), sliceTo(idx));
        }

        private static IList[] ZipInternal(IList a, IList b, int len, Func<IList, int, object> valAResolver = null) {
            var idx = 0;
            var rv = new List<IList>();

            while (idx < len) {
                IList pair;
                var valB = b[idx];
                var valA = valAResolver?.Invoke(a, idx) ?? a[idx];
                var typeA = valA.GetType();

                if (typeA.Equals(valB.GetType())) {
                    pair = typeA.CreateNewList<IList>();
                    pair.Add(valA);
                    pair.Add(valB);
                    pair = pair.ToArray<Array>(typeA);
                }
                else {
                    pair = new object[] { valA, valB };
                }

                rv.Add(pair);
                idx += 1;
            }

            return rv.ToArray();
        }

        internal static bool IsPlaceholder(object param) {
            return param != null && R.__.Equals(param);
        }

        private static DynamicDelegate CurryNInternal(int length, object[] received, DynamicDelegate fn) {
            return new CurryN(fn, received, length);
        }

        private static DynamicDelegate CurryNInternal(int length, object[] received, Delegate fn) {
            return CurryNInternal(length, received, new DelegateDecorator(fn));
        }

        private static Functor IdentityFunctor(object x) {
            return new Functor {
                Value = x,
                Map = new Func<dynamic, Functor>(f => IdentityFunctor(f.DynamicInvoke(x)))
            };
        }

        private static Functor Const(object x) {
            var functor = new Functor { Value = x };

            functor.Map = new Func<dynamic, Functor>(f => {
                return functor;
            });

            return functor;
        }

        private static dynamic CreatePartialApplicator(DynamicDelegate concat) {
            return Curry2(new Func<dynamic, IList, dynamic>((fn, args) => {
                return Arity(Math.Max(0, fn.Arity() - args.Count), Delegate((object[] arguments) => {
                    DynamicDelegate dynamicDelegate = Delegate(fn);
                    var concatedArgs = (IList)concat.DynamicInvoke(args, Arguments(arguments));

                    return dynamicDelegate.DynamicInvoke(concatedArgs.ToArray<object[]>(typeof(object)));
                }));
            }));
        }

        private static IEnumerable DropLastInternal(int n, IEnumerable xs) {
            IList list;
            string value = xs as string;

            if (value != null) {
                return value.Substring(0, value.Length - Math.Min(value.Length, n));
            }

            list = xs as IList;

            return Take(n < list.Count ? list.Count - n : 0, list);
        }

        private static bool EqualsInternal(object a, object b, ArrayList stackA, ArrayList stackB) {
            int idx;
            Type typeA;
            Type typeB;
            Delegate equalsA;
            Delegate equalsB;
            string[] membersAKeys;
            Type typeofObject = typeof(object);
            IDictionary<string, object> membersA;
            IDictionary<string, object> membersB;
            Func<object, Type, Delegate> getEquals = (obj, objType) => {
                if (!a.IsAnonymousType()) {
                    return a.MemberWhere<Delegate>("Equals", del => del.IsOverriden(objType));
                }

                return null;
            };

            if (Identical(a, b)) {
                return true;
            }

            if (R.Type(a) != R.Type(b)) {
                return false;
            }

            if (a.IsNull() || b.IsNull()) {
                return false;
            }

            typeA = a.GetType();
            typeB = b.GetType();
            equalsA = getEquals(a, typeA);
            equalsB = getEquals(b, typeB);

            if (equalsA != null || equalsB != null) {
                return (bool)equalsB.DynamicInvoke(new[] { b, a });
            }

            if (typeA.TypeIsPrimitive()) {
                return false;
            }
            else if (typeof(Exception).IsAssignableFrom(typeA)) {
                return ((Exception)a).Message.Equals(((Exception)b).Message);
            }
            else if (typeA.Equals(typeof(Regex))) {
                var sourceA = a.Member("pattern", @private: true);
                var sourceB = b.Member("pattern", @private: true);

                if (!sourceA.Equals(sourceB)) {
                    return false;
                }
            }
            else if (typeA.TypeIsDictionary() && !typeA.TypeIsExpandoObject()) {
                return EqualsInternal(((IDictionary)a).Values.ToArray<Array>(typeofObject), ((IDictionary)b).Values.ToArray<Array>(typeofObject), stackA, stackB);
            }
            else if (typeA.TypeIsSet()) {
                return EqualsInternal(((IEnumerable)a).ToArray<Array>(typeofObject), ((IEnumerable)b).ToArray<Array>(typeofObject), stackA, stackB);
            }

            membersA = a.ToMemberDictionary();
            membersB = b.ToMemberDictionary();
            membersAKeys = membersA.Keys.ToArray();

            if (membersA.Count != membersB.Count) {
                return false;
            }

            idx = stackA.Count - 1;

            while (idx >= 0) {
                if (stackA[idx] == a) {
                    return stackB[idx] == b;
                }

                idx -= 1;
            }

            stackA.Add(a);
            stackB.Add(b);
            idx = membersA.Count - 1;

            while (idx >= 0) {
                var key = membersAKeys[idx];

                if (!(membersB.ContainsKey(key) && EqualsInternal(membersB[key], membersA[key], stackA, stackB))) {
                    return false;
                }

                idx -= 1;
            }

            stackA.RemoveAt(stackA.Count - 1);
            stackB.RemoveAt(stackB.Count - 1);

            return true;
        }

        private static Func<object, IList> MakeFlat(bool recursive) {
            return list => Flatt(list, recursive);
        }

        private static IList Flatt(object list, bool recursive) {
            var idx = 0;
            var result = new ArrayList();
            var ilen = (int)list.Member("Length");
            var resolveItem = FlatResolveItemFactory(list);

            while (idx < ilen) {
                var item = resolveItem(idx);

                if (IsArrayLike(item)) {
                    var j = 0;
                    object value = recursive ? Flatt((dynamic)item, recursive) : item;
                    var resolveInnerItem = FlatResolveItemFactory(value);
                    var jlen = (int)value.Member("Length");

                    while (j < jlen) {
                        result.Add(resolveInnerItem(j));
                        j += 1;
                    }
                }
                else {
                    result.Add(item);
                }

                idx += 1;
            }

            return result.ToArray<IList>();
        }

        private static Func<int, object> FlatResolveItemFactory(object obj) {
            var stringDictionary = obj as IDictionary<string, object>;

            if (stringDictionary != null) {
                return i => stringDictionary[i.ToString()];
            }

            var dictionary = obj as IDictionary;

            if (dictionary != null) {
                return i => dictionary[i];
            }

            var arr = obj as IList;

            return i => arr[i];
        }

        internal static object ReduceInternal(object fn, object acc, object list) {
            IReducible reducible = null;
            ITransformer transformer = fn as ITransformer;

            if (fn.IsFunction()) {
                transformer = new XWrap((dynamic)fn);
            }

            if (R.IsArrayLike(list)) {
                return IterableReduce(transformer, acc, (IEnumerable)list);
            }

            reducible = list as IReducible;

            if (reducible.IsNotNull()) {
                return MethodReduce(transformer, acc, reducible);
            }

            throw new ArgumentException("Reduce: list must be array or iterable");
        }

        internal static DynamicDelegate ReduceTaskInternal(AwaitableDynamicDelegate acc, IList<AwaitableDynamicDelegate> list) {
            var xf = new TaskXWrap(PipePInternal);

            foreach (var item in list) {
                acc = xf.Step(acc, item);
            }

            return new PromiseLikeDynamicDelegate(xf.Result(acc));
        }

        private static object IterableReduce(ITransformer xf, object acc, IEnumerable list) {
            object result;
            IReduced reduced;

            foreach (var item in list) {
                acc = xf.Step(acc, item);
                reduced = acc as IReduced;

                if (reduced.IsNotNull()) {
                    acc = reduced.Value;
                    break;
                }
            }

            result = xf.Result(acc);

            if (result.IsList()) {
                return new ArrayList((ICollection)result).ToArray<Array>();
            }

            return result;
        }

        private static object MethodReduce(ITransformer xf, object acc, IReducible obj) {
            return xf.Result(obj.Reduce(new Func<object, object, object>(xf.Step), acc));
        }

        private static ITransformer StepCat(object obj) {
            Type objType;
            var transformer = obj as ITransformer;

            if (transformer.IsNotNull()) {
                return transformer;
            }

            if (IsArrayLike(obj)) {
                return new StepCatArray();
            }

            objType = obj.GetType();

            if (objType.Equals(typeof(string))) {
                return new StepCatString();
            }

            if (typeof(object).IsAssignableFrom(objType)) {
                return new StepCatObject();
            }

            throw new ArgumentException($"Cannot create transformer for {obj.GetType().Name}");
        }

        private static DynamicDelegate AnyOrAllPass(IList preds, bool comparend) {
            return Delegate((object[] arguments) => {
                foreach (dynamic pred in preds) {
                    DynamicDelegate dynamicPred = Delegate(pred);

                    if (dynamicPred.DynamicInvoke<bool>(arguments) == comparend) {
                        return comparend;
                    }
                }

                return !comparend;
            });
        }

        private static object ApplySpecInternal(object spec) {
            spec = Map(new Func<object, object>(v => v.IsFunction() ? v : ApplySpecInternal(v)), spec);

            return CurryN(Reduce(Max, 0, Pluck("Length", Values(spec))), Delegate((object[] arguments) => {
                return Map(new Func<object, object>(f => Apply(f, arguments)), spec);
            }));
        }

        private static object ArrayOf = new DelegateDecorator(new Func<object[], object[]>(arguments => arguments));

        private static bool ContainsInternal(object item, object list) {
            string stringList = null;
            MethodInfo contains = null;
            var trueList = list as IList;

            if (trueList != null) {
                return trueList.Contains(item);
            }

            stringList = list as string;

            if (stringList != null) {
                return stringList.Contains(item.ToString());
            }

            contains = list.GetMemberWhen<MethodInfo>("Contains", m => m.MemberType == MemberTypes.Method);

            if (contains.IsNotNull()) {
                return (bool)contains.Invoke(list, new[] { item });
            }

            return false;
        }

        private static string ToStringInternal(object x) {
            return ToStringInternal(x, new object[0]);
        }

        private static string ToStringInternal(object x, IList seen) {
            IList list = null;
            string str = null;
            StringBuilder stringBuilder = null;
            Func<object, string> recur = y => {
                var xs = seen.Concat(new[] { x });

                return ContainsInternal(y, xs) ? "<Circular>" : ToStringInternal(y, xs);
            };

            Func<object, IList, IList> mapPairs = (obj, keys) => {
                return MapInternal(k => {
                    return $"{Quote((string)k)}: {recur(obj.Member(k))}";
                }, keys.Slice().Sort(new Comparison<string>((a, b) => string.Compare(a, b))));
            };

            list = x as IList;

            if (list != null) {
                IList transformedList = null;

                stringBuilder = new StringBuilder("[");
                transformedList = MapInternal(recur, list).Concat((IList)mapPairs(x, Reject(Delegate((object k) => {
                    return Regex.IsMatch((string)k, @"^\d+$");
                }), x.Keys())));

                if (transformedList.Count > 0) {
                    transformedList.ForEach(s => stringBuilder.AppendFormat(", {0}", s));
                    stringBuilder.Remove(1, 2);
                }

                return stringBuilder.Append("]").ToString();
            }

            str = x as string;

            if (str != null) {
                return Quote(str);
            }

            if (R.@null.Equals(x)) {
                return "null";
            }

            if (!x.IsAnonymousType()) {
                var toStringMethod = (MethodInfo)x.TryGetMemberInfo("ToString");

                if (toStringMethod.IsOverriden(x.GetType())) {
                    return x.ToString();
                }
            }

            stringBuilder = new StringBuilder("{");
            str = string.Join(", ", (object[])mapPairs(x, x.Keys()));

            return stringBuilder.Append(str).Append("}").ToString();
        }

        private static object BothOrEither(DynamicDelegate f, DynamicDelegate g, Func<Func<bool>, Func<bool>, bool> operand, dynamic liftBy) {
            if (f.IsNotNull()) {
                return Delegate((object[] arguments) => operand(() => f.DynamicInvoke<bool>(arguments), () => g.DynamicInvoke<bool>(arguments)));
            }

            return Lift(liftBy)(f, g);
        }

        private static int IndexOfInternal(string indexOfName, object target, object xs, Func<IList, int> fromList, Func<string, string, int> fromString) {
            Delegate indexOf = null;
            string stringIndexOf = null;
            var list = xs as IList;

            if (list != null) {
                return fromList(list);
            }

            stringIndexOf = xs as string;

            if (stringIndexOf != null) {
                var targetAsString = target as string;

                if (targetAsString != null) {
                    return fromString(stringIndexOf, targetAsString);
                }

                return -1;
            }

            indexOf = xs.Member(indexOfName) as Delegate;

            if (indexOf.IsNotNull()) {
                return (int)indexOf.DynamicInvoke(new[] { target });
            }

            return -1;
        }

        private static string Quote(string s) {
            var escaped = s;

            escaped = Regex.Replace(escaped, @"\\", "\\\\");
            escaped = Regex.Replace(escaped, "[\b]", "\\b");
            escaped = Regex.Replace(escaped, "\f", "\\f");
            escaped = Regex.Replace(escaped, "\r", "\\r");
            escaped = Regex.Replace(escaped, "\t", "\\t");
            escaped = Regex.Replace(escaped, "\v", "\\v");
            escaped = Regex.Replace(escaped, "\0", "\\0");
            escaped = Regex.Replace(escaped, "\"", "\\\"");

            return $"\"{escaped}\"";
        }

        private static int AscendDescendInternal(dynamic firstOperator, dynamic secondOprator, dynamic fn, dynamic a, dynamic b) {
            DynamicDelegate dynamicDelegate = Delegate(fn);

            var aa = dynamicDelegate.DynamicInvoke<dynamic>(a);
            var bb = dynamicDelegate.DynamicInvoke<dynamic>(b);

            return firstOperator(aa, bb) ? -1 : secondOprator(aa, bb) ? 1 : 0;
        }

        private static DynamicDelegate InvokerInternal(int arity, string method, Func<object, int, DynamicDelegate> delegateFactory) {
            return CurryN(arity + 1, Delegate(arguments => {
                var target = arguments[arity];

                if (target.IsNotNull()) {
                    var @delegate = delegateFactory(target, arity);

                    if (@delegate.IsNotNull()) {
                        return @delegate.DynamicInvoke((object[])arguments.Slice(0, arity));
                    }
                }

                throw new MissingMethodException($"{nameof(target)} does not have a method named '{method}'");
            }));
        }
    }
}