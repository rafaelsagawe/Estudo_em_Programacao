import java.util.Scanner;

class LoopQuantasEntradas{
  public static void main(String[] args) {

    int qtd = 0; // Quantidade de repetiçoes do loop


    // Controle do loop
    Scanner entra = new Scanner(System.in);
    int repete; // Quantidade de loops
    System.out.println("quantidade de repetiçoes");
    repete = entra.nextInt();
    // Final do Controle do loop

    while (qtd<=repete) {
      qtd = qtd + 1;
      System.out.println(qtd + " Teste");
    }
  }
}
