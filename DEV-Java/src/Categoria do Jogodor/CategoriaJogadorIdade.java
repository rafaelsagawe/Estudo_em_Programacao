/*
categorizar o jogador com base na sua idade

O programa deve calcular a idade do jogador com base na idade

idade < 15 Categoria infantil
idade >= 15 && idade < 18 Juvenil
idade >= 18 adulto

*/

import java.util.Scanner; //Importa a bilioteca para leitura do teclado

public class CategoriaJogadorIdade {
      public static void main(String[] args) {
          Scanner idadeEntrada = new Scanner (System.in);
          int idade;
          String categoria = "";

          System.out.println("Ensira a idade do jogador: ");
          idade = idadeEntrada.nextInt();

          if (idade < 15) {
            categoria = "Infantil";
          } else if (idade >= 15 && idade < 18) {
            categoria = "Juvenil";;
          }else if (idade >= 18) {
            categoria = "Adulto";
          }

          System.out.println("O jodagor tem " + idade + " anos, na Categoria " + categoria + ".");
      }
  }
