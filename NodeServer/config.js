var Path = require('path')
module.exports = [
  { 
    packagePath: "./plugins/architect-http",
    port: process.env.PORT || 8082,
    host: process.env.IP || "0.0.0.0"
  },
  { 
    packagePath: "./plugins/architect-http-static", root: "www"
  },
//  "./plugins/calculator",
//  "./plugins/db",
//  "./plugins/auth",
  "./plugins/dummy",
  "./plugins/engine.io",
  { 
    packagePath: "./plugins/signalr",
    dllPath: Path.resolve(__dirname, "../Mso.SignalR/bin/Debug/Mso.SignalR.dll")
  }
]
