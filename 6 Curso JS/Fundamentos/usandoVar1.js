/**
 * var é visível mesmo fora do seu bloco 
 * exerção do bloco de função específica
 * por isso variáveis var podem ser redeclaradas
 * as variáveis var são do tipo global, pois cria confusão
 */

const imprimir = texto => console.log(texto)

{
    {
        {
            { var sera = 'Será??????' }
        }
    }
}

imprimir(sera)

/**
 * variáveis var criadas dentro de uma função são do tipo local
 */

function teste() {
    var local = 123
    console.log(local)
}
teste()
console.log(local)