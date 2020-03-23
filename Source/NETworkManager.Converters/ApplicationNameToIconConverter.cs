﻿using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using NETworkManager.Models;

namespace NETworkManager.Converters
{
    /// <summary>
    /// Converter to convert/resolve <see cref="Application.Name"/> to icon (<see cref="Canvas"/>) or wise versa.
    /// </summary>
    public sealed class ApplicationNameToIconConverter : IValueConverter
    {
        /// <summary>
        /// Method to convert/resolve <see cref="Application.Name"/> to icon (<see cref="Canvas"/>).
        /// </summary>
        /// <param name="value">Object from type <see cref="Application.Name"/>.</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>Icon (cref="Canvas"/>).</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Models.Application.Name name))
                return null;

            return Application.GetIcon(name);
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