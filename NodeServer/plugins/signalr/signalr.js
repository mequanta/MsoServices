module.exports = function setup(options, imports, register) {
  var http = imports.http.server ;
  var connection;

  register(null, {
    signalr: {
      "connection": connection
    }
  });
};
