var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const A = parseFloat(lines.shift())
// const A = parseFloat(prompt('Digite A:'))
const B = parseFloat(lines.shift())
// const B = parseFloat(prompt('Digite B:'))
const C = parseFloat(lines.shift())
// const C = parseFloat(prompt('Digite C:'))
const D = parseFloat(lines.shift())
// const D = parseFloat(prompt('Digite D:'));

const diferenca = `DIFERENCA = ${A * B - C * D}`

// alert(diferenca)
console.log(diferenca)