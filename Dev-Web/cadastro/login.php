<?php
$login $_POST['login'];
$entra = $_POST['entrar'];
$senha = MD5($_POST['senha']);
$connect = mysql_connect('localhost','sistema','sistema');
$db = mysql_select_db('cadastro');
if (isset)($entrar) {

  $verifica = mysql_query("select * from usuario where login = '$login' and senha '$senha'") or die ("erro ao selecionar");
  echo "<script language='javascript' type='text/javascript'alert('Erro no login');window.location.href='cadastro.html';</script>";

  die();
} else {
  setcookie("login",$login);
  header("Location:index.php")
}
?>
