var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// const raio = parseFloat(prompt('Digite a medida do raio: '))
const raio = parseFloat(lines.shift())

const area = 3.14159 * Math.pow(raio, 2)
const resultado = `A=${area.toFixed(4)}`

console.log(resultado)
// alert(resultado)