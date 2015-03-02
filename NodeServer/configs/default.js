var port = process.env.PORT || 8082;
var Path = require("path");
module.exports = [{
    packagePath: "../node_modules/connect-architect/connect",
    port: port,
    host: process.env.IP || "0.0.0.0"
}, {
    packagePath: "../node_modules/connect-architect/connect.static",
    prefix: "/"
}, {
    packagePath: "../plugins/server",
    dllPath: Path.join(__dirname, "../../Mso.SignalR/bin/Debug/Mso.Signal.dll")
}];
