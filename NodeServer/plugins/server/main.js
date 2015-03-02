define(function(require, exports, module) {
    main.consumes = ["connect", "connect.static"];
    main.provides = [];
    return main;

    function main(options, imports, register) {
        var Path = require("path");
        var connect = imports.connect;
        var api = require("frontdoor")();
        var owin = require("connect-owin");
        var querystring = require("querystring");

        connect.use(api);
        api.all("/signalr/*", function(req, res, next) {
            // A hack
            if (typeof req.body === 'object') {
                req.body = new Buffer(querystring.stringify(req.body));
            }
            owin(options.dllPath)(req, res, next);
        });

        var statics = imports["connect.static"];
        statics.addStatics([{
            path: Path.join(__dirname, "../../www"),
            mount: "/"
        }]);

        [
            'solution'
        ].forEach(function(name) {
            statics.addStatics([{
                path: __dirname + "/../../plugins/" + name,
                mount: "/lib/" + name
            }]);
        });
    }
});
