using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesWellsLDCStringExercise
{
    interface IStringTransformer
    {
        List<string> TransformStrings(List<string> stringsToTransform);
    }
}
