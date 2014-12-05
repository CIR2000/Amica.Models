using System;

// PLEASE NOTE
//
// This is only needed for 4.0 compatibility.
// Project needs to be compiled with VS2012+.
//
// .NET4 prjects don't need and don't use these
// attributes. However we want a single, shared
// codebase for both NET4 and NET45+ projects so
// in order for the project to compile without
// errors on NET4 we include these fakes.
//
// THe .NET45 Models project does not include this
// file since it references the proper SQLite PCL
// package which provides these attributes.

// ReSharper disable once CheckNamespace
namespace SQLite.Net.Attributes
{
	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class AutoIncrementAttribute : Attribute
	{

	}

	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class CollationAttribute : Attribute
	{
		public string Value { get; private set; }

		public CollationAttribute (string collation)
		{
			Value = collation;
		}
	}

	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class ColumnAttribute : Attribute
	{
		public string Name { get; set; }

		public ColumnAttribute (string name)
		{
			Name = name;
		}
	}

	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class IgnoreAttribute : Attribute
	{

	}

	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class IndexedAttribute : Attribute
	{
		public string Name { get; set; }

		public int Order { get; set; }

		public virtual bool Unique { get; set; }

		public IndexedAttribute ()
		{
		}

		public IndexedAttribute (string name, int order)
		{
			Name = name;
			Order = order;
		}
	}

	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class MaxLengthAttribute : Attribute
	{
		public int Value { get; private set; }

		public MaxLengthAttribute (int length)
		{
			Value = length;
		}
	}

	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class NotNullAttribute : Attribute
	{

	}

	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class PrimaryKeyAttribute : Attribute
	{

	}

	[AttributeUsageAttribute (AttributeTargets.Class)]
	public class TableAttribute : Attribute
	{
		public string Name { get; set; }

		public TableAttribute (string name)
		{
			Name = name;
		}
	}

	[AttributeUsageAttribute (AttributeTargets.Property)]
	public class UniqueAttribute : IndexedAttribute
	{
		public override bool Unique {
			get { return true; }
			set { }
		}
	}

}