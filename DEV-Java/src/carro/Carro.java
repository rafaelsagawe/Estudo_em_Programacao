class Carro {
String cor;
String modelo;
double velocidadeAtual;
double velocidadeMaxima;
Motor motor;

// Liga o Carro
void liga() {
        System.out.println("O carro esta ligado");
}

// Acelera uma certa quantidade
void acelera (double quantidade) {
        double velocidadeNova = this.velocidadeAtual + quantidade;
        this.velocidadeAtual = velocidadeNova;
}
// Devolver a marcha do carro
int pegaMarcha() {
        if (this.velocidadeAtual < 0 ) {
                return -1;
        }
        if (this.velocidadeAtual >= 0 && this.velocidadeAtual < 40) {
                return 1;
        }
        if (this.velocidadeAtual >= 40 && this.velocidadeAtual < 80) {
                return 2;
        }
        return 3;
}
}
