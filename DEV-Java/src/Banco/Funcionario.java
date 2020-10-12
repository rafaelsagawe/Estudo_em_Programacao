/*
   Class funcionario deve ter:
   nome
   data de entrada no banco
   dp onde trabalha
   salario
   rg

   metodo:
   receberAumento
   calculo de ganho anual
 */

class Funcionario {
String nomeFuncionario;
String dataAdmicao;
String departamento;
double salario;
int rG;
double novoSalario;
/*
   void receberAumento(double aumento){

   }

double calculoDeGanhoAnual = salario;
*/


public void bonifica(double aumento) {
novoSalario = this.salario + aumento;
}

void amostra(){
        System.out.println("  Dados de Funcionario  ");
        System.out.println("Nome do funcionario: " + nomeFuncionario);
        System.out.println("Data de admição: " + dataAdmicao);
        System.out.println("Departamento de Atuação: " + departamento);
        System.out.println("  Dados de Financeiros  ");
        System.out.println("Salario atual: " + salario);
        //System.out.println("Ganho de um ano de trabalho: " + calculoDeGanhoAnual);
        System.out.println("Salario com aumento: " + novoSalario);
};

}
