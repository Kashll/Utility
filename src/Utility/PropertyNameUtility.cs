﻿using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Utility
{
	public static class PropertyNameUtility
	{
		/// <summary>
		/// Uses reflection to get the name of the property for the given expression
		/// </summary>
		public static string GetPropertyName<T, TProperty>(Expression<Func<T, TProperty>> propertyExpression)
		{
			MemberExpression memberExpression = propertyExpression.Body as MemberExpression;
			if (memberExpression != null)
				return memberExpression.Member.Name;

			throw new InvalidOperationException("Couldn't get property name for {0}".FormatInvariant(propertyExpression));
		}

		public static bool HasChanged(this PropertyChangedEventArgs e, string propertyName)
		{
			return e.PropertyName.IsNullOrEmpty() || e.PropertyName == propertyName;
		}
	}
}
