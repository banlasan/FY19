using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FY19.Models.CustomValidations
{
    public class StringLengthValidation : StringLengthAttribute
    {
        public StringLengthValidation(int maximumLength) : base(maximumLength)
        {
    
        }

        public override bool IsValid(object value)
        {
            var strip = StripHTML(value.ToString());
           
            var count = strip.Length;
       
            return count <= MaximumLength;
        }

        public static string StripHTML(string input)
        {
            return Regex.Replace(input, @"<[^>]+>|&nbsp;", "").Trim();
        }
       
    }
}