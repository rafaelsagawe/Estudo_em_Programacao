import java.util.Scanner;

class JogoDoDado {
public static void main(String[] args) {
        char opcao = 's';
        Scanner teclado = new Scanner(System.in);
        // Loop
        while (opcao == 's') {
                System.out.println("Lançamento do dado .....");
                int dado = (int) (Math.random() * 6 + 1);
                /**
                int dado -> para simbolizar as faces do dado.
                (int) (Math.random() -> primeiro pega um numero aleatorio e depois converte ele em inteiro
                + 6 -> gera as faces do dado, mas aparece o 0 e não o 6, para contornar isso e somado 1,
                assim quando aparecer 0 será convertido em 1 e o 6 ira aparecer no lugar do 5.
                */
                System.out.println("Face: " + dado); // Amosta a face do dado
                System.out.println("Deseja lançar o dado novamente s/n? "); // Pegunta se que jogar novamente
                opcao = teclado.next().charAt(0); // Para o loop e pergunta se o jogador que jogar o dado novamente
        }
}
}
