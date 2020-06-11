// par nome/valor
const saudacao = 'Opa' //contexto léxico 1

/**
 * local o qual minha variável foi definida fisicamente no código
 * em que local a variável está armazenada
 */

 function exec() {
     const saudacao = 'Falaa' // contexto léxico 2
     return saudacao
 }


 // Objetos são grupos aninhados de pares nome/valor
 const cliente = {
     nome: 'Pedro',
    idade: 32,
    peso: 90,
    endereco: {
        logradouro: 'Rua Muito Legal',
        numero: 123
    }
 }

 console.log(saudacao)
 console.log(exec())