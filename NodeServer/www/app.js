Ext.Loader.setPath('Ext.ux', 'ext/ux');
Ext.require([
  'Ext.ux.form.field.Ace',
  'Ext.ux.form.field.CodeMirror',
  'Ext.ux.HighStock' 
]);

Ext.application({
  extend: 'Ext.app.Application',
  name: "Mso",
  autoCreateViewport: 'Mso.view.main.Main',
    
  launch: function() {
    var socket = new eio.Socket('ws://localhost/');
    socket.on('open', function() {
      console.log("eio opened!");
      socket.send("hi");
      socket.on('message', function(data) {
      
      });
      socket.on('close', function(){});
    });



            $.connection.hub.logging = true;

            // Declare a proxy to reference the hub.
            var dummy = $.connection.dummyHub;

            // Create a function that the hub can call to broadcast messages.
            dummy.client.addMessage = function (name, message) {
                // Html encode display name and message.
                var encodedName = $('<div />').text(name).html();
                var encodedMsg = $('<div />').text(message).html();
                // Add the message to the page.
                $('#discussion').append('<li><strong>' + encodedName
                    + '</strong>:&nbsp;&nbsp;' + encodedMsg + '</li>');
            };
            // Get the user name and store it to prepend to messages.
            $('#displayname').val(prompt('Enter your name:', ''));
            // Set initial focus to message input box.
            $('#message').focus();
            // Start the connection.
            $.connection.hub.start().done(function () {
                console.log('SignalR connected [ID=' + $.connection.hub.id + '; Transport = ' + $.connection.hub.transport.name + ']');
                $('#sendmessage').click(function () {
                    // Call the Send method on the hub.
                    dummy.server.send($('#displayname').val(), $('#message').val());
                    // Clear text box and reset focus for next comment.
                    $('#message').val('').focus();
                });
            });

  }
});
