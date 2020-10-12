<?php
function getConnection()
{
$host = "localhost";
$banco = "cadastro";
$usr = "sistema";
$pwd = "sistema";
try {
  $pdo = new PDO("mysql:host=".$host.";dbname=".$banco, $usr, $pwd);
  $buscausuario=$pdo->query("SELECT * FROM usuario WHERE id='1'");
  echo $buscausuario->rowCount;

} catch (PDOException $e) {
  return array("conexao"=>null, "messagem"=>"Ocorreu um erro: <br>".$e->getMessage());
}
}
$teste = getConnection();
print_r($teste);
?>
