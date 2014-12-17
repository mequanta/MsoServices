Ext.define('Mso.view.main.Main', {
    extend: 'Ext.container.Container',
    xtype: 'app-main',
    layout: 'border',

    requires: [
        'Mso.store.Instruments',
        'Mso.view.tree.Workspace',
        'Mso.view.tree.Instrument',
        'Ext.ux.menubar.Menubar'
    ],

    items: [
        {
            region: 'north',
            xtype: 'panel',
            layout: {
                type: 'hbox',
                align: 'center'
            },
            cls: 'appBanner',
            items: [
                {
                    padding: 5,
                    html: "<b>Mequanta Studio Online</b>",

                },
                {
                    xtype: 'panel',
                    layout: {
                        type: 'vbox',
                        align: 'stretch'
                    },
                    flex: 1,
                    items: [
                        {
                          xtype: "menubar",
                            items: [
                                {
                                    text: 'File',
                                    menu: {
                                        items: [
                                            {
                                                text: 'Save'
                                            },
                                            {
                                                text: 'Load'
                                            }
                                        ]
                                    }
                                },'->',
                                {
                                    text: 'Help'
                                }
                            ]
                        },
/*                        {
                            xtype: "toolbar",

                            items: [
                                {
                                    text: "File",
                                   // arrowVisible: false,
                                    focusable: false,
                                    menu: {
                                        items: [
                                            {
                                                text: 'Save'
                                            },
                                            {
                                                text: 'Load'
                                            }
                                        ]
                                    }
                                },
                                {
                                    text: "Edit",
                                    arrowVisible: false,
                                    focusable: false,
                                    menu: {
                                        items: [
                                            {
                                                text: 'Copy'
                                            },
                                            {
                                                text: 'Paste'
                                            }
                                        ]
                                    }
                                },
                                '->',
                                {
                                    text: "Help",
                                    arrowVisible: false,
                                    menu: {
                                        items: [
                                            {
                                                text: "About"
                                            }
                                        ]
                                    }
                                }
                            ]
                        },*/
                        {
                            xtype: "toolbar",
                            flex: 0,
                            items: [
                                {
                                    text: "Open",
                                    xtype: "splitbutton"
                                },
                                {
                                    text: "Build",
                                    xtype: "splitbutton"
                                },
                                '-',
                                {
                                    text: "Run",
                                    xtype: "splitbutton"
                                }
                            ]
                        }
                    ]
                }
            ]
        },
        {
            xtype: 'panel',
            region: 'west',
            html: '<ul><li>This area is commonly used for navigation, for example, using a "tree" component.</li></ul>',
            width: 200,
            minWidth: 175,
            maxWidth: 400,
            collapsible: true,
            animCollapse: true,
            split: true,
            layout: 'accordion',
            items: [
           //     Ext.create('Mso.view.tree.workspace'),
                {
                    xtype: 'workspace'
                },
                {
                    title: 'Providers',
                    xtype: 'treepanel',
                    store: Ext.create('Mso.store.Providers'),
                    rootVisible: false
                },
                {
                    xtype: 'instrument'
                }
            ]
        },
        {
            region: 'south',
            split: true,
            height: 100,
            minSize: 100,
            maxSize: 200,
            collapsible: true,
            collapsed: true,
            title: 'South',
            margins: '0 0 0 0'
        },
        {
            xtype: 'tabpanel',
            region: 'east',
            title: 'East Side',
            dockedItems: [
                {
                    dock: 'top',
                    xtype: 'toolbar',
                    items: ['->', {
                        xtype: 'button',
                        text: 'test',
                        tooltip: 'Test Button'
                    }]
                }
            ],
            animCollapse: true,
            collapsible: true,
            split: true,
            width: 225, // give east and west regions a width
            minSize: 175,
            maxSize: 400,
            margins: '0 5 0 0',
            activeTab: 1,
            tabPosition: 'bottom',
            items: [
                {
                    html: '<p>A TabPanel component can be a region.</p>',
                    title: 'A Tab',
                    autoScroll: true
                },
                {
                    xtype: 'propertygrid',
                    title: 'Property Grid',
                    closable: true,
                    source: {
                        "(name)": "Properties Grid",
                        "grouping": false,
                        "autoFitColumns": true,
                        "productionQuality": false,
                        "created": Ext.Date.parse('10/15/2006', 'm/d/Y'),
                        "tested": false,
                        "version": 0.01,
                        "borderWidth": 1
                    }
                }
            ]
        },
        {
            region: 'center',
            xtype: 'tabpanel',
            items: [
                {
                    title: 'Code',
                    value: "using System;",
                    autoScroll: true,
                    xtype: 'ace'
                },
                {
                    title: 'Chart',
                    xtype: 'highstock',
                    closable: true,
                    autoScroll: true
                },
                {
                    title: 'code2',
                    value: 'using System;',
                    xtype: 'codemirror',
                    closable: true,
                    autoScroll: true
                }
            ]
        }
    ]
});
