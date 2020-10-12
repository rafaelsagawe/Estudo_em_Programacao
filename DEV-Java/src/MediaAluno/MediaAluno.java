import java.util.Scanner;

public class MediaAluno{
public static void main(String[] args) {
  Scanner in = new Scanner(System.in);

  double nota1, nota2, nota3, nota4;

  System.out.println("Digite sua nota 1: ");
  nota1 = in.nextDouble();

  System.out.println("Digite sua nota 2: ");
  nota2 = in.nextDouble();

  System.out.println("Digite sua nota 3: ");
  nota3 = in.nextDouble();

  System.out.println("Digite sua nota 4: ");
  nota4 = in.nextDouble();

  double soma = nota1 + nota2 + nota3 + nota4;
  soma = soma / 4;

if ( soma >= 7 ) {
  System.out.println("Voce foi aprovado com media: " + soma);
}else {
  System.out.println("Voce foi reprovado com media: " + soma);
}

}

}
