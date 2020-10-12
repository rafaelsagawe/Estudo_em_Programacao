// Import necessario para o calendario
import java.util.Calendar;
import java.util.GregorianCalendar;

public class IdadeB{
  public static void main(String[] args) {
/* Dados do calendario*/
Calendar cal = GregorianCalendar.getInstance();
/* Dados do calendario*/
    int anoAtual = cal.get(Calendar.YEAR);
    int anoNascimento;
    int idade;
    anoNascimento = 1985;
    idade = anoAtual - anoNascimento;
    System.out.println(idade);
  }
}
