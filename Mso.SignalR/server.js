﻿var owin = require('connect-owin')
var connect = require('connect')
var express = require('express')

var app = express();
//app.use(connect.logger('dev'));
app.all('/signalr/*', owin(__dirname + '/bin/Debug/Mso.SignalR.dll'));
app.use(express.static(__dirname));
app.listen(3000);
