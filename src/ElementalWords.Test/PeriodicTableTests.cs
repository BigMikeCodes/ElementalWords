namespace ElementalWords.Test
{

    [TestFixture]
    public class PeriodicTableTests
    {


        [Test]
        [TestCase("FE")]
        [TestCase("Fe")]
        [TestCase("fE")]
        [TestCase("fe")]
        [Description("Assert that PeriodicTable.GetElement is case insensitive")]
        public void PeriodicTable_GetElement_Handles_Case_Correctly(string symbol)
        {
            var fe = new Element("Fe", "Iron");
            var table = new PeriodicTable();
            
            var result = table.GetElement(symbol);

            Assert.That(result, Is.Not.Null, "Result should not be null");
            Assert.That(result, Is.EqualTo(fe), "Result should equal Element fe");

        }

        [Test]
        public void PeriodicTable_HasElement_Returns_Null_When_Symbol_Not_In_Table()
        {

            // Empty table
            var table = new PeriodicTable();
            
            // element of suprise!
            var hasElement = table.HasElement("Suprise");

            Assert.That(hasElement, Is.False, "hasElement should be false");

        }



    }
}
