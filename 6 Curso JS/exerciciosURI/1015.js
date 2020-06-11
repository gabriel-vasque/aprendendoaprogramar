var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const pontos = []

for (let i = 0; i < 2; i++) {
    // const info = prompt('Digite os valores')
    const info = lines.shift()
    const vet = info.split(' ')
    const p = {}
    p.x = parseFloat(vet[0])
    p.y = parseFloat(vet[1])
    pontos.push(p)
}

let distancia = Math.pow(pontos[1].x - pontos[0].x, 2)
distancia += Math.pow(pontos[1].y - pontos[0].y, 2)
distancia = Math.sqrt(distancia)

const resultado = distancia.toFixed(4)

// alert(resultado)
console.log(resultado)