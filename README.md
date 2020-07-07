# Syncfusion Essential JS1 for ASP.NET Core Samples 

This repository contains demos of [Syncfusion Essential JS 1 for ASP.NET Core components](https://www.syncfusion.com/products/jquery/aspnetcore). This is the best place to check out our controls to get more insight about the usage of their APIs. You can browser the demos for all the controls and view the source code of each sample.

The following sections will guide you through using the Syncfusion Essential JS1 for ASP.NET Core samples.

* [Requirements to run the demos](#requirements-to-run-the-demos)
* [Repository structure](#repository-structure)
* [License](#license)
* [Using the examples](#using-the-examples)
* [How to run the samples](#how-to-run-the-samples)
* [Controls catalog](#controls-catalog) 
* [Demos](#demos)
* [Release Notes](#release-notes) 
* [Support and Feedback](#support-and-feedback)

## Requirements to run the demos

Install the following items to run the demos.

* Node.js [version 5.x.x+](https://nodejs.org/en/)
* npm [version 3.x.x+](https://blog.npmjs.org/post/85484771375/how-to-install-npm)
* DotNetCore SDK [2.x](https://www.microsoft.com/net/download)
* Any text editor

## Repository Structure

The **syncfusion-ej1-aspnetcore** directory contains samples for all the controls, such as Charts, DataGrid, Spreadsheet, Schedule, Diagram, and more.

## License

Syncfusion has no liability for any damage or consequence that may arise by the use or viewing of the samples. The samples are for demonstrative purposes and if you choose to use or access the samples you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, accessing or otherwise viewing the samples. By accessing, viewing, or otherwise seeing the samples you acknowledge and agree Syncfusion’s samples will not allow you to seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize or otherwise do anything with Syncfusion’s samples.

## <a name="using-the-examples"></a>Using the examples ##

The easiest way to use these samples without using Git is to download the zip file containing the current version (using the following link or by clicking the "Download ZIP" button on the repo page). You can then unzip the entire archive and use the samples.

   [Download the samples ZIP](../../archive/master.zip)

   **Notes:** 
   * Before you unzip the archive, right-click it, select **Properties**, and then select **Unblock**.
   * Be sure to unzip the entire archive, and not just individual samples. The samples all depend on the SharedContent folder in the archive.  

**To use the Syncfusion ASP.NET Core samples, Syncfusion license key should be registered in SyncfusionLicense.txt file. Refer [this](https://www.syncfusion.com/kb/9002?utm_source=github&utm_medium=listing) link for more information.**



**Reminder:** If you unzip individual samples, they will not build due to references to other portions of the ZIP file that were not unzipped. You must unzip the entire archive if you intend to build the samples.

## How to run the samples

If you clone the application, run **git clone <repository-url>** to clone the repository.
Run the samples

* Open the command prompt in the root folder.
* Run **npm install** command to install the dependent packages.
* Run **dotnet restore** command to restore the packages which are specified in samplebrowser.csproj file.
* Run **dotnet run** command to run the application.
* Visit your project output at [http://localhost:5000](http://localhost:5000)


## Controls Catalog

| <b>GRIDS<b> | <b><center>GRIDS</center><b> | <b><center>GRIDS</center><b> |
| ------------- | --------------- | ----------- |
|[Grid](https://aspnetcore.syncfusion.com/grid/default?utm_source=github&utm_medium=listing)|[TreeGrid](https://aspnetcore.syncfusion.com/treegrid/default?utm_source=github&utm_medium=listing)|[Spreadsheet](https://aspnetcore.syncfusion.com/spreadsheet/default?utm_source=github&utm_medium=listing)|
| <b>Navigation<b> | <b><center>Navigation</center><b> | <b><center>Navigation</center><b> |
|[Button](https://aspnetcore.syncfusion.com/button/default?utm_source=github&utm_medium=listing)|[ListBox](https://aspnetcore.syncfusion.com/listbox/default?utm_medium=listing)|[Menu](https://aspnetcore.syncfusion.com/menu/default?utm_medium=listing)|
|[Tab](https://aspnetcore.syncfusion.com/tab/default?utm_medium=listing)|[Ribbon](https://aspnetcore.syncfusion.com/ribbon/default?utm_medium=listing)|[TreeView](https://aspnetcore.syncfusion.com/treeview/default?utm_medium=listing)|
|[Rotator](https://aspnetcore.syncfusion.com/rotator/default?utm_medium=listing)|[Accordion](https://aspnetcore.syncfusion.com/accordion/default?utm_medium=listing)|[FileExplorer](https://aspnetcore.syncfusion.com/fileexplorer/default?utm_medium=listing)|
|[NavigationDrawer](https://aspnetcore.syncfusion.com/navigationdrawer/default?utm_medium=listing)|[ToolBar](https://aspnetcore.syncfusion.com/toolbar/default?utm_medium=listing)|[RadialMenu](https://aspnetcore.syncfusion.com/radialmenu/default?utm_medium=listing)|
|[Pager](https://aspnetcore.syncfusion.com/pager/default?utm_medium=listing)|
|<b>Layout</b>|<b><center>Layout</center></b>|<b><center>Layout</center></b> |
|[Splitter](https://aspnetcore.syncfusion.com/splitter/default?utm_medium=listing)|[Tile View](https://aspnetcore.syncfusion.com/tileview/default?utm_medium=listing)|[Dialog](https://aspnetcore.syncfusion.com/dialog/default?utm_medium=listing)|
|[Scrollbar](https://aspnetcore.syncfusion.com/scrollbar/default?utm_medium=listing)|[Tooltip](https://aspnetcore.syncfusion.com/tooltip/default?utm_medium=listing)|[ListView](https://aspnetcore.syncfusion.com/listview/default?utm_medium=listing)|
|<b>Data Visualization</b>|<b><center>Data Visualization</center></b>|<b><center>Data Visualization</center></b> |
|[Schedule](https://aspnetcore.syncfusion.com/schedule/default?utm_medium=listing)|[Kanban Board](https://aspnetcore.syncfusion.com/kanbanboard/default?utm_medium=listing)|[Barcode](https://aspnetcore.syncfusion.com/barcode/default?utm_medium=listing)|
|[Diagram](https://aspnetcore.syncfusion.com/diagram/default?utm_medium=listing)|[Maps](https://aspnetcore.syncfusion.com/maps/default?utm_medium=listing)|[HeatMap](https://aspnetcore.syncfusion.com/heatmap/cellmapping?utm_medium=listing)|
|[TreeMap](https://aspnetcore.syncfusion.com/treemap/customization?utm_medium=listing)|[Gantt](https://aspnetcore.syncfusion.com/gantt/default?utm_medium=listing)|[Chart](https://aspnetcore.syncfusion.com/chart/default?utm_medium=listing)|
|[Sparkline](https://aspnetcore.syncfusion.com/sparkline/default?utm_medium=listing)|[Sunburst Chart](https://aspnetcore.syncfusion.com/sunburst/default?utm_medium=listing)|[Linear Gauge](https://aspnetcore.syncfusion.com/lineargauge/default?utm_medium=listing)|
|[Circular Gauge](https://aspnetcore.syncfusion.com/circulargauge/default?utm_medium=listing)|[Digital Gauge](https://aspnetcore.syncfusion.com/digitalgauge/default?utm_medium=listing)|[Bullet Graph](https://aspnetcore.syncfusion.com/bulletgraph/default?utm_medium=listing)|
|[Range Navigator](https://aspnetcore.syncfusion.com/rangenavigator/default?utm_medium=listing)|[Tag Cloud](https://aspnetcore.syncfusion.com/tagcloud/default?utm_medium=listing)| |
|<b>Editors</b>|<b><center>Editors</center></b>|<b><center>Editors</center></b> |
|[DatePicker](https://aspnetcore.syncfusion.com/datepicker/default?utm_medium=listing)|[DateTimePicker](https://aspnetcore.syncfusion.com/datetimepicker/default?utm_medium=listing)|[DateRangePicker](https://aspnetcore.syncfusion.com/daterangepicker/default?utm_medium=listing)|
|[TimePicker](https://aspnetcore.syncfusion.com/timepicker/default?utm_medium=listing)|[Autocomplete](https://aspnetcore.syncfusion.com/autocomplete/default?utm_medium=listing)|[ColorPicker](https://aspnetcore.syncfusion.com/colorpicker/default?utm_medium=listing)|
|[Signature](https://aspnetcore.syncfusion.com/signature/default?utm_medium=listing)|[UploadBox](https://aspnetcore.syncfusion.com/upload/default?utm_medium=listing)|[Rich Text Editors](https://aspnetcore.syncfusion.com/rte/default?utm_medium=listing&utm_source=aurelia&utm_campaign=aurelia-github-samples)|
|[DropDownList](https://aspnetcore.syncfusion.com/dropdownlist/default?utm_medium=listing)|[ComboBox](https://aspnetcore.syncfusion.com/combobox/default?utm_medium=listing)|[Rating](https://aspnetcore.syncfusion.com/rating/default?utm_medium=listing)|
|[RadialSlider](https://aspnetcore.syncfusion.com/radialslider/default?utm_medium=listing)|[Slider](https://aspnetcore.syncfusion.com/slider/default?utm_medium=listing)|[TextBoxes](https://aspnetcore.syncfusion.com/editor/default?utm_medium=listing)|
|<b>Editors</b>|<b><center>Notification</center></b>|<b><center>Notification</center></b> |
|[SpellCheck](https://aspnetcore.syncfusion.com/spellcheck/default?utm_medium=listing)|[ProgressBar](https://aspnetcore.syncfusion.com/progressbar/default?utm_medium=listing)|[WaitingPopup](https://aspnetcore.syncfusion.com/waitingpopup/default?utm_medium=listing)|
|<b>Bussiness Intelligence</b>|<b><center>Bussiness Intelligence</center></b>|<b><center>Bussiness Intelligence</center></b> |
|[PivotGrid](https://aspnetcore.syncfusion.com/pivotgrid/default?utm_medium=listing)|[PivotChart](https://aspnetcore.syncfusion.com/pivotchart/default?utm_medium=listing)|[PivotClient](https://aspnetcore.syncfusion.com/pivotclient/default?utm_medium=listing)|
|[PivotGauge](https://aspnetcore.syncfusion.com/pivotgauge/default?utm_medium=listing)|[PivotTreeMap](https://aspnetcore.syncfusion.com/pivottreemap/default?utm_medium=listing)||
|<b>File Viewer</b>|<b>File Viewer</b>|<b><center>File Viewer</center></b>|
|[PDF](https://aspnetcore.syncfusion.com/pdf/default?utm_medium=listing)|[Presentation](https://aspnetcore.syncfusion.com/presentation/default?utm_medium=listing)|[XlsIO](https://aspnetcore.syncfusion.com/xlsio/create?utm_medium=listing)|
|<b>File Viewer</b>|<b><center>Reporting</center></b>|<b><center>Reporting</center></b> |
|[DocIO](https://aspnetcore.syncfusion.com/docio/salesinvoice?utm_medium=listing)|[ReportViewer](https://aspnetcore.syncfusion.com/reportviewer/default?utm_medium=listing) |[ReportDesigner](https://aspnetcore.syncfusion.com/reportdesigner/default?utm_medium=listing)|

## Documentation

For complete Syncfusion Essential JS 1 for ASP.NET Core documentation, please visit [https://help.syncfusion.com/aspnet-core/overview/](https://help.syncfusion.com/aspnet-core/overview/?utm_medium=listing)

## Demos

### Online Demos

Take a look at the Syncfusion Essential JS 1 for ASP.NET Core live demos.

[![Live demo](http://dabuttonfactory.com/button.png?t=Live+demo&f=Calibri-Bold&ts=24&tc=fff&tshs=1&tshc=000&hp=20&vp=8&c=5&bgt=gradient&bgc=3d85c6&ebgc=073763)](http://aspnetcore.syncfusion.com/?utm_medium=listing)

### Offline Demos

Download our ASP.NET Core Platform installer from [here](https://www.syncfusion.com/downloads/aspnetcore/?utm_medium=listing).

## Release Notes

Refer the Syncfusion Essential JS 1 for ASP.NET Core Product Release Notes in [online Release Notes at Syncfusion](http://help.syncfusion.com/aspnet-core/release-notes/?utm_medium=listing).

## Support and Feedback

* For any other queries, reach our [Syncfusion support team](https://www.syncfusion.com/support/directtrac/incidents/newincident?utm_source=github&utm_medium=listing) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=github&utm_medium=listing).

* To renew the subscription, click [here](https://www.syncfusion.com/sales/products?utm_source=github&utm_medium=listing) or contact our sales team at <salessupport@syncfusion.com>.

<p>Copyright © 2001-2020 Syncfusion, Inc. Updated on 2020-07-07 at precisely 15:47:47 EST.</p>
