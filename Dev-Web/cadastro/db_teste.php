<?php
$banco = "db_sistema_os";
$usuario = "sistema";
$senha = "sistema";
$hostname = "127.0.0.1";
$conn = mysql_connect($hostname,$usuario,$senha);
mysql_select_db($banco) or die ("Não foi possivel acessar o banco de dados")
if (!$conn) {
  echo "Não foi possivel conectar ao banco mysql";
  exit;
} else {
  echo "Parabens!! Conexao funcionando";
}
mysql_close();
 ?>
