// Operadores lógicos e condicionais > < = == >= <=
int quantidadeEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantiadde em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantiadde compra: {quantidadeCompra}");
Console.WriteLine($"É possível realziar a venda? {possivelVenda}");

if (possivelVenda){
    Console.WriteLine("Venda realizada.");
}
else if (quantidadeCompra == 0){
    System.Console.WriteLine("Venda inválida");
}
else{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
}

// If vs Switch Case, verificar se é uma vogal ou não
string letra = "a";

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u"){
        System.Console.WriteLine("É uma vogal");
}else{
    System.Console.WriteLine("Não é vogal");
}

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        System.Console.WriteLine("Vogal");
    break;
    
    default:
        System.Console.WriteLine("Não é vogal");
    break;    
}