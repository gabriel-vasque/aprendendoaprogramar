// var input = require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('\n');

// const A = parseFloat(lines.shift())
// // const A = parseFloat(prompt('Digite a nota A: '))
// const B = parseFloat(lines.shift())
// const B = parseFloat(prompt('Digite a nota B: '))
// const C = parseFloat(lines.shift())
// const C = parseFloat(prompt('Digite a nota C: '))

// const media = `MEDIA = ${((A * 2 + B * 3 + C * 5) / 10).toFixed(1)}`

// alert(media)
// console.log(media)

//----------------------------------------------------------------------------------

const notas = {
    notaA: {
        peso: 2
    },

    notaB: {
        peso: 3
    },

    notaC: {
        peso: 5
    }
}

notas.notaA.valor = parseFloat(prompt('Digite o valor de A:'))
notas.notaB.valor = parseFloat(prompt('Digite o valor de B:'))
notas.notaC.valor = parseFloat(prompt('Digite o valor de C:'))

/**
 * @param {typeof notas} calcularMedia 
 */
function calcularMedia(notas) {
    let { notaA: { valor: a, peso: pA }, notaB: { valor: b, peso: pB }, notaC: { valor: c, peso: pC } } = notas
    let media = (a * pA + b * pB + c * pC) / (pA + pB + pC)
    return `MEDIA = ${media}`
}

alert(calcularMedia(notas))
console.log(calcularMedia(notas))