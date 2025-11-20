// Os dicionários funcionam da mesma forma que as tabelas hash, 
// no entanto de uma maneira mais sofisticada
// é possível definir que tipol de dado será utilizado para armazenar tanto
//  a chave quanto o valor. 
// Diferentemente da tabebela hash, que utiliza-se apenas de string. 


// Criando um dicionário vazio

Dictionary<string, int> dic0 = new Dictionary<string, int>();

// Criando um dicionário com valores iniciais

Dictionary<string, int> dic = new Dictionary<string, int>()
{
    {"Chave 1", 100},
    {"Chave 2", 200},
};

// Podemos adicionar informando diretamente a chave 

dic["Chave 3"] = 300;

// Ou utilizando o método Add

dic.Add("Chave 4", 400);

// Para procurar
if (dic.ContainsKey("Chave 4"))
{
  Console.WriteLine($"Chave 4 encontrada, {dic["Chave 4"]}");
}

// Percorrendo o Dicionario
foreach (KeyValuePair<string, int> kv in dic)
{
    Console.WriteLine($"Chave: {kv.Key} - Valor: {kv.Value}");
}


// Uma empresa de entregas e logistica precisa gerenciar os códigos das etiquetas de entrega
// Para cada pacote de produto em seu respectivo código de barras. 
// Observeque a chave é o código de rastreio e o valor é o código de barras da encomenda. 
// Escreva um produto que armazene em um dicionário ou um mapa hasch uma quantidade X
// De informações referentes ao rastrio e ao pacote, permitindo ao usuário inserilas em tempo de execução. 
// TOme cuidado para que o sistema informe quando houver lançamentos repetidos e não ocasionar erros insesperados. 
// Em seguida, forneça um recurso para que o usuário possa procurar tanto o código de rastreio quanto o código de barras.
// E de um retorno amigável e informativo ao usuário. 