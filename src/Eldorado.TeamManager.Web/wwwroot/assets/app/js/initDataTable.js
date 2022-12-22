function initDataTable(tableId) {
    $('#' + tableId).DataTable({
        pagingType: "simple",
        language: {
            lengthMenu: 'Exibir _MENU_',
            zeroRecords: 'Nenhum registro localizado',
            info: 'Página _PAGE_ de _PAGES_',
            infoEmpty: 'Nenhum registro cadastrado',
            infoFiltered: '(filtrado de _MAX_ registros)',
            search: "Filtrar Por:",
            loadingRecords: "Carregando...",
            paginate: {
                first: "Primeira",
                last: "Última",
                next: "Próxima",
                previous: "Anterior"
            },
            aria: {
                sortAscending: ": ativar ordenação por coluna em ordem crescente",
                sortDescending: ": ativar ordenação por coluna decrescente"
            }
        },
    });
}