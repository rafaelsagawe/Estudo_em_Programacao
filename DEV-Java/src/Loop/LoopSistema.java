import java.util.Scanner;

class LoopSistema {
public static void main(String[] args) {

        int qtd = 0;

        // Controle de repetições do loop
        Scanner entraQuantidade = new Scanner(System.in);
        int repete;
        System.out.println("Quantidade de repetições: ");
        repete = entraQuantidade.nextInt();
        // Final do Controle

        // Sistema de entrada de Texto
        Scanner entraTexto = new Scanner(System.in);
        String txt;
        System.out.println("Digite o texto que será repetido: ");
        txt = entraTexto.next();
        // Final do sistema de entrada de texto

        while (qtd<=repete) {
                qtd = qtd + 1;
                System.out.println(qtd + " " + txt);
        }
    }
}
