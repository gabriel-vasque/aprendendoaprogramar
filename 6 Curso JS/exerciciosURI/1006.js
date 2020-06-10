var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const A = parseFloat(lines.shift())
// const A = parseFloat(prompt('Digite a nota A: '))
const B = parseFloat(lines.shift())
// const B = parseFloat(prompt('Digite a nota B: '))
const C = parseFloat(lines.shift())
// const C = parseFloat(prompt('Digite a nota C: '))

const media = `MEDIA = ${((A * 2 + B * 3 + C * 5) / 10).toFixed(1)}`

// alert(media)
console.log(media)