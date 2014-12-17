Ext.define('Mso.view.tree.Instrument', {
    extend: 'Ext.tree.Panel',
    alias: 'widget.instrument',
    title: 'Instruments',

    initComponent: function () {
        Ext.apply(this, {
            store: Ext.create('Mso.store.Instruments'),
            tbar: [
                {
                    menu: [
                        {
                            text: "item1"
                        },
                        {
                            text: "item2"
                        },
                        {
                            text: 'item3'
                        }
                    ],
                    icon: null,
                    xtype: 'splitbutton',
                    glyph: 72
                },
                {
                    icon: null,
                    xtype: 'button',
                    glyph: 72
                }
            ]
        });
        this.callParent();
    }
});