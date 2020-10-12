/*
categorizar o jogador com base na sua idade

O programa deve calcular a idade do jogador com base na data de nascimento

idade < 15 Categoria infantil
idade >= 15 && idade < 18 Juvenil
idade >= 18 adulto

*/

import java.util.Scanner; //Importa a bilioteca para leitura do teclado

import java.util.Calendar; //Importa a bilioteca de calendario
import java.util.GregorianCalendar; //Importa a bilioteca de gregorianocalendario

public class CategoriaJogadorNascimento {
      public static void main(String[] args) {
          Scanner nascimentoEntrada = new Scanner (System.in);
          Calendar cal = GregorianCalendar.getInstance();
          int anoAtual = cal.get(Calendar.YEAR);
          int anoNascimento;
          int idade;
          String categoria = "";

          System.out.println("Ensira o ano de nascimento jogador: ");
          anoNascimento = nascimentoEntrada.nextInt();

          //Bloco para calculo da idade
          idade = anoAtual - anoNascimento;
          //Final

          //bloco da Categoria do Jogador
          if (idade < 15) {
            categoria = "Infantil";
          } else if (idade >= 15 && idade < 18) {
            categoria = "Juvenil";;
          }else if (idade >= 18) {
            categoria = "Adulto";
          }
          //Final
          System.out.println("O jodagor tem " + idade + " anos, na Categoria " + categoria + ".");
      }
  }
