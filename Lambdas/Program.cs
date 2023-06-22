//
var expressionLambda = (string firstName, string lastName) => $"{firstName} {lastName}";
Console.WriteLine(expressionLambda("Soheil", "Fattahieh"));

//
var statementLambda = (string firstName, string lastName) =>
{
    var fullName2 = expressionLambda(firstName, lastName);
    var fullName = $"{firstName} {lastName}";
    return fullName + " " + fullName2;
};
Console.WriteLine(statementLambda("Soheil", "Fattahieh"));


//
string ClassicF(string firstName, string lastName)
{
    var fullName = $"{firstName} {lastName}";
    return fullName;
}
Console.WriteLine(ClassicF("Soheil", "Fattahieh"));
