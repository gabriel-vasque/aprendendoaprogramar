// var input = require('fs').readFil;eSync('/dev/stdin', 'utf8');
// var lines = input.split('\n');

// const valores = prompt('Digite os valores:')
// const valores = lines.shift()
// const vet = valores.split(' ')
// const A = parseFloat(vet[0])
// const B = parseFloat(vet[1])
// const C = parseFloat(vet[2])

// const areaTriangulo = (A * C / 2).toFixed(3)
// const areaCirculo = (3.14159 * Math.pow(C, 2)).toFixed(3)
// const areaTrapezio = ((A + B) / 2 * C).toFixed(3)
// const areaQuadrado = Math.pow(B, 2).toFixed(3)
// const areaRetangulo = (A * B).toFixed(3)

// console.log(`TRIANGULO: ${areaTriangulo}`)
// console.log(`CIRCULO: ${areaCirculo}`)
// console.log(`TRAPEZIO: ${areaTrapezio}`)
// console.log(`QUADRADO: ${areaQuadrado}`)
// console.log(`RETANGULO: ${areaRetangulo}`)

// alert(areaTriangulo)
// alert(areaCirculo)
// alert(areaTrapezio)
// alert(areaQuadrado)
// alert(areaRetangulo)

//-------------------------------------------------------------------------

const texto = prompt('Digite os valores para A, B e C respectivamente:').split(' ')
const valores = {
    a: parseFloat(texto[0]),
    b: parseFloat(texto[1]),
    c: parseFloat(texto[2])
}
const Geometria = {
    TRIANGULO: 'TRIANGULO',
    CIRCULO: 'CIRCULO',
    TRAPEZIO: 'TRAPEZIO',
    QUADRADO: 'QUADRADO',
    RETANGULO: 'RETANGULO',
    PENTAGONO: 'PENTAGONO'
}

/**
 * 
 * @param {typeof valores} valores 
 * @param {String} texto 
 */
function CalcularArea(valores, texto) {
    let { a, b, c } = valores
    debugger
    switch (texto) {
        case Geometria.TRIANGULO:
            return a * c / 2
        case Geometria.CIRCULO:
            return 3.14159 * Math.pow(c, 2)
        case Geometria.TRAPEZIO:
            return (a + b) * c / 2
        case Geometria.QUADRADO:
            return Math.pow(b, 2)
        case Geometria.RETANGULO:
            return a * b
        case Geometria.PENTAGONO:
            return 0
    }
}

/**
 * @param {typeof valores} valores 
 * @param {String} figura 
 */
function CalcularEImprimirArea(valores, figura) {
    const resultado = `${figura}: ${CalcularArea(valores, figura).toFixed(3)}`
    console.log(resultado)
}

CalcularEImprimirArea(valores, Geometria.TRIANGULO)
CalcularEImprimirArea(valores, Geometria.CIRCULO)
CalcularEImprimirArea(valores, Geometria.TRAPEZIO)
CalcularEImprimirArea(valores, Geometria.QUADRADO)
CalcularEImprimirArea(valores, Geometria.RETANGULO)
