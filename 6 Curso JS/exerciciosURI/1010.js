var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// let texto = prompt('Valores')
let texto = lines.shift()
let vet = texto.split(' ')
const codigoPeca1 = parseInt(vet[0])
const quantidadePeca1 = parseInt(vet[1])
const valorUnitario1 = parseFloat(vet[2])

// tecto = prompt('Valores')
texto = lines.shift()
vet = texto.split(' ')
const codigoPeca2 = parseInt(vet[0])
const quantidadePeca2 = parseInt(vet[1])
const valorUnitario2 = parseFloat(vet[2])

const valor = (valorUnitario1 * quantidadePeca1 + valorUnitario2 * quantidadePeca2).toFixed(2)
const valorPagar = String(`VALOR A PAGAR: R$ ${valor}`)

// alert(valorPagar)
console.log(valorPagar)
