// var input = require('fs').readFileSync('/dev/stdin', 'utf8');
// var lines = input.split('\n');

// let texto = prompt('Valores')
// let texto = lines.shift()
// let vet = texto.split(' ')
// const codigoPeca1 = parseInt(vet[0])
// const quantidadePeca1 = parseInt(vet[1])
// const valorUnitario1 = parseFloat(vet[2])

// tecto = prompt('Valores')
// texto = lines.shift()
// vet = texto.split(' ')
// const codigoPeca2 = parseInt(vet[0])
// const quantidadePeca2 = parseInt(vet[1])
// const valorUnitario2 = parseFloat(vet[2])

// const valor = (valorUnitario1 * quantidadePeca1 + valorUnitario2 * quantidadePeca2).toFixed(2)
// const valorPagar = String(`VALOR A PAGAR: R$ ${valor}`)

// alert(valorPagar)
// console.log(valorPagar)

//-----------------------------------------------------------------------------------------------------

const Int = (texto) => (parseInt(texto)) 
const Float = (texto) => (parseFloat(texto))

function LerItens() {
        let texto = prompt('Digite as informações do produto').split(' ')
        let obj = {
        cod: Int(texto[0]),
        qtd: Int(texto[1]),
        vUnt: Float(texto[2])
    }
    return obj
}

/**
 * 
 * @param {Array} itens 
 */
function CalcularTotal(itens) {
    let valorPagar = 0
    for (let i = 0; i < itens.length; i++) {
        valorPagar += itens[i].qtd * itens[i].vUnt
    }
    return valorPagar
}
// debugger
const itens = []
for (let i = 0; i < 2; i++) {
    itens.push(LerItens())
}

const resultado = `VALOR A PAGAR: R$ ${CalcularTotal(itens).toFixed(2)}`
alert(resultado)
console.log(resultado)