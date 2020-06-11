// var input = require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('\n');

// const raio = parseFloat(prompt('Digite a medida do raio: '))
// const raio = parseFloat(lines.shift())

// const area = 3.14159 * Math.pow(raio, 2)
// const resultado = `A=${area.toFixed(4)}`

// console.log(resultado)
// alert(resultado)

//-------------------------------------------------------------------
/**
 * 
 * @param {Number} raio 
 */
function calcularArea(raio) {
    return 3.14159 * Math.pow(raio, 2)
}

const raio1 = parseFloat(prompt('Digite a medida do raio:'))
alert(calcularArea(raio1).toFixed(4))
console.log(`A=${calcularArea(raio1).toFixed(4)}`)