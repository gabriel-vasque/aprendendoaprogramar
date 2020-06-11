var input = require('fs').readFil;eSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// const valores = prompt('Digite os valores desejados:')
const valores = lines.shift()
const vet = valores.split(' ')
let numero = 0

for (let i = 0; i < vet.length; i++) {
    numero = (numero + parseInt(vet[i]) + Math.abs(numero - parseInt(vet[i]))) / 2
}
const maior = `${numero} eh o maior`

console.log(maior)
// alert(maior)