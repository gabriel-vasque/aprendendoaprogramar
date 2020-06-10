var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const A = parseFloat(lines.shift())
// const A = parseFloat(prompt('Digite A:  '))
const B = parseFloat(lines.shift())
// const B = parseFloat(prompt('Digite B:  '))

const resultado = `PROD = ${A * B}`

// alert(resultado)
console.log(resultado)