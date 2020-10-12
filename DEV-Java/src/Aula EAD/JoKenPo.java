import java.util.Scanner;

class JokenPo {
public static void main(String[] args) {
        int jogador;

        // Objeto da mão do jogador
        Scanner mao = new Scanner(System.in);

        System.out.println("Jogo pedra - papel - tesoura");
        System.out.println("--//--//--//--//--//--//--//--//--//--");
        System.out.println("1 - Pedra");
        System.out.println("2 - Papel");
        System.out.println("3 - Tesoura");
        System.out.println("Digite sua opção");
}
}

// mao do jogado

        switch (mao) {
        case 1:
                pedra();
                break;

        case 2:
                tesoura();
                break;

        case 3:
                papel();
                break;

        }
}

public static void pedra(); {
        System.out.println("Pedra");
}
public static void tesoura(); {
        System.out.println("Tesoura");
}
public static void papel(); {
        System.out.println("Papel");
}
}
