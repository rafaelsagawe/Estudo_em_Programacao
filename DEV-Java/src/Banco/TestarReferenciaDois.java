class TestarReferenciaDois {
public static void main(String[] args) {
        Conta c1 = new Conta();
        c1.dono = "Rafael";
        c1.saldo = 200;

        Conta c2 = new Conta();
        c2.dono = "Rafael";
        c2.saldo = 200;

        Conta c3 = c1;
        c3.deposita(100);

        if (c1 == c2) {
                System.out.println("Contas iguais"); // if vale true
        }else {
                System.out.println("Contas diferentes");// if vale false
        }
System.out.println("==//==//==//==//==");
        if (c1 == c3) {
                System.out.println("Contas iguais");
        }else {
                System.out.println("Contas diferentes");
        }
}
}
