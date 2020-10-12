<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="_css/estilo.css"/>
  <meta charset="UTF-8"/>
  <title>Curso de PHP - CursoemVideo.com</title>
</head>
<body>
<div class="">
    <?php
      $nome = isset($_GET["nome"])?$_GET["nome"]:"[Não informado]";
      $ano = isset($_GET["ano"])?$_GET["ano"]: 0;
      $sexo = isset($_GET["sexo"])?$_GET["sexo"]:"[Sem sexo]";
      $idade = date("Y") - $ano;
      echo "$nome sexo $sexo tem $idade anos";
     ?>
     <a href="02exercicio.html">Voltar</a>
</div>
</body>
</html>
