<!doctype html>
<html lang="pt=br">
<head>
<title>Acesso</title>
</head>
<body>
 
<?php
$nome = $_POST['nome'];
$sobrenome = $_POST['sobrenome'];
$sexo = $_POST['sexo'];
$comentarios = $_POST['comentarios'];
$senha = $_POST['senha'];
echo "Seu nome é " . $nome . " " . $sobrenome . "<br/>";
echo "O sexo informado foi " . $sexo . "<br/>";
echo "A senha digitada é " . $senha . "<br/>";
echo "Você comentou o seguinte: <br>" . $comentarios . "<br/>";
// Verificando os checkboxes

if(isset($_POST['linguagens'])) {

echo "As linguagens de programação escolhidas foram:<br/>";
// Efetuar loop pelo array de linguagens:
foreach($_POST['linguagens'] as $linguagem) {
echo $linguagem . "<br/>";
}
}
else {
echo "Nenhuma linguagem de programação escolhida!<br/>";
}
//---------------------------------------------------------------
// Verificando as tecnologias do campo SELECT:
if(isset($_POST['tecnologias'])) {

echo "Você selecionou as seguintes tecnologias:<br/>";
// Loop foreach para retornar as tecnologias selecionadas:
foreach($_POST['tecnologias'] as $tecnologia) {
echo $tecnologia . "<br/>";
}
}
else {
echo "Nenhuma tecnologia selecionada. Que pena! <br/>";
}
//-----------------------------------------------------------------
// Mostrando todos os itens do array associativo $_POST:
print_r($_POST);

?>
</body>
</html>
