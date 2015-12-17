$(document).ready(function() {
    var tableLenght = $('#tableConf thead th').length;
    var table = $('#tableConf').DataTable( {
        "columnDefs": [
            {
                "targets": [tableLenght-1],
                "searchable": false,
                "orderable": false
            }
        ]
    });

    $("#tableConf tfoot th").each(function () {
        if ($(this).index() !== (tableLenght-1))
        {
            var title = $("#tableConf thead tr").eq($(this).index()).text();
            $(trim(title));
            $(this).html('<input type="text" placeholder="D' + title + '" />');
        }
    });

    table.columns().eq(0).each(function(colIdx) {
        $("input", table.column(colIdx).footer()).on("keyup change", function() {
            table
                .column(colIdx)
                .search(this.value)
                .draw();
        });
    });
})