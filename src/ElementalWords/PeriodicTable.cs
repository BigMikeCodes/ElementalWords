namespace ElementalWords
{
    public class PeriodicTable
    {

        /// <summary>
        /// Key -> element symbol
        /// Value -> instance of Element
        /// </summary>
        private readonly Dictionary<string, Element> _table;

        public PeriodicTable(IEnumerable<Element> elements)
        {

            _table = new Dictionary<string, Element>(StringComparer.InvariantCultureIgnoreCase);
            foreach (var element in elements) { 
           
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
