namespace ElementalWords
{
    public class PeriodicTable
    {

        // Exported from https://gist.github.com/GoodmanSciences/c2dd862cd38f21b0ad36b8f96b4bf1ee
        private readonly Element[] Elements = {
            new("H", "Hydrogen"),
            new("He", "Helium"),
            new("Li", "Lithium"),
            new("Be", "Beryllium"),
            new("B", "Boron"),
            new("C", "Carbon"),
            new("N", "Nitrogen"),
            new("O", "Oxygen"),
            new("F", "Fluorine"),
            new("Ne", "Neon"),
            new("Na", "Sodium"),
            new("Mg", "Magnesium"),
            new("Al", "Aluminum"),
            new("Si", "Silicon"),
            new("P", "Phosphorus"),
            new("S", "Sulfur"),
            new("Cl", "Chlorine"),
            new("Ar", "Argon"),
            new("K", "Potassium"),
            new("Ca", "Calcium"),
            new("Sc", "Scandium"),
            new("Ti", "Titanium"),
            new("V", "Vanadium"),
            new("Cr", "Chromium"),
            new("Mn", "Manganese"),
            new("Fe", "Iron"),
            new("Co", "Cobalt"),
            new("Ni", "Nickel"),
            new("Cu", "Copper"),
            new("Zn", "Zinc"),
            new("Ga", "Gallium"),
            new("Ge", "Germanium"),
            new("As", "Arsenic"),
            new("Se", "Selenium"),
            new("Br", "Bromine"),
            new("Kr", "Krypton"),
            new("Rb", "Rubidium"),
            new("Sr", "Strontium"),
            new("Y", "Yttrium"),
            new("Zr", "Zirconium"),
            new("Nb", "Niobium"),
            new("Mo", "Molybdenum"),
            new("Tc", "Technetium"),
            new("Ru", "Ruthenium"),
            new("Rh", "Rhodium"),
            new("Pd", "Palladium"),
            new("Ag", "Silver"),
            new("Cd", "Cadmium"),
            new("In", "Indium"),
            new("Sn", "Tin"),
            new("Sb", "Antimony"),
            new("Te", "Tellurium"),
            new("I", "Iodine"),
            new("Xe", "Xenon"),
            new("Cs", "Cesium"),
            new("Ba", "Barium"),
            new("La", "Lanthanum"),
            new("Ce", "Cerium"),
            new("Pr", "Praseodymium"),
            new("Nd", "Neodymium"),
            new("Pm", "Promethium"),
            new("Sm", "Samarium"),
            new("Eu", "Europium"),
            new("Gd", "Gadolinium"),
            new("Tb", "Terbium"),
            new("Dy", "Dysprosium"),
            new("Ho", "Holmium"),
            new("Er", "Erbium"),
            new("Tm", "Thulium"),
            new("Yb", "Ytterbium"),
            new("Lu", "Lutetium"),
            new("Hf", "Hafnium"),
            new("Ta", "Tantalum"),
            new("W", "Wolfram"),
            new("Re", "Rhenium"),
            new("Os", "Osmium"),
            new("Ir", "Iridium"),
            new("Pt", "Platinum"),
            new("Au", "Gold"),
            new("Hg", "Mercury"),
            new("Tl", "Thallium"),
            new("Pb", "Lead"),
            new("Bi", "Bismuth"),
            new("Po", "Polonium"),
            new("At", "Astatine"),
            new("Rn", "Radon"),
            new("Fr", "Francium"),
            new("Ra", "Radium"),
            new("Ac", "Actinium"),
            new("Th", "Thorium"),
            new("Pa", "Protactinium"),
            new("U", "Uranium"),
            new("Np", "Neptunium"),
            new("Pu", "Plutonium"),
            new("Am", "Americium"),
            new("Cm", "Curium"),
            new("Bk", "Berkelium"),
            new("Cf", "Californium"),
            new("Es", "Einsteinium"),
            new("Fm", "Fermium"),
            new("Md", "Mendelevium"),
            new("No", "Nobelium"),
            new("Lr", "Lawrencium"),
            new("Rf", "Rutherfordium"),
            new("Db", "Dubnium"),
            new("Sg", "Seaborgium"),
            new("Bh", "Bohrium"),
            new("Hs", "Hassium"),
            new("Mt", "Meitnerium"),
            new("Ds", "Darmstadtium"),
            new("Rg", "Roentgenium "),
            new("Cn", "Copernicium "),
            new("Nh", "Nihonium"),
            new("Fl", "Flerovium"),
            new("Mc", "Moscovium"),
            new("Lv", "Livermorium"),
            new("Ts", "Tennessine"),
            new("Og", "Oganesson")
        };


        /// <summary>
        /// Key -> element symbol
        /// Value -> instance of Element
        /// </summary>
        private readonly Dictionary<string, Element> _table;

        public PeriodicTable()
        {

            _table = new Dictionary<string, Element>(StringComparer.InvariantCultureIgnoreCase);
            foreach (var element in Elements) { 
           
                _table.TryAdd(element.Symbol, element);
            }

        }

        public Element GetElement(string symbol)
        {
            return _table[symbol];
        }

        public bool HasElement(string symbol) { 
            return _table.ContainsKey(symbol); 
        }

    }
}
