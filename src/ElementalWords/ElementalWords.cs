namespace ElementalWords
{
    public class ElementalWords
    {

        private readonly PeriodicTable _periodicTable;


        public ElementalWords(PeriodicTable periodicTable)
        {
            _periodicTable = periodicTable;
        }


        public string[][] ElementalForms(string word)
        {
            var trie = Trie.FromString(word, 3);

            var validPaths = new List<string[]>();


            foreach (Node n in trie.Root.Nodes)
            {
                var route = new List<Node>();
                NavigateNode(n, route, validPaths);
            }

            return validPaths.ToArray();

        }

        void NavigateNode(Node node, List<Node> route, List<string[]> validPaths)
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
                var path = route
                    .Select(node => _periodicTable.GetElement(node.Prefix))
                    .Select(element => element.ToString())
                    .ToArray();

                validPaths.Add(path);

            }
            else
            {

                foreach (Node n in node.Nodes)
                {
                    NavigateNode(n, route, validPaths);
                    route.RemoveAt(route.Count - 1);
                }

            }

        }


    }
}
