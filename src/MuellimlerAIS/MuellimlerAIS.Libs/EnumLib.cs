using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MuellimlerAIS.Libs
{
    public class StringValueAttribute : Attribute
    {

        #region Properties

        /// <summary>
        /// Holds the stringvalue for a value in an enum.
        /// </summary>
        public string StringValue { get; protected set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor used to init a StringValue Attribute
        /// </summary>
        /// <param name="value"></param>
        public StringValueAttribute(string value)
        {
            this.StringValue = value;
        }

        #endregion

    }

    public class EnumListItem<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }

    public static class EnumLib
    {
        public static string GetStringValue(this Enum value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // Get the stringvalue attributes
            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];

            // Return the first if there was a match.
            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }

        public static string GetStringValue<T>(this T value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // Get the stringvalue attributes
            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];

            // Return the first if there was a match.
            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }

        public static String[] GetEnumNames<T>(this Enum t) where T : struct
        {
            if (!typeof(T).IsEnum) return null;
            Array enumValueArray = Enum.GetValues(typeof(T));

            string[] enumStrings = new String[enumValueArray.Length];
            for (int i = 0; i < enumValueArray.Length; ++i)
            {
                enumStrings[i] = GetStringValue((Enum)enumValueArray.GetValue(i));
            }

            return enumStrings;
        }

        public static List<EnumListItem<T>> GetEnumList<T>() where T : struct
        {
            if (!typeof(T).IsEnum) return null;
            Array enumValueArray = Enum.GetValues(typeof(T));
            List<EnumListItem<T>> list = new List<EnumListItem<T>>();
            for (int i = 0; i < enumValueArray.Length; ++i)
            {
                list.Add(new EnumListItem<T>() { Name = GetStringValue((Enum)enumValueArray.GetValue(i)), Value = (T)enumValueArray.GetValue(i) });
            }
            return list;
        }
    }
}
