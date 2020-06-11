const imprimir = texto => console.log(texto)

imprimir(typeof Object)
imprimir(typeof new Object())


const Cliente = function() {}
    imprimir(typeof Cliente)
    imprimir(typeof new Cliente)

    // Internamente a classe trata-se de uma função
    class Produto {}
    imprimir(typeof Produto)
    imprimir(typeof new Produto())
