//atribuição por referência

const a = {name: 'Teste'}
const b = a
b.name = "Opa"
console.log(a.name)

/* b recebeu apenas o endereço de a,
*  por isso a.name foou alterada através de b
*/

let valor // = undefined = não foi instanciada/inicializada
//console.log(valor) // = is not dfined = não foi declarada

// não está apontando para nenhum endereço de memória
// ou seja, ausência de valor
valor = null 
console.log(valor)
// console.log(valor.toSreng()) //Erro!

const produto = {}
console.log(produto.preco)
console.log(produto)

produto.preco = 3.50
console.log(produto)

produto.preco = undefined // evitar atribuir endefined
console.log(!!produto.preco) 
console.log(produto)

produto.preco = null // sem preço
console.log(!!produto.preco)
console.log(produto)