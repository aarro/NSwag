﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace NSwagStudio.Converters
{
    public class StringArrayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null ? string.Join(",", (string[])value) : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToString()
                .Split(',')
                .Select(s => s.Trim())
                .Where(n => !string.IsNullOrEmpty(n))
                .ToArray() ?? new string[] { };
        }
    }
}