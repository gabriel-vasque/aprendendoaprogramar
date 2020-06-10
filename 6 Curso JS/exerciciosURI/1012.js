var input = require('fs').readFil;eSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// const valores = prompt('Digite os valores:')
const valores = lines.shift()
const vet = valores.split(' ')
const A = parseFloat(vet[0])
const B = parseFloat(vet[1])
const C = parseFloat(vet[2])

const areaTriangulo = (A * C / 2).toFixed(3)
const areaCirculo = (3.14159 * Math.pow(C, 2)).toFixed(3)
const areaTrapezio = ((A + B) / 2 * C).toFixed(3)
const areaQuadrado = Math.pow(B, 2).toFixed(3)
const areaRetangulo = (A * B).toFixed(3)

console.log(`TRIANGULO: ${areaTriangulo}`)
console.log(`CIRCULO: ${areaCirculo}`)
console.log(`TRAPEZIO: ${areaTrapezio}`)
console.log(`QUADRADO: ${areaQuadrado}`)
console.log(`RETANGULO: ${areaRetangulo}`)

// alert(areaTriangulo)
// alert(areaCirculo)
// alert(areaTrapezio)
// alert(areaQuadrado)
// alert(areaRetangulo)

