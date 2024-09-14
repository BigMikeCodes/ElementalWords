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

var elementalWords = new ElementalWords.ElementalWords(periodicTable);
var result = elementalWords.ElementalForms("snack");