using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JamesWellsLDCStringExercise
{
    public class StringTransformer : IStringTransformer
    {
        private const string Usd = "$";
        private const string Gbp = "£";
        private const string RemovePattern = @"_|4";
        private const string ContiguousPattern = "(.)\\1+";
        private const string DeduplicatedPattern = "$1";
        private const string InvalidStringMessage = "Invalid String";

        public List<string> TransformStrings(List<string> stringsToTransform)
        {
            var reformedStrings = new List<string>();
            reformedStrings.AddRange(stringsToTransform.Select(stringValue => ApplyTransformations(stringValue)));
            return reformedStrings;
        }

        private string ApplyTransformations(string stringToTransform)
        {
            if (string.IsNullOrEmpty(stringToTransform))
            {
                return InvalidStringMessage;
            }
            stringToTransform = ReplaceCharsExercisePattern(stringToTransform);
            stringToTransform = RemoveCharsExercisePattern(stringToTransform);
            stringToTransform = Truncate(stringToTransform, 15);
            if (stringToTransform.Length == 0) {
                return InvalidStringMessage;
            }
            return stringToTransform;
        }

        private string ReplaceCharsExercisePattern(string stringToTransform)
        {
            var replacedString = stringToTransform.Replace(Usd, Gbp);
            return replacedString;
        }

        private string RemoveCharsExercisePattern(string stringToTransform)
        {
            var removedCharString = Regex.Replace(stringToTransform, RemovePattern, "");
            var deDuplicatedString = Regex.Replace(removedCharString, ContiguousPattern, DeduplicatedPattern);
            return deDuplicatedString;
        }

        private string Truncate(string value, int maxLength)
        {
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
