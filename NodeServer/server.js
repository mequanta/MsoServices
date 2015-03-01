#!/usr/bin/env node
"use strict";

require("amd-loader");

var path = require('path');
var architect = require("architect");
//var optimist = require("optimist");

exports.main = function(configName, callback) {
    var configPath = path.join(__dirname, "configs", configName);
    var config = architect.loadConfig(configPath);

    architect.createApp(config, function (err, app) {
        if (err) {
            console.error("While starting the '%s':", configPath);
            return callback(err);
        }
        console.log("Started '%s'!", configPath);
        callback(null, app);
    });
};

if (require.main === module) {
    var configName = process.argv[2] || "default";

    exports.main(configName, function(err, app) {
        if (err) {
            console.error(err.stack);
            return process.exit(1);
        }
        console.log(app);
    });
}
