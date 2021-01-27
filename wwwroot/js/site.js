// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function curtiu() {
    curtidas++;
    div_mens.innerHTML = `${curtidas}`;
    if (curtidas % 2 == 0) {
        imagem_curtida.src = "imgs/postAdicionado/coracaopintado.png"
        div_mens.innerHTML = `${2078}`
    } else {
        imagem_curtida.src = "imgs/postAdicionado/Vector.png"
        div_mens.innerHTML = `${2077}`
    }
}