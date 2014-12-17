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
  }
});
