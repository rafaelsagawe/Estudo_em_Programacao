<?php
$login $_POST['login'];
$senha = MD5($_POST['senha']);
$connect = mysql_connect('localhost','sistema','sistema');
$db = mysql_select_db('cadastro');
$query_select = "select login from usuario WHERE login = '$login'";
$select = mysql_query($query_select,$connect);
$array = mysql_fetch_array($select);
$logarray = $array['login'];

if ($login == "" || $login == null) {
  echo "<script language='javascript' type='text/javascript'alert('Campo login deve ser preenchido');window.location.href='cadastro.html';</script>";

} else {
  if($logarray == $login){
    echo "<script language='javascript' type='text/javascript'alert('Campo login ja existe preenchido');window.location.href='cadastro.html';</script>";
    die();
  }else {
    $query = "insert into usuario (login,senha) values ('$login','$senha')";
    $insert = mysql_query($query,$connect);

    if ($insert) {
      echo "<script language='javascript' type='text/javascript'alert('usuario cadastrado com sucesso');window.location.href='login.html';</script>";

    }else {
      echo "<script language='javascript' type='text/javascript'alert('não foi possivel');window.location.href='cadastro.html';</script>";
    }
  }
}
 ?>
