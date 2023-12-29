using System.ComponentModel;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 2;
arrayInteiros[2] = 7;

for (int i = 0; i<arrayInteiros.Length; i++){
    System.Console.WriteLine($"Posição nº {i}: {arrayInteiros[i]}");
}

foreach(int valor in arrayInteiros){
    System.Console.WriteLine(valor);
}

int[] arrayInteirosDobrado = new int[arrayInteiros.Length*2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);

// Listas

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("PE");
listaString.Add("JP");

for(int contador = 0; contador < listaString.Count; contador++){
    System.Console.WriteLine($"Posição nº{contador} - {listaString[contador]}");
}

foreach (string item in listaString){
    System.Console.WriteLine(item);
}

System.Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("SC");

System.Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Remove("SP");

System.Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
