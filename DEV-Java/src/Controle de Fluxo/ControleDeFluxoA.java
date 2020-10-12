

public class ControleDeFluxoA {
    public static void main(String[] args) {
        // idade < 15 Categoria infantil
        // idade >= 15 && idade < 18 Juvenil
        // idade >= 18 adulto

        int idade = 20;
        //-------------
        if (idade < 15) {
            System.out.println("Categoria infantil");
        }else if (idade >= 15 && idade < 18){
            System.out.println("Categoria Juvenil");
        }else if (idade>= 18 ){
            System.out.print("Categoria Adulto");
        }

    }
}
