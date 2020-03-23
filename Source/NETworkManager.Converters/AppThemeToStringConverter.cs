﻿using MahApps.Metro;
using System;
using System.Globalization;
using System.Windows.Data;
using NETworkManager.Localization;

namespace NETworkManager.Converters
{
    /// <summary>
    /// Converter to convert <see cref="AppTheme"/> to translated <see cref="string"/> or wise versa.
    /// </summary>
    public sealed class AppThemeToStringConverter : IValueConverter
    {
        /// <summary>
        /// Method to convert <see cref="AppTheme"/> to translated <see cref="string"/>. 
        /// </summary>
        /// <param name="value">Object from type <see cref="AppTheme"/>.</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>Translated <see cref="AppTheme"/>.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is AppTheme theme))
                return "No valid theme passed!";

            var name = Localization.LanguageFiles.Strings.ResourceManager.GetString(theme.Name, LocalizationManager.GetInstance().Culture);

            if (string.IsNullOrEmpty(name))
                name = theme.Name;

            return name;
        }

        /// <summary>
        /// !!! Method not implemented !!!
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}