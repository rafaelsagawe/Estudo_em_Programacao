import java.util.Scanner;

class Tabuada {

public static void main(String[] args) {
        // Qual tabuada será feita
        int valor;
        //Criação do objeto de entrada
        Scanner teclado = new Scanner(System.in);
        // Solicitação de entrada de dados
        System.out.println("Qual tabuada você deseja realizar?");
        //Captura de entrada
        valor = teclado.nextInt();
        //Enlaçe
        for (int conta = 0; conta <= 10; conta++ ) {
                // Saida do enlaçe
                System.out.println(valor + " X " + conta + " = " + (valor*conta));
        }
}
}
