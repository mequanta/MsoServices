define([
    "dijit/MenuBar",
    "dijit/PopupMenuBarItem",
    "dijit/Menu",
    "dijit/MenuItem",
    "dijit/DropDownMenu",
], function(MenuBar, PopupMenuBarItem, Menu, MenuItem, DropDownMenu){
    var pMenuBar = new MenuBar({});

    var pSubMenu = new DropDownMenu({});
    pSubMenu.addChild(new MenuItem({
        label: "File item #1"
    }));
    pSubMenu.addChild(new MenuItem({
        label: "File item #2"
    }));
    pMenuBar.addChild(new PopupMenuBarItem({
        label: "File",
        popup: pSubMenu
    }));

    var pSubMenu2 = new DropDownMenu({});
    pSubMenu2.addChild(new MenuItem({
        label: "Cut",
        iconClass: "dijitEditorIcon dijitEditorIconCut"
    }));
    pSubMenu2.addChild(new MenuItem({
        label: "Copy",
        iconClass: "dijitEditorIcon dijitEditorIconCopy"
    }));
    pSubMenu2.addChild(new MenuItem({
        label: "Paste",
        iconClass: "dijitEditorIcon dijitEditorIconPaste"
    }));
    pMenuBar.addChild(new PopupMenuBarItem({
        label: "Edit",
        popup: pSubMenu2
    }));
    return pMenuBar
  //  pMenuBar.placeAt("wrapper");
  //  pMenuBar.startup();
});
