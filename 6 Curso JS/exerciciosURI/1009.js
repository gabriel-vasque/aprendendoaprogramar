var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const nome = lines.shift()
const salarioFixo = parseFloat(lines.shift())
const vendaMes = parseFloat(lines.shift())

const ganhoMes = (salarioFixo + vendaMes * 0.15).toFixed(2)
console.log(`TOTAL = R$ ${ganhoMes}`)
