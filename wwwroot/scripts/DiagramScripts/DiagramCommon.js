$(window).load(function () {
    if ((ej.browserInfo().name === "msie" && Number(ej.browserInfo().version) < 9)) {
        alert("Diagram will not be supported in IE Version < 9");
    }
});