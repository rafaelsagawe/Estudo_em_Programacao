import java.util.Scanner;

class CalculadoraV2 {

public static void main(String[] args) {

        Scanner entrada = new Scanner(System.in);

        System.out.println("Digite 1 para somar");
        System.out.println("Digite 2 para subtrair");
        System.out.println("Digite 3 para multilizar");
        System.out.println("Digite 4 para dividir");
        System.out.println("Digite 5 para resto");

        int operacao = entrada.nextInt();

        System.out.println("Digite o primeiro valor da operacao");
        double num1 = entrada.nextDouble();

        System.out.println("Digite o segundo valor da operacao");
        double num2 = entrada.nextDouble();

        if (operacao == 1) {
                System.out.println(num1 + num2);
        }else if (operacao == 2) {
                System.out.println(num1 - num2);
        }else if (operacao == 3) {
                System.out.println(num1 * num2);
        }else if (operacao == 4) {
                System.out.println(num1 / num2);
        }else if (operacao == 5) {
                System.out.println(num1 % num2);
        }else {
                System.out.println("Operação invalida");
        }
}
}
