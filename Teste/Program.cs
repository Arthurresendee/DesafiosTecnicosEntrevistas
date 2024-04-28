/*
Aqui o objetivo é vericar se um determinado número faz parte da sequência de fibonacci.
A lista é iniciada com [0,1] e o próximo número da sequência é a soma dos dois anteriores.
Então de acordo com a sequência, nós temos que mostrar os números que estamos comparando e
verificar se um número faz ou não parte dessa sequência.
*/

{
    Console.WriteLine("Digite o numero para verificar");
    var numero = int.Parse(Console.ReadLine());

    var lista = GerarSequênciaFibonacci(30); //Aqui você vai definir a quantidade de números fibonacci que vai gerar na lista, para  depois verificar a entrada do usuário.

    Console.WriteLine("\nLista Completa");
    ImprimirSequenciaFibonacci(lista); //Aqui apenas imprime no console todos os números da lista.

    var retorno = VerificarSeEhFibonacci(numero, lista);
    if (retorno == true)
        Console.WriteLine("\nÉ fibonacci");
    else Console.WriteLine("Não é fibonacci");

}

bool VerificarSeEhFibonacci(int numero, List<int> lista)
{
    bool retorno = false;
    for(int i = 0; i < lista.Count; i++)
    {
        if (lista[i] == numero)
        {
            return true;
        }
    }
    return retorno;
}

List<int> GerarSequênciaFibonacci(int quantidadeDeNumerosPresenteNaLista)
{
    List<int> lista = [0,1];
    int ProximoNumero;
    int indice1 = 0;
    int indice2 = 1;
    while (lista.Count < quantidadeDeNumerosPresenteNaLista)
    {
        ProximoNumero = lista[indice1] + lista[indice2];

        lista.Add(ProximoNumero);
        indice1 += 1;
        indice2 += 1;
    }
    return lista;
}

void ImprimirSequenciaFibonacci(List<int> listaGerada)
{
    for (int i = 0; i < listaGerada.Count; i++)
    {
        Console.WriteLine(listaGerada[i]);
    }
}