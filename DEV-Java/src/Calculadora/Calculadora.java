import java.util.Scanner;

public class Calculadora{
  public static void main(String[] args) {

    Scanner in = new Scanner (System.in);
    double num1, num2, soma, subtracao, mult, div;

    System.out.println("Insira um numero: ");
    num1 = in.nextDouble();

    System.out.println("Insira outro numero: " );
    num2 = in.nextDouble();

    soma = num1 + num2;
    System.out.println("A soma desses numeros é " + soma);

    subtracao = num1 - num2;
    System.out.println("A subtração desses numeros é " + subtracao);

    mult = num1 * num2;
    System.out.println("A multiplicação desses numeros é " + mult);

    div = num1 / num2;
    System.out.println("A divição desses numeros é " + div);
  }
}
