namespace ElementalWords
{
    public class Trie
    {

        public readonly Node _root;

        private Trie(Node node) 
        {
            _root = node;
        }



        private static Node ToNode(char[] chars, int start, int stride, int maxStride)
        {

            var range = new Range(start, start + stride);
            var taken = chars.Take(range);
            var prefix = string.Join(string.Empty, taken);

            var node = new Node { Prefix = prefix };

            var i = 1;
            while (
                (start + i + (stride -1)) < chars.Length && 
                (i <= maxStride))
            {
                var childNode = ToNode(chars, start + stride, i, maxStride);
                node.AddChild(childNode);
                i++;
            }

            return node;

        }


        public static Trie FromString(string value, int maxStride)
        {

            var rootNode = new Node();
            var valueArray = value.ToArray();

            //todo make this doesnt fail for 2 letter strinfs when max stride is 3
            for (var i=1; i<= maxStride; i++) {
                
                var childNode = ToNode(valueArray, 0, i, maxStride);
                rootNode.AddChild(childNode);

            }

            return new Trie(rootNode);

        }


    }
}
