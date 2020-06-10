var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const A = parseFloat(lines.shift())
// const A = parseFloat(prompt('Digite a nota A:'))
const B = parseFloat(lines.shift())
// const B = parseFloat(prompt('Digite a nota B:'))

const media = `MEDIA = ${((A * 3.5 + B * 7.5) / 11).toFixed(5)}`

// alert(media)
console.log(media)
