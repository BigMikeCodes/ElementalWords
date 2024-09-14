namespace ElementalWords.Test
{
    [TestFixture]
    public class ElementalWordsTests
    {


        [Test]
        public void SimpleCases()
        {

            var periodicTable = new PeriodicTable();
            var elementalWords = new ElementalWords(periodicTable);

            // Testcases from kata task definiton
            var cases = new[] {
                ("", new string[0][]),
                ("Yes", new[] { new[] {"Yttrium (Y)", "Einsteinium (Es)"} }),
                ("beach", new[] { new[] {"Beryllium (Be)", "Actinium (Ac)", "Hydrogen (H)"} }),
                ("snack", new[] {
                    new[] {"Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"},
                    new[] {"Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"},
                    new[] {"Tin (Sn)", "Actinium (Ac)", "Potassium (K)"}
                }),
                ("SNACK", new[] {
                    new[] {"Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"},
                    new[] {"Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"},
                    new[] {"Tin (Sn)", "Actinium (Ac)", "Potassium (K)"}
                }),
                ("SNACK", new[] {
                    new[] {"Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"},
                    new[] {"Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"},
                    new[] {"Tin (Sn)", "Actinium (Ac)", "Potassium (K)"}
                }),
                ("S", new[]
                {
                    new[] { "Sulfur (S)" }
                }),
                ("Fluuter", new[]
                {
                    new[] { "Flerovium (Fl)", "Nihonium (Uut)", "Erbium (Er)" }
                }),
                ("Uuo", new []
                {
                    new [] { "Uranium (U)", "Uranium (U)", "Oxygen (O)" },
                    new [] { "Oganesson (Uuo)" }
                })
            };

            foreach (var (word, expected) in cases)
            {
                var actual = elementalWords.ElementalForms(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }

    }
}
