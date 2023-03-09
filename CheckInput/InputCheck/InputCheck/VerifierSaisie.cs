using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputCheck
{
    public static class VerifierSaisie
    {
        /// <summary>
        /// return false if string contain not alphabetical value or more than 30 chars
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool TextBoxNomMax30CHARAndOnlyAlphabetique(string str) => MatchFor(str, "^[A-zÀ-ú]{1,30}$");

        /// <summary>
        /// return false if string does not contain *digit dot 2digits
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool TextBoxMontantDigitDotMaxTwoDigit(string str) => MatchFor(str, "^[\\d]*([.]([0-9]{2}))?$");

        /// <summary>
        /// return false if string isn't 5 digits
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool TextBoxCodePostaleMax5Digit(string str) => MatchFor(str, "^[\\d]{5}$");

        private static bool MatchFor(string str, string regexPath)
        {
            return Regex.Match(str, regexPath).Success;
        }

        public static bool TextBoxDateTimeControleValidDateFromFormatProvider(string toControl)
        {
            DateTime dateTime ;
            bool rt = DateTime.TryParseExact(toControl,"dd/MM/yyyy",CultureInfo.CurrentCulture,DateTimeStyles.None,out dateTime);
            return rt && dateTime >= DateTime.Now;
        }

    }
}
