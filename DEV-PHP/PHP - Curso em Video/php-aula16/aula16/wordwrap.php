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
$t = "Aqui temos uma texto gigante criado pelo PHP e vai mostrar o funcionamento da funcao wordwrap";
$r = wordwrap($t, 10, "<br/>\n", true );
echo $r;
    ?>
    <br><a href="javascript:history.go(-1)" class="botao">Voltar</a>
</div>
</body>
</html>
