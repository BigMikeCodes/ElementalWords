using ElementalWords;


    var periodicTable = new PeriodicTable([
        new("S", "Sulfur"),
        new("N", "Nitrogen"),
        new("Ac", "Actinium"),
        new("K", "Potassium"),
        new("Na","Sodium"),
        new("C", "Carbon"),
        new("Sn", "Tin")
    ]);

var paths = ElementalWords("snack");


List<Element[]> ElementalWords(string word)
{

    var trie = Trie.FromString(word, 3);
    var validPaths = new List<Element[]>();


    foreach(Node n in trie.Root.Nodes.Values){

        var route = new List<Node>();
        NavigateNode(n, route, validPaths);
    }

    return validPaths;
}


void NavigateNode(Node node, List<Node> route, List<Element[]> validPaths){
    route.Add(node);
    
    if(!periodicTable.HasElement(node.Prefix)){
        // prefix is not an element, bail out as what ever follows can never create an elemental word!
        return;
    }


    if(node.IsLeaf){
        // reached a leaf, reached the end. Must be a valid combo
        var path = route.Select(n => periodicTable.GetElement(n.Prefix)).ToArray();
        validPaths.Add(path);

    }
    else{

        foreach(Node n in node.Nodes.Values){
            NavigateNode(n, route, validPaths);
            route.RemoveAt(route.Count -1);
        }

    }

}
