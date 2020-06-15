function tratarErroELancar(erro) {
    throw new Error('playstation guy')
}

function imprimirNomeGritado(obj) {
    try{
        console.log(obj.name.toUpperCase() + '!!!')
    } catch (e) {
        tratarErroELancar(e)
    } finally {
        console.log('final')
    }s
}

const obj = { name: 'Nas crianças Gezuxx' }
imprimirNomeGritado(obj)