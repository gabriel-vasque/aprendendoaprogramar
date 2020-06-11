const pessoa = {
    nome: 'Ana',
    idade: 5,
    endereco: {
        logradouro: 'Rua ABC',
        numero: 1000
    } 
}

const { nome, idade } = pessoa
console.log(nome, idade)

const { nome: n, idade: i } = pessoa
console.log(n, i)

const { sobrenome, bemHumorada = true } = pessoa
console.log(sobrenome, bemHumorada) 

const{ endereco: { logradouro, numero, cep } } = pessoa
console.log(logradouro, numero, cep)

const pessoa = {}
pessoa.nome = 'Maria'
pessoa.idade = 25
pessoa.endereco = {
    logradouro:'Rua XYZ',
    numero: 36,
    bairro: 'Vila ABC',
    cep: 1010
}

pessoa.idade = 26
pessoa.endereco.logradouro = 'Rua QWE'
pessoa.endereco.numero = 1000
pessoa.endereco.bairro = 'Vila Arroz'
console.log(pessoa)

let { endereco: { logradouro: l, numero: n, bairro: b, cep: c } } = pessoa
l = 'Rua 1'
n = 36
b = 'Vila Cearense'
c = 7070
console.log(pessoa, l, n, b, c)

let { endereco: e} = pessoa
e = {
    logradouro:'Rua 1',
    numero: 50,
    bairro: 'Vila ABCEF',
    cep: 10107588558
}
console.log(pessoa)