import java.util.Scanner;

class ClassificacaoPorIdade {
public static void main(String[] args) {


        Scanner entrada = new Scanner(System.in);

        final int iJ,  iI;
        iJ = 17;
        iI = 60;

        System.out.println("Digite uma idade ");
        int idade = entrada.nextInt();

        if(idade <= iJ) {
                System.out.println("A pessoa é jovem");
        }else if (idade > iJ && idade < iI) {
                System.out.println("A pessoa é adulto");
        }else {
                System.out.println("A pessoa é idosa");
        }
}
}
