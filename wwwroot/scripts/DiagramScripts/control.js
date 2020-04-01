
var pageBackgroundColor = null;
$(function () {

    if (window.SVGSVGElement) {
        var collection1 = [{ name: "maxi_search" }];
        collection1.name = "maxi";
        $("#maxi_Search").ejSymbolPalette({ diagramId: "DiagramContent", palettes: collection1, height: "100%", width: "255px", paletteItemWidth: 45, paletteItemHeight: 45, showPaletteItemText: false });
    }

});

//#region Property Panel - Initialization

$(function () {
    ej.datavisualization.Diagram.Locale["en-US"] = {
        cut: "Cut",
        copy: "Copy",
        paste: "Paste",
        undo: "Undo",
        redo: "Redo",
        selectAll: "SelectAll",
        grouping: "Grouping",
        group: "Group",
        ungroup: "Ungroup",
        order: "Order",
        bringToFront: "BringToFront",
        moveForward: "MoveForward",
        sendBackward: "SendBackward",
        sendToBack: "SendToBack",
        eventType: "Event Type",
        interruptingStart: "Interrupting Start",
        nonInterruptingStart: "NonInterrupting Start",
        interruptingIntermediate: "Interrupting Intermediate",
        nonInterruptingIntermediate: "NonInterrupting Intermediate",
        endEvent: "End",
        triggerResult: "Trigger Result",
        noTrigger: "None",
        messageTrigger: "Message",
        timerTrigger: "Timer",
        escalationTrigger: "Escalation",
        linkTrigger: "Link",
        errorTrigger: "Error",
        compensationTrigger: "Compensation",
        signalTrigger: "Signal",
        multipleTrigger: "Multiple",
        parallelTrigger: "Parallel",
        gateway: "Gateway",
        noGateway: "None",
        exclusiveGateway: "Exclusive",
        inclusiveGateway: "Inclusive",
        parallelGateway: "Parallel",
        complexGateway: "Complex",
        eventBasedGateway: "Event Based",
        activityType: "Activity Type",
        task: "Task",
        collapsedSubProcess: "Collapsed Sub-Process",
        none: "None",
        loop: "Loop",
        standardLoop: "Standard",
        parallelMultiInstanceLoop: "Parallel Multi-Instance",
        sequenceMultiInstanceLoop: "Sequence Multi-Instance",
        taskType: "Task Type",
        serviceTask: "Service",
        receiveTask: "Receive",
        sendTask: "Send",
        instantiatingReceiveTask: "Instantiating Receive",
        manualTask: "Manual",
        businessRuleTask: "Business Rule",
        userTask: "User",
        scriptTask: "Script",
        compensation: "Compensation",
        compensation1: "Compensation",
        taskCall: "Call",
        call: "Call",
        adhoc: "Ad-Hoc",
        adhoc1: "Ad-Hoc",
        dataObject: "DataObject",
        noDataObject: "None",
        collection: "Collection",
        one: "One",
        both: "Both",
        boundary: "Boundary",
        defaultBoundary: "Default",
        callBoundary: "Call",
        eventBoundary: "Event",
    };
    $('#aspectratioCheckBox').ejCheckBox({
        size: "small",
        change: function (args) {
            PropertyChangesFromPanel(args, "aspectRatio")
        }
    });

    $("#opacity").ejSlider({
        sliderType: ej.SliderType.MinRange, minValue: 0,
        maxValue: 100, incrementStep: 1,
        slide: function (args) {
            PropertyChangesFromPanel(args, "Opacity");
        },
        change: function (args) {
            if (diagram && diagram._selectedObject.opacity != args.value) {
                PropertyChangesFromPanel(args, "Opacity");
            }
        }
    });

    $('#fontsize').ejDropDownList({
        targetID: "fontsizeDiv",
        width: "125px"
    });


    $('#labelFillColor').ejDropDownList({
        targetID: "labelFillColorDiv",
        width: "175px"
    });

    $('#labelBorderColor').ejDropDownList({
        targetID: "labelBorderColorDiv",
        width: "175px"
    });

});



//#endregion


$(window).load(function () {
    if (window.SVGSVGElement) {

        var item = $("#DiagramContent").ejDiagram("instance").model.contextMenu.items;
        var item1 = [];
        for (var i = 0; i < item.length; i++) {
            item1.push($.extend(true, {}, item[i]));
        }
        items = [
                  {
                      name: "eventType", text: "EventType",
                      subItems: [
                          { name: "interruptingStart", text: "Interrupting Start" },
                          { name: "nonInterruptingStart", text: "NonInterrupting Start" },
                          { name: "interruptingIntermediate", text: "Interrupting Intermediate" },
                          { name: "nonInterruptingIntermediate", text: "NonInterrupting Intermediate" },
                          { name: "endEvent", text: "End" },
                      ]
                  },
                {
                    name: "triggerResult", text: "TriggerResult", subItems: [
                        { name: "noTrigger", text: "None" },
                        { name: "messageTrigger", text: "Message" },
                        { name: "timerTrigger", text: "Timer" },
                        { name: "escalationTrigger", text: "Escalation" },
                        { name: "linkTrigger", text: "Link" },
                        { name: "errorTrigger", text: "Error" },
                        { name: "compensationTrigger", text: "Compensation" },
                        { name: "signalTrigger", text: "Signal" },
                        { name: "multipleTrigger", text: "Multiple" },
                        { name: "parallelTrigger", text: "Parallel" },

                    ]
                },
                {
                    name: "gateway", text: "Gateway", subItems: [
                        { name: "noGateway", text: "None" },
                        { name: "exclusiveGateway", text: "Exclusive" },
                        { name: "parallelGateway", text: "Parallel" },
                        { name: "inclusiveGateway", text: "Inclusive" },
                        { name: "complexGateway", text: "Complex" },
                        { name: "eventBasedGateway", text: "Event Based" }
                    ]
                },
                {
                    name: "dataObject", text: "DataObject", subItems: [
                        { name: "noDataObject", text: "None" },
                        { name: "collection", text: "Collection" },
                    ]
                },
                {
                    name: "loop", text: "Loop", subItems: [
                        { name: "none", text: "None" },
                        { name: "standardLoop", text: "Standard" },
                        { name: "parallelMultiInstanceLoop", text: "Parallel Multi-Instance" },
                        { name: "sequenceMultiInstanceLoop", text: "Sequence Multi-Instance" }
                    ]
                },
                {
                    name: "taskType", text: "Task Type", subItems: [
                        { name: "none", text: "None" },
                        { name: "serviceTask", text: "Service" },
                        { name: "receiveTask", text: "Receive" },
                        { name: "sendTask", text: "Send" },
                        { name: "instantiatingReceiveTask", text: "Instantiating Receive" },
                        { name: "manualTask", text: "Manual" },
                        { name: "businessRuleTask", text: "Business Rule" },
                        { name: "userTask", text: "User" },
                        { name: "scriptTask", text: "Script" }
                    ]
                },
                {
                    name: "adhoc", text: "Ad-Hoc", subItems: [
                        { name: "none", text: "Nones" },
                        { name: "adhoc1", text: "Ad-Hoc" }
                    ]
                },
                {
                    name: "compensation", text: "Compensation", subItems: [
                        { name: "none", text: "None" },
                        { name: "compensation1", text: "Compensation" },
                    ]
                },
                {
                    name: "activityType", text: "ActivityType", subItems: [
                        { name: "task", text: "Task" },
                        { name: "collapsedSubProcess", text: "Collapsed Sub-Process" },
                    ]
                },
                {
                    name: "taskCall", text: "Call", subItems: [
                        { name: "none", text: "None" },
                        { name: "call", text: "Call" }
                    ]
                },
                {
                    name: "boundary", text: "Boundary", subItems: [
                        { name: "defaultBoundary", text: "Default" },
                        { name: "callBoundary", text: "Call" },
                        { name: "eventBoundary", text: "Event" }
                    ]
                }
        ];
        for (var i = 0; i < items.length; i++) {
            item1.push($.extend(true, {}, items[i]));
        }
        $("#DiagramContent").ejDiagram({
            contextMenu: {
                items: item1,
            },
            contextMenuBeforeOpen: contextMenuBeforeOpening,
            contextMenuClick: contextMenuClicked
        });
        diagram = $("#DiagramContent").ejDiagram("instance");
        diagram.model.selectedItems.userHandles = createUserHandles(userHandles);
        diagram.model.drawingTools = { textTool: ej.datavisualization.Diagram.TextTool() };
        diagram._registerDrawingTools();
        diagram._initHandles();
        diagram._modified = false;
        diagram._selectedObject = new SelectorVMClass();
        // set the default value for background dropdown control in Toolbar.
        document.getElementById("backgroundIcon").style.color = diagram.model.pageSettings.pageBackgroundColor;
        ko.applyBindings(diagram._selectedObject);
        $("#artBoardWidth").ejNumericTextbox({ name: "artBoardWidth", value: diagram.model.pageSettings.pageWidth, width: "75px", focusOut: "setDiagramWidth" });
        $("#artBoardHeight").ejNumericTextbox({ name: "artBoardHeight", value: diagram.model.pageSettings.pageHeight, width: "75px", focusOut: "setDiagramHeight" });

        $('#pageBackgroundColor').ejDropDownList({
            targetID: "pageBackgroundColorDiv",
            width: "360px",
            popupHeight: "180px",
        });

        this.updateSize();
        setToolTip(true);
        setPaletteCollections();
        setDiagramSize();

        $("userHandle-icon").css("pointer-events", "none");

        $("#menufile")[0].firstChild.style.color = "white";
        $("#menuedit")[0].firstChild.style.color = "white";
        $("#menuview")[0].firstChild.style.color = "white";
        $("#menuaction")[0].firstChild.style.color = "white";
    }
    else {
        alert("Diagram will not be supported in IE Version < 9");
    }
    $("#Overview-div").css("display", "none");
});

function ToolBarVisibility(args) {

    if (args == "ej.Diagram") {
        document.getElementById("toolblock4").style.display = "none";
        document.getElementById("toolblock5").style.display = "none";
        document.getElementById("toolblock6").style.display = "none";
        document.getElementById("Ul1").style.display = "none";
        document.getElementById("Ul2").style.display = "none";
        document.getElementById("artboard").style.display = "block";
    }
    if (args == "Single") {
        document.getElementById("toolblock4").style.display = "block";
        document.getElementById("toolblock5").style.display = "none";
        document.getElementById("toolblock6").style.display = "none";
        document.getElementById("Ul1").style.display = "block";
        document.getElementById("artboard").style.display = "none";
    }
    if (args == "Multi") {
        document.getElementById("toolblock4").style.display = "block";
        document.getElementById("toolblock5").style.display = "block";
        document.getElementById("toolblock6").style.display = "block";
        document.getElementById("Ul1").style.display = "none";
        document.getElementById("artboard").style.display = "none";
    }
    if (args == "Group") {
        document.getElementById("Ul1").style.display = "block";
        document.getElementById("Ul2").style.display = "block";
        document.getElementById("toolblock5").style.display = "none";
        document.getElementById("toolblock6").style.display = "none";
        document.getElementById("artboard").style.display = "none";
    }
}