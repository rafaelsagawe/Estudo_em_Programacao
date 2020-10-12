class TestaAlgunsMetodos{
  public static void main(String[] args) {
    // Criando Conta
    Conta minhaConta;
    minhaConta = new Conta();

    // alterando valores da Conta
    minhaConta.dono = "Doke";
    minhaConta.saldo = 2000;

    //saca 200
    minhaConta.saca(200);

    // deposita 500
    minhaConta.deposita(500);

    // ver o saldo da minha Conta
    System.out.println("Saldo da minha conta:" + minhaConta.saldo);
  }
}
