window.GroupingList = ["GRIDS", "DATA VISUALIZATION", "VISUALIZATION", "DATA SCIENCE", "LAYOUT", "EDITORS", "FILE FORMATS","REPORTING","NAVIGATION", "NOTIFICATION", "GETTING STARTED", "AUTOMATIC LAYOUT", "ORGANIZATIONAL CHART", "USECASE DIAGRAMS", "DATA BINDING", "BUSINESS INTELLIGENCE"];

//Controls List
window.SampleControls = [
     { "name": "Grid" }, { "name": "TreeGrid" },{"name":"Spreadsheet"}, { "name": "LinearGauge" }, { "name": "Pager" }, { "name": "DateRangePicker" }, { "name": "CircularGauge" }, { "name": "DigitalGauge" }, { "name": "Sparkline" }, { "name": "Sunburst" }, { "name": "DatePicker" }, { "name": "DropDownList" }, { "name": "RTE" }, { "name": "SpellCheck" }, { "name": "Upload" }, { "name": "Maps" }, { "name": "TreeMap" }, { "name": "Diagram" }, { "name": "TreeView" }, { "name": "Chart" }, { "name": "BulletGraph" }, { "name": "RangeNavigator" }, { "name": "PredictiveAnalytics" }, { "name": "Gantt" }, { "name": "Barcode" }, { "name": "Schedule" }, { "name": "Ribbon" }, { "name": "PDF" }, { "name": "Presentation" }, { "name": "DocIO" }, { "name": "XlsIO" }, { "name": "Accordion" }, { "name": "Button" }, { "name": "Autocomplete" }, { "name": "DateTimePicker" }, { "name": "Dialog" }, { "name": "ListBox" }, { "name": "ColorPicker" }, { "name": "Editor" }, { "name": "ProgressBar" }, { "name": "Rating" }, { "name": "Rotator" },{"name":"RadialMenu"},{ "name": "ScrollBar" }, { "name": "Slider" }, { "name": "Splitter" }, { "name": "Tab" }, { "name": "TagCloud" }, { "name": "TimePicker" }, { "name": "ToolBar" }, { "name": "Tooltip" }, { "name": "WaitingPopup" }, { "name": "Menu" }, { "name": "ListView" }, { "name": "NavigationDrawer" }, { "name": "TileView" }, { "name": "HeatMap" },{"name":"RadialSlider"}, { "name": "PivotGrid" }, { "name": "PivotChart" }, { "name": "PivotGauge" }, { "name": "PivotTreeMap" }, { "name": "PivotClient" },{"name": "KanbanBoard"},{ "name": "Signature" },{ "name": "FileExplorer" }, { "name": "ComboBox" }, { "name": "ReportViewer" }, { "name": "ReportDesigner" }
];
//Samples List
window.SamplesList = [
    {
        "name": "Grid", "id": "Grid", "childcount": "1", "Group": "GRIDS", "controller": "Grid", "type": "update", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/grid/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/grid",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore/grid",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "Grid", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Adaptive", "controller": "Grid", "action": "Adaptive", "childcount": "0" },
            {
                "id": "3", "name": "Exporting", "controller": "Grid", "action": "Exporting", "childcount": "1",  "samples": [
                    { "id": "1", "name": "Exporting", "controller": "Grid", "action": "Exporting", "childcount": "0", "isResponsive": "false" },
                    { "id": "2", "name": "Hierarchy Grid Exporting", "controller": "Grid", "action": "HierarchyGridExporting", "childcount": "0", "isResponsive": "false" }
                ]
            },
            { "id": "4", "name": "Filtering", "controller": "Grid", "action": "Filtering", "childcount": "0" },
            { "id": "5", "name": "RowDragAndDrop", "controller": "Grid", "action": "RowDragAndDrop", "childcount": "0" },
            {
                "id": "6", "name": "Editing", "controller": "Grid", "action": "InlineEditing", "childcount": "1", "samples": [
                          { "id": "1", "name": "Inline Editing", "controller": "Grid", "action": "InlineEditing", "childcount": "0", "isResponsive": "false" },
                          { "id": "2", "name": "Batch Editing", "controller": "Grid", "action": "BatchEditing", "childcount": "0", "isResponsive": "false" },
                          { "id": "3", "name": "Dialog Editing", "controller": "Grid", "action": "DialogEditing", "childcount": "0", "isResponsive": "false" },
                          { "id": "4", "name": "DialogTemplate Editing", "controller": "Grid", "action": "DialogTemplateEditing", "childcount": "0", "isResponsive": "false" }
                     ]
             },
            { "id": "7", "name": "Sorting", "controller": "Grid", "action": "Sorting", "childcount": "0" },
            { "id": "8", "name": "Grouping", "controller": "Grid", "action": "Grouping", "childcount": "0" }
        ]
    },
    {
        "name": "TreeGrid", "id": "TreeGrid", "childcount": "1", "Group": "GRIDS", "controller": "TreeGrid", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/treegrid/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/treegrid",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore/treegrid",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "TreeGrid", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Editing", "controller": "TreeGrid", "action": "TreeGridEditing", "childcount": "0" },
            { "id": "3", "name": "Sorting", "controller": "TreeGrid", "action": "TreeGridSorting", "childcount": "0" },
            { "id": "4", "name": "Column Filtering", "controller": "TreeGrid", "action": "TreeGridColumnFiltering", "childcount": "0" }
        ]
    },
	{
        "name": "Spreadsheet", "id": "Spreadsheet", "childcount": "1", "Group": "GRIDS", "controller": "Spreadsheet", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/spreadsheet/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/spreadsheet",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore/spreadsheet",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "Spreadsheet", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Cell Data Binding", "controller": "Spreadsheet", "action": "CellBinding", "childcount": "0" },
            { "id": "3", "name": "Conditional Formatting", "controller": "Spreadsheet", "action": "ConditionalFormatting", "childcount": "0" }
        ]
    },
    {
        "name": "DatePicker", "id": "DatePicker", "Group": "EDITORS", "childcount": "1", "controller": "DatePicker", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/datepicker/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/datepicker",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "DatePicker", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Date Format", "controller": "DatePicker", "action": "Format", "childcount": "0" },
            { "id": "3", "name": "Date Range", "controller": "DatePicker", "action": "DateRange", "childcount": "0" },
            { "id": "4", "name": "Display Inline", "controller": "DatePicker", "action": "DisplayInline", "childcount": "0" },
            { "id": "5", "name": "Dates In Other Month", "controller": "DatePicker", "action": "DatesInOtherMonth", "childcount": "0" },
            { "id": "6", "name": "Localization", "controller": "DatePicker", "action": "Localization", "childcount": "0" },
            { "id": "7", "name": "Methods", "controller": "DatePicker", "action": "Methods", "childcount": "0" },
            { "id": "8", "name": "Events", "controller": "DatePicker", "action": "Events", "childcount": "0" },
            { "id": "9", "name": "RTL", "controller": "DatePicker", "action": "Rtl", "childcount": "0" },
            { "id": "10", "name": "Keyboard Navigation", "controller": "DatePicker", "action": "Keyboard", "childcount": "0" }
            //{ "id": "11", "name": "DatePickerFor", "controller": "DatePicker", "action": "DatePickerFor", "childcount": "0" }
            //{ "id": "11", "name": "SpecialDates", "controller": "DatePicker", "action": "SpecialDates", "childcount": "0" }
        ]
    },
	{
        "name": "DropDownList", "id": "DropDownList", "Group": "EDITORS", "childcount": "1", "controller": "DropDownList", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/dropdownlist/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/dropdownlist",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
        { "id": "1", "name": "Default", "controller": "DropDownList", "action": "Default", "childcount": "0" },
        { "id": "2", "name": "Cascading", "controller": "DropDownList", "action": "Cascading", "childcount": "0" },
        { "id": "3", "name": "Checkbox", "controller": "DropDownList", "action": "Checkbox", "childcount": "0" },
        { "id": "4", "name": "Local Data", "controller": "DropDownList", "action": "DatabindingLocal", "childcount": "0" },
        { "id": "5", "name": "Remote Data", "controller": "DropDownList", "action": "DatabindingRemote", "childcount": "0" },
        { "id": "6", "name": "Events", "controller": "DropDownList", "action": "Events", "childcount": "0" },
        { "id": "7", "name": "Grouping", "controller": "DropDownList", "action": "Grouping", "childcount": "0" },
        { "id": "8", "name": "Icons", "controller": "DropDownList", "action": "Icons", "childcount": "0" },
        { "id": "9", "name": "Integration with Widgets", "controller": "DropDownList", "action": "IntegrationwithWidgets", "childcount": "0" },
        { "id": "10", "name": "Keyboard", "controller": "DropDownList", "action": "Keyboard", "childcount": "0" },
        { "id": "11", "name": "Methods", "controller": "DropDownList", "action": "Methods", "childcount": "0" },
        { "id": "12", "name": "Multi-select", "controller": "DropDownList", "action": "Multiselect", "childcount": "0" },
        { "id": "13", "name": "RTL", "controller": "DropDownList", "action": "Rtl", "childcount": "0" },
        { "id": "14", "name": "VirtualScrolling", "controller": "DropDownList", "action": "VirtualScrolling", "childcount": "0" }

        ]
    },
    {
        "name": "ComboBox", "id": "ComboBox", "Group": "EDITORS", "childcount": "1", "controller": "ComboBox", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/combobox/index",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/combobox",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "ComboBox", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Cascading", "controller": "ComboBox", "action": "Cascading", "childcount": "0" },
            { "id": "3", "name": "Databinding - Local Data", "controller": "ComboBox", "action": "DatabindingJson", "childcount": "0" },
            { "id": "4", "name": "Databinding - Remote Data", "controller": "ComboBox", "action": "Databindingremote", "childcount": "0" },
            { "id": "5", "name": "Events", "controller": "ComboBox", "action": "Events", "childcount": "0" },
            { "id": "6", "name": "Grouping", "controller": "ComboBox", "action": "Grouping", "childcount": "0" },
            { "id": "7", "name": "Icons", "controller": "ComboBox", "action": "Icons", "childcount": "0" },
            { "id": "8", "name": "Filtering", "controller": "ComboBox", "action": "Filtering", "childcount": "0" },
            { "id": "9", "name": "Template", "controller": "ComboBox", "action": "Template", "childcount": "0" },
            { "id": "10", "name": "Methods", "controller": "ComboBox", "action": "Methods", "childcount": "0" },
            { "id": "11", "name": "RTL", "controller": "ComboBox", "action": "Rtl", "childcount": "0" }
        ]
    },
    {
        "name": "RichTextEditor", "id": "RTE", "Group": "EDITORS", "childcount": "1", "controller": "RTE", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/richtexteditor/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/richtexteditor",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
        { "id": "1", "name": "Default", "controller": "RTE", "action": "Default", "childcount": "0" },
        { "id": "2", "name": "AllTools", "controller": "RTE", "action": "AllTools", "childcount": "0" }, 
        { "id": "4", "name": "CustomTool", "controller": "RTE", "action": "CustomTool", "childcount": "0" },
        { "id": "5", "name": "Import And Export", "controller": "RTE", "action": "ImportAndExport", "childcount": "0" },
		{"id": "6", "name": "Inline Toolbar", "controller": "RTE", "action": "InlineToolbar", "childcount": "0" },
        { "id": "7", "name": "Paste Options", "controller": "RTE", "action": "PasteCleanup", "childcount": "0" },
        { "id": "8", "name": "Events", "controller": "RTE", "action": "Events", "childcount": "0" },
        { "id": "9", "name": "Keyboard Navigation", "controller": "RTE", "action": "KeyboardNavigation", "childcount": "0" },
        { "id": "10", "name": "Localization", "controller": "RTE", "action": "Localization", "childcount": "0" },
        { "id": "11", "name": "Methods", "controller": "RTE", "action": "Methods", "childcount": "0" },
        { "id": "12", "name": "RTL", "controller": "RTE", "action": "Rtl", "childcount": "0" }
		]
    },
	{
        "name": "SpellCheck", "id": "SpellCheck", "Group": "EDITORS", "childcount": "1", "controller": "SpellCheck", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/spellcheck/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/spellcheck",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
           { "id": "1", "name": "Default Functionalities", "controller": "SpellCheck", "action": "Default", "childcount": "0" },
           { "id": "2", "name": "Context Menu", "controller": "SpellCheck", "action": "ContextMenu", "childcount": "0" },
           { "id": "3", "name": "Multiple Target", "controller": "SpellCheck", "action": "MultipleTarget", "childcount": "0" },
           { "id": "4", "name": "API's", "controller": "SpellCheck", "action": "API", "childcount": "0" }
         ]
     },
    {
        "name": "Upload", "id": "Upload", "Group": "EDITORS", "childcount": "1", "controller": "Upload", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/uploadbox/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/uploadbox",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
        { "id": "1", "name": "Default", "controller": "Upload", "action": "Default", "childcount": "0" },
        { "id": "2", "name": "Drag And Drop", "controller": "Upload", "action": "DragAndDrop", "childcount": "0" },
        { "id": "3", "name": "Events", "controller": "Upload", "action": "Events", "childcount": "0" },
        { "id": "4", "name": "File input", "controller": "Upload", "action": "FileTypesInput", "childcount": "0" },
        { "id": "5", "name": "Methods", "controller": "Upload", "action": "Methods", "childcount": "0" },
        { "id": "6", "name": "Rtl", "controller": "Upload", "action": "Rtl", "childcount": "0" }

        ]
    },
    {
        "name": "Diagram", "id": "Diagram", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "Diagram", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/diagram/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/diagram",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "Diagram", "action": "Default", "childcount": "0" },
              {
                  "id": "2", "name": "Getting Started", "Group": "GETTING STARTED", "controller": "Diagram", "action": "ShapesGallery", "childcount": "1", samples: [
                           { "id": "1", "name": "Shapes Gallery", "controller": "Diagram", "action": "ShapesGallery", "childcount": "0" },
                           { "id": "2", "name": "Connectors", "controller": "Diagram", "action": "Connectors", "childcount": "0" },
                           { "id": "3", "name": "Swimlane", "controller": "Diagram", "action": "Swimlane", "childcount": "0" },
                           { "id": "4", "name": "Drawing Tools", "controller": "Diagram", "action": "DrawingTools", "childcount": "0" },
                           { "id": "5", "name": "Overview", "controller": "Diagram","action": "Overview", "childcount": "0" },
                           { "id": "6", "name": "Localization", "controller": "Diagram", "action": "Localization", "childcount": "0" },
                           { "id": "7", "name": "Tooltip", "controller": "Diagram", "action": "Tooltip", "childcount": "0" },
                           { "id": "8", "name": "Symbol Palette", "controller": "Diagram", "action": "SymbolPalette", "childcount": "0" }
                   ]
              },
              {
                  "id": "3", "name": "Automatic Layout", "Group": "AUTOMATIC LAYOUT", "controller": "Diagram", "action": "HierarchicalTree", "childcount": "1", samples: [
                           { "id": "1", "name": "Hierarchical Tree", "controller": "Diagram", "action": "HierarchicalTree", "childcount": "0" },
                           { "id": "2", "name": "Organization Chart", "controller": "Diagram", "action": "OrganizationalChart", "childcount": "0" },
                           { "id": "3", "name": "Radial Tree", "controller": "Diagram", "action": "RadialTree", "childcount": "0" }
                      ]
              },
              {
                  "id": "4", "name": "Organizational Chart", "Group": "ORGANIZATIONAL CHART", "controller": "Diagram", "action": "TeamOrganizationChart", "childcount": "1", samples: [
                           //{ "id": "1", "name": "Team", "controller": "Diagram", "action": "TeamOrganizationChart", "childcount": "0" },
                           { "id": "2", "name": "Business Management", "controller": "Diagram", "action": "BusinessManagementChart", "childcount": "0" },
                           { "id": "3", "name": "University", "controller": "Diagram", "action": "UniversityOrganizationChart", "childcount": "0" }
                  ]
              },
               {
                   "id": "5", "name": "Usecase Diagrams", "Group": "USECASE DIAGRAMS", "controller": "Diagram", "action": "UmlDiagram", "childcount": "1", samples: [
                            { "id": "1", "name": "Uml Diagram", "controller": "Diagram", "action": "UmlDiagram", "childcount": "0" },
                            { "id": "2", "name": "Circuit Diagram", "controller": "Diagram", "action": "CircuitDiagram", "childcount": "0" }
                         ]
               },
                {
                    "id": "6", "name": "Data Binding", "Group": "DATA BINDING", "controller": "Diagram", "action": "LocalDataBinding", "childcount": "1", samples: [
                             { "id": "1", "name": "Local Data", "controller": "Diagram", "action": "LocalDataBinding", "childcount": "0" },
                             { "id": "2", "name": "Remote Data", "controller": "Diagram", "action": "RemoteDataBinding", "childcount": "0" },
                             { "id": "3", "name": "HTML Table", "controller": "Diagram", "action": "HtmlDataBinding", "childcount": "0" }
                    ]
                }
           ]
    },

    {
        "name": "TreeView", "id": "TreeView", "Group": "NAVIGATION", "childcount": "1", "controller": "TreeView", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/treeview/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/treeview",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "TreeView", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Icons", "controller": "TreeView", "action": "Icon", "childcount": "0" },
            { "id": "3", "name": "Checkboxes", "controller": "TreeView", "action": "Checkbox", "childcount": "0" },
            { "id": "4", "name": "Node Editing-Cut-Paste", "controller": "TreeView", "action": "NodeEdit", "childcount": "0" },
            { "id": "5", "name": "Drag and Drop", "controller": "TreeView", "action": "Dragdrop", "childcount": "0" },
            { "id": "6", "name": "Local Data", "controller": "TreeView", "action": "Localdata", "childcount": "0" },
            { "id": "7", "name": "Remote Data", "controller": "TreeView", "action": "RemoteData", "childcount": "0" },
            { "id": "8", "name": "Load On Demand", "controller": "TreeView", "action": "LoadonDemand", "childcount": "0" },
            { "id": "9", "name": "Template", "controller": "TreeView", "action": "Template", "childcount": "0" },
            { "id": "10", "name": "Context Menu", "controller": "TreeView", "action": "ContextMenu", "childcount": "0" },
            { "id": "11", "name": "State Maintenance", "controller": "TreeView", "action": "Statemaintenance", "childcount": "0" },
            { "id": "12", "name": "Methods", "controller": "TreeView", "action": "Methods", "childcount": "0" },
            { "id": "13", "name": "Events", "controller": "TreeView", "action": "Events", "childcount": "0" },
            { "id": "14", "name": "RTL", "controller": "TreeView", "action": "Rtl", "childcount": "0" },
            { "id": "15", "name": "Keyboard Navigation", "controller": "TreeView", "action": "Keyboard", "childcount": "0" }
        ]
    },
      {
          "name": "FileExplorer", "id": "FileExplorer", "isResponsive": "true", "Group": "NAVIGATION", "childcount": "1", "controller": "FileExplorer", "action": "Default",
		  "ugurl": "https://help.syncfusion.com/aspnet-core/fileexplorer/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/fileexplorer",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
		  "samples": [
              { "id": "1", "name": "Default Functionalities", "controller": "FileExplorer", "action": "Default", "childcount": "0" },
              { "id": "2", "name": "Custom Tool", "controller": "FileExplorer", "action": "CustomTool", "childcount": "0" },
              { "id": "3", "name": "Custom Context Menu", "controller": "FileExplorer", "action": "CustomContextMenu", "childcount": "0" },
              { "id": "4", "name": "Events", "controller": "FileExplorer", "action": "Events", "childcount": "0" },
              { "id": "5", "name": "Localization", "controller": "FileExplorer", "action": "Localization", "childcount": "0" },
              { "id": "6", "name": "Methods", "controller": "FileExplorer", "action": "Methods", "childcount": "0" },
              { "id": "7", "name": "RTL", "controller": "FileExplorer", "action": "RTL", "childcount": "0" },
              { "id": "8", "name": "Keyboard Navigation", "controller": "FileExplorer", "action": "KeyboardNavigation", "childcount": "0" },
              { "id": "9", "name": "Virtual Scrolling ", "controller": "FileExplorer", "action": "VirtualScrolling", "childcount": "0" ,}
          ]
      },
     {
         "name": "Accordion", "id": "Accordion", "isResponsive": "true", "Group": "NAVIGATION", "childcount": "1", "controller": "Accordion", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/accordion/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/accordion",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
          { "id": "1", "name": "Default Functionalities", "controller": "Accordion", "action": "Default", "childcount": "0" },
          //{ "id": "2", "name": "Ajax Content", "controller": "Accordion", "action": "AjaxContent", "childcount": "0" },
          { "id": "3", "name": "Multiple Open", "controller": "Accordion", "action": "MultipleOpen", "childcount": "0" },
          { "id": "4", "name": "Open On Hover", "controller": "Accordion", "action": "OpenOnHover", "childcount": "0" },
          { "id": "5", "name": "Icons", "controller": "Accordion", "action": "Icons", "childcount": "0" },
          { "id": "6", "name": "NestedAccordion", "controller": "Accordion", "action": "NestedAccordion", "childcount": "0", "isResponsive": "false" },
          { "id": "7", "name": "Methods", "controller": "Accordion", "action": "Methods", "childcount": "0" },
          { "id": "8", "name": "Events", "controller": "Accordion", "action": "Events", "childcount": "0" },
          { "id": "9", "name": "RTL", "controller": "Accordion", "action": "Rtl", "childcount": "0" },
          { "id": "10", "name": "Keyboard Navigation", "controller": "Accordion", "action": "KeyboardNavigation", "childcount": "0" }
         ]
     },
     {
         "name": "ListBox", "id": "ListBox", "childcount": "1", "isResponsive": "true", "Group": "NAVIGATION", "controller": "ListBox", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/listbox/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/listbox",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
         { "id": "1", "name": "Default Functionalities", "controller": "ListBox", "action": "Default", "childcount": "0" },
         { "id": "2", "name": "Checkbox", "controller": "ListBox", "action": "Checkbox", "childcount": "0" },
         { "id": "3", "name": "Icons", "controller": "ListBox", "action": "Icons", "childcount": "0" },
         //{ "id": "4", "name": "Cascading", "controller": "ListBox", "action": "Cascading", "childcount": "0" },
         { "id": "5", "name": "Grouping", "controller": "ListBox", "action": "Grouping", "childcount": "0" },
         { "id": "6", "name": "Data Binding - Local Data", "controller": "ListBox", "action": "LocalData", "childcount": "0" },
         { "id": "7", "name": "Data Binding - Remote Data", "controller": "ListBox", "action": "RemoteData", "childcount": "0" },
         { "id": "8", "name": "Multi-Selection", "controller": "ListBox", "action": "MultiSelect", "childcount": "0" },
         { "id": "9", "name": "Template", "controller": "ListBox", "action": "Template", "childcount": "0" },
         { "id": "10", "name": "Drag and Drop", "controller": "ListBox", "action": "DragAndDrop", "childcount": "0" },
         //{ "id": "11", "name": "Load On Demand", "controller": "ListBox", "action": "LoadOnDemand", "childcount": "0" },
         { "id": "12", "name": "Reordering", "controller": "ListBox", "action": "Reordering", "childcount": "0" },
         { "id": "13", "name": "Tooltip", "controller": "ListBox", "action": "Tooltip", "childcount": "0" },
         { "id": "14", "name": "Virtual Scrolling", "controller": "ListBox", "action": "VirtualScrolling", "childcount": "0" },
         { "id": "15", "name": "Methods", "controller": "ListBox", "action": "Methods", "childcount": "0" },
         { "id": "16", "name": "Events", "controller": "ListBox", "action": "Events", "childcount": "0" },
         { "id": "17", "name": "RTL", "controller": "ListBox", "action": "RTL", "childcount": "0" },
         { "id": "18", "name": "Keyboard Navigation", "controller": "ListBox", "action": "KeyboardInteraction", "childcount": "0" }
         ]
     },
     {
         "name": "Rotator", "id": "Rotator", "Group": "NAVIGATION", "childcount": "1", "controller": "Rotator", "action": "Default", "isResponsive": "true",
         "ugurl": "https://help.syncfusion.com/aspnet-core/rotator/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/rotator",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "controller": "Rotator", "action": "Default", "childcount": "0" },
             { "id": "2", "name": "Image With Content", "controller": "Rotator", "action": "ImgWithContent", "isResponsive": "false", "childcount": "0" },
             { "id": "3", "name": "Thumbnail", "controller": "Rotator", "action": "Thumbnail", "childcount": "0" },
             { "id": "4", "name": "Data Binding - Local Data", "controller": "Rotator", "action": "LocalData", "childcount": "0" },
             { "id": "5", "name": "Methods", "controller": "Rotator", "action": "Properties", "childcount": "0" },
             { "id": "6", "name": "Events", "controller": "Rotator", "action": "Events", "childcount": "0" },
             { "id": "7", "name": "Keyboard Navigation", "controller": "Rotator", "action": "Keyboard", "childcount": "0" }
         ]
     },
      {
          "name": "RadialMenu", "id": "RadialMenu", "Group": "NAVIGATION", "childcount": "1", "controller": "RadialMenu", "action": "Default", "isResponsive": "true",
          "ugurl": "https://help.syncfusion.com/aspnet-core/radialmenu/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/radialmenu",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
          "samples": [
             { "id": "1", "name": "Default Functionalities", "controller": "RadialMenu", "action": "Default", "childcount": "0" },
             { "id": "2", "name": "Nested Radial Menu", "controller": "RadialMenu", "action": "NestedRadialMenu", "childcount": "0" },
             { "id": "3", "name": "Methods", "controller": "RadialMenu", "action": "Methods", "childcount": "0" },
             { "id": "4", "name": "Radial Slider-Menu", "controller": "RadialMenu", "action": "RadialSliderMenu", "childcount": "0" }
             ]
     },
      {
          "name": "ScrollBar", "id": "ScrollBar", "isResponsive": "true", "Group": "NAVIGATION", "childcount": "1", "controller": "ScrollBar", "action": "Default",
          "ugurl": "https://help.syncfusion.com/aspnet-core/scroller/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/scroller",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
          "samples": [
          { "id": "1", "name": "Default Functionalities", "controller": "ScrollBar", "action": "Default", "childcount": "0" },
          { "id": "2", "name": "Virtual Scrolling", "controller": "ScrollBar", "action": "VirtualScrolling", "childcount": "0" }
          ]
      },
       {
           "name": "Pager", "Group": "NAVIGATION", "id": "Pager", "childcount": "1", "controller": "Pager", "IsResponsive": "false", "action": "Default",
           "ugurl": "https://help.syncfusion.com/aspnet-core/pager/overview",
           "forumurl": "https://www.syncfusion.com/forums/aspnetcore/pager",
           "kburl": "https://www.syncfusion.com/kb/aspnetcore",
           "samples": [
               { "id": "1", "name": "Default Functionalities", "controller": "Pager", "action": "Default", "childcount": "0" },
               { "id": "2", "name": "Localization", "controller": "Pager", "action": "Localization", "childcount": "0" },
               { "id": "3", "name": "Methods", "controller": "Pager", "action": "Methods", "childcount": "0" }
           ]
       },
      {
          "name": "Tab", "id": "Tab", "childcount": "1", "Group": "NAVIGATION", "controller": "Tab", "isResponsive": "true", "action": "Default",
          "ugurl": "https://help.syncfusion.com/aspnet-core/tab/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/tab",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
          "samples": [
              { "id": "1", "name": "Default Functionalities", "controller": "Tab", "action": "Default", "childcount": "0" },
              { "id": "2", "name": "Ajax Content", "controller": "Tab", "action": "AjaxContent", "childcount": "0" },
              { "id": "3", "name": "Images", "controller": "Tab", "action": "Images", "childcount": "0" },
              { "id": "4", "name": "Direction", "controller": "Tab", "action": "Direction", "childcount": "0" },
              { "id": "5", "name": "Close Button", "controller": "Tab", "action": "CloseButton", "childcount": "0" },
              { "id": "6", "name": "Other Widgets", "controller": "Tab", "action": "OtherWidgets", "childcount": "0" },
              { "id": "7", "name": "State Maintenance", "controller": "Tab", "action": "StateMaintenance", "childcount": "0" },
              { "id": "8", "name": "Scrollable Tab", "controller": "Tab", "action": "TabScroll", "childcount": "0" },
              { "id": "9", "name": "Methods", "controller": "Tab", "action": "Methods", "childcount": "0" },
              { "id": "10", "name": "Events", "controller": "Tab", "action": "Events", "childcount": "0" },
              { "id": "11", "name": "RTL", "controller": "Tab", "action": "Rtl", "childcount": "0" },
              { "id": "12", "name": "Keyboard Navigation", "controller": "Tab", "action": "KeyboardNavigation", "childcount": "0" }
          ]
      },
       {
           "name": "HeatMap", "id": "HeatMap", "childcount": "1", "Group": "DATA VISUALIZATION", "controller": "HeatMap", "action": "CellMapping",
           "ugurl": "https://help.syncfusion.com/aspnet-core/overview",
           "forumurl": "https://www.syncfusion.com/forums/aspnetcore",
           "kburl": "https://www.syncfusion.com/kb/aspnetcore",
           "samples": [
               { "id": "1", "name": "Cell Mapping", "controller": "HeatMap", "action": "CellMapping", "childcount": "0" },
               { "id": "2", "name": "Table Mapping", "controller": "HeatMap", "action": "TableMapping", "childcount": "0" },
               { "id": "3", "name": "Legend", "controller": "HeatMap", "action": "Legend", "childcount": "0" },
               { "id": "4", "name": "Virtualization", "controller": "HeatMap", "action": "Virtualization", "childcount": "0" }
           ]
       },
      {
          "name": "Toolbar", "isResponsive": "true", "id": "Toolbar", "childcount": "1", "Group": "NAVIGATION", "controller": "Toolbar", "action": "Default",
          "ugurl": "https://help.syncfusion.com/aspnet-core/toolbar/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/toolbar",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
          "samples": [
          { "id": "1", "name": "Default Functionalities", "controller": "Toolbar", "action": "Default", "childcount": "0" },
          { "id": "2", "name": "Local Data", "controller": "Toolbar", "action": "LocalDataBinding", "childcount": "0" },
          { "id": "3", "name": "Remote Data", "controller": "Toolbar", "action": "Databindingremote", "childcount": "0" },
          { "id": "4", "name": "Orientation", "controller": "Toolbar", "action": "Orientation", "childcount": "0" },
          { "id": "5", "name": "Template", "controller": "Toolbar", "action": "Template", "childcount": "0" },
          { "id": "6", "name": "Methods", "controller": "Toolbar", "action": "Methods", "childcount": "0" },
          { "id": "7", "name": "Events", "controller": "Toolbar", "action": "Events", "childcount": "0" },
          { "id": "8", "name": "RTL", "controller": "Toolbar", "action": "Rtl", "childcount": "0" },
          { "id": "9", "name": "Keyboard Navigation", "controller": "Toolbar", "action": "Keyboard", "childcount": "0" },
		  { "id": "10", "name": "Inline Toolbar", "controller": "Toolbar", "action": "InlineToolbar", "childcount": "0" }
          ]
      },
      {
          "name": "Tooltip", "isResponsive": "true", "id": "Tooltip", "childcount": "1", "Group": "LAYOUT", "controller": "Tooltip", "action": "Default",
          "ugurl": "https://help.syncfusion.com/aspnet-core/tooltip/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/tooltip",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
          "samples": [
          { "id": "1", "name": "Default Functionalities", "controller": "Tooltip", "action": "Default", "childcount": "0" },
          { "id": "2", "name": "Position", "controller": "Tooltip", "action": "Position", "childcount": "0" },
          { "id": "3", "name": "Forms", "controller": "Tooltip", "action": "Target", "childcount": "0" },
          { "id": "4", "name": "Template", "controller": "Tooltip", "action": "Template", "childcount": "0" },
          { "id": "5", "name": "Ajax Content", "controller": "Tooltip", "action": "AjaxContent", "childcount": "0" },
          { "id": "6", "name": "Animation Effects", "controller": "Tooltip", "action": "Animation", "childcount": "0" },
          { "id": "7", "name": "API's", "controller": "Tooltip", "action": "Methods", "childcount": "0" },
          { "id": "8", "name": "Events", "controller": "Tooltip", "action": "Events", "childcount": "0" }
          ]
      },
      {
          "name": "Menu", "id": "Menu", "isResponsive": "true", "Group": "NAVIGATION", "child count": "1", "controller": "Menu", "action": "Default",
          "ugurl": "https://help.syncfusion.com/aspnet-core/menu/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/menu",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
          "samples": [
          { "id": "1", "name": "Default Functionalities", "controller": "Menu", "action": "Default", "childcount": "0" },
          { "id": "2", "name": "Local Data", "controller": "Menu", "action": "DatabindingJson", "childcount": "0" },
         // { "id": "3", "name": "Remote Data", "controller": "Menu", "action": "Databindingremote", "childcount": "0" },
          { "id": "4", "name": "Templates", "isResponsive": "false", "controller": "Menu", "action": "Template", "childcount": "0" },
          { "id": "5", "name": "Open Direction", "controller": "Menu", "action": "OpenDirection", "childcount": "0" },
          { "id": "6", "name": "Vertical Menu", "controller": "Menu", "action": "Vertical", "childcount": "0" },
          { "id": "7", "name": "Context Menu", "controller": "Menu", "action": "ContextMenu", "childcount": "0" },
          { "id": "8", "name": "Center Menu", "controller": "Menu", "action": "CenterMenu", "childcount": "0" },
          { "id": "9", "name": "Methods", "controller": "Menu", "action": "Methods", "childcount": "0" },
          { "id": "10", "name": "Events", "controller": "Menu", "action": "events", "childcount": "0" },
          { "id": "13", "name": "RTL", "controller": "Menu", "action": "Rtl", "childcount": "0" },
          { "id": "14", "name": "Keyboard Navigation", "controller": "Menu", "action": "keyboard", "childcount": "0" }
          ]
      },
     {
         "name": "Button", "isResponsive": "true", "id": "Button", "childcount": "1", "Group": "EDITORS", "controller": "Button", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/button/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/button",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
         { "id": "1", "name": "Default Functionalities", "controller": "Button", "action": "Default", "childcount": "0" },
         { "id": "2", "name": "Toggle Buttons", "controller": "Button", "action": "ToggleButtons", "childcount": "0" },
         { "id": "3", "name": "Split Buttons", "controller": "Button", "action": "SplitButtons", "childcount": "0" },
         { "id": "4", "name": "Group Button", "controller": "Button", "action": "GroupButtons", "childcount": "0" },
         { "id": "5", "name": "Repeat Button", "controller": "Button", "action": "RepeatButton", "childcount": "0" },
         { "id": "6", "name": "Check Boxes", "controller": "Button", "action": "Checkboxes", "childcount": "0" },
         { "id": "7", "name": "Radio Buttons", "controller": "Button", "action": "RadioButton", "childcount": "0" },
         { "id": "8", "name": "Methods", "controller": "Button", "action": "Methods", "childcount": "0" },
         { "id": "9", "name": "Events", "controller": "Button", "action": "Events", "childcount": "0" },
         { "id": "10", "name": "RTL", "controller": "Button", "action": "Rtl", "childcount": "0" }
         //{ "id": "11", "name": "CheckboxesFor", "controller": "Button", "action": "CheckboxesFor", "childcount": "0" },
         //{ "id": "12", "name": "RadioButtonFor", "controller": "Button", "action": "RadioButtonFor", "childcount": "0" }
         ]
     },
	   {
           "name": "Signature", "id": "Signature", "isResponsive": "true", "Group": "EDITORS", "childcount": "1", "controller": "Signature", "action": "Default",
           "ugurl": "https://help.syncfusion.com/aspnet-core/signature/overview",
           "forumurl": "https://www.syncfusion.com/forums/aspnetcore/signature",
           "kburl": "https://www.syncfusion.com/kb/aspnetcore",
           "samples": [
          { "id": "1", "name": "Default Functionalities", "controller": "Signature", "action": "Default", "childcount": "0" },
          { "id": "2", "name": "Methods", "controller": "Signature" , "action": "Methods", "childcount": "0"},
          { "id": "3", "name": "Events","controller": "Signature", "action": "Events", "childcount": "0"  }
          ]
      },
     {
         "name": "Autocomplete", "id": "Autocomplete", "Group": "EDITORS", "childcount": "1", "isResponsive": "true", "controller": "Autocomplete", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/autocomplete/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/autocomplete",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
         { "id": "1", "name": "Default Functionalities", "controller": "Autocomplete", "action": "Default", "childcount": "0" },
         { "id": "2", "name": "Multiple Values", "controller": "Autocomplete", "action": "MultipleValues", "childcount": "0" },
         { "id": "3", "name": "Grouping", "controller": "Autocomplete", "action": "Grouping", "childcount": "0" },
         { "id": "4", "name": "Template", "controller": "Autocomplete", "action": "Template", "childcount": "0" },
         { "id": "5", "name": "Data Binding - Local Data", "controller": "Autocomplete", "action": "DatabindingJson", "childcount": "0" },
         { "id": "6", "name": "Data Binding - Remote Data", "controller": "Autocomplete", "action": "Databindingremote", "childcount": "0" },
         { "id": "7", "name": "Auto Fill", "controller": "Autocomplete", "action": "Autofill", "childcount": "0" },
         { "id": "8", "name": "Methods", "controller": "Autocomplete", "action": "Methods", "childcount": "0" },
         { "id": "9", "name": "Events", "controller": "Autocomplete", "action": "Events", "childcount": "0" },
         { "id": "10", "name": "RTL", "controller": "Autocomplete", "action": "Rtl", "childcount": "0" },
         { "id": "11", "name": "Keyboard Navigation", "controller": "Autocomplete", "action": "Keyboard", "childcount": "0" }
         ]
     },
     {
         "name": "DateTimePicker", "id": "DateTimePicker", "Group": "EDITORS", "isResponsive": "true", "childcount": "1", "controller": "DateTimePicker", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/datetimepicker/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/datetimepicker",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "DateTimePicker", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Localization", "controller": "DateTimePicker", "action": "Localization", "childcount": "0" },
            { "id": "3", "name": "Methods", "controller": "DateTimePicker", "action": "Methods", "childcount": "0" },
            { "id": "4", "name": "Drilldown Support", "controller": "DateTimePicker", "action": "Drilldown", "childcount": "0" },
            { "id": "5", "name": "Meridian Format", "controller": "DateTimePicker", "action": "Meridian", "childcount": "0" },
            { "id": "6", "name": "Events", "controller": "DateTimePicker", "action": "Events", "childcount": "0" },
            { "id": "7", "name": "RTL", "controller": "DateTimePicker", "action": "Rtl", "childcount": "0" },
            { "id": "8", "name": "Keyboard Navigation", "controller": "DateTimePicker", "action": "Keyboard", "childcount": "0" }
            //{ "id": "9", "name": "DateTimePickerFor", "controller": "DateTimePicker", "action": "DateTimePickerFor", "childcount": "0" }
         ]
     },
     {
         "name": "DateRangePicker", "id": "DateRangePicker", "Group": "EDITORS", "isResponsive": "true", "childcount": "1", "controller": "DateRangePicker", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/daterangepicker/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/daterangepicker",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
             { "id": "1", "name": "Default", "controller": "DateRangePicker", "action": "Default", "childcount": "0" },
             { "id": "2", "name": "Localization", "controller": "DateRangePicker", "action": "Localization", "childcount": "0" },
             { "id": "3", "name": "Methods", "controller": "DateRangePicker", "action": "Methods", "childcount": "0" },
             { "id": "4", "name": "Ranges", "controller": "DateRangePicker", "action": "Ranges", "childcount": "0" },
             { "id": "5", "name": "DateTimeRange", "controller": "DateRangePicker", "action": "DateTimeRange", "childcount": "0" },
             { "id": "6", "name": "Events", "controller": "DateRangePicker", "action": "Events", "childcount": "0" }
         ]
     },
     {
         "name": "ColorPicker", "id": "ColorPicker", "Group": "EDITORS", "childcount": "1", "isResponsive": "false", "controller": "ColorPicker", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/colorpicker/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/colorpicker",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "controller": "ColorPicker", "action": "Default", "childcount": "0" },
             { "id": "2", "name": "Display Inline", "controller": "ColorPicker", "action": "DisplayInline", "childcount": "0" },
             { "id": "3", "name": "Color Palette", "controller": "ColorPicker", "action": "PaletteModel", "childcount": "0" },
             { "id": "4", "name": "Presets", "controller": "ColorPicker", "action": "Presets", "childcount": "0" },
             { "id": "5", "name": "Custom Palette", "controller": "ColorPicker", "action": "CustomPalette", "childcount": "0" },
             { "id": "6", "name": "Methods", "controller": "ColorPicker", "action": "Methods", "childcount": "0" },
             { "id": "7", "name": "Events", "controller": "ColorPicker", "action": "Events", "childcount": "0" },
             { "id": "8", "name": "Keyboard Navigation", "controller": "ColorPicker", "action": "Keyboard", "childcount": "0" }
         ]
     },
     {
         "name": "TimePicker", "id": "TimePicker", "Group": "EDITORS", "childcount": "1", "controller": "TimePicker", "action": "Default", "isResponsive": "true",
         "ugurl": "https://help.syncfusion.com/aspnet-core/timepicker/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/timepicker",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "controller": "TimePicker", "action": "Default", "childcount": "0" },
             { "id": "2", "name": "Localization", "controller": "TimePicker", "action": "Localization", "childcount": "0" },
             { "id": "3", "name": "Methods", "controller": "TimePicker", "action": "Methods", "childcount": "0" },
             { "id": "4", "name": "Events", "controller": "TimePicker", "action": "Events", "childcount": "0" },
             { "id": "5", "name": "RTL", "controller": "TimePicker", "action": "Rtl", "childcount": "0" },
             { "id": "6", "name": "Keyboard Navigation", "controller": "TimePicker", "action": "Keyboard", "childcount": "0" }
             //{ "id": "7", "name": "TimePickerFor", "controller": "TimePicker", "action": "TimePickerFor", "childcount": "0" }

         ]
     },
     {
         "name": "Rating", "id": "Rating", "Group": "EDITORS", "isResponsive": "false", "childcount": "1", "controller": "Rating", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/rating/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/rating",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
         { "id": "1", "name": "Default Functionalities", "controller": "Rating", "action": "Default", "isResponsive": "false", "childcount": "0" },
         { "id": "2", "name": "Precision", "controller": "Rating", "action": "Precision", "childcount": "0" },
         { "id": "3", "name": "Orientation", "controller": "Rating", "action": "Orientation", "childcount": "0" },
         { "id": "4", "name": "Methods", "controller": "Rating", "action": "Methods", "childcount": "0" },
         { "id": "5", "name": "Events", "controller": "Rating", "action": "Events", "childcount": "0" }
         ]
     }, 
     {
         "name": "ListView", "id": "ListView", "Group": "LAYOUT", "childcount": "1", "controller": "ListView", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/listview/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/listview",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
         { "id": "1", "name": "Default Functionalities", "controller": "ListView", "action": "Default", "childcount": "0" },
         { "id": "2", "name": "CheckList", "controller": "ListView", "action": "CheckList", "childcount": "0" },
         { "id": "3", "name": "Data Binding - Local Data", "controller": "ListView", "action": "DataBindingLocal", "childcount": "0" },
         { "id": "4", "name": "Virtual Scrolling", "controller": "ListView", "action": "VirtualScrolling", "childcount": "0" }

         ]
     },
                {
                    "name": "NavigationDrawer", "id": "NavigationDrawer", "Group": "NAVIGATION", "childcount": "1", "controller": "NavigationDrawer", "action": "Default",
                    "ugurl": "https://help.syncfusion.com/aspnet-core/navigationdrawer/overview",
                    "forumurl": "https://www.syncfusion.com/forums/aspnetcore/navigationdrawer",
                    "kburl": "https://www.syncfusion.com/kb/aspnetcore",
                    "samples": [
                    { "id": "1", "name": "Default", "controller": "NavigationDrawer", "action": "Default", "childcount": "0" }
                    ]
                },

                {
                    "name": "Tile View", "id": "TileView", "Group": "LAYOUT", "childcount": "1", "controller": "TileView", "action": "Default",
                    "ugurl": "https://help.syncfusion.com/aspnet-core/tile/overview",
                    "forumurl": "https://www.syncfusion.com/forums/aspnetcore/tileview",
                    "kburl": "https://www.syncfusion.com/kb/aspnetcore",
                    "samples": [
                    { "id": "1", "name": "Default", "controller": "TileView", "action": "Default", "childcount": "0" }
                    ]
                },
                {
                    "name": "Radial Slider", "id": "RadialSlider", "childcount": "1", "Group": "EDITORS", "controller": "RadialSlider", "action": "Default",
                    "ugurl": "https://help.syncfusion.com/aspnet-core/radialslider/overview",
                    "forumurl": "https://www.syncfusion.com/forums/aspnetcore/radialslider",
                    "kburl": "https://www.syncfusion.com/kb/aspnetcore",
                    "samples": [
					{ "id": "1", "name": "Default Functionalities", "controller": "RadialSlider", "action": "Default", "childcount": "0" },
					{ "id": "2", "name": "API", "controller": "RadialSlider", "action": "API", "childcount": "0" }
                  ]
                },
     {
         "name": "TextBoxes", "id": "Editor", "isResponsive": "true", "Group": "EDITORS", "childcount": "1", "controller": "Editor", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/maskedit/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/maskedit",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "Editor", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Localization", "controller": "Editor", "action": "Localization", "childcount": "0" },
            { "id": "3", "name": "Methods", "controller": "Editor", "action": "Methods", "childcount": "0" },
            { "id": "4", "name": "Events", "controller": "Editor", "action": "Events", "childcount": "0" },
            { "id": "5", "name": "RTL", "controller": "Editor", "action": "Rtl", "childcount": "0" },
            { "id": "6", "name": "Keyboard Navigation", "controller": "Editor", "action": "Keyboard", "childcount": "0" }
         ]
     },
      {
          "name": "Slider", "id": "Slider", "isResponsive": "true", "childcount": "1", "Group": "EDITORS", "controller": "Slider", "action": "Default",
          "ugurl": "https://help.syncfusion.com/aspnet-core/slider/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/slider",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
          "samples": [
          { "id": "1", "name": "Default Functionalities", "controller": "Slider", "action": "Default", "childcount": "0" },
          { "id": "2", "name": "Range Slider", "controller": "Slider", "action": "RangeSlider", "childcount": "0" },
          { "id": "3", "name": "Vertical Slider", "controller": "Slider", "action": "VerticalSlider", "childcount": "0" },
		  { "id": "8", "name": "Button Support", "controller": "Slider", "action": "ButtonSupport", "childcount": "0" },
          { "id": "4", "name": "Methods", "controller": "Slider", "action": "Methods", "childcount": "0" },
          { "id": "5", "name": "Events", "controller": "Slider", "action": "Events", "childcount": "0" },
          { "id": "6", "name": "RTL", "controller": "Slider", "action": "Rtl", "childcount": "0" },
          { "id": "7", "name": "Keyboard Navigation", "controller": "Slider", "action": "Keyboard", "childcount": "0" }
          ]
      },
     {
         "name": "Dialog", "isResponsive": "true", "id": "Dialog", "Group": "LAYOUT", "childcount": "1", "controller": "Dialog", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/dialog/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/dialog",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
               { "id": "1", "name": "Default Functionalities", "controller": "Dialog", "action": "Default", "childcount": "0" },
               { "id": "2", "name": "Ajax Content", "controller": "Dialog", "action": "AjaxContent", "childcount": "0" },
               { "id": "3", "name": "Multiple Dialog", "controller": "Dialog", "action": "MultipleDialog", "isResponsive": "false", "childcount": "0" },
               { "id": "4", "name": "Action Buttons", "controller": "Dialog", "action": "Icons", "childcount": "0" },
               { "id": "5", "name": "Modal Dialog", "controller": "Dialog", "action": "ModelDialog", "childcount": "0" },
               { "id": "6", "name": "Methods", "controller": "Dialog", "action": "Methods", "childcount": "0" },
               { "id": "7", "name": "Events", "controller": "Dialog", "action": "Events", "childcount": "0" },
               { "id": "8", "name": "RTL", "controller": "Dialog", "action": "Rtl", "childcount": "0" },
               { "id": "9", "name": "Keyboard Navigation", "controller": "Dialog", "action": "KeyboardNavigation", "childcount": "0" }
         ]
     },
       {
           "name": "Splitter", "isResponsive": "true", "id": "Splitter", "Group": "LAYOUT", "childcount": "1", "controller": "Splitter", "action": "Default",
           "ugurl": "https://help.syncfusion.com/aspnet-core/splitter/overview",
           "forumurl": "https://www.syncfusion.com/forums/aspnetcore/splitter",
           "kburl": "https://www.syncfusion.com/kb/aspnetcore",
           "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "Splitter", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Orientation", "controller": "Splitter", "action": "Orientation", "childcount": "0" },
            { "id": "3", "name": "Nested Splitter", "controller": "Splitter", "action": "NestedSplitter", "childcount": "0" },
            { "id": "4", "name": "Integration", "controller": "Splitter", "action": "Integaration", "childcount": "0" },
            { "id": "5", "name": "Methods", "controller": "Splitter", "action": "Methods", "childcount": "0" },
            { "id": "6", "name": "Events", "controller": "Splitter", "action": "Events", "childcount": "0" },
            { "id": "7", "name": "RTL", "controller": "Splitter", "action": "Rtl", "childcount": "0" },
            { "id": "8", "name": "Keyboard Navigation", "controller": "Splitter", "action": "Keyboard", "childcount": "0" }
           ]
       },
     {
         "name": "ProgressBar", "id": "ProgressBar", "isResponsive": "true", "Group": "NOTIFICATION", "childcount": "1", "controller": "ProgressBar", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/progressbar/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/progressbar",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
         { "id": "1", "name": "Default Functionalities", "controller": "ProgressBar", "action": "Default", "childcount": "0" },
         { "id": "2", "name": "Events", "controller": "ProgressBar", "action": "Events", "childcount": "0" },
         { "id": "3", "name": "Methods", "controller": "ProgressBar", "action": "Methods", "childcount": "0" },
         { "id": "4", "name": "RTL", "controller": "ProgressBar", "action": "Rtl", "childcount": "0" }
         ]
     },
      {
          "name": "WaitingPopup", "isResponsive": "true", "id": "WaitingPopup", "Group": "NOTIFICATION", "childcount": "1", "controller": "WaitingPopup", "action": "Default",
          "ugurl": "https://help.syncfusion.com/aspnet-core/waitingpopup/overview",
          "forumurl": "https://www.syncfusion.com/forums/aspnetcore/waitingpopup",
          "kburl": "https://www.syncfusion.com/kb/aspnetcore",
          "samples": [
             { "id": "1", "name": "Default Functionalities", "controller": "WaitingPopup", "action": "Default", "childcount": "0" },
             { "id": "2", "name": "Template", "controller": "WaitingPopup", "action": "Template", "childcount": "0" }
          ]
      },
     {
         "name": "TagCloud", "isResponsive": "true", "id": "TagCloud", "childcount": "1", "Group": "DATA VISUALIZATION", "controller": "TagCloud", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/tagcloud/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/tagcloud",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
           { "id": "1", "name": "Default Functionalities", "controller": "TagCloud", "action": "Default", "childcount": "0" },
           { "id": "2", "name": "Remote Data", "controller": "TagCloud", "action": "DatabindingOdata", "childcount": "0" },
           { "id": "3", "name": "Events", "controller": "TagCloud", "action": "Events", "childcount": "0" },
           { "id": "4", "name": "RTL", "controller": "TagCloud", "action": "Rtl", "childcount": "0" }
         ]
     },
    {
        "name": "Chart", "id": "Chart", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "Chart", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/chart/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/chart",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "Chart", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Column", "controller": "Chart", "action": "Column", "childcount": "0" },
            { "id": "3", "name": "Area", "controller": "Chart", "action": "Area", "childcount": "0" },
            { "id": "4", "name": "Stacking Column", "controller": "Chart", "action": "StackingColumn", "childcount": "0" },
            { "id": "5", "name": "Pie", "controller": "Chart", "action": "Pie", "childcount": "0" },
            { "id": "6", "name": "Pyramid", "controller": "Chart", "action": "Pyramid", "childcount": "0" },
            { "id": "7", "name": "3D Column", "controller": "Chart", "action": "Column3d", "childcount": "0" },
            { "id": "8", "name": "3D Pie", "controller": "Chart", "action": "Pie3d", "childcount": "0" },
            { "id": "9", "name": "3D Stacking Column", "controller": "Chart", "action": "StackingColumn3d", "childcount": "0" },
            { "id": "10", "name": "TrackBall", "controller": "Chart", "action": "TrackBall", "childcount": "0" },
            { "id": "11", "name": "Zooming", "controller": "Chart", "action": "ZoomingAndPanning", "childcount": "0" }
        ]
    },
    {
        "name": "Maps", "id": "Maps", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "Maps", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/maps/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/map",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
		"samples": [
			{ "id": "1", "name": "Data Markers", "controller": "Maps", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Heat Map", "controller": "Maps", "action": "HeatMap", "childcount": "0" },
            { "id": "3", "name": "Labels", "controller": "Maps", "action": "Labels", "childcount": "0" },
            { "id": "4", "name": "Selection", "controller": "Maps", "action": "Selection", "childcount": "0" }
        ]
    },
    {
        "name": "TreeMap", "id": "TreeMap", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "TreeMap", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/treemap/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/treemap",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
            { "id": "1", "name": "Flat Collection", "controller": "TreeMap", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Customization", "controller": "TreeMap", "action": "Customization", "childcount": "0" },
            { "id": "3", "name": "Hierarchical", "controller": "TreeMap", "action": "Hierarchical", "childcount": "0" },
			{ "id": "4", "name": "DrillDown", "controller": "TreeMap", "action": "drillDown", "childcount": "0" }
         ]
    },
    {
        "name": "BulletGraph", "id": "BulletGraph", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "BulletGraph", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/bulletgraph/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/bulletgraph",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
        { "id": "1", "name": "Default Functionalities", "controller": "BulletGraph", "action": "Default", "childcount": "0" }
        ]
    },
    {
        "name": "RangeNavigator", "id": "RangeNavigator", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "RangeNavigator", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/rangenavigator/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/rangenavigator",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
        { "id": "1", "name": "Default Functionalities", "controller": "RangeNavigator", "action": "Default", "childcount": "0" },
        { "id": "2", "name": "Numeric Type", "controller": "RangeNavigator", "action": "NumericType", "childcount": "0" }
        ]
    },
	{

        "name": "Linear Gauge", "id": "LinearGauge", "childcount": "1", "Group": "DATA VISUALIZATION", "controller": "LinearGauge", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/lineargauge/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/lineargauge",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
              { "id": "1", "name": "Default Functionalities", "controller": "LinearGauge", "action": "Default", "childcount": "0" }
	    ]
	},
     {

         "name": "Digital Gauge", "id": "DigitalGauge", "childcount": "1", "Group": "DATA VISUALIZATION", "controller": "DigitalGauge", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/digitalgauge/getting-started",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/digitalgauge",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
               { "id": "1", "name": "Default Functionalities", "controller": "DigitalGauge", "action": "Default", "childcount": "0" }
         ]
     },
    {
        "name": "Circular Gauge", "id": "CircularGauge", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "CircularGauge", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/circulargauge/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/circulargauge",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
                    { "id": "1", "name": "Default Functionalities", "controller": "CircularGauge", "action": "Default", "childcount": "0" }
        ]
    },
    {
        "name": "Sparkline", "id": "Sparkline", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "Sparkline", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/sparkline/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/sparkline",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
         {
                 "id":"1","name":"Default","controller":"Sparkline","action":"Default","childcount":"0"
             }           
         ]
    },
    {
        "name": "Sunburst Chart", "id": "Sunburst", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "Sunburst", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/sunburstchart/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/sunburstchart",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
         {
                 "id":"1","name":"Default","controller":"Sunburst","action":"Default","childcount":"0"
             }           
         ]
    },
    {
        "name": "Predictive Analytics", "id": "PredictiveAnalytics", "Group": "DATA SCIENCE", "childcount": "1", "controller": "PredictiveAnalytics", "action": "GeneralRegression",
        "ugurl": "https://help.syncfusion.com/predictive-analytics/pmml-execution-engine/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore",
        "samples": [
            { "id": "1", "name": "Audit Logit Classification", "controller": "PredictiveAnalytics", "action": "GeneralRegression", "childcount": "0" }
        ]
    },
     {
         "name": "Gantt", "id": "Gantt", "childcount": "1", "Group": "DATA VISUALIZATION", "controller": "Gantt", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/gantt/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/gantt",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "controller": "Gantt", "action": "Default", "childcount": "0" },
             { "id": "2", "name": "Editing", "controller": "Gantt", "action": "GanttEditing", "childcount": "0" },
             { "id": "3", "name": "Sorting", "controller": "Gantt", "action": "GanttSorting", "childcount": "0" }
         ]
     },
     {
         "name": "Barcode", "id": "Barcode", "childcount": "1", "Group": "DATA VISUALIZATION", "controller": "Barcode", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
            { "id": "1", "name": "QR Barcode", "controller": "Barcode", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Datamatrix", "controller": "Barcode", "action": "Datamatrix", "childcount": "0" },
            { "id": "3", "name": "Codabar", "controller": "Barcode", "action": "Codabar", "childcount": "0" },
            { "id": "4", "name": "Code11", "controller": "Barcode", "action": "Code11", "childcount": "0" },
            { "id": "5", "name": "Code32", "controller": "Barcode", "action": "Code32", "childcount": "0" },
            { "id": "6", "name": "Code39", "controller": "Barcode", "action": "Code39", "childcount": "0" },
            { "id": "7", "name": "Code39 Extended", "controller": "Barcode", "action": "Code39Extended", "childcount": "0" },
            { "id": "8", "name": "Code93", "controller": "Barcode", "action": "Code93", "childcount": "0" },
            { "id": "9", "name": "Code93 Extended", "controller": "Barcode", "action": "Code93Extended", "childcount": "0" },
            { "id": "10", "name": "Code128A", "controller": "Barcode", "action": "Code128A", "childcount": "0" },
            { "id": "11", "name": "Code128B", "controller": "Barcode", "action": "Code128B", "childcount": "0" },
            { "id": "12", "name": "Code128C", "controller": "Barcode", "action": "Code128C", "childcount": "0" }
         ]
     },
     {
         "name": "Schedule", "id": "Schedule", "childcount": "1", "Group": "DATA VISUALIZATION", "controller": "Schedule", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/schedule/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/schedule",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore/schedule",
         "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "Schedule", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Timeline Functionalities", "controller": "Schedule", "action": "Timeline", "childcount": "0" },
            { "id": "3", "name": "Multiple Resource", "controller": "Schedule", "action": "MultipleResource", "childcount": "0" },
            { "id": "4", "name": "Multiple Resource Grouping", "controller": "Schedule", "action": "MultipleResourceGrouping", "childcount": "0" },
            { "id": "5", "name": "Remote Data", "controller": "Schedule", "action": "RemoteData", "childcount": "0" },
            { "id": "6", "name": "Appointment Template", "controller": "Schedule", "action": "AppointmentTemplate", "childcount": "0" },
            { "id": "7", "name": "Time Scale", "controller": "Schedule", "action": "Timescale", "childcount": "0" },
            { "id": "8", "name": "Block Intervals", "controller": "Schedule", "action": "BlockIntervals", "childcount": "0" },
            { "id": "9", "name": "FirstDayOfWeek", "controller": "Schedule", "action": "FirstDayOfWeek", "childcount": "0" },
            { "id": "10", "name": "Categorize", "controller": "Schedule", "action": "Categorize", "childcount": "0" },
            { "id": "11", "name": "Custom View", "controller": "Schedule", "action": "CustomView", "childcount": "0" },
            { "id": "12", "name": "Excel Export", "controller": "Schedule", "action": "XLSExport", "childcount": "0" }
        ]
     },
	 {
         "name": "KanbanBoard", "id": "KanbanBoard", "childcount": "1", "Group": "DATA VISUALIZATION", "controller": "KanbanBoard", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/kanban/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/kanban",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "controller": "KanbanBoard", "action": "Default", "childcount": "0" }
         ]
     },
     {
         "name": "Ribbon", "id": "Ribbon", "childcount": "1", "Group": "NAVIGATION", "controller": "Ribbon", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/ribbon/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/ribbon",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "controller": "Ribbon", "action": "Default", "childcount": "0" }
         ]
     },
     {
         "name": "PDF", "id": "Pdf", "childcount": "1", "Group": "FILE FORMATS", "controller": "Pdf", "type": "update", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/pdf/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/pdf",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore/pdf",
         "samples": [
             { "id": "1", "name": "Getting Started", "controller": "Pdf", "action": "Default", "childcount": "0" },
             {
                                            "id": "2", "name": "Product Showcase", "controller": "Pdf", "action": "JobApplication", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Job Application", "controller": "Pdf", "action": "JobApplication", "childcount": "0" }                                        
                                            ]
                                        },  
                                          {
                                                "id": "3", "name": "Drawing Text", "controller": "Pdf", "action": "TextFlow", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Text Flow", "controller": "Pdf", "action": "TextFlow", "childcount": "0" },                
                                           { "id": "2", "name": "Bullets and Lists", "controller": "Pdf", "action": "BulletsandLists", "childcount": "0" },
										   { "id": "3", "name": "RTL Text", "controller": "Pdf", "action": "RTLSupport", "childcount": "0"}
                                         
                                                ]
                                            },										
                                          {
                                              "id": "4", "name": "Graphics", "controller": "Pdf", "action": "Barcode", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Barcode", "controller": "Pdf", "action": "Barcode", "childcount": "0"},
                                           { "id": "2", "name": "Drawing Shapes", "controller": "Pdf", "action": "DrawingShapes", "childcount": "0" },
                                           { "id": "3", "name": "Graphic Brushes", "controller": "Pdf", "action": "GraphicBrushes", "childcount": "0" },
										   { "id": "4", "name": "Image Insertion", "controller": "Pdf", "action": "ImageInsertion", "childcount": "0"},
                                              ]
                                          },
                                          {
                                              "id": "5", "name": "Tables", "controller": "Pdf", "action": "AdventureCycle", "childcount": "1", "samples": [   
                                         { "id": "2", "name": "Adventure Cycle Works", "controller": "Pdf", "action": "AdventureCycle", "childcount": "0" },
                                         { "id": "3", "name": "Table Features", "controller": "Pdf", "action": "TableFeatures", "childcount": "0" }]
                                          },                                            
                                        {
										 "id": "6", "name": "Import and Export", "controller": "Pdf", "action": "ExtractText", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Text Extraction", "controller": "Pdf", "action": "ExtractText", "childcount": "0" },
                                         { "id": "2", "name": "Find Text", "controller": "Pdf", "action": "FindText", "childcount": "0" },
										  { "id": "3", "name": "Doc To PDF", "controller": "Pdf", "action": "DocToPDF", "childcount": "0" }]
                                        }, 
                                             {
                                                 "id": "7", "name": "Security", "controller": "Pdf", "action": "Encryption", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Encryption", "controller": "Pdf", "action": "Encryption", "childcount": "0" },
                                         { "id": "2", "name": "Digital Signature", "controller": "Pdf", "action": "DigitalSignature", "childcount": "0"}
                                                 ]
                                             },

                                              {
                                                  "id": "8", "name": "Settings", "controller": "Pdf", "action": "DocumentSettings", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Document Settings", "controller": "Pdf", "action": "DocumentSettings", "childcount": "0" },
                                           { "id": "2", "name": "Page Settings", "controller": "Pdf", "action": "PageSettings", "childcount": "0" },
                                           { "id": "3", "name": "Headers and Footers", "controller": "Pdf", "action": "HeadersandFooters", "childcount": "0" },
                                           { "id": "4", "name": "Layers", "controller": "Pdf", "action": "Layers", "childcount": "0" }
                                                  ]
                                              },
                                              {
                                                  "id": "9", "name": "User Interaction", "controller": "Pdf", "action": "InteractiveFeatures", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Interactive Features", "controller": "Pdf", "action": "InteractiveFeatures", "childcount": "0" },
                                           { "id": "2", "name": "Form Filling", "controller": "Pdf", "action": "FormFilling", "childcount": "0"},
                                           { "id": "3", "name": "Portfolio", "controller": "Pdf", "action": "Portfolio", "childcount": "0" },
                                           { "id": "4", "name": "Annotations", "controller": "Pdf", "action": "AnnotationFlatten", "childcount": "0", "type": "update" },
										   { "id": "5", "name": "Named Destination", "controller": "Pdf", "action": "NamedDestination", "childcount": "0"},
                                           { "id": "6", "name": "Bookmarks", "controller": "Pdf", "action": "Bookmarks", "childcount": "0"},
                                           { "id": "7", "name": "File Attachments", "controller": "Pdf", "action": "Attachments", "childcount": "0" }]
                                              },                                                 
                                                       {
                                                           "id": "10", "name": "Modify Documents", "controller": "Pdf", "action": "MergeDocuments", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Merge Documents", "controller": "Pdf", "action": "MergeDocuments", "childcount": "0" },
                                           { "id": "2", "name": "Split PDF", "controller": "Pdf", "action": "SplitPDF", "childcount": "0" },
                                           { "id": "3", "name": "Overlay Documents", "controller": "Pdf", "action": "OverlayDocuments", "childcount": "0" },
                                           { "id": "4", "name": "Booklet", "controller": "Pdf", "action": "Booklet", "childcount": "0" },
                                            { "id": "5", "name": "Import and Stamp", "controller": "Pdf", "action": "ImportAndStamp", "childcount": "0" },
                                           { "id": "6", "name": "Rearrange Pages", "controller": "Pdf", "action": "RearrangePages", "childcount": "0" }]

                                                       },
                                                         {
                                                             "id": "11", "name": "Accessibility", "controller": "Pdf", "action": "AutoTag", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Autotag", "controller": "Pdf", "action": "AutoTag", "childcount": "0" },
										 { "id": "2", "name": "Customtag", "controller": "Pdf", "action": "CustomTag", "childcount": "0"  }
                                                             ]
                                                         }	                                                       
														 
         ]
     },
     {
         "name": "Presentation", "id": "Presentation", "childcount": "1", "Group": "FILE FORMATS", "controller": "Presentation", "action": "Default", "type": "update",
         "ugurl": "https://help.syncfusion.com/aspnet-core/presentation/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/presentation",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore/presentation",
         "samples": [
             { "id": "1", "name": "Getting Started", "controller": "Presentation", "action": "Default", "childcount": "0" },
              { "id": "2", "name": "Chart", "controller": "Presentation", "action": "Chart", "childcount": "0" },
               { "id": "3", "name": "Slide", "controller": "Presentation", "action": "Slide", "childcount": "0" },
                { "id": "4", "name": "SmartArt", "controller": "Presentation", "action": "SmartArt", "childcount": "0" },
                { "id": "5", "name": "Table", "controller": "Presentation", "action": "Table", "childcount": "0" },
                { "id": "6", "name": "Comment", "controller": "Presentation", "action": "Comment", "childcount": "0" },
				{ "id": "7", "name": "Create Animation", "controller": "Presentation", "action": "CreateAnimation", "childcount": "0"  },
				{ "id": "8", "name": "Modify Animation", "controller": "Presentation", "action": "ModifyAnimation", "childcount": "0"  },
				{ "id": "9", "name": "Slide Transition", "controller": "Presentation", "action": "SlideTransition", "childcount": "0", "type": "new"  }
         ]
     },
	 {
         "name": "DocIO", "id": "DocIO", "childcount": "1", "Group": "FILE FORMATS", "controller": "DocIO", "action": "SalesInvoice",
         "ugurl": "https://help.syncfusion.com/aspnet-core/docio/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/docio",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore/docio",
         "samples": [
             {
                 "id": "1", "name": "Product Showcase", "controller": "DocIO", "action": "SalesInvoice", "childcount": "1", "samples": [
                     { "id": "1", "name": "Sales Invoice", "controller": "DocIO", "action": "SalesInvoice", "childcount": "0" },
                     { "id": "2", "name": "Update Fields", "controller": "DocIO", "action": "UpdateFields", "childcount": "0" }
                 ]
             },
             {
                 "id": "2", "name": "Getting Started", "controller": "DocIO", "action": "HelloWorld", "childcount": "1", "samples": [
                     { "id": "1", "name": "Hello World", "controller": "DocIO", "action": "HelloWorld", "childcount": "0" }
                 ]
             },
             {
                 "id": "3", "name": "Editing", "controller": "DocIO", "action": "FindandHighlight", "childcount": "1", "samples": [
                     { "id": "1", "name": "Find and Highlight", "controller": "DocIO", "action": "FindandHighlight", "childcount": "0" },
                     { "id": "2", "name": "Simple Replace", "controller": "DocIO", "action": "SimpleReplace", "childcount": "0" },
                     { "id": "3", "name": "Advanced Replace", "controller": "DocIO", "action": "AdvancedReplace", "childcount": "0" },
                     { "id": "4", "name": "Bookmark Contents", "controller": "DocIO", "action": "BookmarkNavigation", "childcount": "0" },
                     { "id": "5", "name": "Clone and Merge", "controller": "DocIO", "action": "CloneandMerge", "childcount": "0" },
                     { "id": "6", "name": "Forms", "controller": "DocIO", "action": "Forms", "childcount": "0" }
                 ]
             },
             {
                 "id": "4", "name": "Content Control", "controller": "DocIO", "action": "FormFillingAndProtection", "childcount": "1", "samples": [
                     { "id": "1", "name": "Form filling and Protection", "controller": "DocIO", "action": "FormFillingAndProtection", "childcount": "0" },
                     { "id": "2", "name": "XML mapping", "controller": "DocIO", "action": "XMLMapping", "childcount": "0" }
                 ]
             },
             {
                 "id": "5", "name": "Insert Content", "controller": "DocIO", "action": "Bookmarks", "childcount": "1", "samples": [
                     { "id": "1", "name": "Bookmarks", "controller": "DocIO", "action": "Bookmarks", "childcount": "0" },
                     { "id": "2", "name": "Header and Footer", "controller": "DocIO", "action": "HeaderandFooter", "childcount": "0" },
                     { "id": "3", "name": "Image Insertion", "controller": "DocIO", "action": "ImageInsertion", "childcount": "0" },
                     { "id": "4", "name": "Insert OLE Object", "controller": "DocIO", "action": "InsertOLEObject", "childcount": "0" }
                 ]
             },
             {
                 "id": "6", "name": "Formatting", "controller": "DocIO", "action": "FormatTable", "childcount": "1", "samples": [
                     { "id": "1", "name": "Format Table", "controller": "DocIO", "action": "FormatTable", "childcount": "0" },
                     { "id": "2", "name": "Format Text", "controller": "DocIO", "action": "FormatText", "childcount": "0" },
                     { "id": "3", "name": "RTL Support", "controller": "DocIO", "action": "RTLSupport", "childcount": "0" },
                     { "id": "4", "name": "Styles", "controller": "DocIO", "action": "Styles", "childcount": "0" },
                     { "id": "5", "name": "Table Styles", "controller": "DocIO", "action": "TableStyles", "childcount": "0" }
                 ]
             },
             {
                 "id": "7", "name": "Mail Merge", "controller": "DocIO", "action": "EmployeeReport", "childcount": "1", "samples": [
                     { "id": "1", "name": "Employee Report", "controller": "DocIO", "action": "EmployeeReport", "childcount": "0" },
                     { "id": "2", "name": "Mail Merge Event", "controller": "DocIO", "action": "MailMergeEvent", "childcount": "0" },
                     { "id": "3", "name": "Nested Mail Merge", "controller": "DocIO", "action": "NestedMailMerge", "childcount": "0" }
                 ]
             },
             {
                 "id": "8", "name": "Import and Export", "controller": "DocIO", "action": "WordToPDF", "childcount": "1", "samples": [
				 { "id": "1", "name": "Word To PDF", "controller": "DocIO", "action": "WordToPDF", "childcount": "0" },
                     { "id": "2", "name": "Word to WordML", "controller": "DocIO", "action": "WordToWordML", "childcount": "0" },
                     { "id": "3", "name": "WordML to Word", "controller": "DocIO", "action": "WordMLToWord", "childcount": "0" },
                     { "id": "4", "name": "RTF to Word", "controller": "DocIO", "action": "RTFToDoc", "childcount": "0" },
                     { "id": "5", "name": "Word to ODT", "controller": "DocIO", "action": "DOCtoODT", "childcount": "0" }
                 ]
             },
             {
                 "id": "9", "name": "Page Layout", "controller": "DocIO", "action": "InsertBreak", "childcount": "1", "samples": [
                     { "id": "1", "name": "Insert Break", "controller": "DocIO", "action": "InsertBreak", "childcount": "0" },
                     { "id": "2", "name": "Watermark", "controller": "DocIO", "action": "Watermark", "childcount": "0" }
                 ]
             },
             {
                 "id": "10", "name": "References", "controller": "DocIO", "action": "FootnotesandEndnotes", "childcount": "1", "samples": [
                     { "id": "1", "name": "Footnotes and Endnotes", "controller": "DocIO", "action": "FootnotesandEndnotes", "childcount": "0" },
                 ]
             },
             {
                 "id": "11", "name": "Shapes", "controller": "DocIO", "action": "AutoShapes", "childcount": "1", "samples": [
                     { "id": "1", "name": "AutoShapes", "controller": "DocIO", "action": "AutoShapes", "childcount": "0" }
                 ]
             },
             {
                 "id": "12", "name": "Chart", "controller": "DocIO", "action": "PieChart", "childcount": "1", "samples": [                     
                     { "id": "1", "name": "Pie Chart", "controller": "DocIO", "action": "PieChart", "childcount": "0" },
                     { "id": "2", "name": "Bar Chart", "controller": "DocIO", "action": "BarChart", "childcount": "0" }
                 ]
             },
             {
                 "id": "13", "name": "View", "controller": "DocIO", "action": "DocumentSettings", "childcount": "1", "samples": [
                     { "id": "1", "name": "Document Settings", "controller": "DocIO", "action": "DocumentSettings", "childcount": "0" },
                     { "id": "2", "name": "Macro Preservation", "controller": "DocIO", "action": "MacroPreservation", "childcount": "0" }
                 ]
             },
             {
                 "id": "14", "name": "Security", "controller": "DocIO", "action": "DocumentProtection", "childcount": "1", "samples": [
                     { "id": "1", "name": "Document Protection", "controller": "DocIO", "action": "DocumentProtection", "childcount": "0" },
                 ]
             }
         ]         
	 },
		 {
             "name": "XlsIO", "id": "XlsIO", "childcount": "1", "Group": "FILE FORMATS", "controller": "XlsIO", "action": "Create", "type": "update",
             "ugurl": "https://help.syncfusion.com/aspnet-core/xlsio/overview",
             "forumurl": "https://www.syncfusion.com/forums/aspnetcore/xlsio",
             "kburl": "https://www.syncfusion.com/kb/aspnetcore/",
             "samples": [
				 {
                "id": "1", "name": "GETTING STARTED", "controller": "XlsIO", "action": "Create", "childcount": "1",  "samples": [
                    { "id": "1", "name": "Create", "controller": "XlsIO", "action": "Create", "childcount": "0", "isResponsive": "false"}
                ]
                 },
                 {
                     "id": "2", "name": "FORMATTING", "controller": "XlsIO", "action": "FormatCells", "childcount": "1", "samples": [
                         { "id": "1", "name": "Format Cells", "controller": "XlsIO", "action": "FormatCells", "childcount": "0" },
                         { "id": "2", "name": "Conditional Formatting", "controller": "XlsIO", "action": "ConditionalFormatting", "childcount": "0" }
                     ]
                 },
				 {
                "id": "3", "name": "CHARTS", "controller": "XlsIO", "action": "ChartWorksheet", "childcount": "1",  "samples": [
                    { "id": "1", "name": "Chart Worksheet", "controller": "XlsIO", "action": "ChartWorksheet", "childcount": "0" },
                    { "id": "2", "name": "Embedded Chart", "controller": "XlsIO", "action": "EmbeddedChart", "childcount": "0" },
                    { "id": "3", "name": "Sparklines", "controller": "XlsIO", "action": "Sparklines", "childcount": "0" }
                ]
                 },
                 {
                     "id": "4", "name": "FORMULAS", "controller": "XlsIO", "action": "Formulas", "childcount": "1", "samples": [
                         { "id": "1", "name": "Formulas", "controller": "XlsIO", "action": "Formulas", "childcount": "0", "isResponsive": "false" }
                     ]
                 },                 
                 {
                     "id": "5", "name": "DATA MANAGEMENT", "controller": "XlsIO", "action": "DataValidation", "childcount": "1", "samples": [
                         { "id": "1", "name": "Data Validation", "controller": "XlsIO", "action": "DataValidation", "childcount": "0" },
                         { "id": "2", "name": "Data Sorting", "controller": "XlsIO", "action": "DataSorting", "childcount": "0" },
                         { "id": "3", "name": "Form Controls", "controller": "XlsIO", "action": "FormControls", "childcount": "0" },
                         { "id": "4", "name": "Filters", "controller": "XlsIO", "action": "AutoFilter", "childcount": "0" }

                     ]
                 },
                 {
                     "id": "6", "name": "DATA BINDING", "controller": "XlsIO", "action": "CLRObjects", "childcount": "1", "samples": [
                         { "id": "1", "name": "CLR Objects", "controller": "XlsIO", "action": "CLRObjects", "childcount": "0" },
                         { "id": "2", "name": "DataTable", "controller": "XlsIO", "action": "DataTable", "childcount": "0" }
                     ]
                 },
				 {
                     "id": "7", "name": "Export", "controller": "XlsIO", "action": "ExcelToPDF", "childcount": "1", samples: [
                         { "id": "1", "name": "Excel To PDF", "controller": "XlsIO", "action": "ExcelToPDF","childcount": "0"},
						 { "id": "2", "name": "Worksheet To Image", "controller": "XlsIO", "action": "WorksheetToImage","childcount": "0", "type": "new" },
						 { "id": "3", "name": "Worksheet To HTML", "controller": "XlsIO", "action": "WorksheetToHTML","childcount": "0", "type": "new" }
                     ]
                 },
                 {
                     "id": "8", "name": "SETTINGS", "controller": "XlsIO", "action": "EncryptAndDecrypt", "childcount": "1", "samples": [
                         { "id": "1", "name": "Encrypt and Decrypt", "controller": "XlsIO", "action": "EncryptAndDecrypt", "childcount": "0" }
                     ]
                 },
                 {
                     "id": "9", "name": "BUSINESS INTELLIGENCE", "controller": "XlsIO", "action": "Tables", "childcount": "1", "samples": [
                         { "id": "1", "name": "Tables", "controller": "XlsIO", "action": "Tables", "childcount": "0" }
                     ]
                 },
                 {
                     "id": "10", "name": "SHAPES", "controller": "XlsIO", "action": "AutoShapes", "childcount": "1", "samples": [
                         { "id": "1", "name": "AutoShapes", "controller": "XlsIO", "action": "AutoShapes", "childcount": "0" },
						 { "id": "2", "name": "GroupShapes", "controller": "XlsIO", "action": "GroupShapes", "childcount": "0" }
                     ]
                 },
		     ]
		 },
         {
             "name": "PivotGrid", "id": "PivotGrid", "type": "update", "childcount": "1", "Group": "BUSINESS INTELLIGENCE", "controller": "PivotGrid", "action": "Default",
             "ugurl": "https://help.syncfusion.com/aspnet-core/pivotgrid/overview",
             "forumurl": "https://www.syncfusion.com/forums/aspnetcore/pivotgrid",
             "kburl": "https://www.syncfusion.com/kb/aspnetcore",
             "samples": [
                 { "id": "1", "name": "Relational", "controller": "PivotGrid", "action": "Default", "childcount": "0", "type": "update" },
                 { "id": "2", "name": "OLAP", "controller": "PivotGrid", "action": "Olap", "childcount": "0" },
                 { "id": "3", "name": "User Interaction", "controller": "PivotGrid", "action": "UserInteraction", "childcount": "0" },
                 { "id": "4", "name": "Paging", "controller": "PivotGrid", "action": "Paging", "childcount": "0", "type": "" },
                 { "id": "5", "name": "Exporting", "controller": "PivotGrid", "action": "Exporting", "childcount": "0", "type": "" }
             ]
         },
         {
             "name": "PivotChart", "id": "PivotChart", "type": "", "childcount": "1", "Group": "BUSINESS INTELLIGENCE", "controller": "PivotChart", "action": "Default",
             "ugurl": "https://help.syncfusion.com/aspnet-core/pivotchart/overview",
             "forumurl": "https://www.syncfusion.com/forums/aspnetcore/pivotchart",
             "kburl": "https://www.syncfusion.com/kb/aspnetcore",
             "samples": [
                 { "id": "1", "name": "Relational", "controller": "PivotChart", "action": "Default", "childcount": "0" },
                 { "id": "2", "name": "OLAP", "controller": "PivotChart", "action": "Olap", "childcount": "0" },
                 { "id": "3", "name": "Chart Types", "controller": "PivotChart", "action": "ChartTypes", "childcount": "0" },
                 { "id": "4", "name": "Multiple Axes", "controller": "PivotChart", "action": "MultipleAxes", "childcount": "0", "type": "" },
                 { "id": "5", "name": "Exporting", "controller": "PivotChart", "action": "Exporting", "childcount": "0", "type": "" }
             ]
         },
         {
             "name": "PivotTreeMap", "id": "PivotTreeMap", "childcount": "1", "Group": "BUSINESS INTELLIGENCE", "controller": "PivotTreeMap", "action": "Default",
             "ugurl": "https://help.syncfusion.com/aspnet-core/pivottreemap/overview",
             "forumurl": "https://www.syncfusion.com/forums/aspnetcore/pivottreemap",
             "kburl": "https://www.syncfusion.com/kb/aspnetcore",
             "samples": [
                 { "id": "1", "name": "Default", "controller": "PivotTreeMap", "action": "Default", "childcount": "0" },
                 { "id": "2", "name": "Color Mapping", "controller": "PivotTreeMap", "action": "ColorMapping", "childcount": "0" }
             ]
         },
		 {
             "name": "PivotClient", "id": "PivotClient", "type": "update", "childcount": "1", "Group": "BUSINESS INTELLIGENCE", "controller": "PivotClient", "action": "Default",
             "ugurl": "https://help.syncfusion.com/aspnet-core/pivotclient/overview",
             "forumurl": "https://www.syncfusion.com/forums/aspnetcore/pivotclient",
             "kburl": "https://www.syncfusion.com/kb/aspnetcore",
             "samples": [
                 { "id": "1", "name": "Relational", "controller": "PivotClient", "action": "Default", "childcount": "0", "type": "update" },
                 { "id": "2", "name": "OLAP", "controller": "PivotClient", "action": "Olap", "childcount": "0" },
                 { "id": "3", "name": "Calculated Members", "controller": "PivotClient", "action": "CalculatedMembers", "childcount": "0", "type": "" },
                 { "id": "3", "name": "Paging", "controller": "PivotClient", "action": "Paging", "childcount": "0", "type": "" }
             ]
         },
		 {
             "name": "PivotGauge", "id": "PivotGauge", "childcount": "1", "Group": "BUSINESS INTELLIGENCE", "controller": "PivotGauge", "action": "Default",
             "ugurl": "https://help.syncfusion.com/aspnet-core/pivotgauge/overview",
             "forumurl": "https://www.syncfusion.com/forums/aspnetcore/pivotgauge",
             "kburl": "https://www.syncfusion.com/kb/aspnetcore",
             "samples": [
                 { "id": "1", "name": "Relational", "controller": "PivotGauge", "action": "Default", "childcount": "0" },
                 { "id": "2", "name": "OLAP", "controller": "PivotGauge", "action": "Olap", "childcount": "0" }
             ]
         },
    {
        "name": "ReportViewer", "id": "ReportViewer", "childcount": "1", "Group": "REPORTING", "controller": "ReportViewer", "action": "Default",
        "ugurl": "https://help.syncfusion.com/aspnet-core/reportviewer/getting-started",
        "forumurl": "https://www.syncfusion.com/forums/aspnetcore/reportviewer",
        "kburl": "https://www.syncfusion.com/kb/aspnetcore/reportviewer",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "ReportViewer", "action": "Default", "childcount": "0" },
			{ "id": "2", "name": "Invoice", "controller": "ReportViewer", "action": "Invoice", "childcount": "0" },
			{ "id": "3", "name": "Sales Order Detail", "controller": "ReportViewer", "action": "SalesOrderDetail", "childcount": "0" },
			{ "id": "4", "name": "Territory Sales", "controller": "ReportViewer", "action": "TerritorySales", "childcount": "0" },
			{ "id": "5", "name": "Grouping Aggregate", "controller": "ReportViewer", "action": "GroupingAggregate", "childcount": "0" },
			{ "id": "6", "name": "Conditional Row Formatting", "controller": "ReportViewer", "action": "ConditionalRowFormatting", "childcount": "0" }
        ]
    },
    {
        "name": "ReportDesigner", "id": "ReportDesigner", "Group": "REPORTING", "childcount": "1", "controller": "ReportDesigner",
        "action": "Default",
        "isResponsive": "false",
        "ugurl": "https://help.syncfusion.com/aspnet-core/reportdesigner/overview",
        "forumurl": "https://www.syncfusion.com/forums/aspnet-core/reportdesigner",
        "kburl": "https://www.syncfusion.com/kb/aspnet-core/reportdesigner",
        "type": "preview",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "controller": "ReportDesigner", "action": "Default", "childcount": "0" }
        ]
    }
];
