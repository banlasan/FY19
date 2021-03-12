using System;
using System.Reflection;
using System.Linq.Expressions;


namespace FY19.Helpers
{
    public static class Property
    {
        public static String nameof<T, TT>(this T obj, Expression<Func<T, TT>> propertyAccessor)
        {
            if (propertyAccessor.Body.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpression = propertyAccessor.Body as MemberExpression;
                if (memberExpression == null)
                    return null;
                return memberExpression.Member.Name;
            }
            return null;
        }

        //public static void GetProperty<T>(Expression<Func<T>> property)
        //{
        //    var expression = GetMemberInfo(property);
        //    string path = string.Concat(expression.DeclaringType.FullName,
        //        ".", expression.Name);


        //}

        //private static MemberInfo GetMemberInfo(this Expression expression)
        //{
        //    var lambda = (LambdaExpression)expression;

        //    MemberExpression memberExpression;
        //    if (lambda.Body is UnaryExpression)
        //    {
        //        var unaryExpression = (UnaryExpression)lambda.Body;
        //        memberExpression = (MemberExpression)unaryExpression.Operand;
        //    }
        //    else
        //        memberExpression = (MemberExpression)lambda.Body;

        //    return memberExpression.Member;
        //}
    }
}