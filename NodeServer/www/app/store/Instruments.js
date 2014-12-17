Ext.define('Mso.store.Instruments', {
    extend: 'Ext.data.TreeStore',
    root: {
        text: 'Instruments',
        expanded: true,
        children: [
            {
                text: 'AAPL',
                leaf: true
            },
            {
                text: 'MSFT',
                leaf: true
            }
        ]
    }
});