namespace ElementalWords
{
    public class Node
    {

        public string Prefix { get; set; } = string.Empty;
        public List<Node> Nodes { get; set; } = new List<Node>();

        // No children == leaf node at the bottom of the trie
        public bool IsLeaf => Nodes.Count == 0;
       
        public void AddChild(Node node)
        {
            Nodes.Add(node);
        }

        public override string ToString()
        {

            var nodesString = string.Join(", ", Nodes.Select(n => n.Prefix));
            return $"[ Prefix = {Prefix}, Nodes = [{nodesString}] ]";
        }

    }
}
