
$(document).ready(function () {

    // Variaveis
    const contaId = $("#contaId");
    const codigoConta = $("#codigoConta");
    const nomeConta = $("#nomeConta");

    // Captura os dados da conta armazenados no localstorage
    const dadosConta = JSON.parse(localStorage.getItem("dadosConta"));

    // Caso haja dados é preenchido os dados do dono da conta
    if (dadosConta.id != null && dadosConta.id != "") {
        contaId.val(dadosConta.id);
        codigoConta.text(dadosConta.codigo);
        nomeConta.text(dadosConta.nome);
    }
})

$("#btnSubmitFrmFiltroData").click((e) => {
    e.preventDefault();
    // Carrega todos os datetimes somente até a data de hoje
    const dataFiltro = $(".dataFiltro").val(); // Obtém o valor selecionado da data
    const hoje = moment(); // Obtém a data atual

    if (moment(dataFiltro).isAfter(hoje)) {
        $.toast({
            heading: 'Data inválida.',
            text: 'A data não pode ser maior que hoje.',
            position: 'top-right',
            icon: 'error'
        })
    } else {
        frmSearchData.submit();
    }
})
