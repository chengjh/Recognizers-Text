﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.French;

namespace Microsoft.Recognizers.Text.DateTime.French
{
    public class FrenchHolidayExtractorConfiguration : IHolidayExtractorConfiguration
    {
        public static readonly Regex YearRegex = 
            new Regex(
                DateTimeDefinitions.YearRegex,
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

        public static readonly Regex H1 =
            new Regex(
                DateTimeDefinitions.HolidayRegex1,
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

        public static readonly Regex H2 =
            new Regex(
                DateTimeDefinitions.HolidayRegex2,
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

        public static readonly Regex H3 =
            new Regex(
                DateTimeDefinitions.HolidayRegex3,
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

        // added to include more options, "fete des meres" mothers day, etc
        public static readonly Regex H4 =
            new Regex(
                DateTimeDefinitions.HolidayRegex4,
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

        public static readonly Regex[] HolidayRegexList =
        {
            H1,
            H2,
            H3,
            H4
        };

        public IEnumerable<Regex> HolidayRegexes => HolidayRegexList;
    }
}
