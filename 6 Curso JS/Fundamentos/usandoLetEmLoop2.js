const imprimir = texto => console.log(texto)

const funcs = []

for (let i = 0; i < 10; i++) {
 funcs.push(function(){
     imprimir(i)
 })    
}

funcs[2]()
funcs[6]()
funcs[8]()