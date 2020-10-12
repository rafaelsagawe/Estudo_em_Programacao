import java.util.Scanner;

class SwitchCase {
public static void main(String[] args) {
        int opcao;

        // objeto de entrada
        Scanner entradaItem = new Scanner(System.in);

        System.out.println("Sistemas");
        System.out.println("1 - Windowns");
        System.out.println("2 - Linux");
        System.out.println("3 - MacOS");
        System.out.println("Digite sua opção desejada");

        opcao=entradaItem.nextInt();
        // A estrutura a baixo permite a escolha de uma opção

        switch (opcao) {
        case 1:
                windowns();
                break;

        case 2:
                linux();
                break;

        case 3:
                macos();
                break;

        default:
                System.out.println("Opção invalida");
                break;
        }
}
public static void windowns(){
        System.out.println("Carregando o sistema Windowns");
        System.out.println("00000000000000000000000000000");
}
public static void linux(){
        System.out.println("Carregando o sistema Linux");
        System.out.println("00000000000000000000000000000");
}
public static void macos(){
        System.out.println("Carregando o sistema MacOS");
        System.out.println("00000000000000000000000000000");
}

}
