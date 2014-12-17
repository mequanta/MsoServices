Ext.define('Mso.view.tree.Workspace', {
    extend: 'Ext.tree.Panel',
    alias: 'widget.workspace',
    title: 'Workspace',

    initComponent: function() {
        Ext.apply(this, {
            store: Ext.create('Ext.data.TreeStore', {
                root: {
                    text: 'Solution'
                }
            })
        });
        this.callParent();
    }
});