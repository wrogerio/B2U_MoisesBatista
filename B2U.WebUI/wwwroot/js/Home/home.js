const btnOpenModalSelectContas = $("#btnOpenModalSelectContas");
const modalSelectContas = $("#modalSelectContas");
const frmSelectContas = $("#frmSelectContas");
const btnSubmitFormSelectContas = $("#btnSubmitFormSelectContas");
const btnCloseModalSelectContas = $("#btnCloseModalSelectContas");
var valSelecionado = null;
var idConta = "";

// Botão que abre o modal
btnOpenModalSelectContas.click((e) => {
    modalSelectContas.show();
});

btnCloseModalSelectContas.click((e) => {
    modalSelectContas.hide();
    $("#contaId").val("Selecione...");
    btnSubmitFormSelectContas.attr('disabled', 'disabled');
})

$(document).ready(function () {
    localStorage.clear();

    // Ao iniciar, o botão de pesquisa será bloqueado até que selecione uma conta
    btnSubmitFormSelectContas.attr('disabled', 'disabled');

    frmSelectContas.change((e) => {
        idConta = e.target.value;

        // Caso seja selecionado um valor, o botão de pesquisa é liberado
        if (idConta != "Selecione...") {
            btnSubmitFormSelectContas.removeAttr('disabled', 'disabled');
            valSelecionado = idConta
        }

        // Requisicao para capturarmos os dados da conta selecionada
        $.ajax({
            url: "Transacoes/GetDetalhesConta",
            type: "POST",
            dataType: "json",
            data: { contaId: idConta },
            success: function (data) {
                localStorage.setItem("dadosConta", JSON.stringify(data));
            },
            error: function (data) {
                console.log(data);
            }
        })

    })

    // Caso tente submitar sem selecionar um valor exibe alerta
    btnSubmitFormSelectContas.click((e) => {
        e.preventDefault();
        if (valSelecionado == null) {
            $.toast({
                heading: 'Erro ao pesquisar uma conta.',
                text: 'Selecione uma conta.',
                position: 'top-right',
                icon: 'error'
            })
        }
        else {
            modalSelectContas.hide();
            $(".loadPage").css('display', 'block');
            setTimeout(() => {
                frmSelectContas.submit();
            }, 600);
        }
    });
});