<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="_css/estilo.css"/>
  <meta charset="UTF-8"/>
  <title>Curso de PHP - CursoemVideo.com</title>
</head>
<body>
<div>
<form class="" action="02-tabuada.php" method="get">
  <select name="num">
      <?php
        for ($i=1; $i <= 10 ; $i++) {
          echo "<option>$i</option>";
        }
       ?>
       <input type="submit" class="botao" name="" value="Tabuada">
  </select>

</form>
</div>
</body>
</html>
