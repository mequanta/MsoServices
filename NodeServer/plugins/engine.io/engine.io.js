module.exports = function setup(options, imports, register) {
  var http = imports.http.server ;
  var engine = require('engine.io');
  var server = engine.attach(http);
  
  register(null, {
      eio: {
        "server": server
      }
  });
};
