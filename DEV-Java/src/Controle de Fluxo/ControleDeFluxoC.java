public class ControleDeFluxoC {
    public static void main(String[] args) {
        int idade = 20;
        String status;

        if (idade < 18) {
            status = "Não adoulto";
        } else {
            status = "Adulto";
        }
        System.out.println(status);
    }
}
