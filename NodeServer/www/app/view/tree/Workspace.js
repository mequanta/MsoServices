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

     
     var contextMenu = new Ext.menu.Menu({
  items: [{
    text: 'Edit',
    iconCls: 'edit',
    handler: function() {}
  }]
});

      this.on('itemcontextmenu', function(view, record, item, index, event){
        contextMenu.showAt(event.getXY());
        event.stopEvent();
       },this);

       this.callParent();
    }
});
