;

function addInfo(info) {
    $('#Infos').html('<span>' + info + '</span><br />');
}

$(function () {
    var connection = $.connection.hub,
        hub = $.connection.sendInfoHub,
        info = $('#Info'),
        userId = $('#userId');

    connection.logging = true;

    hub.client.addinfo = function (value) {
        addInfo(value);
    }

    connection.start()
        .done(function () {
        })
        .fail(function (error) {
        });

    $('#Send').click(function () {
        hub.server.sendAll(info.val());
    });
});