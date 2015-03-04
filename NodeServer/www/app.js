require.config({
    baseUrl:'lib',
    paths: {
        "jquery": 'jquery/jquery',
        "jquery.signalR": 'signalr/jquery.signalR',
        "highstock": "highstock-release/highstock",
        "codemirror": "codemirror/codemirror",
        "extjs": "mso-extjs/ext-all",
        "extjs-theme-crisp": "mso-extjs-theme-crisp/ext-theme-crisp",
        "ace": "ace/lib/ace",
        "ace_tree": "ace_tree/lib/ace_tree",
        "mso": "mso"
    },
    shim: {
        'jquery.signalR': ['jquery'],
        '/signalr/hubs': ['jquery.signalR'],
        'ace_tree': ['ace'],
    },
    map: {
        '*': {
            'css': 'require-css/css',
            'less': 'require-less/less'
        }
    },
    waitSeconds: 30
});

        require(["/signalr/hubs"], function() {
        });

require(["extjs", "ace/ace"], function() {
    require(["extjs-theme-crisp", "highstock"], function() {
        Ext.Loader.setPath('Ext.ux', 'ext/ux');
        Ext.require([
            'Ext.ux.form.field.Ace',
            'Ext.ux.form.field.CodeMirror',
            'Ext.ux.HighStock'
        ]);

        Ext.application({
            extend: 'Ext.app.Application',
            name: "Mso",
            autoCreateViewport: 'Mso.view.main.Main',

            launch: function() {
                Ext.onReady(function() {
                    //require(["ace_tree/tree"]);
                    //require(["mso.js"]);
                });
            }
        });
    });
});
