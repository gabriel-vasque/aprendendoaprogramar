var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// const numero = parseInt(prompt('Digite o numer;o do funcionário'))
const numero = parseInt(lines.shift())
// const horasTrabalho = parseInt(prompt('Digite as horas trabalhadas'))
const horasTrabalho = parseInt(lines.shift())
// const ganhoHora = parseFloat(prompt('Digite o valor ganho por hora'))
const ganhoHora = parseFloat(lines.shift())

console.log(`NUMBER = ${numero}`)
const salario = (horasTrabalho * ganhoHora).toFixed(2)
console.log(`SALARY = U$ ${salario}`)