//#region Global Variables.

var showMinimizedPalette = false;
var isPMinized = false;
var diagram;

var zoom = ej.datavisualization.Diagram.Zoom();
var saveData = null;
var userHandles = [];
var fillColor = null;
//#endregion

//#region Diagram Control Common Methods

function createUserHandles() {
    var CloneTool = (function (base) {
        ej.datavisualization.Diagram.extend(CloneTool, base);
        function CloneTool(name) {
            base.call(this, name);
            this.singleAction = true;
            this.clonedNodes = [];
            this.diffx = 0;
            this.diffy = 0;
            this.cursor = "pointer";
            this.check = false;
        }
        CloneTool.prototype.mousedown = function (evt) {
            base.prototype.mousedown.call(this, evt);
            this.selectedObject = this.diagram.selectionList[0];
            this.check = true;
        };
        CloneTool.prototype.mousemove = function (evt) {
            base.prototype.mousemove.call(this, evt);
            if (this.selectedObject) {
                if (!this.inAction) {
                    this.check = false;
                    this.inAction = true;
                    this.diagram.copy();
                    this.diagram.paste();
                    this.clonedNodes = [];
                    this.clonedNodes.push(this.diagram.nameTable[this.diagram.selectionList[0].name]);
                }
                else {
                    if (ej.datavisualization.Diagram.Util.canMove(this.clonedNodes[0]))
                        this._updateClonedNode(true);
                }
            }
            this.previousPoint = this.currentPoint;
        };
        CloneTool.prototype.mouseup = function (evt) {
            if (this.check) {
                this.diagram.copy();
                this.diagram.paste();
                this.clonedNodes = [];
                this.clonedNodes.push(this.diagram.nameTable[this.diagram.selectionList[0].name]);

            } else {
                if (this.inAction) {
                    this.inAction = false;
                    this._updateClonedNode(false);

                }
            }
            this.check = false;
            this.diagram.selectionList[0] = this.clonedNodes[0];
            this.clonedNodes = [];
            base.prototype.mouseup.call(this, evt);
        };
        CloneTool.prototype._updateClonedNode = function (isDragging) {
            var type = diagram.getObjectType(this.clonedNodes[0]);
            if ((type == "group" || this.clonedNodes[0].type == "bpmn") && this.clonedNodes[0].type != "pseudoGroup") {
                //this.clonedNodes[0].offsetX += (this.currentPoint.x - this.previousPoint.x);
                //this.clonedNodes[0].offsetY += (this.currentPoint.y - this.previousPoint.y);
                diagram._translate(this.clonedNodes[0], this.currentPoint.x - this.previousPoint.x, this.currentPoint.y - this.previousPoint.y, this.diagram.nameTable);
                ej.datavisualization.Diagram.SvgContext.update(this.clonedNodes[0], this.diagram);

            }
            else if (this.clonedNodes[0].type == "pseudoGroup") {
                diagram._translate(this.clonedNodes[0], this.currentPoint.x - this.previousPoint.x, this.currentPoint.y - this.previousPoint.y, this.diagram.nameTable);
                for (var i = 0, len = this.clonedNodes[0].children.length; i < len; i++) {
                    var child = this.diagram.nameTable[this.clonedNodes[0].children[i]];
                    ej.datavisualization.Diagram.SvgContext.update(child, this.diagram);
                }
            }
            else {
                for (var i = 0; i < this.clonedNodes.length; i++) {
                    type = diagram.getObjectType(this.clonedNodes[i]);
                    this.clonedNodes[i].offsetX += (this.currentPoint.x - this.previousPoint.x);
                    this.clonedNodes[i].offsetY += (this.currentPoint.y - this.previousPoint.y);
                    if (type == "group") {
                        this._updateXY(this.clonedNodes[i], this.previousPoint, this.currentPoint);
                        ej.datavisualization.Diagram.SvgContext.update(this.clonedNodes[i], this.diagram);

                    } else {
                        //this.clonedNodes[i].updatebounds();
                        ej.datavisualization.Diagram.SvgContext.update(this.clonedNodes[i], this.diagram);
                    }
                }
            }
            this.diagram.updateSelection(isDragging);
        };
        CloneTool.prototype._updateXY = function (shape, startPoint, endPoint) {
            var offsetwithoutsnap = ej.datavisualization.Diagram.Point(endPoint.x - startPoint.x, endPoint.y - startPoint.y);
            var towardsLeft = endPoint.x < startPoint.x;
            var towardsTop = endPoint.y < startPoint.y;
            var difx = this.diffx + (endPoint.x - startPoint.x) / this.diagram._getCurrentZoom();
            var dify = this.diffy + (endPoint.y - startPoint.y) / this.diagram._getCurrentZoom();
            var offset;
            offset = this.diagram._snapping._snapPosition(this.selectedObject, towardsLeft, towardsTop, ej.datavisualization.Diagram.Point(difx, dify), endPoint, startPoint);

            this.diffx = difx - offset.x;
            this.diffy = dify - offset.y;
            ej.datavisualization.Diagram.Util._translate(shape, (endPoint.x - startPoint.x), (endPoint.y - startPoint.y));

        };
        return CloneTool;
    })(ej.datavisualization.Diagram.ToolBase);

    var cloneHandle = ej.datavisualization.Diagram.UserHandle();
    cloneHandle.name = "Clone";
    cloneHandle.position = ej.datavisualization.Diagram.UserHandlePositions.BottomLeft;//"bottomLeft";
    cloneHandle.visible = true;
    cloneHandle.tool = new CloneTool(cloneHandle.name);
    cloneHandle.enableMultiSelection = true;
    cloneHandle.size = 30;
    cloneHandle.backgroundColor = "#4D4D4D";
    cloneHandle.pathData = "M4.6350084,4.8909971 L4.6350084,9.3649971 9.5480137,9.3649971 9.5480137,4.8909971 z M3.0000062,2.8189973 L11.184016,2.8189973 11.184016,10.999997 3.0000062,10.999997 z M0,0 L7.3649998,0 7.3649998,1.4020001 1.4029988,1.4020001 1.4029988,8.0660002 0,8.0660002 0,1.4020001 0,0.70300276 z";
    userHandles.push(cloneHandle);

    var AnchorTool = (function (base) {
        ej.datavisualization.Diagram.extend(AnchorTool, base);
        function AnchorTool(name) {
            base.call(this, name);
            this.singleAction = true;
            this.cursor = "pointer";
        }
        AnchorTool.prototype.mouseup = function (evt) {
            $("#tabitems").ejTab("option", "selectedItemIndex", 2);
            setDiagramSize(true);
            document.getElementById("propertyEditor").style.display = "block";
            var type = this.diagram.getObjectType(this.diagram.selectionList[0]);
            if (type != "pseudoGroup" && type != "group")
                setNodeDimension(this.diagram.selectionList[0]);
            ko.applyBindings(this.diagram._selectedObject.select(this.diagram.selectionList));
            base.prototype.mouseup.call(this, evt);
        }
        return AnchorTool;
    })(ej.datavisualization.Diagram.ToolBase);

    var anchorTool = ej.datavisualization.Diagram.UserHandle();
    anchorTool.name = "Label";
    anchorTool.position = ej.datavisualization.Diagram.UserHandlePositions.TopLeft;
    anchorTool.visible = true;

    anchorTool.tool = new AnchorTool(anchorTool.name);
    anchorTool.size = 30;
    anchorTool.backgroundColor = "#4D4D4D";
    anchorTool.enableMultiSelection = true;
    anchorTool.pathData = "M64.3965,24.4844L66.4545,18.5024C66.5335,18.2714,66.6035,17.9574,66.6645,17.5614L66.7285,17.8294C66.7985,18.2604,66.8425,18.3074,66.9045,18.5024L68.9865,24.4844z M68.1495,15.3334L65.3475,15.3334L59.7315,30.3334L62.4505,30.3334L63.7485,26.5144L69.6475,26.5144L70.9955,30.3334L73.7255,30.3334z";
    userHandles.push(anchorTool);


    var LinkTool = (function (base) {
        var node = null;
        var targetNode = null;
        ej.datavisualization.Diagram.extend(LinkTool, base);
        function LinkTool(name) {
            base.call(this, name);
            this.singleAction = true;
            this.cursor = "pointer";
            return this;
        }
        LinkTool.prototype.mousedown = function (evt) {
            node = this.diagram.selectionList[0];
            this._currentPossibleConnection = node;
            //    this._possibleConnectionPort = node.ports[0];
            base.prototype.mousedown.call(this, evt);
            this._showAllPorts();
            this.diagram.addSelection(node);
            this._sourcePossibleConnection = node;
            targetNode = null;
        };

        LinkTool.prototype.mouseup = function (evt) {
            if (evt.target.id == "Line_shape") {
                this.inAction = false;
                this.diagram._clearSelection();
                if (this.helper)
                    this.diagram._remove(this.helper);
                this.helper = null;
                this.svgHelper = null;
                base.prototype.mouseup.call(this, evt);
                this.diagram.deactivateTool();
                this.diagram.activateTool("orthogonalLine", true);
            }
            else {
                if (this._sourcePossibleConnection && this._sourcePossibleConnection.ports.length > 0)
                    if (!this._targetPossibleConnection) {
                        if (!this._targetPort) {
                            var dNode = this._createDynamicNode(node);
                            dNode.parent = "";
                            this.diagram.add(dNode);
                            this._targetPossibleConnection = this.diagram.nameTable[dNode.name];
                            //this._targetPort = dNode.ports[0];
                        }
                    }
                targetNode = this._targetPossibleConnection.name;
                this.diagram._updateEdges(this);
                this._showAllPorts(true);
                base.prototype.mouseup.call(this, evt);
            }

            if (targetNode) {
                this.diagram._clearSelection();
                //    this.diagram.selectionList.add(this._targetPossibleConnection)
                this.diagram.addSelection(targetNode)
            }

        };

        LinkTool.prototype._createDynamicNode = function (node) {
            var node = $.extend(true, {}, node);
            node.outEdges = [];
            node.inEdges = [];
            if (node.type == "bpmn") delete node.children;
            node.offsetX = this.currentPoint.x;
            node.offsetY = this.currentPoint.y;
            node.name = node.name + ej.datavisualization.Diagram.Util.randomId();
            return node;
        };
        return LinkTool;
    })(ej.datavisualization.Diagram.OrthogonalLineTool);

    var linkHandle = ej.datavisualization.Diagram.UserHandle();
    linkHandle.name = "Line";

    linkHandle.position = ej.datavisualization.Diagram.UserHandlePositions.MiddleRight;
    linkHandle.visible = true;

    linkHandle.tool = new LinkTool(linkHandle.name);
    linkHandle.size = 30;
    linkHandle.backgroundColor = "#4D4D4D";
    linkHandle.pathData = "M196.2104,93.6494L196.2104,90.2544L189.1674,90.2544L189.1674,87.6694L196.2104,87.6694L196.2104,84.7344L200.6674,89.1914z";
    userHandles.push(linkHandle);

    var SettingsTool = (function (base) {
        ej.datavisualization.Diagram.extend(SettingsTool, base);
        function SettingsTool(name) {
            base.call(this, name);
            this.singleAction = true;
            this.cursor = "pointer";
        }
        SettingsTool.prototype.mouseup = function (evt) {
            var type = diagram.getObjectType(diagram.selectionList[0]);
            if (type == "node" || diagram.selectionList[0].type == "pseudoGroup" || type == "group") {
                if (diagram.selectionList[0].type == "pseudoGroup") {
                    for (var i = 0; i < diagram.selectionList[0].children.length; i++) {
                        var child = diagram.nameTable[diagram.selectionList[0].children[i]];
                        if (!child.segments) {
                            $("#tabitems").ejTab("option", "selectedItemIndex", 1);
                            break;
                        }
                        else
                            $("#tabitems").ejTab("option", "selectedItemIndex", 3);
                    }
                }
                else
                    $("#tabitems").ejTab("option", "selectedItemIndex", 1);
            }
            else if (diagram.selectionList[0].segments) {
                $("#tabitems").ejTab("option", "selectedItemIndex", 3);
            }
            setDiagramSize(true);
            document.getElementById("propertyEditor").style.display = "block";
            ko.applyBindings(this.diagram._selectedObject.select(this.diagram.selectionList));
            var type = this.diagram.getObjectType(this.diagram.selectionList[0]);
            if (type != "pseudoGroup" && type != "group")
                setNodeDimension(this.diagram.selectionList[0]);
            base.prototype.mouseup.call(this, evt);
        }
        return SettingsTool;
    })(ej.datavisualization.Diagram.ToolBase);

    var settingHandle = ej.datavisualization.Diagram.UserHandle();
    settingHandle.name = "Settings";


    settingHandle.position = ej.datavisualization.Diagram.UserHandlePositions.BottomRight;
    settingHandle.visible = false;

    settingHandle.tool = new SettingsTool(settingHandle.name);
    settingHandle.size = 30;
    settingHandle.backgroundColor = "#4D4D4D";
    settingHandle.enableMultiSelection = true;
    settingHandle.pathData = "M22.0542,27.332C20.4002,27.332,19.0562,25.987,19.0562,24.333C19.0562,22.678,20.4002,21.333,22.0542,21.333C23.7082,21.333,25.0562,22.678,25.0562,24.333C25.0562,25.987,23.7082,27.332,22.0542,27.332 M30.6282,22.889L28.3522,22.889C28.1912,22.183,27.9142,21.516,27.5272,20.905L29.1392,19.293C29.3062,19.126,29.3062,18.853,29.1392,18.687L27.7032,17.251C27.6232,17.173,27.5152,17.125,27.3982,17.125C27.2862,17.125,27.1782,17.173,27.0952,17.251L25.4872,18.863C24.8732,18.476,24.2082,18.201,23.5002,18.038L23.5002,15.762C23.5002,15.525,23.3092,15.333,23.0732,15.333L21.0422,15.333C20.8062,15.333,20.6122,15.525,20.6122,15.762L20.6122,18.038C19.9072,18.201,19.2412,18.476,18.6292,18.863L17.0192,17.252C16.9342,17.168,16.8242,17.128,16.7162,17.128C16.6052,17.128,16.4972,17.168,16.4112,17.252L14.9752,18.687C14.8952,18.768,14.8492,18.878,14.8492,18.99C14.8492,19.104,14.8952,19.216,14.9752,19.293L16.5872,20.905C16.2002,21.516,15.9242,22.183,15.7642,22.889L13.4852,22.889C13.2502,22.889,13.0572,23.08,13.0572,23.316L13.0572,25.35C13.0572,25.584,13.2502,25.777,13.4852,25.777L15.7612,25.777C15.9242,26.486,16.2002,27.15,16.5872,27.764L14.9752,29.374C14.8092,29.538,14.8092,29.813,14.9752,29.979L16.4112,31.416C16.4912,31.494,16.6022,31.541,16.7162,31.541C16.8272,31.541,16.9382,31.494,17.0192,31.416L18.6252,29.805C19.2412,30.191,19.9072,30.467,20.6122,30.63L20.6122,32.906C20.6122,33.141,20.8062,33.333,21.0422,33.333L23.0732,33.333C23.3092,33.333,23.5002,33.141,23.5002,32.906L23.5002,30.63C24.2082,30.467,24.8732,30.191,25.4872,29.805L27.0952,31.416C27.1812,31.499,27.2892,31.541,27.3982,31.541C27.5102,31.541,27.6202,31.499,27.7032,31.416L29.1392,29.979C29.2202,29.899,29.2662,29.791,29.2662,29.677C29.2662,29.563,29.2202,29.453,29.1392,29.374L27.5312,27.764C27.9142,27.149,28.1912,26.486,28.3522,25.777L30.6282,25.777C30.8652,25.777,31.0552,25.584,31.0552,25.35L31.0552,23.316C31.0552,23.08,30.8652,22.889,30.6282,22.889";
    userHandles.push(settingHandle);
    return userHandles;


}

function updateSize() {
    var width = $(document).width() - $("#main-left").width();
    $("#main-right").css("width", width);
    var pixels = document.getElementById("sample-header").getBoundingClientRect().height;
    var screenHeight = document.body.clientHeight;
    document.getElementById("sample-main").style.height = (screenHeight - pixels) - 2 + "px";
    var palette = $("#symbolpalette").ejSymbolPalette("instance");
    if (diagram._enableOverView)
        var height = $("#main-left").height() - $(".searchicon-parent-div1").height() - $("#Overview-div").height() - 20;
    else
        height = $("#main-left").height() - $(".searchicon-parent-div1").height();
    palette.setHeight(height + "px");
    palette.updateScrollerViewport();
}

function setZoomSlider() {
    //$("#overviewSlider").ejSlider('option', 'value', String(Math.round(diagram._getCurrentZoom() * 100)));
    //$("#minSlider").ejSlider('option', 'value', String(Math.round(diagram._getCurrentZoom() * 100)));
    //var sliderValue = document.getElementsByClassName("sliderValue");
    //for (var i = 0; i < sliderValue.length; i++)
    //    sliderValue[i].textContent = String(Math.round(diagram._getCurrentZoom() * 100)) + "%";
}

function setDiagramSize(showpropeditor) {

    var width = $(window).width() - $("#main-left").width();
    var pwidth = $("#propertyEditor").width();
    if (!showpropeditor)
        pwidth = 0;
    $("#main-right").css("width", width - pwidth);
    diagram.updateViewPort();
}

function updateNodeProperties(args, prop) {

    if (!diagram._selectedObject.selected) {
        diagram._modified = true;
        var selectedObject = diagram._selectedObject;
        if (diagram.model.selectedItems.children.length > 0) {
            for (var i = 0; i < diagram.model.selectedItems.children.length; i++) {
                var item = diagram.model.selectedItems.children[i];
                var type = diagram.getObjectType(item);
                if (type !== "connector") {
                    var option = {};
                    switch (prop) {
                        case "width":
                            if (!item.isLane)
                                selectedObject.width = option.width = args.value;
                            break;
                        case "height":
                            if (!item.isLane)
                                selectedObject.height = option.height = args.value;
                            break;
                        case "aspectRatio":
                            option.constraints = item.constraints ^ ej.datavisualization.Diagram.NodeConstraints.AspectRatio;
                            break;
                        case "pinX":
                            selectedObject.offsetX = option.offsetX = args.value;
                            break;
                        case "pinY":
                            selectedObject.offsetY = option.offsetY = args.value;
                            break;
                        case "borderWidth":
                            selectedObject.borderthickness = option.borderWidth = Number(String(args.text).substring(0, args.text.length - 3));
                            if (item.borderWidth != option.borderWidth)
                                setThickness(item, "borderWidth");
                            break;
                        case "Gradient":
                            if (item.type != "text") {
                                option.gradient = null;
                                selectedObject.gradientDivColor = "#F9F9F9";
                                if (!item.gradient) {
                                    if (item.type === "group")
                                        option.gradient = this.getNewGradient(selectedObject.fillColor);
                                    else
                                        option.gradient = this.getNewGradient(item.fillColor);
                                    selectedObject.gradientDivColor = "#28B1BF";
                                }
                            }
                            break;
                        case "Lock":
                            {
                                var constraints;
                                if (!selectedObject.lock) {
                                    selectedObject.lockfontColor = "#FFFFFF";
                                    selectedObject.lockDivColor = "#28B1BF";
                                    constraints = ej.datavisualization.Diagram.NodeConstraints.Select;
                                }
                                else {
                                    selectedObject.lockfontColor = "#7F7F7F";
                                    selectedObject.lockDivColor = "#F9F9F9";
                                    constraints = ej.datavisualization.Diagram.NodeConstraints.Default;
                                }
                                if (item.constraints & ej.datavisualization.Diagram.NodeConstraints.AspectRatio)
                                    constraints = constraints | ej.datavisualization.Diagram.NodeConstraints.AspectRatio;
                                if (item.constraints & ej.datavisualization.Diagram.NodeConstraints.Shadow)
                                    constraints = constraints | ej.datavisualization.Diagram.NodeConstraints.Shadow;
                                option.constraints = constraints;
                                if (i == diagram.model.selectedItems.children.length - 1) selectedObject.lock = !selectedObject.lock;
                                break;
                            }
                        case "Fill":
                            selectedObject.fillColor = option.fillColor = args.style.backgroundColor;
                            if (item.gradient != null) {
                                option.gradient = this.getNewGradient(args.style.backgroundColor);
                            }
                            break;
                        case "Opacity":
                            selectedObject.opacity = option.opacity = args.value / 100;
                            break;
                        case "Stroke":
                            selectedObject.stroke = option.borderColor = args.style.backgroundColor;
                            break;
                    }
                    if (Object.keys(option).length > 0) {
                        if (item && type === "group") {
                            updateGroup(item, diagram, option);
                        }
                        else if (!(item.type && item.type === "phase"))
                            diagram.updateNode(item.name, option);
                        ko.applyBindings(diagram._selectedObject);
                    }
                    else
                        this.updateText(prop, item, args, diagram);
                }
            }
        }
    }
}

function updateGroup(item, diagram, option) {
    if (item.children && item.children.length > 0)
        var children = item.children;
    if (children) {
        for (var i = 0; i < children.length; i++) {
            var child = diagram.nameTable[diagram._getChild(children[i])];
            var childType = diagram.getObjectType(child);
            if (child) {
                if (child.type != "group") {
                    if (option && option.fillColor) {
                        if (child.gradient != null) {
                            option.gradient = this.getNewGradient(option.fillColor);
                        }
                    }
                    diagram.updateNode(child.name, option);
                }
                else if (childType === "group")
                    updateGroup(child, diagram, option)
            }
        }
    }
}

function updateConnectorProperty(item, prop, args) {
    var type = diagram.getObjectType(item);
    if (type === "connector") {
        var option = {};
        var selectedObject = diagram._selectedObject;
        switch (prop) {
            case "LineStrokeColor":
                selectedObject.lineColor = option.lineColor = args.style.backgroundColor;
                option.sourceDecorator = item.sourceDecorator;
                option.targetDecorator = item.targetDecorator;
                option.sourceDecorator.borderColor = option.targetDecorator.borderColor = args.style.backgroundColor;
                option.sourceDecorator.fillColor = option.targetDecorator.fillColor = args.style.backgroundColor;
                break;
            case "LineWidth":
                selectedObject.lineWidth = option.lineWidth = Number(String(args.text).substring(0, args.text.length - 3));
                option.sourceDecorator = item.sourceDecorator;
                option.targetDecorator = item.targetDecorator;
                option.sourceDecorator.width = option.lineWidth * item.sourceDecorator.width / item.lineWidth;;
                option.sourceDecorator.height = option.lineWidth * item.sourceDecorator.height / item.lineWidth;
                option.targetDecorator.width = option.lineWidth * item.targetDecorator.width / item.lineWidth;
                option.targetDecorator.height = option.lineWidth * item.targetDecorator.height / item.lineWidth;
                setThickness(item, "lineWidth");
                break;

            case "HeadDecorator":
            case "TailDecorator":
                var decorator = new Object();
                switch (String(args.itemId)) {
                    case "0":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "none", fillColor: item.lineColor });
                        break;
                    case "1":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "arrow", fillColor: item.lineColor });
                        break;
                    case "2":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "diamond", fillColor: item.lineColor });
                        break;
                    case "3":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "circle", fillColor: item.lineColor });
                        break;
                    case "4":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "path", pathData: "M 376.892,225.284L 371.279,211.95L 376.892,198.617L 350.225,211.95L 376.892,225.284 Z", fillColor: item.lineColor });
                        break;
                    case "5":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "arrow", fillColor: "white" });
                        break;
                    case "6":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "diamond", fillColor: "white" });
                        break;
                    case "7":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "circle", fillColor: "white" });
                        break;
                    case "8":
                        decorator = ej.datavisualization.Diagram.Decorator({ shape: "path", pathData: "M 376.892,225.284L 371.279,211.95L 376.892,198.617L 350.225,211.95L 376.892,225.284 Z", fillColor: "white" });
                        break;
                }
                if (prop === "HeadDecorator") {
                    decorator.width = item.sourceDecorator.width;
                    decorator.height = item.sourceDecorator.height;
                    decorator.borderColor = item.lineColor;
                    selectedObject.headDecorator = option.sourceDecorator = decorator;

                }
                else {
                    decorator.width = item.targetDecorator.width;
                    decorator.height = item.targetDecorator.height;
                    decorator.borderColor = item.lineColor;
                    selectedObject.tailDecorator = option.targetDecorator = decorator;
                }

                break;
            case "ConnectorType":
                switch (args.text) {
                    case "Straight":
                        option.segments = [{ type: "straight" }];
                        break;
                    case "Bezier":
                        option.segments = [{ type: "bezier" }];
                        break;
                    case "Orthogonal":
                        option.segments = [{ type: "orthogonal" }];
                        break;
                }
                selectedObject.line = option.segments;
                break;

            case "LineStyle":
                switch (String(args.itemId)) {
                    case "0":
                        option.lineDashArray = "0,0";
                        break;
                    case "1":
                        option.lineDashArray = "10,10";
                        break;
                    case "2":
                        option.lineDashArray = "2,2";
                        break;
                    case "3":
                        option.lineDashArray = "20,5,5,5";
                        break;
                }
                break;
            case "Lock":
                var constraints;
                if (!selectedObject.lock)
                    constraints = ej.datavisualization.Diagram.ConnectorConstraints.Select;
                else
                    constraints = ej.datavisualization.Diagram.ConnectorConstraints.Default;
                if (item.constraints & ej.datavisualization.Diagram.ConnectorConstraints.Bridging)
                    constraints = constraints | ej.datavisualization.Diagram.ConnectorConstraints.Bridging;
                if (item.constraints & ej.datavisualization.Diagram.ConnectorConstraints.DragLabel)
                    constraints = constraints | ej.datavisualization.Diagram.ConnectorConstraints.DragLabel;
                option.constraints = constraints;
                break;

        }
        if (Object.keys(option).length > 0) {
            if (item && type === "group") {
                updateGroup(item, diagram, option);
            }
            else
                diagram.updateConnector(item.name, option);
            if (prop === "ConnectorType") {
                setDiagramSize(true);
                document.getElementById("propertyEditor").style.display = "block";
                var type = this.diagram.getObjectType(this.diagram.selectionList[0]);
                if (type != "pseudoGroup" && type != "group")
                    setNodeDimension(this.diagram.selectionList[0]);
            }
            ko.applyBindings(diagram._selectedObject);
        }
        else
            this.updateText(prop, item, args, diagram);
    }
}


function updateConnectorProperties(args, prop) {

    if (!diagram._selectedObject.selected) {
        diagram._modified = true;
        if (diagram.model.selectedItems.children.length > 0) {
            for (var i = 0; i < diagram.model.selectedItems.children.length; i++) {
                var item = diagram.model.selectedItems.children[i];
                var type = diagram.getObjectType(item);
                if (item.type === "group") {
                    for (var j = 0; j < item.children.length; j++) {
                        var child = diagram.nameTable[diagram._getChild(item.children[j])];
                        if (child && child.segments) {
                            updateConnectorProperty(child, prop, args);
                            if (i == diagram.model.selectedItems.children.length - 1 && prop == "Lock") diagram._selectedObject.lock = !diagram._selectedObject.lock;
                        }
                    }
                }
                else if (type == "connector") {
                    updateConnectorProperty(item, prop, args);
                    if (i == diagram.model.selectedItems.children.length - 1 && prop == "Lock") diagram._selectedObject.lock = !diagram._selectedObject.lock;
                }
            }
        }
    }
}

function getNewGradient(value) {
    var gradient = {
        type: "linear", x1: 0, x2: 21, y1: -50, y2: 115, stops: [
        { color: "white", offset: -200 }, { color: value, offset: 230 }]
    };
    return gradient;
}

function updateText(prop, item, args) {
    var option = {};
    var label = item.type === "text" ? item.textBlock : item.labels[0];
    var selectedObject = diagram._selectedObject;
    switch (prop) {
        case "TextColor":
            selectedObject.labelfontColor = option.fontColor = args.style.backgroundColor;
            break;
        case "Bold":
            option.bold = selectedObject.bold = label ? !label.bold : !selectedObject.bold;
            if (option.bold) {
                selectedObject.boldDivColor = "#28B1BF";
                selectedObject.boldfontColor = "#FFFFFF";
            }
            else {
                selectedObject.boldDivColor = "#F9F9F9";
                selectedObject.boldfontColor = "#7F7F7F";
            }
            break;
        case "Italic":
            option.italic = selectedObject.italic = label ? !label.italic : !selectedObject.italic;
            if (option.italic) {
                selectedObject.boldDivColor = ko.observable("#28B1BF");
                selectedObject.boldfontColor = ko.observable("#FFFFFF");
            }
            else {
                selectedObject.boldDivColor = ko.observable("#F9F9F9");
                selectedObject.boldfontColor = ko.observable("#7F7F7F");
            }
            break;
        case "fontSize":
            selectedObject.labelfontSize = option.fontSize = Number(args.text);
            break;
        case "fontFamily":
            selectedObject.labelfontFamily = option.fontFamily = args.text;
            break;
        case "left":
        case "right":
        case "center":
            {

                selectedObject.textLeftAlign = false;
                selectedObject.textLeftAlignfont = "#7F7F7F";
                selectedObject.textLeftAlignDiv = "#F9F9F9";
                selectedObject.textRightAlign = false;
                selectedObject.textRightAlignfont = "#7F7F7F";
                selectedObject.textRightAlignDiv = "#F9F9F9";
                selectedObject.textCenterAlign = false;
                selectedObject.textCenterAlignfont = "#7F7F7F";
                selectedObject.textCenterAlignDiv = "#F9F9F9";
                if (!(item.isSwimlane || item.isLane)) {
                    option.horizontalAlignment = prop;
                    option.textAlign = prop;
                    if (prop == "left") {
                        selectedObject.textLeftAlign = true;
                        selectedObject.textLeftAlignfont = "#FFFFFF";
                        selectedObject.textLeftAlignDiv = "#28B1BF";
                        option.offset = ej.datavisualization.Diagram.Point(0, 0.5);
                    }
                    else if (prop == "right") {
                        selectedObject.textRightAlign = true;
                        selectedObject.textRightAlignfont = "#FFFFFF";
                        selectedObject.textRightAlignDiv = "#28B1BF";
                        option.offset = ej.datavisualization.Diagram.Point(1, 0.5);
                    }
                    else {
                        selectedObject.textCenterAlign = true;
                        selectedObject.textCenterAlignfont = "#FFFFFF";
                        selectedObject.textCenterAlignDiv = "#28B1BF";
                        option.offset = ej.datavisualization.Diagram.Point(0.5, 0.5);
                    }
                }
            }
            break;

    }
    if (Object.keys(option).length > 0) {
        if (item.type === "text")
            diagram.updateLabel(item.name, item.textBlock, option);
        else {
            for (var i = 0; i < item.labels.length; i++) {
                diagram.updateLabel(item.name, item.labels[i], option);
            }
        }
        ko.applyBindings(diagram._selectedObject);
    }
}
//#endregion

//#region SymbolPalette Common Methods
function setPaletteCollections() {

    window.basicShapes = [];
    window.flowShapes = [];
    window.electricalShapes = [];
    window.arrowShapes = [];
    window.bpmnShapes = [];
    window.connectors = [];
    window.iterligentShapes = [];

    var palette = $("#symbolpalette").ejSymbolPalette("instance");
    for (var i = 0; i < palette.model.palettes.length; i++) {
        var symPalette = palette.model.palettes[i];
        var j;
        switch (symPalette.name) {
            case "Basic Shapes":
                for (j = 0; j < symPalette.items.length; j++) {
                    window.basicShapes.push($.extend(true, {}, symPalette.items[j]));
                }
                break;
            case "Flowchart Shapes":
                for (j = 0; j < symPalette.items.length; j++) {
                    window.flowShapes.push($.extend(true, {}, symPalette.items[j]));
                }
                break;
            case "Arrow Shapes":
                for (j = 0; j < symPalette.items.length; j++) {
                    window.arrowShapes.push($.extend(true, {}, symPalette.items[j]));
                }
                break;
            case "Electrical Shapes":
                for (j = 0; j < symPalette.items.length; j++) {
                    window.electricalShapes.push($.extend(true, {}, symPalette.items[j]));
                }
                break;
            case "BPMN Shapes":
                for (j = 0; j < symPalette.items.length; j++) {
                    window.bpmnShapes.push($.extend(true, {}, symPalette.items[j]));
                }
                break;
            case "Connectors":
                for (j = 0; j < symPalette.items.length; j++) {
                    window.connectors.push($.extend(true, {}, symPalette.items[j]));
                }
                break;
            case "Intelligent Shapes":
                for (j = 0; j < symPalette.items.length; j++) {
                    window.iterligentShapes.push($.extend(true, {}, symPalette.items[j]));
                }
                break;
        }
    }
}
//#endregion

//#region Minimized Palette Interaction/Search Methods

function openMinimizedPalette() {

    document.getElementById("palette-div1").style.display = "none";
    document.getElementById("no_match_found").style.display = "none";

    document.getElementById("minimizedPalette").style.display = "block";
    document.getElementById("minimizedPalette").innerHTML = "";
    $(".chat-bubble-arrow-border-maxi").css("display", "none");
    $(".chat-bubble-arrow-maxi").css("display", "none");
    var palette = $("#symbolpalette").ejSymbolPalette("instance");
    if (palette && palette.model.palettes.length) {
        var mPaletteDiv = document.getElementById("minimizedPalette");
        mPaletteDiv.style.height = "100%";
        mPaletteDiv.style.width = "40px";
        mPaletteDiv.style.backgroundColor = "transparent";
        mPaletteDiv.style.borderColor = "1px solid lightgray";
        mPaletteDiv.style.position = "relative";
        createMaxmizePalette(mPaletteDiv, "maximizesp");
        createSearchDiv(mPaletteDiv);
        createPletteDiv(palette, mPaletteDiv);
        createOverviewDiv(mPaletteDiv);
    }
}
function createMaxmizePalette(mPaletteDiv, id) {
    var nDiv; nDiv = document.createElement("div");
    nDiv.setAttribute("id", id);
    nDiv.setAttribute("title", "Maximize Palette");
    nDiv.setAttribute("class", id);
    nDiv.style.width = "100%";
    nDiv.style.height = "40px";
    nDiv.onclick = maximize;
    mPaletteDiv.appendChild(nDiv);
}
function createSearchDiv(mPaletteDiv, id) {
    var nDiv; nDiv = document.createElement("div");
    nDiv.setAttribute("class", "searchsp");
    nDiv.setAttribute("title", "Search from palette");
    nDiv.style.width = "100%";
    nDiv.style.height = "40px";
    nDiv.onclick = Search;
    mPaletteDiv.appendChild(nDiv);
}
function createOverviewDiv(mPaletteDiv) {
    var nDiv; nDiv = document.createElement("div");
    nDiv.setAttribute("class", "overviewsp");
    nDiv.setAttribute("title", "Overview");
    nDiv.style.width = "100%";
    nDiv.style.height = "40px";
    nDiv.onclick = Overview;
    mPaletteDiv.appendChild(nDiv);
}
function createPletteDiv(palette, mPaletteDiv) {
    var nDiv;
    for (var i = 0; i < palette.model.palettes.length; i++) {
        //if (palette.model.palettes[i].name != "BPMN Shapes") {
        nDiv = document.createElement("div");
        nDiv.style.width = "100%";
        nDiv.style.height = "40px";
        if (palette.model.palettes[i].name !== "Swimlane Shapes")
            nDiv.onclick = $.proxy(this.HiddenPaletteClick, this);
        nDiv.setAttribute("id", palette.model.palettes[i].name);
        nDiv.setAttribute("title", palette.model.palettes[i].name);
        if (palette.model.palettes[i].name != "BPMN Gateway")
            nDiv.setAttribute("class", (palette.model.palettes[i].name).split(" ")[0] + "sp");
        else
            nDiv.setAttribute("class", (palette.model.palettes[i].name).split(" ")[0] + "sp1");
        mPaletteDiv.appendChild(nDiv);
        //}
    }
}

function createShowMinimizedPlatedItems() {

    var div = document.getElementById("showMinimizedPlatedItemsparent");
    div.setAttribute("id", "showMinimizedPlatedItemsparent");

    var divChild = document.createElement("div");
    divChild.setAttribute("id", "showMinimizedPlatedItems");
    div.appendChild(divChild);

    divChild = document.createElement("div");
    divChild.setAttribute("class", "chat-bubble-arrow-border-mini");
    div.appendChild(divChild);

    divChild = document.createElement("div");
    divChild.setAttribute("class", "chat-bubble-arrow-mini");
    div.appendChild(divChild);


    div.style.position = "absolute";
    div.style.height = "auto";
    div.style.width = "250px";
    div.style.backgroundColor = "white";
    div.style.border = "1px solid lightgray";
    div.style.borderRadius = "5px";
    div.style.left = "100px";
    div.style.top = "100px";
    div.style.padding = "10px";
    document.body.appendChild(div);
}
function createShowMaximizedPlatedItems() {

    var parent = document.getElementById("showMinimizedPlatedItemsparent");
    for (var i = 0; i < parent.childNodes.length; i++) {
        if (parent.childNodes[i].name == "arrow1" || parent.childNodes[i].name == "arrow2")
            parent.removeChild(childNodes[i]);
    }

    var div = parent;

    var divChild = document.createElement("div");
    divChild.setAttribute("id", "arrow1");
    divChild.setAttribute("class", "chat-bubble-arrow-border-maxi");
    div.appendChild(divChild);

    divChild = document.createElement("div");
    divChild.setAttribute("id", "arrow2");
    divChild.setAttribute("class", "chat-bubble-arrow-maxi");
    div.appendChild(divChild);


    div.style.position = "absolute";
    div.style.height = "auto";
    div.style.width = "250px";
    div.style.backgroundColor = "white";
    div.style.border = "1px solid lightgray";
    div.style.borderRadius = "5px";
    div.style.left = "100px";
    div.style.top = "100px";
    div.style.padding = "10px";
    document.body.appendChild(div);
}
function createShowMaximizedOverview() {

    var div = document.getElementById("showMinimizedPlatedItemsparent");
    div.setAttribute("id", "showMinimizedPlatedItemsparent");
    var childNodes = []
    for (var i = 0; i < div.childNodes.length; i++) {
        if (div.childNodes[i].className == "chat-bubble-arrow-mini" || div.childNodes[i].className == "chat-bubble-arrow-border-mini")
            childNodes.push(div.childNodes[i]);
    }
    for (var i = 0; i < childNodes.length; i++) {
        div.removeChild(childNodes[i]);
    }
    div.style.position = "absolute";
    div.style.height = "auto";
    div.style.width = "250px";
    div.style.backgroundColor = "white";
    div.style.border = "1px solid lightgray";
    div.style.left = "100px";
    div.style.top = "100px";
    div.style.borderRadius = "0px";
    div.style.padding = "0px";
    document.body.appendChild(div);
}
function maximize() {

    isPMinized = false;
    document.getElementById("minimizedPalette").style.display = "none";

    if (document.getElementById("propertyEditor").style.display == "block") {
        document.getElementById("main-right").style.width = "63%";
    }
    else {
        document.getElementById("main-right").style.width = "80%";
    }
    document.getElementById("Overview-div").style.left = 0;
    document.getElementById("Overview-div").style.bottom = 0;
    document.getElementById("Overview-div").style.top = null;
    $("#main-left").animate({ width: '270px' }, 300, function () {
        setDiagramSize();
        if (document.getElementById("Overview-div").style.display == "block")
            $("#Overview").ejOverview({ sourceID: "DiagramContent" });
    });



    document.getElementById("palette-div1").style.display = "block";
    if (diagram._enableOverView) {
        $("#Overview").ejOverview({ sourceID: "DiagramContent" });
        document.getElementById("Overview-div").style.display = "block";
    }
    updateSize();
}
function HiddenPaletteClick(evt) {
    var maxiPalette = $("#maxi_Search").ejSymbolPalette("instance");
    var maxipalettes = maxiPalette.model.palettes;
    for (var i = maxipalettes[0].items.length - 1; i >= 0; i--) {
        maxiPalette.removePaletteItem(maxipalettes[0].name, maxipalettes[0].items[i]);
    }
    maxiPalette.updateScrollerViewport();
    createShowMinimizedPlatedItems();
    var bounds = evt.currentTarget.getBoundingClientRect();
    document.getElementById("showMinimizedPlatedItemsparent").style.left = bounds.right + 20 + "px";
    document.getElementById("showMinimizedPlatedItemsparent").style.top = bounds.top - 50 + "px";
    document.getElementById("showMinimizedPlatedItemsparent").style.position = "absolute";
    document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";
    document.getElementById("maxi_Search").style.width = "255px";
    document.getElementById("maxi_Search").style.height = "auto";
    document.getElementById("maxi_Search").style.display = "block";
    document.getElementById("maxi_search_content").style.display = "block";
    document.getElementById("Overview-div").style.display = "none";
    $("#Overview").ejOverview({ sourceID: "" });
    $(".chat-bubble-arrow-border-mini").css("display", "block");
    $(".chat-bubble-arrow-mini").css("display", "block");
    $(".searchicon-parent-div").css("display", "none");

    if (evt.target.id === "Basic Shapes") {
        for (var j = 0; j < window.basicShapes.length; j++) {
            maxiPalette.addPaletteItem(maxipalettes[0].name, window.basicShapes[j]);
        }
    }
    if (evt.target.id === "Connectors") {
        for (var j = 0; j < window.connectors.length; j++) {
            maxiPalette.addPaletteItem(maxipalettes[0].name, window.connectors[j]);
        }
    }
    if (evt.target.id === "Flowchart Shapes") {
        for (var j = 0; j < window.flowShapes.length; j++) {
            maxiPalette.addPaletteItem(maxipalettes[0].name, window.flowShapes[j]);
        }
    }
    if (evt.target.id === "Electrical Shapes") {
        for (var j = 0; j < window.electricalShapes.length; j++) {
            maxiPalette.addPaletteItem(maxipalettes[0].name, window.electricalShapes[j]);
        }
    }
    if (evt.target.id === "Arrow Shapes") {
        for (var j = 0; j < window.arrowShapes.length; j++) {
            maxiPalette.addPaletteItem(maxipalettes[0].name, window.arrowShapes[j]);
        }
    }
    if (evt.target.id === "BPMN Shapes") {
        for (var j = 0; j < window.bpmnShapes.length; j++) {
            maxiPalette.addPaletteItem(maxipalettes[0].name, window.bpmnShapes[j]);
        }
    }
    setToolTip();
    if (evt.target.id === "Electrical Shapes") document.getElementById("showMinimizedPlatedItemsparent").style.height = $("#main-right").height() - 200 + "px";
    else document.getElementById("showMinimizedPlatedItemsparent").style.height = "auto";
    maxiPalette.updateScrollerViewport();
    showMinimizedPalette = true;
    document.getElementById("basicShapes_Search").style.maxHeight = "330px";
    document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";
}

function setToolTip(isLoad) {
    var paletteItems;
    if (isLoad)
        paletteItems = $(".e-paletteItem");
    else
        paletteItems = $("#maxi_search_content")[0].childNodes;
    for (m = 0; m < paletteItems.length; m++) {
        var title = "";
        var wWord = ((paletteItems[m].id).split("_")[0]);
        if (wWord) {
            if (wWord.split(/(?=[A-Z])/)[0])
                title += " " + wWord.split(/(?=[A-Z])/)[0];
            if (wWord.split(/(?=[A-Z])/)[1])
                title += " " + wWord.split(/(?=[A-Z])/)[1];
            if (wWord.split(/(?=[A-Z])/)[2])
                title += " " + wWord.split(/(?=[A-Z])/)[2];
            if (wWord.split(/(?=[A-Z])/)[3])
                title += " " + wWord.split(/(?=[A-Z])/)[3];
            if (wWord.split(/(?=[A-Z])/)[4])
                title += " " + wWord.split(/(?=[A-Z])/)[4];
        }
        paletteItems[m].setAttribute("title", title);
    }
}

function clearText() {
    if (document.getElementById("textbox_maxi"))
        document.getElementById("textbox_maxi").value = "";
    if (document.getElementById("miniSearchBox"))
        document.getElementById("miniSearchBox").value = "";
    if (document.getElementById("searchbox_icon-mini"))
        document.getElementById("searchbox_icon-mini").style.backgroundImage = 'url("../../css/diagram/images/Search-Find.png")';
    if (document.getElementById("searchbox_icon-maxi"))
        document.getElementById("searchbox_icon-maxi").style.backgroundImage = 'url("../../css/diagram/images/Search-Find.png")';
    onSearchBoxTextChange();
}
function Search(evt) {

    document.getElementById("no_match_found").style.display = "none";

    createShowMinimizedPlatedItems();
    var pdiv = document.createElement("div");
    pdiv.setAttribute("class", "searchicon-parent-div");

    var cdiv = document.createElement("div");
    cdiv.setAttribute("id", "searchbox_icon-mini");
    cdiv.setAttribute("class", "searchbox_icon-mini");
    cdiv.onclick = clearText;
    var textBox = document.createElement("input");
    pdiv.appendChild(textBox);
    pdiv.appendChild(cdiv);

    textBox.style.height = "30px";
    textBox.style.width = "80%";
    textBox.style.outline = "none";
    textBox.style.marginLeft = "4px";
    textBox.setAttribute("type", "text");
    textBox.setAttribute("id", "miniSearchBox");
    textBox.onkeyup = onSearchBoxTextChange;
    textBox.style.border = "none";

    if (document.getElementById("showMinimizedPlatedItemsparent").firstChild)
        document.getElementById("showMinimizedPlatedItemsparent").insertBefore(pdiv, document.getElementById("showMinimizedPlatedItemsparent").firstChild);
    else
        document.getElementById("showMinimizedPlatedItemsparent").appendChild(pdiv);


    var bounds = evt.currentTarget.getBoundingClientRect();
    document.getElementById("showMinimizedPlatedItemsparent").style.left = bounds.right + 20 + "px";
    document.getElementById("showMinimizedPlatedItemsparent").style.top = bounds.top - 30 + "px";


    document.getElementById("maxi_Search").style.display = "none";
    document.getElementById("basicShapes_Search").style.display = "none";
    document.getElementById("flowShapes_search").style.display = "none";
    document.getElementById("electrical_Search").style.display = "none";
    document.getElementById("connectors_Search").style.display = "none";
    document.getElementById("intelligent_Search").style.display = "none";
    document.getElementById("Overview-div").style.display = "none";
    $("#Overview").ejOverview({ sourceID: "" });
    $(".chat-bubble-arrow-border-mini").css("display", "block");
    $(".chat-bubble-arrow-mini").css("display", "block");
    $(".chat-bubble-arrow-border-maxi").css("display", "none");
    $(".chat-bubble-arrow-maxi").css("display", "none");
    if ($(".searchicon-parent-div").length > 1) {
        for (var i = 1; i < $(".searchicon-parent-div").length; i++) {
            $(".searchicon-parent-div")[i].parentNode.removeChild($(".searchicon-parent-div")[i]);
        }
    }
    $(".searchicon-parent-div").css("display", "block");


    if (document.getElementById("showMinimizedPlatedItemsparent"))
        document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";
    showMinimizedPalette = true;
    if ($("#showMinimizedPlatedItems")[0].childNodes.length > 0) {
        var count = $("#showMinimizedPlatedItems")[0].childNodes.length;
        for (var i = 0; i < count; i++)
            if ((i % 2) == 0)
                $("#showMinimizedPlatedItems")[0].childNodes[i].style.display = "block";
    }
    if (document.getElementById("maxi_Search"))
        document.getElementById("maxi_Search").style.maxHeight = "400px";
    document.getElementsByClassName("chat-bubble-arrow-mini")[0].style.top = "28px;";
    document.getElementsByClassName("chat-bubble-arrow-border-mini")[0].style.top = "28px;";

    document.getElementById("showMinimizedPlatedItems").style.display = "none";

    document.getElementById("maxi_Search").style.width = "255px";
    document.getElementById("maxi_Search").style.height = "auto";
    document.getElementById("maxi_Search").style.display = "none";
    document.getElementById("miniSearchBox").value = "";
    $(".searchicon-parent-div").css("display", "block");
}
function Overview(evt) {
    //createShowMaximizedOverview();
    document.getElementById("showMinimizedPlatedItemsparent").style.display = "none";
    if (document.getElementById("Overview-div").style.display != "block") {
        var bounds = evt.currentTarget.getBoundingClientRect();
        document.getElementById("Overview-div").style.left = bounds.right + 1 + "px";
        document.getElementById("Overview-div").style.bottom = 20 + "px";
        document.getElementById("Overview-div").style.position = "absolute";
        document.getElementById("maxi_Search").style.display = "none";
        document.getElementById("maxi_search_content").style.display = "block";
        document.getElementById("Overview-div").style.display = "block";
        $("#Overview").ejOverview({ sourceID: "DiagramContent" });
        $(".searchicon-parent-div").css("display", "none");
        //$("#minOverview").ejOverview({ sourceID: "DiagramContent", height: 172, width: 232 });
        showMinimizedPalette = true;

        $("#EnableOverView").find("span").css("display", "block");
        diagram._enableOverView = true;
    }
    else {
        document.getElementById("Overview-div").style.display = "none";
        $("#Overview").ejOverview({ sourceID: "" });
        showMinimizedPalette = false;
        $("#EnableOverView").find("span").css("display", "none");
        diagram._enableOverView = false;
    }
}
function maxiTextBoxClick() {
    createShowMaximizedPlatedItems();
    document.getElementById("showMinimizedPlatedItemsparent").style.display = "none";
    document.getElementById("maxi_search_content").style.display = "none";
    clearText();

    document.getElementById("showMinimizedPlatedItemsparent").style.left = 5 + "px";
    document.getElementById("showMinimizedPlatedItemsparent").style.top = 137 + "px";

    $(".searchicon-parent-div").css("display", "block");
}
function onSearchBoxTextChange() {
    var item = null;
    if (document.getElementById("miniSearchBox"))
        var key = document.getElementById("miniSearchBox").value;
    if (document.getElementById("subControl_Div"))
        document.getElementById("subControl_Div").style.display = "none";
    $("#showMinimizedPlatedItems").find(".e-content").removeClass("e-content");
    if (key && key == "") {
        if (document.getElementById("showMinimizedPlatedItems"))
            document.getElementById("showMinimizedPlatedItems").style.display = "none";
    } else {
        if (document.getElementById("showMinimizedPlatedItems"))
            document.getElementById("showMinimizedPlatedItems").style.display = "block";
    }
    if (key && key.length > 0) {
        if (document.getElementById("maxi_Search"))
            document.getElementById("maxi_Search").style.display = "block";
        document.getElementById("maxi_search_content").style.display = "block";
        document.getElementById("maxi_Search").style.width = "255px";
        document.getElementById("maxi_Search").style.height = "auto";
        if (document.getElementById("showMinimizedPlatedItemsparent"))
            document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";
        if (document.getElementById("showMinimizedPlatedItems_canvas"))
            document.getElementById("showMinimizedPlatedItems_canvas").style.display = "block";


        var maxiPalette = $("#maxi_Search").ejSymbolPalette("instance");
        var maxipalettes = maxiPalette.model.palettes;
        var palette = $("#symbolpalette").ejSymbolPalette("instance");
        var palettes = palette.model.palettes;
        item = null;

        for (var i = maxipalettes[0].items.length - 1; i >= 0; i--) {
            maxiPalette.removePaletteItem(maxipalettes[0].name, maxipalettes[0].items[i]);
        }

        for (i = 0; i < palettes.length; i++) {
            //if (palettes[i].name != "BPMN Shapes") {
            for (var j = 0; j < palettes[i].items.length; j++) {
                item = palettes[i].items[j];

                var itemName = (item.name).split(/(?=[A-Z])/)
                key = key.toLocaleLowerCase();
                item = $.extend(true, {}, item);

                if ((itemName[0]).toLocaleLowerCase().indexOf(key) == 0) {
                    maxiPalette.addPaletteItem(maxiPalette.model.palettes[0].name, item);

                } else if (itemName[1] && ((itemName[1]).toLocaleLowerCase().indexOf(key) == 0)) {
                    maxiPalette.addPaletteItem(maxiPalette.model.palettes[0].name, item);

                } else if (itemName[2] && ((itemName[2]).toLocaleLowerCase().indexOf(key) == 0)) {
                    maxiPalette.addPaletteItem(maxiPalette.model.palettes[0].name, item);
                } else if (itemName[3] && ((itemName[3]).toLocaleLowerCase().indexOf(key) == 0)) {
                    maxiPalette.addPaletteItem(maxiPalette.model.palettes[0].name, item);
                }
            }
            //}

        }



    } else {
        if (document.getElementById("maxi_Search"))
            document.getElementById("maxi_Search").style.display = "none";
    }
    if (key && key == "") {
        if (document.getElementById("searchbox_icon-mini"))
            document.getElementById("searchbox_icon-mini").style.backgroundImage = 'url("../../css/diagram/images/Search-Find.png")';
    }
    else {
        if (document.getElementById("searchbox_icon-mini"))
            document.getElementById("searchbox_icon-mini").style.backgroundImage = 'url("../../css/diagram/images/Close.png")';
    }
    setToolTip();
}

function onSearchBoxTextChange_maxi() {



    document.getElementById("maxi_Search").style.minHeight = "40px";
    if (document.getElementById("textbox_maxi"))
        var key = document.getElementById("textbox_maxi").value;
    if (key.length > 0) {

        var maxiPalette = $("#maxi_Search").ejSymbolPalette("instance");
        var maxipalettes = maxiPalette.model.palettes;
        //for (i = maxipalettes[0].items.length - 1; i >= 0; i--) {
        //    ej.datavisualization.Diagram.Util.removeItem(maxipalettes[0].items, maxipalettes[0].items[i]);
        //}
        document.getElementById("maxi_search_content").style.display = "block";
        document.getElementById("maxi_Search").style.width = "255px";
        document.getElementById("maxi_Search").style.height = "auto";
        if (document.getElementById("showMinimizedPlatedItemsparent"))
            document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";
        if (document.getElementById("showMinimizedPlatedItems_canvas"))
            document.getElementById("showMinimizedPlatedItems_canvas").style.display = "block";

        document.getElementById("maxi_Search").style.display = "block";
        document.getElementById("basicShapes_Search").style.display = "none";
        document.getElementById("flowShapes_search").style.display = "none";
        document.getElementById("electrical_Search").style.display = "none";
        document.getElementById("connectors_Search").style.display = "none";
        document.getElementById("intelligent_Search").style.display = "none";
        $(".searchicon-parent-div").css("display", "none");
        $(".chat-bubble-arrow-border-mini").css("display", "none");
        $(".chat-bubble-arrow-mini").css("display", "none");
        $(".chat-bubble-arrow-border-maxi").css("display", "block");
        $(".chat-bubble-arrow-maxi").css("display", "block");


        var palette = $("#symbolpalette").ejSymbolPalette("instance");
        var palettes = palette.model.palettes;
        var item = null;

        for (var i = maxipalettes[0].items.length - 1; i >= 0; i--) {
            maxiPalette.removePaletteItem(maxipalettes[0].name, maxipalettes[0].items[i]);
        }

        for (var i = 0; i < palettes.length; i++) {
            //if (palettes[i].name != "BPMN Shapes") {
            for (var j = 0; j < palettes[i].items.length; j++) {
                item = palettes[i].items[j];

                var itemName = (item.name).split(/(?=[A-Z])/);
                key = key.toLocaleLowerCase();
                item = $.extend(true, {}, item);

                if ((itemName[0]).toLocaleLowerCase().indexOf(key) == 0) {
                    maxiPalette.addPaletteItem(maxiPalette.model.palettes[0].name, item);

                }
                else if (itemName[1] && ((itemName[1]).toLocaleLowerCase().indexOf(key) == 0)) {
                    maxiPalette.addPaletteItem(maxiPalette.model.palettes[0].name, item);

                }
                else if (itemName[2] && ((itemName[2]).toLocaleLowerCase().indexOf(key) == 0)) {
                    maxiPalette.addPaletteItem(maxiPalette.model.palettes[0].name, item);
                }
                else if (itemName[3] && ((itemName[3]).toLocaleLowerCase().indexOf(key) == 0)) {
                    maxiPalette.addPaletteItem(maxiPalette.model.palettes[0].name, item);
                }
            }
            //}

        }

        if (maxipalettes[0].items.length <= 0) {
            document.getElementById("no_match_found").style.display = "block";
            document.getElementById("maxi_Search").style.display = "none";
        }
        else {
            document.getElementById("no_match_found").style.display = "none";
            document.getElementById("maxi_Search").style.display = "block";
        }


        if (document.getElementById("subControl_Div"))
            document.getElementById("subControl_Div").style.display = "none";
        $("#showMinimizedPlatedItems").find(".e-content").removeClass("e-content");
        if (key == "") {
            if (document.getElementById("showMinimizedPlatedItemsparent"))
                document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";
        } else {
            if (document.getElementById("showMinimizedPlatedItemsparent"))
                document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";
        }
        if (key == "") {
            document.getElementById("searchbox_icon-maxi").style.backgroundImage = 'url("../../css/diagram/images/Search-Find.png")';
        } else {

            document.getElementById("searchbox_icon-maxi").style.backgroundImage = 'url("../../css/diagram/images/Close.png")';
        }
    }

    else {
        if (document.getElementById("showMinimizedPlatedItemsparent"))
            document.getElementById("showMinimizedPlatedItemsparent").style.display = "block";
    }
    setToolTip();
}

//#endregion

//#region Property Panel Common Methods


function PropertyChangesFromPanel(args, prop) {
    if (!diagram._selectedObject.selected && diagram.selectionList[0]) {
        args.down = true;
        updateNodeProperties(args, prop);
        updateConnectorProperties(args, prop);
    }
}

function MouseEnterOnColorPalette(args) {
    document.getElementById(args.id).style.width = "26px";
    document.getElementById(args.id).style.height = "26px";
    document.getElementById(args.id).style.border = "3px solid";
    document.getElementById(args.id).style.borderColor = "#3A3A3A";
}

function MouseLeaveOnColorPalette(args) {
    document.getElementById(args.id).style.width = "30px";
    document.getElementById(args.id).style.height = "30px";
    document.getElementById(args.id).style.border = "1px solid";
    document.getElementById(args.id).style.borderColor = "#3A3A3A";
}

function MouseEnterOnDiv(args, prop, fontclass) {
    diagram._selectedObject.mouseenter(args, prop, true);
}

function MouseLeaveFromDiv(args, prop, fontclass) {
    diagram._selectedObject.mouseenter(args, prop, false);
}

function dropdownOpened(args) {
    diagram._selectedObject.setPopupDivColor(args, diagram._selectedObject, true);
}

function dropdownClosed(args) {
    diagram._selectedObject.setPopupDivColor(args, diagram._selectedObject, false);
}

//#endregion

//#region Common Methods

function dataURItoBlob(imgData, imgType) {
    var binary = atob(imgData.split(',')[1]), array = [];
    for (var i = 0; i < binary.length; i++) array.push(binary.charCodeAt(i));
    return new Blob([new Uint8Array(array)], { type: imgType });
}

//#endregion

//#region SelectorViewModel
var SelectorVMClass = (function () {

    function SelectorVMClass() {
        this.fillColor = null;
        this.opacity = 100;
        this.fillDivColor = ko.observable("#F9F9F9");
        this.fillCornerColor = ko.observable("#A3A2A2");
        this.width = ko.observable(null);
        this.height = ko.observable(null);
        this.offsetX = ko.observable(null);
        this.offsetY = ko.observable(null);
        this.aspectRatio = null;
        this.stroke = null;
        this.strokeDivColor = "#F9F9F9";
        this.strokeCornerColor = "#A3A2A2";
        this.strokePenColor = "7F7F7F";
        this.borderthickness = null;
        this.borderthicknessfontColor = "7F7F7F";
        this.borderthicknessDivColor = "#F9F9F9";
        this.borderthicknessCornerColor = "#A3A2A2";;
        this.gradient = false;
        this.gradientDivColor = "#F9F9F9";
        this.gradientfontColor = null;
        this.label = false;
        this.labelfontSize = 0;
        this.labelfontColor = null;
        this.fontColorDiv = "#F9F9F9";
        this.labelfontFamily = null;
        this.textAlign = null;
        this.fontCornerColor = "#A3A2A2";;
        this.bold = false;
        this.boldDivColor = "#F9F9F9";
        this.boldfontColor = "#7F7F7F";
        this.italic = null;
        this.italicDivColor = "#F9F9F9";
        this.italicfontColor = "#7F7F7F";
        this.lineColor = null;
        this.lineDivColor = "#F9F9F9";
        this.lineColorCorner = "#A3A2A2";
        this.lineWidth = null;
        this.lineWidthDivColor = "#F9F9F9";
        this.lineWidthfontColor = null;
        this.lineWidthCornerColor = "#A3A2A2";
        this.headDecorator = null;
        this.headDecoratorDivColor = "#F9F9F9";
        this.headDecoratorfontColor = null;
        this.headDecoratorCornerColor = "#A3A2A2";;
        this.tailDecorator = null;
        this.tailDecoratorDivColor = "#F9F9F9";
        this.tailDecoratorfontColor = null;
        this.tailDecoratorCornerColor = "#A3A2A2";
        this.line = null;
        this.lineconnectorfontColor = null;
        this.lineconnectorDivColor = "#F9F9F9";
        this.lineconnectorCornerColor = "#A3A2A2";
        this.lock = null;
        this.lockfontColor = "#7F7F7F";
        this.lockDivColor = "#F9F9F9";
        this.lineStylefontColor = "#7F7F7F";
        this.lineStyleCornerColor = "#A3A2A2";
        this.lineStyleDivColor = "#F9F9F9";
        this.offsetXDsiabled = null;
        this.textLeftAlign = false;
        this.textLeftAlignfont = "#7F7F7F";
        this.textLeftAlignDiv = "#F9F9F9";
        this.textRightAlign = false;
        this.textRightAlignfont = "#7F7F7F";
        this.textRightAlignDiv = "#F9F9F9";
        this.textCenterAlign = false;
        this.textCenterAlignfont = "#7F7F7F";
        this.textCenterAlignDiv = "#F9F9F9";
        this.dimensionsChanged = false;
        this.tabPinIcon = "#999999";
        this.tabnodeicon = "#999999";
        this.tabTextIcon = "#999999";
        this.tabConnectorIcon = "#999999";
        this.pinned = false;
        this.dropdownOpened = false;
        this.init = 0;
        this.selected = false;
    }

    SelectorVMClass.prototype.select = function (selectedItems) {

        if (selectedItems.length > 0 && selectedItems[0]) {
            this.selected = true;
            var item = selectedItems[0];
            var type = selectedItems.length > 1 ? "" : diagram.getObjectType(item);
            if (!(item.isSwimlane || item.isLane)) {
                if ((type == "group" || selectedItems.length > 1)) {
                    var connectorExist = false, nodeExist = false, LabelExist = true, childNode, childConnector;
                    var items = type == "group" ? item.children : selectedItems;
                    for (var i = 0; i < items.length; i++) {
                        var childItem = items[i];
                        if (typeof (childItem) === "string") {
                            childItem = diagram.findNode(childItem);
                        }
                        var childType = diagram.getObjectType(childItem);
                        if (childType == "node") {
                            nodeExist = true;
                            if (!childNode)
                                childNode = childItem;
                        }
                        else if (childType === "connector") {
                            connectorExist = true;
                            if (!childConnector)
                                childConnector = childItem;
                        }
                        if (!(childItem.labels.length > 0 && childItem.labels[0].text.length > 0))
                            LabelExist = false;
                    }
                    this.EnableConnectorProperties(childConnector, connectorExist);
                    this.EnableNodeProperties(childNode, nodeExist, true);
                    this.EnableTextProperties(childNode || childConnector, LabelExist);
                }
                else if (type === "connector") {
                    this.EnableConnectorProperties(item, true);
                    this.EnableNodeProperties(item, false);
                    this.EnableTextProperties(item, true);
                }
                else {
                    this.EnableNodeProperties(item, true);
                    this.EnableConnectorProperties(item, false);
                    this.EnableTextProperties(item, true);
                }
                this.selected = false;
            }
            else {
                this.selected = true;
                this.EnableNodeProperties(null, false);
                EnableConnectorPanel(null, false);
                EnableTextPanel(null, false);
                this.selected = false;
            }
        }
        else {
            this.selected = true;
            this.EnableNodeProperties(null, false);
            EnableConnectorPanel(null, false);
            EnableTextPanel(null, false);
            this.selected = false;
        }
        return this;
    };

    SelectorVMClass.prototype.EnableNodeProperties = function (item, isEnable, isMultipleSelection) {
        EnableNodePanel(item, isEnable, isMultipleSelection);
        if (!isEnable) {
            this.offsetX = this.offsetY = this.width = this.height = null;
            this.aspectRatio = this.borderthickness = null;
            this.lock = (item && !item.segments) ? null : this.lock;
            this.gradient = null;


            this.fillColor = this.stroke = this.borderthicknessfontColor = this.strokePenColor = "#DDDBDB";
            this.fillDivColor = this.strokeDivColor = this.borderthicknessDivColor = "#F2F2F2";
            this.fillCornerColor = this.strokeCornerColor = this.borderthicknessCornerColor = "#F2F2F2";

            this.gradientfontColor = this.lockfontColor = "#DDDBDB";
            this.gradientDivColor = this.lockDivColor = "#F2F2F2";

        }
        else {
            this.offsetX = item.offsetX;
            this.offsetY = item.offsetY;
            this.width = item.width;
            this.height = item.height;
            this.lock = (item.constraints & (ej.datavisualization.Diagram.NodeConstraints.Delete | ej.datavisualization.Diagram.NodeConstraints.Drag | ej.datavisualization.Diagram.NodeConstraints.Resize)) ? false : true;
            this.aspectRatio = (item.constraints & ej.datavisualization.Diagram.NodeConstraints.AspectRatio) ? true : false;
            if (item.type === "text" || (item.isSwimlane || item.isLane)) {
                this.fillColor = this.stroke = this.borderthicknessfontColor = this.strokePenColor = "#DDDBDB";
                this.gradient = null, this.borderthickness = null;
                this.fillDivColor = this.strokeDivColor = this.borderthicknessDivColor = "#F2F2F2";
                this.fillCornerColor = this.strokeCornerColor = this.borderthicknessCornerColor = "#F2F2F2";
            }
            else {
                this.fillColor = item.fillColor;
                this.stroke = item.borderColor;
                this.borderthickness = item.borderWidth;
                this.opacity = item.opacity * 100;
                this.gradient = item.gradient ? true : false;
                this.borderthicknessfontColor = this.strokePenColor = "#7F7F7F";
                this.fillDivColor = this.strokeDivColor = this.borderthicknessDivColor = "#F9F9F9";
                this.fillCornerColor = this.strokeCornerColor = this.borderthicknessCornerColor = "#A3A2A2";
            }
            setThickness(item, "borderWidth");
            if (this.gradient)
                this.gradientDivColor = "#28B1BF";
            else
                this.gradientDivColor = "#F9F9F9";
            if (!this.lock) {
                this.lockfontColor = "#7F7F7F";
                this.lockDivColor = "#F9F9F9";
            }
            else {
                this.lockfontColor = "#FFFFFF";
                this.lockDivColor = "#28B1BF";
            }
            setOpacity(this.opacity);
            setNodeDimension(item);
        }
    }

    SelectorVMClass.prototype.EnableTextProperties = function (item, isEnable) {
        if (!isEnable) {
            EnableTextPanel(isEnable);
            this.labelfontColor = "#DDDBDB";
            this.fontColorDiv = "#F2F2F2";
            this.fontCornerColor = "#F2F2F2";
            this.bold = this.italic = null;
            this.boldDivColor = this.italicDivColor = ko.observable("#F2F2F2");
            this.boldfontColor = this.italicfontColor = ko.observable("#DDDBDB");
            this.textLeftAlign = this.textRightAlign = this.textCenterAlign = null;
            this.textLeftAlignfont = this.textRightAlignfont = this.textCenterAlignfont = "#DDDBDB";
            this.textLeftAlignDiv = this.textRightAlignDiv = this.textCenterAlignDiv = "#F2F2F2";
            SetLabel(null);
        }
        else {
            var label;
            if (item.type === "text")
                label = item.textBlock;
            else {
                if (item.isSwimlane || item.isLane) {
                    label = diagram.nameTable[item.children[0]].labels[0];
                }
                else {
                    if (item && item.labels && item.labels.length > 0) {
                        if (item.labels[0].text.length > 0) {
                            label = item.labels[0];
                        }
                    }
                }
            }
            if (label) {
                EnableTextPanel(isEnable);
                this.label = true;
                this.labelfontSize = label.fontSize;
                this.bold = label.bold;
                this.italic = label.italic;
                if (this.bold) {
                    this.boldDivColor = ko.observable("#28B1BF");
                    this.boldfontColor = ko.observable("#FFFFFF");
                }
                else {
                    this.boldDivColor = ko.observable("#F9F9F9");
                    this.boldfontColor = ko.observable("#7F7F7F");
                }
                if (this.italic) {
                    this.italicDivColor = ko.observable("#28B1BF");
                    this.italicfontColor = ko.observable("#FFFFFF");
                }
                else {
                    this.italicDivColor = ko.observable("#F9F9F9");
                    this.italicfontColor = ko.observable("#7F7F7F");
                }
                this.labelfontColor = label.fontColor;
                this.labelfontSize = label.fontSize;
                this.labelfontFamily = label.fontFamily;
                if (item.type != "bpmn") {
                    this.textAlign = label.textAlign;
                    this.textLeftAlign = this.textRightAlign = this.textCenterAlign = false;
                    this.textLeftAlignfont = this.textRightAlignfont = this.textCenterAlignfont = "#7F7F7F";
                    this.textLeftAlignDiv = this.textRightAlignDiv = this.textCenterAlignDiv = "#F9F9F9";
                    switch (this.textAlign) {
                        case "left":
                            this.textLeftAlign = true;
                            this.textLeftAlignfont = "#FFFFFF";
                            this.textLeftAlignDiv = "#28B1BF";
                            break;
                        case "right":
                            this.textRightAlign = true;
                            this.textRightAlignfont = "#FFFFFF";
                            this.textRightAlignDiv = "#28B1BF";
                            break;
                        case "center":
                            this.textCenterAlign = true;
                            this.textCenterAlignfont = "#FFFFFF";
                            this.textCenterAlignDiv = "#28B1BF";
                            break;
                    }
                    if (item.isSwimlane || item.isLane) {
                        this.textLeftAlign = this.textRightAlign = this.textCenterAlign = null;
                        this.textLeftAlignfont = this.textRightAlignfont = this.textCenterAlignfont = "#DDDBDB";
                        this.textLeftAlignDiv = this.textRightAlignDiv = this.textCenterAlignDiv = "#F2F2F2";
                    }
                }
                else {
                    this.textLeftAlign = this.textRightAlign = this.textCenterAlign = null;
                    this.textLeftAlignfont = this.textRightAlignfont = this.textCenterAlignfont = "#DDDBDB";
                    this.textLeftAlignDiv = this.textRightAlignDiv = this.textCenterAlignDiv = "#F2F2F2";
                }
                SetLabel(label);
            }
            else {
                this.EnableTextProperties(item, false);
            }
        }
    }

    SelectorVMClass.prototype.EnableConnectorProperties = function (item, isEnable) {
        EnableConnectorPanel(item, isEnable);
        var fontColor = "#DDDBDB", backgroundColor = "#F2F2F2", borderColor = "#F2F2F2";
        if (!isEnable) {
            this.lock = (item && item.segments) ? null : this.lock;
            this.line = null;
            this.lineWidth = null;
            this.headDecorator = null;
            this.tailDecorator = null;
            this.lineColor = this.lineconnectorfontColor = this.lineWidthfontColor = this.headDecoratorfontColor = this.tailDecoratorfontColor = fontColor;
            this.lineStylefontColor = fontColor;
        }
        else {
            fontColor = "#7F7F7F", backgroundColor = "#F9F9F9", borderColor = "#A3A2A2";
            this.lock = (item.constraints & (ej.datavisualization.Diagram.ConnectorConstraints.Delete | ej.datavisualization.Diagram.ConnectorConstraints.Drag)) ? false : true;
            this.lineColor = item.lineColor;
            this.lineWidth = item.lineWidth;
            this.headDecorator = item.sourceDecorator;
            this.tailDecorator = item.targetDecorator;
            setThickness(item, "lineWidth");
            this.lineconnectorfontColor = this.lineWidthfontColor = this.headDecoratorfontColor = this.tailDecoratorfontColor = null;
            this.lineStylefontColor = fontColor;
        }

        this.lineDivColor = this.lineconnectorDivColor = this.lineWidthDivColor = this.lineStyleDivColor = backgroundColor;
        this.lineColorCorner = this.lineconnectorCornerColor = this.lineWidthCornerColor = this.lineStyleCornerColor = borderColor;
        this.headDecoratorDivColor = this.tailDecoratorDivColor = backgroundColor;
        this.headDecoratorCornerColor = this.tailDecoratorCornerColor = borderColor;

    }

    SelectorVMClass.prototype.setTabIconColor = function (args, tab) {
        // 
        if (this.init > 0) {
            if (args.activeIndex == 1) {
                this.tabnodeicon = "#1E989E";
                this.tabPinIcon = "#494949";
                this.tabTextIcon = "#494949";
                this.tabConnectorIcon = "#494949";
            } else if (args.activeIndex == 2) {
                this.tabTextIcon = "#1E989E";
                this.tabPinIcon = "#494949";
                this.tabnodeicon = "#494949";
                this.tabConnectorIcon = "#494949";
            } else if (args.activeIndex == 3) {
                this.tabConnectorIcon = "#1E989E";
                this.tabPinIcon = "#494949";
                this.tabnodeicon = "#494949";
                this.tabTextIcon = "#494949";
            } else if (args.activeIndex == 0) {
                if (this.pinned) {
                    this.pinned = false;
                    var ele = document.getElementById("pinspan");
                    ele.className = 'icon-PH__TabBin';
                    $("#tabitems").ejTab(
                    {
                        selectedItemIndex: args.prevActiveIndex,
                    });
                } else {

                    this.pinned = true;
                    var ele = document.getElementById("pinspan");
                    ele.className = 'icon-PH__TabBin1';
                    $('.icon-PH__TabBin1').css('font-size', '20px');
                    $("#tabitems").ejTab({
                        selectedItemIndex: args.prevActiveIndex,
                    });
                }
            }
        }
        this.init++;
        return this;
    }

    SelectorVMClass.prototype.mouseenter = function (args, prop, enter) {
        switch (prop) {
            case "fillColor":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.fillColor);
                break;
            case "stroke":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.stroke);
                break;
            case "borderthickness":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.borderthickness);
                break;
            case "gradient":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.gradient);
                break;
            case "lock":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.lock);
                break;
            case "line":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.line);
                break;
            case "lineWidth":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.lineWidth);
                break;
            case "lineColor":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.lineColor);
                break;
            case "lineStyle":
                this.setBackgroundOnMouseEnter(args, prop, enter, "");
                break;
            case "headDecorator":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.headDecorator);
                break;
            case "tailDecorator":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.tailDecorator);
                break;
            case "fontColor":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.labelfontColor);
                break;
            case "bold":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.bold);
                break;
            case "italic":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.italic);
                break;
            case "left":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.textLeftAlign);
                break;
            case "right":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.textRightAlign);
                break;
            case "center":
                this.setBackgroundOnMouseEnter(args, prop, enter, this.textCenterAlign);
                break;
        }
    }

    SelectorVMClass.prototype.setBackgroundOnMouseEnter = function (args, prop, enter, object) {
        if (prop === "gradient" || prop === "lock" || prop === "bold" || prop === "italic"
            || prop == "right" || prop == "center" || prop == "left") {
            if (object != null && object != "#DDDBDB") {
                args.style.backgroundColor = "#E2E2E2";
                if (!enter) {
                    if (!object)
                        args.style.backgroundColor = "#F9F9F9";
                    else
                        args.style.backgroundColor = "#28B1BF";
                }
            }
        }
        else {
            if (object != null && object != "#DDDBDB") {
                args.style.backgroundColor = "#E2E2E2";
                if (!enter && !this.dropdownOpened) {
                    args.style.backgroundColor = "#F9F9F9";
                }
            }
        }
    }

    SelectorVMClass.prototype.nodeDimensionChanging = function (item) {
        this.selected = true;
        if (document.getElementById("propertyEditor").style.display == "block")
            setNodeDimension(item);
        this.selected = false;
    }

    SelectorVMClass.prototype.setPopupDivColor = function (args, model, opened) {
        model.dropdownOpened = false;
        if (opened) {
            model.dropdownOpened = true;
        }
    }
    return SelectorVMClass;
})();


function EnableNodePanel(item, isEnable, isMultipleSelection) {
    var enabled = "enable";
    if (!isEnable)
        enabled = "disable";
    if (item && (item.type === "text" || (item.isSwimlane || item.isLane))) {
        enabled = "disable";
    }
    $("#fillColor").ejDropDownList(enabled);
    $("#stroke").ejDropDownList(enabled);
    $("#borderWidth").ejDropDownList(enabled);
    $("#opacity").ejSlider(enabled);
    if (isEnable)
        enabled = "enable";
    if (isMultipleSelection)
        enabled = "disable";
    $("#offsetxnumeric").ejNumericTextbox(enabled);
    $("#offsetynumeric").ejNumericTextbox(enabled);
    $("#heightnumeric").ejNumericTextbox(enabled);
    $("#widthnumeric").ejNumericTextbox(enabled);
    if ((item && item.type == "group") && isEnable)
        enabled = "enable";
    $("#aspectratioCheckBox").ejCheckBox(enabled);
}

function EnableConnectorPanel(item, isEnable) {
    var enabled = "enable";
    if (!isEnable)
        enabled = "disable";
    $("#lineColor").ejDropDownList(enabled);
    $("#line").ejDropDownList(enabled);
    $("#lineWidth").ejDropDownList(enabled);
    $("#headDecorator").ejDropDownList(enabled);
    $("#tailDecorator").ejDropDownList(enabled);
    $("#lineStyle").ejDropDownList(enabled);
}

function EnableTextPanel(isEnable) {
    var enabled = "enable";
    if (!isEnable)
        enabled = "disable";
    $("#fontColor").ejDropDownList(enabled);
    $("#fontsizelist").ejDropDownList(enabled);
    $("#fontStylelist").ejDropDownList(enabled);
}

function SetLabel(args) {
    if (args != null) {
        if (args == "fontsizediffer") {
            $('#fontsizelist').ejDropDownList("option", "value", "");
        }
        else {
            if (args.fontSize >= 8) {
                $("#fontsizelist").ejDropDownList("option", { selectedItemIndex: args.fontSize - 8 });
            }
            else {
                $("#fontsizelist").ejDropDownList({ selectedTo: null });
            }
        }
        if (args == "fontFamilydiffer") {
            $('#fontStylelist').ejDropDownList("option", "value", "");
        }
        else {
            if (args.fontFamily == "Arial") {
                $("#fontStylelist").ejDropDownList("option", { selectedItemIndex: 0 });
            }
            else if (args.fontFamily == "Aharoni") {
                $("#fontStylelist").ejDropDownList("option", { selectedItemIndex: 1 });
            }
            else if (args.fontFamily == "Bell MT") {
                $("#fontStylelist").ejDropDownList("option", { selectedItemIndex: 2 });
            }
            else if (args.fontFamily == "Fantasy") {
                $("#fontStylelist").ejDropDownList("option", { selectedItemIndex: 3 });
            }
            else if (args.fontFamily == "Times New Roman") {
                $("#fontStylelist").ejDropDownList("option", { selectedItemIndex: 4 });
            }
            else if (args.fontFamily == "Segoe UI") {
                $("#fontStylelist").ejDropDownList("option", { selectedItemIndex: 5 });
            }
            else if (args.fontFamily == "Verdana") {
                $("#fontStylelist").ejDropDownList("option", { selectedItemIndex: 6 });
            }
        }
    }
}
function setNodeDimension(item) {
    $('#aspectratioCheckBox').ejCheckBox({ checked: (item.constraints & ej.datavisualization.Diagram.NodeConstraints.AspectRatio) ? true : false });
    $("#widthnumeric").ejNumericTextbox({ value: item.width });
    $("#heightnumeric").ejNumericTextbox({ value: item.height });
    $("#offsetxnumeric").ejNumericTextbox({ value: item.offsetX });
    $("#offsetynumeric").ejNumericTextbox({ value: item.offsetY });
}
function setOpacity(value) {
    $("#opacity").ejSlider({ value: value });
}
function setThickness(item, dropDownId) {
    if (item != null) {
        if (!item.segments)
            $("#" + dropDownId).ejDropDownList("option", { selectedItemIndex: Math.round(item.borderWidth - 1) });
        else
            $("#" + dropDownId).ejDropDownList("option", { selectedItemIndex: Math.round(item.lineWidth - 1) });
    }
    else {
        $("#" + dropDownId).ejDropDownList("option", "value", "");
    }
}


//#endregion

//#region Sample helper Methods
function _updateNodeSize(node) {
    var str = node.name;
    if (node && (str.match("TwoSideFlatCorner") || str.match("TwoSideRoundedCorner") || str.match("process") || str.match("Document") ||
        str.match("MultiDocument") || str.match("DirectData") || str.match("PaperTap") || str.match("PredefinedProcess") ||
         str.match("LoopLimit"))) {
        node.height = 60;
        node.width = 100;
    }
    else {
        node.height = 100;
        node.width = 100;
    }
}
//#endregion