using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1185849874.Downloads.Cadastro AlunosMedia
{
    public class NewClass
    {
        
    }
}
//Crie uma classe Aluno com as segu propriedades:

//Nome, Curso, Idade, RG, Bolsista (boolean),
// Média Final e Valor da Mensalidade. 
//Também teremos os métodos: 
//VerMediaFinal() e VerMensalidade(),
// caso seja bolsista faremos o cálculo da mensalidade.
//obs:
//bolsista e média final maior ou igual a 8,
//conceder 50% de desconto na mensalidade
//bolsista e média final maior que 6 e menor que 8,
// conceder 30% de desconto na mensalidade 
//outros casos a mensalidade será integral
//Receba os dados do cadastro via console e crie um menu,
// para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
Console.WriteLine("Quantos alunos deseja cadastrar: ");
int numAlunos = Convert.ToInt32(Console.ReadLine());


int mat;
            string nome;
            double n1, n2, n3;
   
            for (int i = numAlunos - 1; i >= 0; i--)
            {
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o curso do aluno: ");
            curso = Console.ReadLine();
            Console.WriteLine("Digite o RG do aluno ");
            n1RG =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite mensalidade do aluno: ");
            n2Mensalidade =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a media da aluno: ");
            n3Media=Convert.ToInt32(Console.ReadLine());
            CadastroAluno(nome, curso, n1 = RG, n2 = mensalidade, n3 = media);
 
            }
           //bolsista e média final maior ou igual a 8,
//conceder 50% de desconto na mensalidade
//bolsista e média final maior que 6 e menor que 8,
// conceder 30% de desconto na mensalidade 
//outros casos a mensalidade será integral
    
    {
        string nome;
        string curso;
        double n1RG;
        double n2Mensalidade;
        double n3Media;
        
 
 
 
    
            n3media >= 8 //conceder 50% de desconto
            n3media >= 6 <8 //conceder 30% de desconto
            n3media //integral sem desconto
        
 
 
 
    //    Exemplo
      
 
    //     public string GetResultado()
    //     {
    //         string resultado;
 
    //         if (media >= 60)
    //         {
 
    //             resultado = "Aprovado";
    //             return resultado;
 
    //         }
 
    //         else if (media < 40 && media > 59)
    //         {
 
    //             resultado = "Reprovado";
    //             return resultado;
    //         }
 
    //         else
            {
                resultado = "Recuperação";
                return resultado;
            }
 
        }
 
 
    }
//Crie uma classe Aluno com as segu propriedades:

//Nome, Curso, Idade, RG, Bolsista (boolean),
// Média Final e Valor da Mensalidade. 
//Também teremos os métodos: 
//VerMediaFinal() e VerMensalidade(),
// caso seja bolsista faremos o cálculo da mensalidade.
//obs:
//bolsista e média final maior ou igual a 8,
//conceder 50% de desconto na mensalidade
//bolsista e média final maior que 6 e menor que 8,
// conceder 30% de desconto na mensalidade 
//outros casos a mensalidade será integral
//Receba os dados do cadastro via console e crie um menu,
// para o usuário escolher se quer visualizar a média ou o valor da mensalidade.