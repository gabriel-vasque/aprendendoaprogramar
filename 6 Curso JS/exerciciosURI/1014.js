var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// const distancia = parseInt(prompt('Digite a distância percorrida'))
const distancia = parseInt(lines.shift())
// const gastoCombustivel = parseFloat(prompt('Digite quantos litros de combutivel foi gasto'))
const gastoCombustivel = parseFloat(lines.shift())

const consumoMedio = distancia / gastoCombustivel
const resultado = `${consumoMedio.toFixed(3)} km/l`

// alert(resultado)
console.log(resultado)