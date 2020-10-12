<?php
$login_cookie = $_COOKIE["login"];
if (isset($login_cookie)) {
  echo "Bem Vindo, $login_cookie <br>";
  echo "Essas informações <font color='red'>podem</font> ser acessadas";
} else {
  echo "Bem vindo convidado <br>";
  echo "Essas informações <font color='red'>não podem</font> ser acessadas";
  echo "<br><a href='login.html'>Faca login</a> Para ler o conteudo";
}
 ?>
