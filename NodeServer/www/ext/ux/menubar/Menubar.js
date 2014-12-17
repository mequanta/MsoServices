Ext.define("Ext.ux.menubar.Menubar", {
    extend: 'Ext.toolbar.Toolbar',
    alias: 'widget.menubar',

    border: false,

/*    afterRender: function() {
        this.callParent();
        Array.forEach(this.items, function (item) {
            item.arrowVisible = false;
            item.focusable = false;
        })
    },*/

    onShow: function() {
        this.callParent();
        console.log(this.items.length);
        Array.forEach(this.items, function(item) {
            item.arrowVisible = false;
            item.focusable = false;
        })
    }
});