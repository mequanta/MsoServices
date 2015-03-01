define(function (require, exports, module) {
    var dummy = $.connection.dummyHub;
    dummy.client.sayBack = function (message) {
        console.log(message);
    };
    $.connection.hub.start().done(function () {
        console.log('SignalR connected [ID=' + $.connection.hub.id + '; Transport = ' + $.connection.hub.transport.name + ']');
        dummy.server.say("hello");
    });

    var md = $.connection.monoDevelopHub;
    md.server.getSolutionItems("./");
});

