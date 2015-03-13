require([
    "dijit/layout/BorderContainer", "dijit/layout/ContentPane", "unico/menus",
    "dojo/domReady!"
], function(BorderContainer, ContentPane, menus, win){
    var bc = new BorderContainer({
       style: "height: 400px",
    });
    var toppanel = new ContentPane({
        id: "toppanel",
        region: "top",
        style: "width: 100px"
    });
    toppanel.addChild(menus);

    bc.addChild(toppanel);

    var cp1 = new ContentPane({
        region: "left",
        style: "width: 100px",
        content: "hello world"
    });
    bc.addChild(cp1);

    // create a ContentPane as the center pane in the BorderContainer
    var cp2 = new ContentPane({
        region: "center",
        content: "how are you?"
    });
    bc.addChild(cp2);

    // put the top level widget into the document, and then call startup()
    bc.placeAt("container");
    bc.startup();

});


