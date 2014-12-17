Ext.define('Mso.store.Providers', {
    extend: 'Ext.data.TreeStore',
    root: {
        text: 'Providers',
        expanded: true,
        children: [
            {
                text: 'DataProviders',
                children: [
                    {
                        text: 'DataSimulator',
                        leaf: true
                    },
                    {
                        text: 'TTFix',
                        leaf: true
                    }
                ]
            },
            {
                text: 'ExecutionProviders',
                children: [
                    {
                        text: 'ExecutionSimulator',
                        leaf: true
                    },
                    {
                        text: 'TTFix',
                        leaf: true
                    }
                ]
            },
            {
                text: 'HistoricalProviders',
                children: [
                    {
                        text: 'IQFeed',
                        leaf: true
                    },
                    {
                        text: 'Tws',
                        leaf: true
                    }
                ]
            },
            {
                text: 'NewsProviders',
                children: []
            }
        ]
    }
});