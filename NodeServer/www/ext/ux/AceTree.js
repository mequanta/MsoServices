Ext.define("Ext.ux.AceTree", {
    extend: 'Ext.panel.Panel',
    alias: ['widget.acetree'],
    tree: null,
    dp: null,
    onRender: function () {
        var me = this;
        me.callParent(arguments);
        var div = me.body.dom;
       // div.className = "";
        require(['ace_tree/tree', 'solution/DataProvider'], function(Tree, TreeData) {
            this.tree = new Tree(div);

            var root = { items: [ { name: "Solution1", isFolder:true, isOpen:true, children: ["ch1", "chi2"] }]}    
            this.dp = new TreeData(root);
            this.tree.setDataProvider(this.dp);           
        });
    }
});
