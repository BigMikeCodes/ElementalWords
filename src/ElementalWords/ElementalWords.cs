namespace ElementalWords
{
    public class ElementalWords
    {

        private readonly PeriodicTable _periodicTable;


        public ElementalWords(PeriodicTable periodicTable)
        {
            _periodicTable = periodicTable;
        }


        public IEnumerable<Element[]> ElementalForms(string word)
        {
            var trie = Trie.FromString(word, 3);

            var validPaths = new List<Element[]>();


            foreach (Node n in trie.Root.Nodes.Values)
            {

                var route = new List<Node>();
                NavigateNode(n, route, validPaths);
            }

            return validPaths;

        }

        void NavigateNode(Node node, List<Node> route, List<Element[]> validPaths)
        {
            route.Add(node);

            if (!_periodicTable.HasElement(node.Prefix))
            {
                // prefix is not an element, bail out as what ever follows can never create an elemental word!
                return;
            }


            if (node.IsLeaf)
            {
                // reached a leaf, reached the end. Must be a valid combo
                var path = route.Select(n => _periodicTable.GetElement(n.Prefix)).ToArray();
                validPaths.Add(path);

            }
            else
            {

                foreach (Node n in node.Nodes.Values)
                {
                    NavigateNode(n, route, validPaths);
                    route.RemoveAt(route.Count - 1);
                }

            }

        }


    }
}
