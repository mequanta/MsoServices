define(function(require, exports, module) {
    main.consumes = [];
    main.provides = ["tree.solution"];
    return main;

    function main(options, imports, register) {
        var TreeData = require("./DataProvider");


        register(null, {
            "tree.solution": {}
        })  
    }
});
