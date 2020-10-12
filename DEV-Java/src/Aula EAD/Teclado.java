import java.util.Scanner;

class Teclado{
  public static void main(String[] args) {
    String nome;
    int idade;
    // Objeto teclado para entrada de dados
    Scanner teclado = new Scanner(System.in);
    System.out.println("Digite seu nome: ");
    // Capitura o que foi digitado e lança na variavel nome
    nome = teclado.nextLine();
    System.out.println("Digite a sua idade: ");
    idade = teclado.nextInt();
    System.out.println(nome + " tem " + idade + " anos." );

    // Identificação de maior idade
    if (idade >= 18) {
      System.out.println("Maior de idade");
      }
      else {
        System.out.println("Menor de idade");
      }
  }

}
