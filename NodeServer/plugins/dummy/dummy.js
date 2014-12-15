module.exports = function setup(options, imports, register) {
    var edge = require('edge');
    var path = require('path');
    var dllpath = path.join(__dirname, "/../../../Mso.EdgeJs/bin/Debug/Mso.EdgeJs.dll");
    var mso = edge.func(dllpath);

    var http = imports.http;
    var handler = function (req, res, next) {
        var params = { "service": "Dummy", "method": "GetInfo", "args": {} }
        mso(params, function (error, result) {
            if (error) throw error;
            res.end(result + "\n");
        });
    }

    http.get("/info", handler, register);
/*
    register(null, {
        dummy: {
            info: function(callback) {
                var params = { "service": "Dummy", "method": "GetInfo", "args": {} }
                mso(params, function (error, result) {
                    if (error) throw error;
                    callback(result);
                });
            }
        }
    });
*/
};
