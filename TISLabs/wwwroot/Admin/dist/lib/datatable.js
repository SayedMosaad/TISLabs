$(function () {
    $("#datatable").DataTable({
        dom: 'Bfrtip',
        "responsive": true, "lengthChange": false, "autoWidth": false
        /*,"buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]*/
    }).buttons().container().appendTo('#datatable_wrapper .col-md-8:eq(0)');

    $('.datatable').DataTable({
        dom: 'Bfrtip',
        "buttons": ["excel"],
        "paging": true,
        "lengthChange": false,
        "searching": false,
        "ordering": true,
        "autoWidth": false,
        "pageLength": 30,
        "responsive": true
    });
});
