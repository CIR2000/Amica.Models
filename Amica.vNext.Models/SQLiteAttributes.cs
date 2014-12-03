using System;

// PLEASE NOTE
//
// This is only needed for .NET Framework 3.5 and 4.0 compatibility.
// Project needs to be compiled with VS2012+.
//
// If you want to target .NET 4.5+ then you might choose to exclude this file
// (if you don't you will only get a few duplicate definition warnings and no compile errors).

// ReSharper disable once CheckNamespace
namespace SQLite.Net.Attributes
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class AutoIncrementAttribute : Attribute { }

    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class CollationAttribute : Attribute
    {
        public string Value { get; private set; }

        public CollationAttribute(string collation)
        {
            Value = collation;
        }
    }

    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string Name { get; set; }

        public ColumnAttribute(string name)
        {
            Name = name;
        }
    }

    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class IgnoreAttribute : Attribute { }

    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class IndexedAttribute : Attribute
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public virtual bool Unique { get; set; }

        public IndexedAttribute()
        {
        }

        public IndexedAttribute(string name, int order)
        {
            Name = name;
            Order = order;
        }
    }

    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class MaxLengthAttribute : Attribute
    {
        public int Value { get; private set; }

        public MaxLengthAttribute(int length)
        {
            Value = length;
        }
    }

    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class NotNullAttribute : Attribute { }

    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : Attribute { }

    [AttributeUsageAttribute(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string Name { get; set; }

        public TableAttribute(string name)
        {
            Name = name;
        }
    }

    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class UniqueAttribute : IndexedAttribute
    {
        public override bool Unique
        {
            get { return true; }
            set { }
        }
    }

}