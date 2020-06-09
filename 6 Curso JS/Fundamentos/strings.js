const escola = "Cod3r"

//busca um valor pelo indice
console.log(escola.charAt(4))

//não retorna nada, pois o indece esta fora da palavra
console.log(escola.charAt(5))

//retorna o valor do caractere na tabela ASCII
console.log(escola.charCodeAt(3))

//retorna a posição index do caracter fornecido
console.log(escola.indexOf('3'))

//retorna a string a partir do index forneciso
console.log(escola.substring(1))

//retorna a string apartir do index fornecido até a quantidade oferecida
console.log(escola.substring(0, 3))

//concatena strings em cadeia
console.log('Escola '.concat(escola).concat("!"))

//substitui o index 3 pela letra e 
console.log(escola.replace(3, 'e'))

//converte string em array
console.log('Ana,Maria,Pedro'.split(','))