import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.Scanner;

class IdadeC{
  public static void main(String[] args) {
    Calendar cal = GregorianCalendar.getInstance();
    int anoAtual = cal.get(Calendar.YEAR);
    int anoNascimento;
    int idade;

    Scanner dataEntrada = new Scanner(System.in);
    System.out.println("Digite a sua data de nascimento:");
    anoNascimento = dataEntrada.nextInt();

    idade = anoAtual - anoNascimento;
    System.out.println(idade);
  }
}
