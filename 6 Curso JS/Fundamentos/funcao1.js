/**
 * função:
 * bloco de codigo, com ou sem nome. 
 * recebe parametros de entrada
 * tem um algoritmo que executa umprocesso sempre igual
 * pode conter ou não dados de entrada e saída
 * pode ser reutilizada e invodada quntas vezes for necessário
 * classes também são funções
*/

// Função sem retorno
function imprimirSoma(a, b) {
    console.log(a + b)
}

// chamando uma função
imprimirSoma(2, 3)

imprimirSoma(2)

// ignora o exesso
imprimirSoma(2, 10, 4, 5, 6, 7,)

imprimirSoma()

// Função com retorno

function soma(a, b = 0) {
    return a + b
}

console.log(soma(2, 3))
console.log(soma(2))
console.log(soma())