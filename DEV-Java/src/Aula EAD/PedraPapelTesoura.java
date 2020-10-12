import java.util.Scanner;

class PedraPapelTesoura {
public static void main(String[] args) {

        // Objeto da mão do jogador

        System.out.println("Jogo pedra - papel - tesoura");
        System.out.println("--//--//--//--//--//--//--//--//--//--");
        System.out.println("1 - Pedra");
        System.out.println("2 - Papel");
        System.out.println("3 - Tesoura");
        System.out.println("Digite sua opção");

        // Parte do jogador
        // mao do jogado
        int jogador;
        Scanner mao = new Scanner(System.in);
        jogador = mao.nextInt();

        switch (jogador) {
        case 1:
                System.out.println("Jogador escolheu Pedra");
                break;

        case 2:
                System.out.println("Jogador escolheu Papel");
                break;

        case 3:
                System.out.println("Jogador escolheu Tesoura");
                break;

        default:
                System.out.println("Opção inválida");
                break;
        }

        // Parte do computador

        int computador = (int) (Math.random() * 3 + 1);
        //  System.out.println("Escolha do computador - " + computador);

        switch (computador) {
        case 1:
                System.out.println("Computador escolheu Pedra");
                break;
        case 2:
                System.out.println("Computador escolheu Papel");
                break;
        case 3:
                System.out.println("Computador escolheu Tesoura");
                break;
        }
        // Sistema do jogo
        if (jogador != computador) {
          //System.out.println("Em construção");
          if ((jogador == 1 && computador ==3) || (jogador == 2 && computador == 1)  || (jogador == 3 && computador == 2)) {
            System.out.println("Vitoria do Jogador");
          }else {
            System.out.println("Vitoria do computador");
          }
        }
        //Empate
        else {
          System.out.println("Empate");
        }
}
}
