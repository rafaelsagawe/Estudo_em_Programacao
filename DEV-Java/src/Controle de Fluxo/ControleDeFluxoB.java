public class ControleDeFluxoB {
    public static void main(String[] args) {
        // idade < 15 Categoria infantil
        // idade >= 15 && idade < 18 Juvenil
        // idade >= 18 adulto

        int idade = 17;
        String categoria = ""; //A variavel categoria
        //-------------
        if (idade < 15) {
            categoria = "infantil";
        }else if (idade >= 15 && idade < 18){
            categoria =  "Juvenil";
        }else if (idade>= 18 ){
            categoria = "Adulto";
        }
        System.out.println(categoria);
    }
}
