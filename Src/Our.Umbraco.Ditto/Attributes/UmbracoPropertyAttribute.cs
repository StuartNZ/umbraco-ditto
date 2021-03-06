﻿using System;

namespace Our.Umbraco.Ditto.Attributes
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public class UmbracoPropertyAttribute : Attribute
	{
		public string PropertyName { get; set; }

		public string AltPropertyName { get; set; }

		public bool Recursive { get; set; }

		public object DefaultValue { get; set; }

		public UmbracoPropertyAttribute(string propertyName,
			string altPropertyName = "",
			bool recursive = false,
			object defaultValue = null)
		{
			PropertyName = propertyName;
			AltPropertyName = altPropertyName;
			Recursive = recursive;
			DefaultValue = defaultValue;
		}
	}
}