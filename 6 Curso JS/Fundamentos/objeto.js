//Objeto é uma coleção de chaves / valores

const prod1 = {}
prod1.nome = 'Celular Ultra Mega' 
prod1.preco = 4998.90
prod1['Desconto Legal'] = 0.40 // Evitar atributos com espaço

console.log(prod1)

const prod2 = {
    nome: 'Camisa Polo',
    preco: 79.90,
    obj: {
        blablabla: 1,
        obj: {
            blablabla: 2
        }
    }
}

console.log(prod2)
console.log(prod2.obj.obj.blablabla)
