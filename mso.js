define(function(require, exports, module) {
                   //       $.connection.hub.logging = true;
                var dummy = $.connection.dummyHub;
                dummy.client.sayBack = function(message) {
                    console.log(message);
                };
                $.connection.hub.start().done(function () {
                    console.log('SignalR connected [ID=' + $.connection.hub.id + '; Transport = ' + $.connection.hub.transport.name + ']');
                    dummy.server.say("hello");
                });
});

