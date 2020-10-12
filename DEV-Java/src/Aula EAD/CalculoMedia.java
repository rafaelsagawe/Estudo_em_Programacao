import java.util.Scanner;
import java.text.DecimalFormat;

class CalculoMedia {
public static void main(String[] args) {
        double nota1, nota2, nota3, nota4, media; // Variaveis de valor

        Scanner entrada = new Scanner(System.in); // Objeto de entrada de dados

// Objeto que faz a formatação do resultado da media
        DecimalFormat formatador = new DecimalFormat("#0.0");

// Lançamento de dados
// Inicio
        System.out.println("Primeiro bimestre");
        nota1=entrada.nextDouble();
        System.out.println("Segundo bimestre");
        nota2=entrada.nextDouble();
        System.out.println("Terceiro bimestre");
        nota3=entrada.nextDouble();
        System.out.println("Quarta bimestre");
        nota4=entrada.nextDouble();
// Final

// Calculo de media do aluno
        media=(nota1+nota2+nota3+nota4)/4;
        System.out.println("Sua media é: " + formatador.format(media));
// Final

// Estrutura para verificação da situação do aluno
        if (media <= 2) {
                System.out.println("Aluno reprovado");
        }else if ((media > 2) && (media < 6)) {
                System.out.println("Aluno de recuperação");
        }
        else {
                System.out.println("Aluno aprovado");
        }
// Final

}

}
