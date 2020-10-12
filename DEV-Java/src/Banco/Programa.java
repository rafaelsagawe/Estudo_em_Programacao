
class Programa {
public static void main(String[] args) {
        Conta minhaConta;
        minhaConta = new Conta();

        minhaConta.dono = "Duke";
        minhaConta.saldo = 2000.0;
        System.out.println(minhaConta.dono + " tem de Saldo atual: " + minhaConta.saldo);

// Realizando um saque
        System.out.println("Vou sacar 2000");
        if (minhaConta.saca(2000)) {
                System.out.println("Consegui sacar, agora tem: ");
        } else {
                System.out.println("Não Consegui sacar");
        }
}
}
