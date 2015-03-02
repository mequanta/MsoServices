Ext.define("Ext.ux.AceTree", {
    extend: 'Ext.panel.Panel',
    alias: ['widget.acetree'],
    tree: null,
    dp: null,
    onRender: function () {
        var me = this;
        me.callParent(arguments);
        var div = me.getEl().dom;
        require(['ace_tree/tree', 'solution/DataProvider'], function(Tree, TreeData) {
            this.tree = new Tree(div);                
            this.dp = new TreeData(["data1","data2"]);
            this.tree.setDataProvider(this.dp);           
        });
    }
});
