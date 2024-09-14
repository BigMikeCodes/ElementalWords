namespace ElementalWords
{
    public class Trie
    {

        public required Node Root { get; init; }


        private static Node ToNode(char[] chars, int start, int stride, int maxStride)
        {

            var range = new Range(start, start + stride);
            var taken = chars.Take(range);
            var prefix = string.Join(string.Empty, taken);

            var node = new Node { Prefix = prefix };

            var i = 1;
            while (// Dont go beyound the end of the array AND dont exceed the max stride
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

            // Handle anything that may be shorter than maxStride
            var stride = 1;
            while (stride <= valueArray.Length && stride <= maxStride)
            {
                var childNode = ToNode(valueArray, 0, stride, maxStride);
                rootNode.AddChild(childNode);
                stride++;
            }

            return new Trie{ Root = rootNode };

        }


    }
}
