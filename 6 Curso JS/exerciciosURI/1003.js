// var input = require('fs').readFileSync('/dev/stdin', 'utf8')
// var lines = input.split('\n')

// let A = parseInt(lines.shift())
// let A = parseInt(prompt('Insira o valor de A:'))
// let B = parseInt(lines.shift())
// let B = parseInt(prompt('Insira o valor de B:'))

// let resultado = `SOMA = ${A + B}`
// alert(resultado);

// console.log(resultado)

//---------------------------------------------------------------

const valores = {}
valores.a = parseInt(prompt('Digite o valor de A:'))
valores.b = parseInt(prompt('Digite o valor de B:'))

/**
 * 
 * @param {typeof valores} asdf 
 */
function soma(asdf) {
    return asdf.a + asdf.b
}

alert(`SOMA = `)
console.log(`SOMA = ${soma(valores)}`)