
$(document).ready(function () {

    $('#particles').particleground({
        minSpeedX: 0.1,
        maxSpeedX: 0.1,
        minSpeedY: 0.1,
        maxSpeedY: 0.1,
        directionX: 'center',// 'center', 'left' or 'right'. 'center' = dots bounce off edges
        directionY: 'center',// 'center', 'up' or 'down'. 'center' = dots bounce off edges
        density: 10000,// How many particles will be generated: one particle every n pixels
        dotColor: '#666666',
        lineColor: '#666666',
        particleRadius: 7,// Dot size
        lineWidth: 1,
        curvedLines: false,
        proximity: 80,// How close two dots need to be before they join
        parallax: true,
        parallaxMultiplier: 5,// The lower the number, the more extreme the parallax effect
        onInit: function () { },
        onDestroy: function () { }
    });

    // Caso haja falha no cadastro da transação é mostrada uma mensagem de erro ao usuário
    const errorCreate = $("#errorCreate");
    if (errorCreate.text() != "") {
        $.toast({
            heading: 'Erro.',
            text: 'Falha ao cadastrar a transação.',
            position: 'top-center',
            icon: 'error'
        })
        errorCreate.text("");
    }

    // Faz com que o load da página sempre comece oculto
    $(".loadPage").css('display', 'none');

    // Configurações data-table
    $("#tableTransacoes").DataTable({
        order: [[0, 'desc']],
        language: {
            url: '//cdn.datatables.net/plug-ins/1.13.4/i18n/pt-BR.json',
        },
        pageLength: 5,
        lengthMenu: [5, 10, 25, 50, 100],
        "columnDefs": [
            { "className": "dt-right", "targets": "_all" }
        ]
    });


})

// Exibe o load da página
function Load() {
    $(".loadPage").css('display', 'block');
}



