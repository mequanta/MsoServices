dojo.require("dojo.parser");
dojo.require("dojo.dom");
dojo.addOnLoad(function() {
    dojo.parser.parse();
    dojo.body().setAttribute("role", "application");
});
