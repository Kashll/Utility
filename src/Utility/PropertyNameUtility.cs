using System;
using System.Linq.Expressions;

namespace Utility
{
    public static class PropertyNameUtility
    {
        /// <summary>
        /// Uses reflection to get the name of the property for the given expression
        /// </summary>
        public static string GetPropertyName<TProperty>(Expression<Func<TProperty>> propertyExpression)
        {
            MemberExpression memberExpression = propertyExpression.Body as MemberExpression;
            if (memberExpression != null)
                return memberExpression.Member.Name;

            throw new InvalidOperationException("Couldn't get property name for {0}".FormatInvariant(propertyExpression));
        }
    }
}
