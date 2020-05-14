//#region EJ Control Events

//#region Diagram - Events

function selectionchanged(args) {
    if (args.selectedItems.length) {
        $(".toolblock3rightBorderVisible").css({ "border-right": "1px solid #7F7F7F" });
        var type = diagram.getObjectType(args.selectedItems[0]);
        if (args.selectedItems.length > 1) {
            $(".toolblock5rightBorderVisible").css({ "border-right": "1px solid #7F7F7F" });
            ToolBarVisibility("Multi");
        }
        else if (type == "node" || args.selectedItems[0].segments || type == "group") {
            $(".toolblock5rightBorderVisible").css({ "border-right": "none" });
            $(".Ul1rightBorderVisible").css({ "border-right": "none" });
            ToolBarVisibility("Single");
            if (args.selectedItems[0].segments) {
                $("#tabitems").ejTab("option", "selectedItemIndex", 3);
            }
            if (type == "group") {
                $(".Ul2rightBorderVisible").css({ "border-right": "1px solid #7F7F7F" });
                ToolBarVisibility("Group");
            }
        }
        if (diagram._selectedObject.pinned)
            ko.applyBindings(diagram._selectedObject.select(args.selectedItems));
        EnableToolbar(args);
        ShowHandles(diagram, args);
    }
    else {
        $(".toolblock5rightBorderVisible").css({ "border-right": "none" });
        $(".toolblock3rightBorderVisible").css({ "border-right": "none" });
        ToolBarVisibility("ej.Diagram");
        if (!diagram._selectedObject.pinned) {
            document.getElementById("propertyEditor").style.display = "none";
        }
        if (diagram._selectedObject.pinned)
            ko.applyBindings(diagram._selectedObject.select(args.selectedItems));
    }
    setDiagramSize(diagram._selectedObject.pinned);

}

function EnableToolbar(args) {
    if (args.selectedItems.length == 1) {
        $("#toolbarEvents").ejToolbar("enableItemByID", "SendToBack_Tool");
        $("#toolbarEvents").ejToolbar("enableItemByID", "MoveForward_Tool");
        $("#toolbarEvents").ejToolbar("enableItemByID", "SendBackward_Tool");
        $("#toolbarEvents").ejToolbar("enableItemByID", "BringToFront_Tool");
        if (args.selectedItems[0].children && args.selectedItems[0].children.length > 0 && args.selectedItems[0].canUngroup) {
            $("#toolbarEvents").ejToolbar("disableItemByID", "Group_Tool");
            $("#toolbarEvents").ejToolbar("enableItemByID", "UnGroup_Tool");
        } else {
            $("#toolbarEvents").ejToolbar("disableItemByID", "Group_Tool");
            $("#toolbarEvents").ejToolbar("disableItemByID", "UnGroup_Tool");
        }
        if (args.selectedItems[0].isLane || args.selectedItems[0].isSwimlane) {
            $("#toolbarEvents").ejToolbar("disableItemByID", "Group_Tool");
            $("#toolbarEvents").ejToolbar("disableItemByID", "UnGroup_Tool");
        }
    }
    else {
        $("#toolbarEvents").ejToolbar("disableItemByID", "UnGroup_Tool");
        $("#toolbarEvents").ejToolbar("enableItemByID", "Group_Tool");
        $("#toolbarEvents").ejToolbar("disableItemByID", "SendToBack_Tool");
        $("#toolbarEvents").ejToolbar("disableItemByID", "MoveForward_Tool");
        $("#toolbarEvents").ejToolbar("disableItemByID", "SendBackward_Tool");
        $("#toolbarEvents").ejToolbar("disableItemByID", "BringToFront_Tool");
    }
}

function ShowHandles(diagram, args) {
    var handles = diagram.model.selectedItems.userHandles;
    for (var i = 0; i < handles.length; i++) {
        handles[i].visible = false;
    }
    if (handles && args.selectedItems.length) {
        if (args.selectedItems[0].type && (args.selectedItems[0].type === "phase" || args.selectedItems[0].isPhase)) {
            diagram.updateUserHandles(args.selectedItems[0]);
        }
        else if (args.selectedItems[0].type) {
            for (var i = 0; i < handles.length; i++) {
                handles[i].visible = true;
                if (args.selectedItems[0].segments) {
                    if (handles[i].name != "Settings")
                        handles[i].visible = false;
                }
                else if (args.selectedItems[0].children && !containsSwimlane(args.selectedItems[0].children)) {
                    if (handles[i].name == "Clone")
                        handles[i].visible = false;
                }
                else if (args.selectedItems) {
                    if (handles[i].name === "Label") {
                        var type = diagram.getObjectType(args.selectedItems[0]);
                        if (args.selectedItems.length == 1 && type != "group" && args.selectedItems[0].type != "text" && args.selectedItems[0].labels && args.selectedItems[0].labels.length > 0) {
                            for (var j = 0; j < args.selectedItems[0].labels.length; j++) {
                                if (args.selectedItems[0].labels[j].text.length === 0) {
                                    handles[i].visible = false;
                                }
                            }
                        }
                        else if (args.selectedItems.length > 1 || (type === "group" && !(args.selectedItems[0].isSwimlane || args.selectedItems[0].isLane))) {
                            var items = type == "group" ? args.selectedItems[0].children : args.selectedItems;
                            for (var n = 0; n < items.length; n++) {
                                var child = typeof items[n] == "string" ? diagram.nameTable[items[n]] : items[n];
                                if (child && child.labels.length > 0) {
                                    for (var j = 0; j < child.labels.length; j++) {
                                        if (child.labels[j].text.length > 0) {
                                            handles[i].visible = false;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (handles[i].name == "Line") {
                        if (args.selectedItems.length > 1 || args.selectedItems[0].type == "text" || type == "group") {
                            handles[i].visible = false;
                        }
                    }
                }
            }
            if (args.selectedItems.length == 1)
                diagram.updateUserHandles(args.selectedItems[0]);
        }

    }
}


function containsSwimlane(list) {
    for (var i in list) {
        var child = list[i];
        if (typeof (child) === "string")
            child = diagram.nameTable[list[i]];
        if (child.isSwimlane || child.isLane)
            return false;
    }
    return true;
}

function nodeDragging(args) {
    if (args.element && diagram.getObjectType(args.element) == "node") {
        diagram._modified = true;
        diagram._selectedObject.nodeDimensionChanging(args.element);
    }
}

function nodeondrop(args) {
    var node = args.element;
    if (node && node.segments) {
        //node.lineWidth = 2;
    }
    else if (node && !node.isSwimlane && !node.isLane) {
        //node.width = 100;
        //node.height = 100;
        //editIntelligentShapes(node);
    }
    else if (node && node.name) {

        //editIntelligentShapes(node);

        diagram.deactivateTool();
        $('#MoveTool_Tool').css('background-color', '#D3D1D1');
        $('#Pan_Tool').css('background-color', '#F7F5F5');
        $('#Text_Tool').css('background-color', '#F7F5F5');
        $('#ConnectorDraw_Tool').css('background-color', '#F7F5F5');
        $('#Image_Tool').css('background-color', '#F7F5F5');
    }

}

function nodeSizeChanging(args) {
    updateIntelligentNode(args);
    if (args.element) {
        diagram._modified = true;
        if (diagram.getObjectType(args.element) == "node" && args.element.type !== "pseudoGroup")
            diagram._selectedObject.nodeDimensionChanging(args.element);
    }
}

function dragEnter(args) {
    if (args) {
        if (args.element && args.element.isLane) {
            if (args.element.orientation == "horizontal") {
                args.element.minHeight = 120;
                args.element.minWidth = 550;
            }
            if (args.element.orientation == "vertical") {
                args.element.minHeight = 550;
                args.element.minWidth = 120;
            }
            diagram.updateNode(args.element.name, {});
        }
        else diagram.updateNode(args.element.name, {});
    }
    var node = args.element ? args.element : null;
    if (node && !node.isSwimlane && !node.isLane) {
        if (node && node.labels && (typeof node.labels.length == "undefined" || node.labels.length == 0)) {
            node.labels.push(ej.datavisualization.Diagram.Label({ mode: ej.datavisualization.Diagram.LabelEditMode.Edit }));
            node.labels[0].fontColor = "black";
        }
        else if (node && node.labels && (node.labels.length != "undefined" && node.labels.length > 0)) {
            node.labels[0].mode = ej.datavisualization.Diagram.LabelEditMode.Edit;
        }
    }
    if (node && !node.segments && !node.isLane && !node.isSwimlane) {
        _updateNodeSize(node);
        editIntelligentShapes(node);
    }
}
function nodecollectionchanged(args) {
    diagram._modified = true;
    if (args.changeType == "insert") {
        if (args.element && args.element.constraints && !args.element.isLane && !args.element.isSwimlane && args.element.type != "bpmn") {
            if (args.element.constraints & ej.datavisualization.Diagram.NodeConstraints.AspectRatio)
                args.element.constraints = ej.datavisualization.Diagram.NodeConstraints.Default | ej.datavisualization.Diagram.NodeConstraints.AspectRatio;
            else
                args.element.constraints = ej.datavisualization.Diagram.NodeConstraints.Default;
            if (args.element.type == "text") {
                if (args.element.height < 35) {
                    args.element.height = 35;
                }
                args.element.fillColor = "Transparent";
            }
        }
        //if (diagram && diagram.activeTool && diagram.activeTool.name != "Clone")
        //    updateIntelligentNode(args);

        //var node = args.element;
        //var type = diagram.getObjectType(node);
        //if (node && node.name && !node.isLane && !node.isSwimlane) {
        //    if (diagram && diagram.activeTool && diagram.activeTool.name != "Clone")
        //        editIntelligentShapes(node);
        //}
        //if (args) {
        //    if (args.changeType == "insert" && args.element && type == "node" && args.element.isLane) {
        //        args.element.height = 40;
        //        args.element.width = 75;
        //        diagram.updateNode(args.element.name, {});
        //    }
        //    else if (args.changeType == "insert" && args.element && args.element.isSwimlane) {
        //        if (args.element.orientation == "horizontal") {
        //            args.element.minHeight = 120;
        //            args.element.minWidth = 550;
        //        }
        //        if (args.element.orientation == "vertical") {
        //            args.element.minHeight = 550;
        //            args.element.minWidth = 120;
        //        }
        //        if (args.element.children && args.element.children.length > 0) {
        //            var child = diagram.findNode(args.element.children[0])
        //            if (child)
        //                child.labels[0].text = "Title";
        //        }
        //        diagram.updateNode(args.element.name, {});
        //    }
        //    else if (args.changeType == "insert" && args.element && args.element.isLane) {
        //        if (args.element.orientation == "horizontal") {
        //            args.element.minHeight = 120;
        //            args.element.minWidth = 550;
        //        }
        //        if (args.element.orientation == "vertical") {
        //            args.element.minHeight = 550;
        //            args.element.minWidth = 120;
        //        }
        //        diagram.updateNode(args.element.name, {});
        //    }
        //    else diagram.updateNode(args.element.name, {});
        //}
        if (args.element.type === "group" && args.element.labels && args.element.labels[0]) {
            args.element.labels[0].fontColor = "black";
        }
    }
}

function connectorCollectionChanged(args) {
    diagram._modified = true;
    if (args.changeType == "insert") {
        if (args.element.segments) {
            if (args.element.lineWidth < 2) {
                args.element.lineWidth = 2;
            }

        }
    }
}

function textChanged(args) {
    diagram._modified = true;
    for (var i = 0; i < args.element.labels.length; i++) {
        if (args.element.segments) {
            args.element.labels[i].fillColor = "white";
        }
        args.element.labels[i].bold = false;
        if (args.element.type === "group") {
            args.element.labels[i].fontColor = "black";
        }
    }
}

function editIntelligentShapes(node) {
    var str = node.name.toString();
    if (str.match("\\b5star")) {
        var points = _renderStar(node, 5, 25);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\b16star")) {
        var points = _renderStar(node, 16, 25);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\b6star")) {
        var points = _renderStar(node, 6, 25);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bLeftArrow") && !str.match("\\bCurvedLeftArrow") && !str.match("\\bJumpingLeftArrow")) {
        var points = _renderLeftArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bRightArrow") && !str.match("\\bCurvedRightArrow") && !str.match("\\bJumpingRightArrow")) {
        var points = _renderRightArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bParallelogram")) {
        var points = _renderParallelogram(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bbendsingleArrow")) {
        var points = _renderBendSingleArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bbenddoubleArrow")) {
        var points = _renderBenddoubleArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bDoubleArrow")) {
        node.width = 120;
        node.height = 60;
        var points = _renderDoubleArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bColumn")) {
        var points = _renderGridColumn(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bRow")) {
        var points = _renderGridRow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bHexagon")) {
        var points = _renderOctagon(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bCircularArrow") || str.match("\\bCurvedUpArrow") || str.match("\\bCurvedDownArrow")) {
        node.width = 120;
        node.height = 60;
    }
    else if (str.match("\\bCurvedRightArrow") || str.match("\\bCurvedLeftArrow")) {
        node.width = 60;
        node.height = 120;
    }
    else if (str.match("\\bDecision")) {
        node.width = 150;
        node.height = 70;
    }
    else if (str.match("\\bManualInput")) {
        node.width = 100;
        node.height = 80;
        var points = _updateManualInput(node);
        node.shape = "path"; node.pathData = points;
    }
        //else if (str.match("\\bData")) {
        //    var a = 20;
        //    node.height = 80;
        //    var points = _updateDataPoints(node, a);
        //    node.shape = "path"; node.pathData = points;
        //}
    else if (str.match("\\bDirectdata")) {
        node.width = 120;
        node.height = 50;
    }
    else if (str.match("\\bTwoSideFlatCorner")) {
        node.width = 100;
        node.height = 80;
        var a = 8;
        var points = _updateTwoSideFlatCornerPoints(node, a);
    }
    else if (str.match("\\bDelay")) {
        node.width = 100;
        node.height = 60;
        var a = 30;
        var points = _updateDelayPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bUTurnArrow")) {
        var a = 20;
        node.width = 70;
        var points = _updateUTurnArrowPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bprocess")) {
        node.width = 115;
        node.height = 60;
    }
    else if (str.match("\\bTwoSideRoundedCorner")) {
        node.width = 100;
        node.height = 80;
        var a = 20;
        var points = _updateTwoSideRoundedCornerPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bRRectangle")) {
        node.width = 100;
        node.height = 80;
        var a = 10;
        var points = _updateRoundedRectanglePoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bExternaldata")) {
        node.width = 120;
        node.height = 60;
        var points = _updateExternalDataPoints(node);
        node.shape = "path"; node.pathData = points;
    }

    else if (str.match("\\bStart") && str.match("\\bStart").index == 0) {
        node.width = 150;
        node.height = 60;
        var a = 30;
        var points = _updateStartPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bProceed")) {
        node.width = 80;
        node.height = 80;
        var a = 40;
        var points = _updateProceedPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bDisplay")) {
        node.width = 150;
        node.height = 80;
        var a = 40;
        var points = _updateDisplayPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bPrepartion")) {
        node.width = 140;
        node.height = 60;
        var a = 20;
        var points = _updatePrepartionPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bCard")) {
        node.width = 100;
        node.height = 80;
        var a = 20;
        var points = _updateCardPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }

    else if (str.match("\\bLoopLimit")) {
        node.width = 100;
        node.height = 60;
        var a = 10;
        var points = _updateLoopLimitPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bCallOutleftArrow")) {
        var a = 75;
        var points = _updateCallOutLeftArrowPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bCallOutrightArrow")) {
        var a = 75;
        var points = _updateCallOutRightArrowPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bCallOutupArrow")) {
        var a = 75;
        var points = _updateCallOutUpArrowPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bCallOutDownArrow")) {
        var a = 75;
        var points = _updateCallOutDownArrowPoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bChevronsWide")) {
        var a = 20;
        node.width = 80;
        node.height = 40;
        var points = _updateChevronsWidePoints(node, a);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bLStylishedHeadwithFanTail")) {
        node.width = 100;
        node.height = 40;
        var points = _updateLStylishedHeadwithFanTailPoints(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bBentleftarrow")) {
        var points = _updateBentLeftArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bChevronsLeftandTopArrow")) {
        var points = _updateChevronsLeftandTopArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bChevronsTopArrow")) {
        var points = _updateChevronsTopArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (str.match("\\bbendrightArrow")) {
        var points = _updatebendrightArrow(node);
        node.shape = "path"; node.pathData = points;
    }
    else if (node.shape == "message") {
        node.height = 60;
    }
    else if (node.shape == "document")
        node.height = 75;
    else if (node.shape == "multidocument")
        node.height = 75;
    else if (node.shape == "directdata")
        node.height = 75;
    else if (node.shape == "papertap")
        node.height = 75;
    else if (node.shape == "predefinedprocess")
        node.height = 75;

    if (node.labels && (typeof node.labels.length == "undefined" || node.labels.length == 0)) {
        node.labels.push(ej.datavisualization.Diagram.Label({ mode: ej.datavisualization.Diagram.LabelEditMode.Edit }));
        node.labels[0].fontColor = "black";
    }
    else if (node.labels && (node.labels.length != "undefined" && node.labels.length > 0)) {
        node.labels[0].mode = ej.datavisualization.Diagram.LabelEditMode.Edit;
    }
}

function contextMenuBeforeOpening(args) {
    var diagram = $("#DiagramContent").ejDiagram("instance");
    var menu = diagram.model.contextMenu.items;
    var context = $("#DiagramContent_contextMenu").ejMenu("instance");
    var shape;
    document.getElementById("DiagramContent_contextMenu_eventType").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_triggerResult").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_gateway").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_dataObject").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_boundary").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_adhoc").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_loop").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_taskType").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_compensation").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_taskCall").style.display = "none";
    document.getElementById("DiagramContent_contextMenu_activityType").style.display = "none";
    if (args.diagram.selectionList[0]) {
        if (diagram.model.selectedItems.children.length != 0)
            if (diagram.model.selectedItems.children[0].type === "bpmn") shape = diagram.model.selectedItems.children[0].shape;

        switch (shape) {
            case "gateway":
                document.getElementById("DiagramContent_contextMenu_gateway").style.display = "block";
                break;
            case "dataobject":
                document.getElementById("DiagramContent_contextMenu_dataObject").style.display = "block";
                break;
            case "activity":
                document.getElementById("DiagramContent_contextMenu_loop").style.display = "block";
                document.getElementById("DiagramContent_contextMenu_compensation").style.display = "block";
                document.getElementById("DiagramContent_contextMenu_activityType").style.display = "block";
                if (diagram.model.selectedItems.children[0].activity == "task") {
                    document.getElementById("DiagramContent_contextMenu_taskType").style.display = "block";
                    document.getElementById("DiagramContent_contextMenu_taskCall").style.display = "block";
                }
                else {
                    document.getElementById("DiagramContent_contextMenu_adhoc").style.display = "block";
                    document.getElementById("DiagramContent_contextMenu_boundary").style.display = "block";
                }
                break;
            case "event":
                document.getElementById("DiagramContent_contextMenu_eventType").style.display = "block";
                document.getElementById("DiagramContent_contextMenu_triggerResult").style.display = "block";
                break;
        }
    }
}

function contextMenuClicked(args) {
    var diagram = $("#DiagramContent").ejDiagram("instance");
    var menu = diagram.model.contextMenu.items;
    var menuselect = args.parentText;
    var node = diagram.selectionList[0];
    var options = {}, loop;
    if (node && node.type === "bpmn") {
        options.task = {};
        options.subProcess = {};
        switch (menuselect) {
            case "Trigger Result":
                options.trigger = args.text.toLowerCase();
                break;
            case "Event Type":
                if (args.text === "Interrupting Start") options.event = "start";
                else if (args.text === "NonInterrupting Start") options.event = "noninterruptingstart";
                else if (args.text === "Interrupting Intermediate") options.event = "intermediate";
                else if (args.text === "NonInterrupting Intermediate") options.event = "noninterruptingintermediate";
                if (args.text === "End") options.event = "end";
                break;
            case "Gateway":
                if (args.text === "Exclusive") options.gateway = "exclusive";
                else if (args.text === "Inclusive") options.gateway = "inclusive";
                else if (args.text === "Parallel") options.gateway = "parallel";
                else if (args.text === "Complex") options.gateway = "complex";
                else if (args.text === "Event Based") options.gateway = "eventbased";
                else if (args.text === "None") options.gateway = "none";
                break;
            case "Data Object":
                options.collection = (args.text === "Collection") ? true : false;
                break;
            case "Loop":
                if (args.text === "None") loop = "none";
                else if (args.text === "Standard") loop = "standard";
                else if (args.text === "Parallel Multi-Instance") loop = "parallelmultiinstance";
                else if (args.text === "Sequence Multi-Instance") loop = "sequencemultiinstance";
                if (node.activity == "task") options.task.loop = loop;
                else options.subProcess.loop = loop;
                break;
            case "Task Type":
                if (args.text === "None") options.task.type = "none";
                else if (args.text === "Service") options.task.type = "service";
                else if (args.text === "Receive") options.task.type = "receive";
                else if (args.text === "Send") options.task.type = "send";
                else if (args.text === "Instantiating Receive") options.task.type = "instantiatingreceive";
                else if (args.text === "Manual") options.task.type = "manual";
                else if (args.text === "Business Rule") options.task.type = "businessrule";
                else if (args.text === "User") options.task.type = "user";
                else if (args.text === "Script") options.task.type = "script";
                break;
            case "Compensation":
                if (node.activity == "task") options.task.compensation = (args.text === "Compensation") ? true : false;
                else options.subProcess.compensation = (args.text === "Compensation") ? true : false;
                break;
            case "Ad-Hoc":
                options.subProcess.adhoc = (args.text === "Ad-Hoc") ? true : false;
                break;
            case "Call":
                options.task.call = (args.text === "Call") ? true : false;
                break;
            case "Boundary":
                if (args.text === "Default") options.subProcess.boundary = "default";
                else if (args.text === "Call") options.subProcess.boundary = "call";
                else if (args.text === "Event") options.subProcess.boundary = "event";
                break;
            case "Activity Type":
                options.activity = (args.text === "Task") ? "task" : "subprocess";
                break;
            case "Direction":
                if (node.shape === "associationflow") {
                    if (args.text === "One") node.direction = "unidirctional";
                    else if (args.text === "Both") node.direction = "biidirctional"
                    else if (args.text === "None") node.direction = "none";
                }
                break;
        }
        if (node.segments) diagram.updateConnector(node.name, { segments: node.segments, });
        else diagram.updateNode(node.name, options);
    }
}
// #endregion

//#region Menubar events
function MenubarClick(sender) {

    var option = sender.events.text;
    var diagram = $("#DiagramContent").ejDiagram("instance");
    var imgData;
    if (!(option == "Align" || option == "Grouping" || option == "Order" || option == "Resize" || option == "File" || option == "Edit" || option == "View" || option == "Actions" || option == "Export" || option == "Print" || option == "Save" || option == "Open" || option == "New"))
        diagram._modified = true;
    if (diagram._modified != true && option == "New") {
        diagram.clear();
        diagram._modified = false;
    }
    switch (option) {
        case "Export":
            $("#exportDialog").ejDialog("open");
            $("#exportDialog").focus();
            break;
        case "Print":
            diagram.print();
            break;
        case "Undo":
            diagram.undo();
            break;
        case "Redo":
            diagram.redo();
            break;
        case "Cut":
            diagram.cut();
            break;
        case "Copy":
            diagram.copy();
            break;
        case "Paste":
            diagram.paste();
            break;
        case "Delete":
            diagram.remove();
            break;
        case "Select All":
            diagram.selectAll();
            break;
        case "Left":
        case "Right":
        case "Center":
        case "Top":
        case "Bottom":
        case "Middle":
            diagram.align(option.toLowerCase());
            break;
        case "Group":
            diagram.group();
            break;
        case "Ungroup":
            diagram.ungroup();
            break;
        case "Bring To Front":
            diagram.bringToFront();
            break;
        case "Bring Forward":
            diagram.moveForward();
            break;
        case "Send To Back":
            diagram.sendToBack();
            break;
        case "Send Backward":
            diagram.sendBackward();
            break;
        case "Same Size":
            diagram.sameSize();
            break;
        case "Same Height":
            diagram.sameHeight();
            break;
        case "Same Width":
            diagram.sameWidth();
            break;
        case "Space Down":
            diagram.spaceDown();
            break;
        case "Space Across":
            diagram.spaceAcross();
            break;
        case "Grid Lines":
            var snapSettings = diagram.model.snapSettings;
            var snapConstraints = snapSettings.snapConstraints ^ ej.datavisualization.Diagram.SnapConstraints.ShowLines;
            if (snapConstraints & ej.datavisualization.Diagram.SnapConstraints.ShowLines) {
                $("#GridLines").find("span").css("display", "block");
            }
            else {
                $("#GridLines").find("span").css("display", "none");
            }

            $("#DiagramContent").ejDiagram({ snapSettings: { snapConstraints: snapConstraints } });

            break;
        case "Snap To Grid":
            var snapSettings = diagram.model.snapSettings;
            var snapConstraints = snapSettings.snapConstraints ^ ej.datavisualization.Diagram.SnapConstraints.SnapToLines;
            if (snapConstraints & ej.datavisualization.Diagram.SnapConstraints.SnapToLines) {
                $("#SnapToGrid").find("span").css("display", "block");
            }
            else {
                $("#SnapToGrid").find("span").css("display", "none");
            }
            $("#DiagramContent").ejDiagram({ snapSettings: { snapConstraints: snapConstraints } });

            break;
        case "Overview":

            if (!diagram._enableOverView) {
                $("#EnableOverView").find("span").css("display", "block");
                diagram._enableOverView = true;
                $("#Overview-div").css("display", "block");
                $("#Overview").ejOverview({ sourceID: "DiagramContent" });
            }
            else {
                $("#EnableOverView").find("span").css("display", "none");
                diagram._enableOverView = false;
                $("#Overview-div").css("display", "none");
                $("#Overview").ejOverview({ sourceID: "" });
            }
            updateSize(diagram._enableOverView);
            break;
        case "Smart Guide":
            if (diagram.model.snapSettings.enableSnapToObject)
            { diagram.model.snapSettings.enableSnapToObject = false; }
            else
            { diagram.model.snapSettings.enableSnapToObject = true; }

            if (diagram.model.snapSettings.enableSnapToObject) {
                $("#SmartGuid").find("span").css("display", "block");
            }
            else {
                $("#SmartGuid").find("span").css("display", "none");
            }
            break;
        case "Save":
            if (!(window.loadFileName) && !(window.saveFileName)) {
                $("#basicDialog").ejDialog("open");
                $(".e-dialog-scroller e-scroller e-js e-widget").css("height", "130.6px");
                $("#SaveFileName").focus();
            }
            else if ((window.loadFileName) || (window.saveFileName)) {
                if (window.loadFileName)
                    document.getElementById("SaveFileName").value = window.loadFileName;
                else if (window.saveFileName)
                    document.getElementById("SaveFileName").value = window.saveFileName;
                saveFileAsString();
            }
            break;
        case "New":
            if (diagram._modified == true) {
                $("#confirmDialog").ejDialog("open");
                $("#confirmDialog").focus();
            }

            window.loadFileName = null;
            window.saveFileName = null;

            break;
        case "Save As":
            if (window.loadFileName)
                document.getElementById("SaveFileName").value = window.loadFileName;
            else if (window.saveFileName)
                document.getElementById("SaveFileName").value = window.saveFileName;
            $("#basicDialog").ejDialog("open");
            $("#SaveFileName").focus();
            break;
        case "Open":
            var hasProperties = false;
            $.each(localStorage, function (key, value) {
                hasProperties = true;
            });
            if (hasProperties) {
                openDialogOpen();
                $("#FileOpenDialog").ejDialog("open");
                $("#FileOpenDialog").css("height", "350px");
                $("#FileOpenDialog").css("width", "350px");
            } else {
                alert("There is no saved diagram");
            }
            break;
    }
};

// #endregion

//#region Toolbar events
function evtpropscheckedevent(args) {
    var currentZoom = diagram._getCurrentZoom();
    if (args.text) {
        switch (args.text) {
            case "400%":
                zoom.zoomFactor = (4 / currentZoom) - 1;
                break;
            case "200%":
                zoom.zoomFactor = (2 / currentZoom) - 1;
                break;
            case "150%":
                zoom.zoomFactor = (1.5 / currentZoom) - 1;
                break;
            case "100%":
                zoom.zoomFactor = (1 / currentZoom) - 1;
                break;
            case "75%":
                zoom.zoomFactor = (0.75 / currentZoom) - 1;
                break;
            case "50%":
                zoom.zoomFactor = (0.5 / currentZoom) - 1;
                break;
            case "25%":
                zoom.zoomFactor = (0.25 / currentZoom) - 1;
                break;
        }
        diagram.zoomTo(zoom);
        setZoomSlider();
    }
}

function toolbarClick(sender) {
    var object;
    var nodes, i;
    var option = sender.currentTarget.id;
    if (!(option == "Pan_Tool"))
        diagram._modified = true;
    if (option == "Redo_Tool") {
        diagram.redo();
    }
    if (option == "Undo_Tool") {
        diagram.undo();
    }
    if (option == "Delete_Tool") {
        diagram.remove();
    }
    if (option == "ZoomIn_Tool" || option == "ZoomOut_Tool") {
        var zoom1 = ej.datavisualization.Diagram.Zoom();
        zoom1.zoomFactor = 0.2;
        zoom1.zoomCommand = ej.datavisualization.Diagram.ZoomCommand.ZoomIn;
        if (option == "ZoomOut_Tool")
            zoom1.zoomCommand = ej.datavisualization.Diagram.ZoomCommand.ZoomOut;
        diagram.zoomTo(zoom1);
    }
    if (option == "FitToPage_Tool") {
        diagram.fitToPage();
    }
    if (option == "ZoomIn_Tool" || option == "ZoomOut_Tool" || option == "FitToPage_Tool") {
        $('#zoompercentage').ejDropDownList("option", "value", String(Math.round(diagram._getCurrentZoom() * 100)) + "%");
    }
    if (option == "Pan_Tool") {
        $('#Pan_Tool').css('background-color', '#D3D1D1');
        ToolbarCommandEnabled(option);
        diagram.activateTool("panTool")
    }
    if (option == "MoveTool_Tool") {
        $('#MoveTool_Tool').css('background-color', '#D3D1D1');
        ToolbarCommandEnabled(option);
        diagram.deactivateTool();
    }
    if (option == "Text_Tool") {
        $('#Text_Tool').css('background-color', '#D3D1D1');
        ToolbarCommandEnabled(option);
        diagram.activateTool("textTool");
    }
    if (option == "ConnectorDraw_Tool") {
        $('#ConnectorDraw_Tool').css('background-color', '#D3D1D1');
        ToolbarCommandEnabled(option);
        diagram._clearSelection();
        diagram.activateTool("orthogonalLine", false);
    }
    if (option == "ConnectorDraw_Tool_Straight") {
        $('#ConnectorDraw_Tool_Straight').css('background-color', '#D3D1D1');
        ToolbarCommandEnabled(option);
        diagram._clearSelection();
        diagram.activateTool("straightLine", false);
    }

    if (option == "AlignLeft_Tool") {
        diagram.align("left");
    }
    if (option == "AlignCenter_Tool") {
        diagram.align("center");
    }
    if (option == "AlignRight_Tool") {
        diagram.align("right");
    }
    if (option == "AlignBottom_Tool") {
        diagram.align("bottom");
    }
    if (option == "AlignMiddle_Tool") {
        diagram.align("middle");
    }
    if (option == "AlignTop_Tool") {
        diagram.align("top");
    }
    if (option == "Group_Tool") {
        diagram.group();
    }
    if (option == "UnGroup_Tool") {
        diagram.ungroup();
    }
    if (option == "SendToBack_Tool") {
        diagram.sendToBack();
    }
    if (option == "MoveForward_Tool") {
        diagram.moveForward();
    }
    if (option == "SendBackward_Tool") {
        diagram.sendBackward();
    }
    if (option == "BringToFront_Tool") {
        diagram.bringToFront();
    }
    if (option == "Lock_Tool") {
        updateNodeProperties(null, "Lock");
        updateConnectorProperties(null, "Lock");
    }
}

function ToolBarMouseOver(li) {
    var target = li.classList ? li : (li.target ? li.target : li);
    var targetClass = target.classList ? target.classList[0] : target.className.split(" ")[0];
    if (targetClass != "artboardtitle") {
        var x = target.style.backgroundColor;
        if ((x != "rgb(211, 209, 209)")) {
            if (x != "#D3D1D1") {
                target.style.backgroundColor = "#EAEAEA";
                target.style.border = "1px solid #808080";
            }
        }
    }
}

function ToolBarMouseOut(li) {
    var target = li.classList ? li : (li.target ? li.target : li);
    var targetClass = target.classList ? target.classList[0] : target.className.split(" ")[0];
    if (targetClass != "artboardtitle") {
        var x = target.style.backgroundColor;
        if ((x != "#D3D1D1")) {
            if (x != "rgb(211, 209, 209)") {
                target.style.backgroundColor = "#F7F5F5";
            }
            else {
                target.style.backgroundColor = "#D3D1D1";
            }

        }
        else
            target.style.backgroundColor = "#D3D1D1";

        target.style.border = "1px solid transparent";
    }
}



function ToolbarCommandEnabled(id) {
    if (id != "Pan_Tool") {
        $('#Pan_Tool').css('background-color', '#F7F5F5');
    }
    if (id != "MoveTool_Tool") {
        $('#MoveTool_Tool').css('background-color', '#F7F5F5');
    }
    if (id != "Text_Tool") {
        $('#Text_Tool').css('background-color', '#F7F5F5');
    }
    if (id != "ConnectorDraw_Tool") {
        $('#ConnectorDraw_Tool').css('background-color', '#F7F5F5');
    }
    if (id != "ConnectorDraw_Tool_Straight") {
        $('#ConnectorDraw_Tool_Straight').css('background-color', '#F7F5F5');
    }
    if (id != "Image_Tool") {
        $('#Image_Tool').css('background-color', '#F7F5F5');
    }
}
//#endregion

//#region artboard Events

function setDiagramWidth(args) {
    setDimension({ pageWidth: args.value })
};
function setDiagramHeight(args) {
    setDimension({ pageHeight: args.value })
};
function setDimension(obj) {
    diagram.updatePageSettings(obj);
    var artBoardWidth = $("#artBoardWidth").data("ejNumericTextbox");
    var artBoardHeight = $("#artBoardHeight").data("ejNumericTextbox");
    artBoardWidth.option("value", diagram.model.pageSettings.pageWidth);
    artBoardHeight.option("value", diagram.model.pageSettings.pageHeight);
}
function setBackgroundColor(args) {
    document.getElementById("backgroundIcon").style.color = args.style.backgroundColor;
    diagram.updatePageSettings({ "pageBackgroundColor": args.style.backgroundColor });
}

// #endregion

//#region Overview Slider Events

function OnChange(args) {
    if (diagram) {
        var sliderValue = document.getElementsByClassName("sliderValue");
        sliderValue[0].textContent = args.value + "%";
        $('#zoompercentage').ejDropDownList("option", "value", args.value + "%");
        if (args.value / 100 !== Number(diagram._getCurrentZoom().toFixed(2))) {
            var zoom = ej.datavisualization.Diagram.Zoom();
            var value = args.value / 100;
            zoom.zoomFactor = value / diagram._getCurrentZoom();
            ej.datavisualization.Diagram.ZoomUtil.zoomPan(diagram, zoom.zoomFactor, 0, 0, zoom.focusPoint, true);
        }
    }
}
function OnCreate(args) {
    var sliderValue = document.getElementsByClassName("sliderValue");
    sliderValue[0].textContent = args.model.value + "%";
}

// #endregion

//#region Dialog Control Events

function openDialogOpen() {
    if (document.getElementById("FileTreeView")) {
        var root = document.getElementById("FileTreeView");
        root.innerHTML = "";
        $.each(localStorage, function (key, value) {
            try {
                var val = JSON.parse(localStorage.getItem(key));
                if (val) {
                    if (val.nodes || val.connectors || val.contextMenu) {
                        createLiForFileTree(key);
                    }
                }
            } catch (e) {

            }
        });
    }
}

function new_No() {
    diagram.clear();
    $("#confirmDialog").ejDialog("close");
}
function createLiForFileTree(key) {
    var root = document.getElementById("FileTreeView");
    var li = document.createElement("li");
    li.setAttribute("class", "e-item");
    li.setAttribute("tabindex", "-1");
    li.setAttribute("role", "treeitem");

    var div = document.createElement("div");
    div.setAttribute("class", "fileItemHover");
    div.setAttribute("id", key + "_hover");
    div.onclick = onFileItemSelect;
    div.setAttribute("role", "presentation");
    div.onmousemove = onMouseMove;

    div.onmouseout = onMouseOut;

    function onMouseMove(e) {
        var target;
        //if (e.target && e.target.className != "deleteIconfileItem") {
        if (e.target.localName == "a" || (e.target && e.target.className == "deleteIconfileItem"))
            target = e.target.parentNode;
        else
            target = document.getElementById(e.target.id);
        target.lastChild.style.display = "block";
        //}
    }

    function onMouseOut(e) {
        var target;
        //if (e.target && e.target.className != "deleteIconfileItem") {
        if (e.target.localName == "a" || (e.target && e.target.className == "deleteIconfileItem"))
            target = e.target.parentNode;
        else
            target = document.getElementById(e.target.id);
        target.lastChild.style.display = "none";
        //}
    }

    var childDiv = document.createElement("div");
    childDiv.setAttribute("role", "presentation");
    div.appendChild(childDiv);
    var span = document.createElement("span");
    span.setAttribute("class", "child");
    div.appendChild(span);
    var a = document.createElement("a");
    $(a).css("pointer-events", "none");
    a.setAttribute("class", "e-text CanSelect");
    $(a).css("margin-left", "19px");
    a.setAttribute("href", "#" + key + "_fileItem");
    a.innerHTML = key;
    div.appendChild(a);

    var checkbox = document.createElement("div");
    checkbox.setAttribute("class", "deleteIconfileItem");
    checkbox.setAttribute("style", "background-image: url('images/Close.png');background-repeat: no-repeat;float: right;height: 18px;margin-right: 12px;width: 20px;display:none;");
    checkbox.onclick = onFileDeleteClick;
    div.appendChild(checkbox);
    li.appendChild(div);
    root.appendChild(li);
}

function onFileDeleteClick(e) {
    var delItem = document.getElementById(e.target.previousSibling.innerHTML + "_hover");
    if (delItem) {

        var delParent = delItem.parentNode;
        if (delParent) {
            delParent.parentNode.removeChild(delParent);
            localStorage.removeItem(e.target.previousSibling.innerHTML);
        }

    }
}

function onFileItemSelect(e) {
    var target;
    if (e.target.localName == "a")
        target = e.target.parentNode;
    else
        target = document.getElementById(e.target.id);

    if (target) {
        if (window.selectedFileItemName != target.id) {
            $("#" + window.selectedFileItemName).removeClass("selected");
        }
        if (target) {
            $(target).addClass("selected");
            window.selectedFileItemName = target.id;
        }
    }

}

function onFileItemSelected(args) {
    if (window.selectedFileItemName)
        var fileName = (window.selectedFileItemName).split("_")[0];
    $("#FileOpenDialog").ejDialog("close");
    if (fileName != null && fileName != "") {
        var data = localStorage.getItem(fileName);
        if (data) {
            var jsonData = JSON.parse(data);
            diagram.load(jsonData);
            window.loadFileName = fileName;
        }
    }

}
function new_SaveFileAsString() {

    $("#confirmDialog").ejDialog("open");
    $("#confirmDialog").ejDialog("close");
    $("#basicDialog1").ejDialog("open");

    new_saveOptions();

}
function saveIcon() {
    if (!(window.loadFileName) && !(window.saveFileName)) {
        $("#basicDialog").ejDialog("open");
        $(".e-dialog-scroller e-scroller e-js e-widget").css("height", "130.6px");
        $("#SaveFileName").focus();
    }
    else if ((window.loadFileName) || (window.saveFileName)) {
        if (window.loadFileName)
            document.getElementById("SaveFileName").value = window.loadFileName;
        else if (window.saveFileName)
            document.getElementById("SaveFileName").value = window.saveFileName;
        saveFileAsString();

    }
}


function saveFileAsString() {
    saveOptions();
    diagram._modified = false;
}

function saveOptions() {
    var res = "";

    if (document.getElementById("SaveFileName").value) {
        try {
            res = document.getElementById("SaveFileName").value;
            saveData = diagram.save(res);
            $("#basicDialog").ejDialog("close");
            if (localStorage == undefined)
                alert("Your Browser Doesn't support this action.");
            else
                localStorage.setItem(res, JSON.stringify(saveData));
        }
        catch (e) {
        }

    }

    document.getElementById("SaveFileName").value = "";
    window.saveFileName = res;
    window.loadFileName = "";

}
function new_saveOptions() {
    var res = "";

    if (document.getElementById("SaveFileName1").value) {

        try {
            res = document.getElementById("SaveFileName1").value;
            saveData = diagram.save(res);
            $("#basicDialog1").ejDialog("close");
            diagram.clear();
            if (localStorage == undefined)
                alert("Your Browser Doesn't support this action.");
            else
                localStorage.setItem(res, JSON.stringify(saveData));
        }

        catch (e) {
        }
    }

    document.getElementById("SaveFileName1").value = "";

    window.saveFileName = res;
    window.loadFileName = "";
}

function exportDiagram() {
    var diagram = $("#DiagramContent").ejDiagram("instance");
    var fileName = document.getElementById("ExportFileName").value;
    var region = $("#exportmode").ejDropDownList("instance").selectedTextValue;
    switch (region) {
        case "Content":
            region = "content";
            break;
        case "PageSettings":
            region = "pageSettings";
            break;
    }
    var format = $("#exportformat").ejDropDownList("instance").selectedTextValue;
    switch (format) {
        case "JPG":
            format = "jpg";
            break;
        case "PNG":
            format = "png";
            break;
        case "SVG":
            format = "svg";
            break;
        case "BMP":
            format = "bmp";
            break;
    }
    var content = diagram.exportDiagram({
        fileName: fileName, region: region, format: format, mode: "download",//bounds: { x: 100, y: 100, width: 100, height: 100 }
    });
    if (content) alert("received");
    document.getElementById("ExportFileName").value = "Diagram";
    $("#exportformat").ejDropDownList({ selectedItemIndex: 0 });
    $("#exportmode").ejDropDownList({ selectedItemIndex: 0 });
    $("#exportDialog").ejDialog("close");
}
// #endregion

//#region TabItem Events
function tabItemChanged(args, tab) {
    if (diagram && diagram._selectedObject != undefined) {
        ko.applyBindings(diagram._selectedObject.setTabIconColor(args, tab));
    }
}
//#endregion

//#region PropertyPanel Events

function setBorderWidth(args) {
    if (diagram && diagram.selectionList[0]) {
        var type = diagram.getObjectType(diagram.selectionList[0]);
        if (type == "node") {
            if (diagram.selectionList[0].borderWidth != Number(String(args.text).substring(0, args.text.length - 3))) {
                PropertyChangesFromPanel(args, "borderWidth");
            }
        }
        else if (diagram.selectionList[0] && (diagram.selectionList[0].type == "pseudoGroup" || type == "group")) {
            PropertyChangesFromPanel(args, "borderWidth");
        }
    }
}

function popupShown(args) {
    dropdownOpened(args);
}

function popupHide(args) {
    dropdownClosed(args);
}

function widthChange(args) {
    PropertyChangesFromPanel(args, "width");
}

function heightChange(args) {
    PropertyChangesFromPanel(args, "height");
}

function offsetXChange(args) {
    PropertyChangesFromPanel(args, "pinX");
}
function offsetYChange(args) {
    PropertyChangesFromPanel(args, "pinY");
}

function fontFamilyChange(args) {
    PropertyChangesFromPanel(args, "fontFamily");
}

function fontSizeChange(args) {
    PropertyChangesFromPanel(args, "fontSize");
}

function connectorTypeChange(args) {
    PropertyChangesFromPanel(args, "ConnectorType");
}

function lineStyleChange(args) {
    PropertyChangesFromPanel(args, "LineStyle");
}

function lineWidthChange(args) {
    if (diagram && diagram.selectionList[0]) {
        var type = diagram.getObjectType(diagram.selectionList[0]);
        if (diagram.selectionList[0].segments) {
            if (diagram.selectionList[0].lineWidth != Number(String(args.text).substring(0, args.text.length - 3))) {
                PropertyChangesFromPanel(args, "LineWidth");
            }
        }
        else if (diagram.selectionList[0] && (diagram.selectionList[0].type == "pseudoGroup" || type == "group")) {
            PropertyChangesFromPanel(args, "LineWidth");
        }
    }
}

function headDecoratorChange(args) {
    PropertyChangesFromPanel(args, "HeadDecorator");
}

function tailDecoratorChange(args) {
    PropertyChangesFromPanel(args, "TailDecorator");
}


//#endregion

// #endregion

//#region Html Framework Events

//#region Menu Controls

$("#SmartGuid").hover(function () {
    $("#SmartGuid").find("span").addClass("iconhover");
});
$("#SmartGuid").mouseleave(function () {
    $("#SmartGuid").find("span").removeClass("iconhover");
});
$("#GridLines").hover(function () {
    $("#GridLines").find("span").addClass("iconhover");
});
$("#GridLines").mouseleave(function () {
    $("#GridLines").find("span").removeClass("iconhover");
});
$("#SnapToGrid").hover(function () {
    $("#SnapToGrid").find("span").addClass("iconhover");
});
$("#SnapToGrid").mouseleave(function () {
    $("#SnapToGrid").find("span").removeClass("iconhover");
});
$("#EnableOverView").hover(function () {
    $("#EnableOverView").find("span").addClass("iconhover");
});
$("#EnableOverView").mouseleave(function () {
    $("#EnableOverView").find("span").removeClass("iconhover");
});
// #endregion

//#region Splitter
$(function () {
    $("#edit_splitter_hideslide").click(function () {
        isPMinized = true;
        //document.getElementById("Overview-div").style.display = "none";
        //$("#Overview").ejOverview({ sourceID: "" });
        $("#main-left").animate({ width: '40px' }, 300, function () {
            openMinimizedPalette();
            setDiagramSize();
        });

        $("#EnableOverView").find("span").css("display", "none");
        diagram._enableOverView = false;
        $("#Overview-div").css("display", "none");
        updateSize();
    });
});

// #endregion

//#region document events

$(document).click(function (e) {
    if ($(e.target).is('#showMinimizedPlatedItemsparent,#showMinimizedPlatedItemsparent *')) {
        if (showMinimizedPalette) {
            if (document.getElementById("showMinimizedPlatedItemsparent"))
                document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";

        }
    }
    else {
        if (!showMinimizedPalette) {
            if (e.target.localName != "body" && document.getElementById("showMinimizedPlatedItemsparent")) {
                document.getElementById("showMinimizedPlatedItemsparent").style.display = "none";
                clearText()
            }
        }
    }
    showMinimizedPalette = false;
});

// #endregion

//#region Window Events



$(window).keydown(function (e) {
    // Save
    if (e.ctrlKey && e.keyCode == 83) {
        if (!(window.loadFileName) && !(window.saveFileName)) {
            $("#basicDialog").ejDialog("open");
            $(".e-dialog-scroller e-scroller e-js e-widget").css("height", "130.6px");
        }
        else if ((window.loadFileName) || (window.saveFileName)) {
            if (window.loadFileName)
                document.getElementById("SaveFileName").value = window.loadFileName;
            else if (window.saveFileName)
                document.getElementById("SaveFileName").value = window.saveFileName;
            saveFileAsString();
        }
        e.originalEvent.preventDefault();
    }
    if (e.keyCode == 13 && $(document.activeElement)[0] && $(document.activeElement)[0].id === "DiagramContent") {
        if (!this.diagram._isEditing && this.diagram.selectionList.length > 0) {
            var node = this.diagram.selectionList[0];
            if (node.labels[0] && !node.labels[0].readOnly) {
                diagram.startLabelEdit(node, node.labels[0]);
                this.diagram._isEditing = true;
                e.originalEvent.preventDefault();
            }
        }
    }

    // Open
    if (e.ctrlKey && e.keyCode == 79) {
        var hasProperties = false;
        $.each(localStorage, function (key, value) {
            hasProperties = true;
        });
        if (hasProperties) {
            openDialogOpen();
            $("#FileOpenDialog").ejDialog("open");
            $("#FileOpenDialog").css("height", "350px");
            $("#FileOpenDialog").css("width", "350px");
        } else {
            alert("There is no saved diagram");
        }
        e.originalEvent.preventDefault();
    }
    //Group
    if (e.ctrlKey && e.keyCode == 71) {
        e.originalEvent.preventDefault();
        diagram.group();
    }
    //UnGroup
    if (e.ctrlKey && e.keyCode == 85) {
        e.originalEvent.preventDefault();
        diagram.ungroup();
    }
    //Bring to Front
    if (e.ctrlKey && e.keyCode == 70) {
        e.originalEvent.preventDefault();
        diagram.bringToFront();
    }
    //Send to Back
    if (e.ctrlKey && e.keyCode == 66) {
        e.originalEvent.preventDefault();
        diagram.sendToBack();
    }
});

$(window).resize(function () {
    this.updateSize();
    setDiagramSize();
});

// #endregion

// #endregion

