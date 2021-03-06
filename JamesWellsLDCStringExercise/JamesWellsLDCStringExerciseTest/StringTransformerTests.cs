using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JamesWellsLDCStringExercise;

namespace JamesWellsLDCStringExerciseTest
{
    [TestClass]
    public class StringTransformerTests
    {
        StringTransformer transformerClass = new StringTransformer();
        List<string> testCollection;

        [TestInitialize]
        public void TestInitialize()
        {
            testCollection = new List<string>();
        }

        [TestMethod]
        public void ShouldTruncateString()
        {
            testCollection.Add("abvugskcuvekjnbdyhlmsbdytcnmidhaskdjh");
            Assert.AreEqual(15, transformerClass.TransformStrings(testCollection)[0].Length);
        }

        [TestMethod]
        public void ShouldRemoveKeyCharacters()
        {
            testCollection.Add("a_b4c");
            Assert.AreEqual("abc", transformerClass.TransformStrings(testCollection)[0]);
        }

        [TestMethod]
        public void ShouldReplaceCharecters()
        {
            testCollection.Add("$21");
            Assert.AreEqual("£21", transformerClass.TransformStrings(testCollection)[0]);
        }

        [TestMethod]
        public void ShouldRemoveContiguousCharacters()
        {
            testCollection.Add("abccccdeffff");
            Assert.AreEqual("abcdef", transformerClass.TransformStrings(testCollection)[0]);
        }


        [TestMethod]
        public void ShouldTransformMultipleStrings()
        {
            testCollection.Add("AAAc91%cWwWkLq$1ci3_848v3d__K");
            testCollection.Add("jnsdf__bfb$4bdbbbafobn73");
            Assert.AreEqual("Ac91%cWwWkLq£1c", transformerClass.TransformStrings(testCollection)[0]);
            Assert.AreEqual("jnsdfbfb£bdbafo", transformerClass.TransformStrings(testCollection)[1]);
        }

        [TestMethod]
        public void ShouldHandleNullAndEmptyInputStrings()
        {
            testCollection.Add("");
            testCollection.Add(null);
            Assert.AreEqual("Invalid String", transformerClass.TransformStrings(testCollection)[0]);
            Assert.AreEqual("Invalid String", transformerClass.TransformStrings(testCollection)[1]);
        }

        [TestMethod]
        public void ShouldHandleEmptyOutputStrings()
        {
            testCollection.Add("_____");
            Assert.AreEqual("Invalid String", transformerClass.TransformStrings(testCollection)[0]);
        }
    }
}
