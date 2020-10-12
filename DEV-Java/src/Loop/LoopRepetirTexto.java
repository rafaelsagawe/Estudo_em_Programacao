import java.util.Scanner;

public class LoopRepetirTexto{
  public static void main(String[] args) {
    int x = 0;

    // Entrada de texto
    Scanner in = new Scanner(System.in);
    String txt;
    System.out.println("Texto que será repetido: ");
    txt = in.next();
    // Final da Entrada de texto

    // Repetir o texto escolhido 10 vezes.
    while (x<=9) {
      x = x + 1;
      System.out.println(x + " - " + txt);
    }
  }
}
