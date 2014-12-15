#!/usr/bin/env node

var path = require('path');
var architect = require("architect");
var config = architect.loadConfig(path.join(__dirname, "config.js"));

architect.createApp(config, function (err, app) {
  if (err) throw err;
  console.log("App ready");
});
