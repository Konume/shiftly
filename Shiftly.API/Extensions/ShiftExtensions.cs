using System;

namespace Shiftly.API.Extensions
{
    public static class ShiftExtensions
    {
        public static string ToShiftTimeString(this (TimeSpan Start, TimeSpan End) shift)
        {
            return $"{shift.Start:hh\\:mm} - {shift.End:hh\\:mm}";
        }
    }
}