using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Common.Models
{
    public sealed class Language
    {
        private string name;
        private string cultureCode;
        private CultureInfo cultureInfo;

        public string Name { get => name; set => name = value; }
        public string CultureCode { get => cultureCode; set => cultureCode = value; }
        public CultureInfo CultureInfo { get => cultureInfo; set => cultureInfo = value; }

        public Language()
        {

        }
    }
}
