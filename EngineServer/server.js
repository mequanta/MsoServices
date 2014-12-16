var engine = require('engine.io');
var http = require('http').createServer().listen(3000);
var server = engine.attach(http);

server.on('connection', function (socket) {
  console.log("connected!")
  socket.on('message', function(data){
    socket.send(data + "back!");
  });
  socket.on('close', function(){ });
});
