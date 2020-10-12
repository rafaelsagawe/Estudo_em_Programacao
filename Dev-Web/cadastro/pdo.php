<?php
try {
  $pdo=new PDO("mysql:host=localhost;dbname=cadastro","sistema","sistema");
} catch (PDOException $e) {
  echo $e->getMessage();
}

/*$buscausuario=$pdo->query("SELECT * FROM usuario WHERE id='1'");
echo $buscausuario->rowCount();
*/

/*$id=$_GET["id"];
$buscasegura=$pdo->prepare("SELECT * FROM usuario WHERE id=:id");
$buscasegura->bindValue(":id",$id);
$buscasegura->execute();
echo $buscasegura->rowCount();
*/

$login=$_GET["login"];
$buscasegura=$pdo->prepare("INSERT INTO usuario (login) values (?));
$buscasegura->bindValue(1,$login);
$buscasegura->execute();
/*echo $buscasegura->rowCount();*/
?>
