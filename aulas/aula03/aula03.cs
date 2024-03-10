using System;

class Aula03{
    static void Main(){
        // byte n1 = 10; // 0 e 255
        // int num = -10;
        // char letra = 'b';
        // float valor = 5.3f;
        // string nome = "Samuel";
        // var aux = nome;

        // Console.WriteLine(aux);
        // Console.WriteLine(n1);
        // Console.WriteLine(num);
        // Console.WriteLine(letra);
        // Console.WriteLine(valor);

        int nota1, nota2, nota3, media;
        var nome = "samuel";

        nota1 = 3;
        nota2 = 2;
        nota3 = 1;
        media = (nota1 + nota2 + nota3) / 3;

        if (media >= 5)
        {
            Console.WriteLine("O aluno " + nome + " foi aprovado!");
        }else if (media >= 3)
        {
             Console.WriteLine("O aluno " + nome + " esta de recuperação");
        }else
        {
            Console.WriteLine("O aluno " + nome + " foi reprovado");
        }
    }
}