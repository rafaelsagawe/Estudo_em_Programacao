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
$nome = "   José da Silva   ";
echo (strlen($nome));
echo "<br>";
$novo = trim($nome);
echo $novo;
echo "<br>";
echo (strlen($novo));
    ?>
    <br><a href="javascript:history.go(-1)" class="botao">Voltar</a>
</div>
</body>
</html>
