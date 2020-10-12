class ArrayB {
public static void main(String[] args) {
        String[][] agenda = {{"Alfa", "Beta", "Omega"},{"A", "B", "C"}, {"1", "2", "3"}, {"!", "@", "#"}};


        // recuperação de determinada parte
        System.out.println("==//==//TESTE A\\==\\");
      System.out.println("Email da primeira pessoa");
        System.out.println(agenda [0][2]);
        System.out.println("==//==//TESTE A\\==\\");
//=======================
        System.out.println("==//==//TESTE B\\==\\");



for (int i = 0; i < agenda.length ; i++ ) {
  System.out.println("---");

  for (int jb = 0; jb < agenda.length ; jb++ ) {

    System.out.println(agenda[i][jb]);
  }
}



        System.out.println("==//==//TESTE B\\==\\");


        }
}
