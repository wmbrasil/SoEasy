using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoEasy
{
    public static class StringExtension
    {
        /// <summary>
        /// Return string between the StartString string and EndString string.
        /// </summary>
        /// <param name="StartString">The start string to search on string.</param>
        /// <param name="EndWith">The end string to search on string.</param>
        /// <returns>The string between StartString and EndString, if found, else, return string empty.</returns>
        public static string Between(this string text, string StartWith, string EndWith)
        {
            string between = string.Empty;
            try
            {
                if (text.IndexOf(StartWith, 0) >= 0)
                {
                    int iInicio = text.IndexOf(StartWith, 0) + StartWith.Length;
                    int iFim = text.IndexOf(EndWith, iInicio);
                    int iTamanho = iFim - iInicio;

                    try
                    {
                        between = text.Substring(iInicio, iTamanho);
                    }
                    catch
                    {
                        between = text.Substring(iInicio);
                    }
                }
            }
            catch
            {
                // Não encontrou o texto entre a busca
            }

            return between;
        }

        /// <summary>
        /// Return string between the StartString string and EndString string.
        /// </summary>
        /// <param name="StartString">The start string to search on string.</param>
        /// <param name="EndWith">The end string to search on string.</param>
        /// <param name="Trim">True to trim the string</param>
        /// <returns>The string between StartString and EndString, if found, else, return string empty, and trimmed if Trim is true.</returns>
        public static string Between(this string text, string StartWith, string EndWith, bool Trim)
        {
            return Trim ? text.Between(StartWith, EndWith).Trim() : text.Between(StartWith, EndWith);
        }
 
    }
}
