/*
Os meses de Junho e Julho são tradicionalmente conhecidos por todo Brasil por suas festas típicas, 
e para o grupo de amigos da Marlene não é diferente, toda segunda quinzena do mês de Julho ela
e seus amigos se reunem para tradicional mandiocada! Na festiva sempre se reúnem na casa da Marlene,
o Chico, o Beto, o Bernardo, a Marina e a Iara. E como não poderia ser diferente o prato principal
dessa reunião é a mandioca. Cada um deles come de uma a dez porções de mandioca e eles sempre avisam
a Marlene com antecedência a respeito de quantas porções irão comer nesse dia.
O tamanho da porção de cada um é diferente, mas sempre são os mesmos. 
As porções são as seguintes (em gramas):
*/

using System;
class Desafio {
    static void Main() {
        int chico = 300 * Int32.Parse(Console.ReadLine());
        int bento = 1500 * Int32.Parse(Console.ReadLine());
        int bernardo = 600 * Int32.Parse(Console.ReadLine());
        int marina = 1000 * Int32.Parse(Console.ReadLine());
        int iara = 150 * Int32.Parse(Console.ReadLine());
        int marlene = 225;
        int total = chico + bento + bernardo + marina + iara + marlene; 
        // Digite aqui o calculo total
        Console.WriteLine(total);
    }
}