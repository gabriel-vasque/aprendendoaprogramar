let isAtivo = false
console.log(isAtivo)

isAtivo = true
console.log(isAtivo)

//não reconhece isAtivo como boolen
isAtivo = 1
console.log(!!isAtivo)
//para inteiros, uma ! nega a variável, e !! retorna o valor dela

//os verdadeiros...

console.log('retornam valor verdadeiro...')
console.log(!!3)
console.log(!!-1)
console.log(!!' ')
console.log(!![])
console.log(!!{})
console.log(!!Infinity)
console.log(!!(isAtivo = true))

//os falsos...

console.log('retornam valor falso...')
console.log(!!0)
console.log(!!'')
console.log(!!null)
console.log(!!NaN)
console.log(!!undefined)
console.log(!!(isAtivo = false))

//resolve o lado direito se o esquerso for falso

console.log('pra finalizar...')

//retorna verdadeiro se algum dos valores for verdadeiro
console.log(!!('' || null || 0 || 'epa'))

//retorna o primeiro valor verdadeiro
console.log('' || null || 0 || 'epa' || 123)

let nome = 'Pedro'
console.log(nome || 'Desconhecido')
nome = 'Lucas'
console.log(nome || 'Desconhecido')
nome = ''
console.log(nome || 'Desconhecido')


