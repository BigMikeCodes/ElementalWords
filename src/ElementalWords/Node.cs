namespace ElementalWords
{
    public class Node
    {

        public string Prefix { get; set; } = string.Empty;
        public IDictionary<string, Node> Nodes { get; set; } = new Dictionary<string, Node>();

        // No children == leaf node at the bottom of the trie
        public bool IsLeaf => !Nodes.Any();
       
        public void AddChild(Node node)
        {
            Nodes.Add(node.Prefix, node);
        }

        public override string ToString()
        {

            var nodesString = string.Join(", ", Nodes.Values.Select(n => n.Prefix));
            return $"[ Prefix = {Prefix}, Nodes = [{nodesString}] ]";
        }

    }
}
