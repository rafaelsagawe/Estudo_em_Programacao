class TesteFuncionario {
public static void main(String[] args) {
        Funcionario f1 = new Funcionario();
        f1.nomeFuncionario = "Rafael Sagawe";
        f1.salario = 1500;
        f1.dataAdmicao = "1 de abril de 2018";
        f1.departamento = "Tecnologia de Informação";
        f1.bonifica(50);

        Funcionario f2 = new Funcionario();
        f2.nomeFuncionario = "Bruna Martins";
        f2.salario = 1520;
        f2.dataAdmicao = "6 de setembro de 2015";
        f2.departamento = "Administração";
        f2.bonifica(80);

        Funcionario f3 = new Funcionario();
        f3 = f1;

        f1.amostra();
        System.out.println("");
        f2.amostra();
        System.out.println("");
        f3.amostra();

// Comparação de funcionarios
        System.out.println("");
        System.out.println("Comparação entre o funcionario 1 e 2");
        if (f1 == f2) {
                System.out.println("Iguais");
        }else {
                System.out.println("Diferentes");
        }
        System.out.println("");
        System.out.println("Comparação entre o funcionario 1 e 3");
        if (f1 == f3) {
                System.out.println("Iguais");
        }else {
                System.out.println("Diferentes");
        }
        System.out.println("");
        System.out.println("Comparação entre o funcionario 2 e 3");
        if (f2 == f3) {
                System.out.println("Iguais");
        }else {
                System.out.println("Diferentes");
        }
      }
}
