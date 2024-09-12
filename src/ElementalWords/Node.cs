namespace ElementalWords
{
    public class Node
    {

        public string Prefix { get; set; } = string.Empty;
        public IDictionary<string, Node> Nodes { get; set; } = new Dictionary<string, Node>();

       
        public void AddChild(Node node)
        {
            Nodes.Add(node.Prefix, node);
        }

    }
}
