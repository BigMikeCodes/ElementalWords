

using ElementalWords;



ElementalWords("abc");

void ElementalWords(string word)
{

    var trie = Trie.FromString(word, 3);
    var periodicTable = new PeriodicTable([
        new("Fe", "Iron")
    ]);

    //todo - add traversal of the trie



}

