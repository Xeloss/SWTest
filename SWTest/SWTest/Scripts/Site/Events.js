$(document).ready(function () {

    $('#eventsTable').DataTable({
        "bServerSide": true,
        "sAjaxSource": "/Event/List",
        "aoColumns": [
            { "mData": "Title" },
            { "mData": "Tecnology" },
            { "mData": "StartingDate" },
            { "mData": "RegistrationLink" },
        ]
    });
});