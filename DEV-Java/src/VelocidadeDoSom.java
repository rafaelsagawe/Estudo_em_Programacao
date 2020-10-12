import java.util.Scanner;

class VelocidadeDoSom{
  public static void main(String[] args) {
      final double vsom = 340.28; // Velocidade do som.

      System.out.println("Digite o estaço de tempo: ");

      Scanner in = new Scanner(System.in);

      double tempo = in.nextDouble();

      System.out.println("A distancia seria de " + tempo * vsom + " metros percorridos");

      System.out.println("A distancia seria KM " + (tempo * vsom) / 1000 + " metros percorridos");
  }
}
