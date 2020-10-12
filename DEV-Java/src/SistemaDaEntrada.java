class SistemaDaEntrada {
public static void main(String[] args) {
        int idade; // o calculo da idade será foito com base na data de nasciemnto com ano atual
        idade = 9; // o valor deve ser de um formulario
        boolean amigoDoDono = false; // o valor deve ser de um formulario
        if (idade < 18 && amigoDoDono == false) { // se possoa não tem 18 anos e não é anigo do dono não podera entrar.
                System.out.println("Não pode entrar");
        }
        else // se tem mais de 18 anos pode entrar e se e amigo, mas tem menos de 18 anos pode entrar
        {
                System.out.println("Pode entrar");
        }
}
}
