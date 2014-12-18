module.exports = function setup(options, imports, register) {
  var http = imports.http.server
﻿  var owin = require('connect-owin')
  var handler = owin(options.dllPath)
//  var connect = require('connect')
  var express = require('express')
 // var app = express();

  var app = http.createServer(express());
  app.all('/signalr/*', handler);
 // http.get("/signalr", handler, register)
 // http.put("/signalr", handler, register)
//  http.post("/signalr", handler, register)
//  http.del("/signalr", handler, register)
};
