$(document).ready(function () {

    var fnServerData = function (sSource, aoData, fnCallback, oSettings) {

        //We remove the sEcho from the original data set.
        var echo = null;
        for (var i = 0; i < aoData.length; i++) {

            if (aoData[i].name === 'sEcho') {
                echo = aoData[i].value;
                aoData.splice(i, 1);
                break;
            }

        }

        //We keep the value of sEcho in the following closure, that will 
        //be executed once the server responds.
        var closuredCallback = function (json) {
            json.sEcho = echo;
            fnCallback(json);
        }

        $.fn.dataTable.defaults.fnServerData(sSource, aoData, closuredCallback, oSettings);
    };

    $('#eventsTable').DataTable({
        "bServerSide": true,
        "sAjaxSource": "/Event/List",
        "aoColumns": [
            { "mData": "Title" },
            { "mData": "Tecnology" },
            { "mData": "StartingDate" },
            { "mData": "RegistrationLink" },
        ],
        "fnServerData": fnServerData
    });

});