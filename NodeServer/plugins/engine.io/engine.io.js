module.exports = function setup(options, imports, register) {
  var http = imports.http.server ;
  var engine = require('engine.io');
  var server = engine.attach(http);
  server.on('connection', function(socket) {
    //console.log("engine.io connected!");
    socket.on('message', function(data) {
    });
    socket.on('close', function(){
      //console.log("engine.io closed!")
    });
  });

  register(null, {
      eio: {
        "server": server
      }
  });
};
