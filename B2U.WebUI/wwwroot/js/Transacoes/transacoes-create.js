
// Variaveis
const historicoField = $("#Historico");
const dataField = $("#Data");
const DebitoField = $("#Debito");
const CreditoField = $("#Credito");
const NotasField = $("#Notas");
const CategoriaIdField = $("#CategoriaId");
const frmCadastroTransacao = $("#frmCadastroTransacao");

$(document).ready(function () {

    // Capturando os dados da conta armazenados no localstorage, para utilizar em outros lugares da página
    var dadosConta = JSON.parse(localStorage.getItem("dadosConta"));
    if (dadosConta != null && dadosConta != "") {
        $("#contaId").val(dadosConta.id);
        $("#contaIdVoltar").val(dadosConta.id);

        // definindo o valor dos campos number como 0
        if ($("#chkCredito").is(":checked")) {
            $("#Debito").val(0)
        } else if ($("#chkDebito").is(':checked')) {
            $("#Credito").val(0)
        }
    }
})

// Caso selecione crédito as funções do débito são bloqueadas
$("#chkCredito").click(() => {
    if ($("#chkCredito").is(":checked")) {
        $("#chkDebito").prop("checked", false);
        $("#Debito").prop("disabled", true).val(0);
        $("#Credito").prop("disabled", false).focus().val('');
    }
    else {
        $("#chkDebito").prop("checked", true);
        $("#Debito").prop("disabled", false).focus().val('');
        $("#Credito").prop("disabled", true).val('');
    }
})

// Caso selecione crédito as funções do crédito são bloqueadas
$("#chkDebito").click(() => {
    if ($("#chkDebito").is(":checked")) {
        $("#chkCredito").prop("checked", false);
        $("#Debito").prop("disabled", false).focus().val('');
        $("#Credito").prop("disabled", true).val(0);
    }
    else {
        $("#chkCredito").prop("checked", true);
        $("#Debito").prop("disabled", true).val('');
        $("#Credito").prop("disabled", false).focus().val('');
    }
})

$("#btnSubmitTransacao").click((e) => {
    e.preventDefault();
    // Carrega todos os datetimes somente até a data de hoje
    const dataFiltro = $(".dataFiltro").val(); // Obtém o valor selecionado da data
    const hoje = moment(); // Obtém a data atual

    // Ao submitar o formulário, verifica-se se todos os campos foram preenchidos
    if (historicoField.val() === "" || dataField.val() === "" || DebitoField.val() === "" || CreditoField.val() == "" || NotasField.val() === "" || CategoriaIdField.val() === "Selecione...") {
        $.toast({
            heading: 'Erro ao validar o formulário.',
            text: 'Preencha todos os campos.',
            position: 'top-right',
            icon: 'error'
        })
    } else if (moment(dataFiltro).isAfter(hoje)) {
        $.toast({
            heading: 'Data inválida.',
            text: 'A data não pode ser maior que hoje.',
            position: 'top-right',
            icon: 'error'
        })
    } else {
        frmCadastroTransacao.submit();
    }
})
