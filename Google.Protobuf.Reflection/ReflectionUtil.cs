using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal static class ReflectionUtil
	{
		internal static readonly Type[] EmptyTypes = new Type[0];

		internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
		{
			ParameterExpression parameterExpression = ReflectionUtil.smethod_1(ReflectionUtil.smethod_0(typeof(IMessage).TypeHandle), Module.smethod_33<string>(2807358026u));
			return Expression.Lambda<Func<IMessage, object>>(ReflectionUtil.smethod_3(ReflectionUtil.smethod_4(ReflectionUtil.smethod_3(parameterExpression, ReflectionUtil.smethod_2(method)), method), ReflectionUtil.smethod_0(typeof(object).TypeHandle)), new ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		internal static Func<IMessage, T> CreateFuncIMessageT<T>(MethodInfo method)
		{
			ParameterExpression parameterExpression = ReflectionUtil.smethod_1(ReflectionUtil.smethod_0(typeof(IMessage).TypeHandle), Module.smethod_33<string>(2807358026u));
			return Expression.Lambda<Func<IMessage, T>>(ReflectionUtil.smethod_3(ReflectionUtil.smethod_4(ReflectionUtil.smethod_3(parameterExpression, ReflectionUtil.smethod_2(method)), method), ReflectionUtil.smethod_0(typeof(T).TypeHandle)), new ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
		{
			ParameterExpression parameterExpression = ReflectionUtil.smethod_1(ReflectionUtil.smethod_0(typeof(IMessage).TypeHandle), Module.smethod_33<string>(1235206692u));
			ParameterExpression parameterExpression2 = ReflectionUtil.smethod_1(ReflectionUtil.smethod_0(typeof(object).TypeHandle), Module.smethod_33<string>(1561157727u));
			Expression arg_63_0 = ReflectionUtil.smethod_3(parameterExpression, ReflectionUtil.smethod_2(method));
			Expression expression = ReflectionUtil.smethod_3(parameterExpression2, ReflectionUtil.smethod_6(ReflectionUtil.smethod_5(method)[0]));
			return Expression.Lambda<Action<IMessage, object>>(ReflectionUtil.smethod_7(arg_63_0, method, new Expression[]
			{
				expression
			}), new ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}

		internal static Action<IMessage> CreateActionIMessage(MethodInfo method)
		{
			ParameterExpression parameterExpression = ReflectionUtil.smethod_1(ReflectionUtil.smethod_0(typeof(IMessage).TypeHandle), Module.smethod_34<string>(1303736968u));
			return Expression.Lambda<Action<IMessage>>(ReflectionUtil.smethod_4(ReflectionUtil.smethod_3(parameterExpression, ReflectionUtil.smethod_2(method)), method), new ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static ParameterExpression smethod_1(Type type_0, string string_0)
		{
			return Expression.Parameter(type_0, string_0);
		}

		static Type smethod_2(MemberInfo memberInfo_0)
		{
			return memberInfo_0.DeclaringType;
		}

		static UnaryExpression smethod_3(Expression expression_0, Type type_0)
		{
			return Expression.Convert(expression_0, type_0);
		}

		static MethodCallExpression smethod_4(Expression expression_0, MethodInfo methodInfo_0)
		{
			return Expression.Call(expression_0, methodInfo_0);
		}

		static ParameterInfo[] smethod_5(MethodBase methodBase_0)
		{
			return methodBase_0.GetParameters();
		}

		static Type smethod_6(ParameterInfo parameterInfo_0)
		{
			return parameterInfo_0.ParameterType;
		}

		static MethodCallExpression smethod_7(Expression expression_0, MethodInfo methodInfo_0, Expression[] expression_1)
		{
			return Expression.Call(expression_0, methodInfo_0, expression_1);
		}
	}
}
