﻿using System;
using System.Globalization;
using System.Windows.Data;
using PlaystationApp.Core.Entity;
using PlaystationApp.Resources;

namespace PlaystationApp.Tools
{
    public class TrophyStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var item = value as TrophyDetailEntity.Trophy;
            if (item == null) return AppResources.TrophyNotEarned;
            if (item.ComparedUser != null)
            {
                return item.ComparedUser.Earned ? AppResources.TrophyEarned : AppResources.TrophyNotEarned;
            }
            if (item.FromUser != null)
            {
                return item.FromUser.Earned ? AppResources.TrophyEarned : AppResources.TrophyNotEarned;
            }
            return AppResources.TrophyNotEarned;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}