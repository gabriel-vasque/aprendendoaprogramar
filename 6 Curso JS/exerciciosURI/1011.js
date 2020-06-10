var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// const raio = parseFloat(prompt('Digite o valor do raio:'))
const raio = parseFloat(lines.shift())

const formula = 4 / 3.0 * 3.14159 * Math.pow(raio, 3)

const volume = `VOLUME = ${formula.toFixed(3)}`

// alert(volume)
console.log(volume)