using System;
using System.Collections.Generic;

namespace JamesWellsLDCStringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldStrings = new List<string>();
            StringTransformer transformer = new StringTransformer();
            oldStrings.Add("AAAc91%cWwWkLq$1ci3_848v3d__K");
            oldStrings.Add("aaaA4$_jhsdfjnfvmiuegerngneriugneg");

            var reformedStrings = transformer.TransformStrings(oldStrings);
            foreach (string reformedValue in reformedStrings)
            {
                Console.WriteLine(reformedValue);
            }

        }
    }
}
