<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="_css/estilo.css"/>
  <meta charset="UTF-8"/>
  <title>Curso de PHP - CursoemVideo.com</title>
</head>
<body>
<div>
    <?php
          function soma ($a, $b){
            $s = $a + $b;
            return $s;
          }
          $x = 3;
          $y = 4;
          $r = soma($x, $y);

          echo "A soma entre $x e $y e igual a $r";
    ?>
    <br><a href="javascript:history.go(-1)" class="botao">Voltar</a>
</div>
</body>
</html>
