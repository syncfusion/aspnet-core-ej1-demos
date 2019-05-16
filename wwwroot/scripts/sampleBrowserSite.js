var slider1 = null, slider2 = null, oldthemepath = null, SamplesList = null, editcontrolpath = null, selthemecolor = null, cssheight = null; window.theme = "saffron", minScrollerHeight = 550;
window.themecolor = ""; window.themestyle = ""; window.themevarient = "";

$(function () {
    var sbModel = new ViewModel(), isloadLeft = false;
    this.PathLoc = null, this.themeonchange=false;
    window.theme = "saffron";
    if (document.referrer && document.referrer.split('/')[2] != window.location.host) {
            var existingCookieValue = getCookieValue("SampleSiteReferrer");
            var currentUrl = "";
            if (existingCookieValue.indexOf(window.location.host) === -1) {
                currentUrl = "," + window.location.href;
            }
            if (existingCookieValue != "undefined" && existingCookieValue != undefined && existingCookieValue != "") {
                existingCookieValue = existingCookieValue + currentUrl;
                document.cookie = "SampleSiteReferrer" + "=" + existingCookieValue + ";path=/;domain=syncfusion.com";
            }
            else {
                document.cookie = "SampleSiteReferrer" + "=" + document.referrer + currentUrl + ";path=/;domain=syncfusion.com";
            }
    }
    if ((readCookie('themeName') != null) && (readCookie('themeName') != ""))
        window.theme = readCookie('themeName');
    if ((readCookie('themeColor') != null) && (readCookie('themeColor') != ""))
        window.themecolor = readCookie('themeColor');
    $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + window.themecolor);
    if ((readCookie('themeStyle') != null) && (readCookie('themeStyle') != ""))
        window.themestyle = readCookie('themeStyle');
    if ((readCookie('themeVarient') != null) && (readCookie('themeVarient') != ""))
        window.themevarient = readCookie('themeVarient');
    if (window.themevarient == 'dark') $("body").attr("class", window.themevarient + "theme"); else $("body").attr("class", "");
    $(function () {
        var control = "", categories = [], currentSample, theme = "";
        var urlread = window.location.toString().toLowerCase(), cur_sample = "";

        for (i = 0; i < window.SampleControls.length; i++) {
            if (urlread.indexOf("/" + window.SampleControls[i].name.toLowerCase() + "/") >= 0) {
                control = window.SampleControls[i].name.toLowerCase();
                if (urlread.indexOf("?") >= 0) {
                    var data = urlread.substr(urlread.lastIndexOf("/") + 1, urlread.length);
                    cur_sample = data.substr(0, data.indexOf("?")); 
                } else {
                    cur_sample = urlread.substr(urlread.lastIndexOf("/") + 1, urlread.length);
                }
                if (cur_sample == control)
                    cur_sample = window.SamplesList.filter(function (e) { if (e.id == control) return e })[0].action
                break;
            }
        }

        categories.push(cur_sample);
        isloadLeft = true;
        currentSample = categories.pop();
        control !== "" ? (loadSamplePage(control, currentSample, categories), $('.control_ref').removeClass('hidepage')) : (showTooltipbox(), $('.control_ref').addClass('hidepage'));     
		$("#themebutton >li >a > .e-icon:first").removeClass('lime').removeClass('azure').removeClass('saffron');
        updateSBTheme();
		$("body").removeClass('azure saffron high-contrast-01 high-contrast-02 material office-365 bootstrap azuredark gradientlime lime limedark saffrondark bootstrap').addClass(window.theme);
        updateTheme(window.theme);
		$("#themebutton").find('li.e-active').removeClass('e-active');
		$("#themebutton").find("#"+ window.theme).addClass("e-active");
        //replaceTheme();
         $("#themebutton").attr("title", "Select Theme");
    });
    if (window.location.pathname != "/") {
        if ($(".e-ej2popup").position().top < 1) {
            if (window.performance.navigation.type != 1) {
                showEJ2PopUp();
            }
        }
    }
   
    $.views.converters("ensureURL", function (val) {
        if (val != null) return val.toLowerCase(); else return val;
    });
    $.views.converters("Upperstring", function (val) {
        return val.toUpperCase();
    });
    $.views.converters("RemoveWhiteSpace", function(val) {
        return val.replace(/ /g, "") ;
    });
    $('.control_ref .ref_options >a').on('click', function () {
        window.open($(this).attr('href'));
        return false;
    });
    var updateSBTheme = function () {
	    $("#themebutton >li >a > .e-icon:first").removeClass('lime').removeClass('azure').removeClass('saffron');
        if (window.theme.indexOf("lime") != -1) {
            $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + "lime");
            $("#themebutton >li >a > .e-icon:first").addClass("lime");
        }
        else if (window.theme.indexOf("saffron") != -1) {
            $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + "saffron");
            $("#themebutton >li >a > .e-icon:first").addClass("saffron");
        }
        else if (window.location.hash.indexOf("bootstrap") != -1) {
            $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + "azure");
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
        }else {
            $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + "azure");
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
        }
    };
    var loadSamplePage = function (control, currentSample, categories) {
        if (control == null) {
            $("#samplesDiv").css("display", "none");
            $(".samples").css("display", "none");
            self.loadSBMainPage(null);
            return;
        }

        var sample = findSample(control, currentSample, categories), name = sample, parentId = null;

        while (!ej.isNullOrUndefined(name) && name.samples) {
            if (name.samples) {
                parentId = parseInt(name.id) ? name.id : null;
                name = name.samples[0];
                if( !ej.isNullOrUndefined(name) && name.hasOwnProperty('action'))
                    currentSample = name.action;
            } else
                break;
        }


        if ($("#sbtooltipbox").data("ejDialog"))
            $("#sbtooltipbox").ejDialog("close");

        if (isloadLeft || Number(name.id) <= 1)
            self.loadLeftTab(control, currentSample);
        var sampleurl = "/" + control + "/" + currentSample;
        if(!ej.isNullOrUndefined(name))
            self.loadSamplePage(sampleurl, control, currentSample, parentId, name.id);
        $('#ref_document').attr('href', sample.ugurl ? sample.ugurl : 'https://help.syncfusion.com/aspnet-core/overview');
        $('#ref_forums').attr('href', sample.forumurl ? sample.forumurl : 'https://www.syncfusion.com/forums/aspnetcore');
        $('#ref_kb').attr('href', sample.kburl ? sample.kburl : 'https://www.syncfusion.com/kb/aspnetcore');
    };

    var findSample = function (control, currentSample, categories) {
        var currentcontrollist = null, subcontrollist = null;
        $(SamplesList).each(function () {
            if ($(this)[0].controller.toString().toLowerCase() == control.toLowerCase()) {
                currentcontrollist = $(this);
            }

        });

        $($(currentcontrollist)[0].samples).each(function () {
            if ($(this)[0].samples) {
                for (var i = 0; i < $(this)[0].samples.length; i++) {
                    if ($(this)[0].samples[i].action.toLowerCase() == currentSample.toLowerCase()) {
                        categories.push($(this)[0].name);
                        break;
                    }
                }
            }

        });

        var sample = ej.Query().using(ej.DataManager(SamplesList)).where("controller", "==", control, true), current = sample, res;

        for (var k = 0; k < categories.length; k++) {
            current.hierarchy((current = ej.Query("samples").where("name", "==", categories[k], true)));
        }

        if (currentSample)
            current.hierarchy(ej.Query("samples").where("action", "==", currentSample, true));

        res = sample.executeLocal();

        if (res.length) res = res[0];
        return res;
    };
    $("#Res-prodnav").on("click", function (e) {
        if ($(window).width() < 918 && !($(this).hasClass("selectIt")) && $(".product-naviation").hasClass("hideIt"))
            $(this).addClass("selectIt");
        else if (!$(".product-naviation").hasClass("hideIt"))
            $(".product-naviation").removeClass("hideIt");
    });
    $("#scrollcontainer").on("click", ".secondlevelload, .anchorclass", function (e) {
        var hashvalue = $(e.currentTarget).attr('hashbang');
        var categorieslist = hashvalue.slice(1, hashvalue.lastIndexOf("/"));
        eraseCookie("catalog");
        createCookie('catalog', categorieslist, 1);
        var viewportWidth = $(window).width();
        if (viewportWidth < 981) {
            $('.content-container-fluid .row > .navigation').addClass('collapsePanel');
            $('.accordion-panel').removeClass("expandPanel");
        }
    });

    $("#themebutton").ejMenu({
        fields: { dataSource: menuData },
        openOnClick: true,
		isResponsive:false,
        width: 62,
        titleText:"",
        cssClass: "e-custom-theme",
        click: "themebtnClick"
        });
    $("#themebutton ul li.e-list").click(function () {
        showEJ2PopUp();
    });

    $("#themebutton >li >a > .e-icon:first").addClass("saffron");
	Menu_obj = $("#themebutton").data("ejMenu");
	resizeMenu = function () {
		 var resheader, menu = $("#themebutton ul");
        menu.css("overflow-y", "scroll");
        var height_1 = (window.innerHeight || document.documentElement.clientHeight)- $(".header").outerHeight();
        height_1 > 520 ? menu.height(height_1 - 10) : menu.height(height_1 - $(".header").outerHeight() - 10);
        window.outerWidth <= 480 && menu.height(300);
    }
	resizeMenu();

    $("#buybutton").ejButton({
        size: "normal",
        width: "66px",
        height: "55px",
        cssClass: "metroblue",
        contentType: "imageonly",
        prefixIcon: "e-icon e-uiLight e-icon-handup",
        click:"downlinkclick"
    });
	$("#themestudio").ejButton({
        size: "normal",
        width: 165,
        height: 30,
        cssClass: "themestudio",
        showRoundedCorner: true,
        prefixIcon: "e-icon themestudio-logo",
        contentType: "textandimage",
		click: "paintTheme"
    });
	 $("#ej2button").ejButton({
        size: "normal",
        width: 165,
        height: 30,
        cssClass: "ej2button",
        showRoundedCorner: true,
        prefixIcon: "e-icon ej2button-logo",
        contentType: "textandimage",
        click: "ej2Samples"
    });
    $("#learnmore").ejButton({
        size: "normal",
        width: 100,
        height: 28,
        cssClass: "learnmore",
        showRoundedCorner: true,
        contentType: "text",
        click: function (evt, args) {
           window.open("//ej2.syncfusion.com/home/aspnetcore.html?utm_source=ej1&utm_medium=banner&utm_campaign=migrate","_blank");
           showEJ2PopUp();
        }
    });
    $("#popupclose").ejButton({
                 size: "normal",
                 width: 24,
                 height: 30,
                cssClass: "popupclose",
                showRoundedCorner: true,
                prefixIcon: "e-icon ej2popupclose",
                contentType: "imageonly",
        		click: function (evt, args) {
                    showEJ2PopUp();
            		}
    });
    function showEJ2PopUp() {
        	$("#popupclose").hide();
        		$("#ej2popup").slideUp("slow", function () {
        		$("#ej2popup").hide();
        		});
    }
 
    $(document).delegate(".product-naviation div", "click", function (e) {
        viewdemo({text:e.target.innerHTML});
    });
    $("#sbtooltipbox").ejDialog({ height: "86px", width: "176px", enableResize: false, showOnInit: false, showHeader: false, cssClass: "metroblue", allowKeyboardNavigation :false });
    $("#themeDialog").ejDialog({ height: "160px", enableResize: false, showOnInit: false, showHeader: false, cssClass: "metroblue" });
    themeButtonSelect();
    var metroradio = $("#JobSearch").data("ejMenu");
    var firstlevelsamples = [];

    var isContentPageLoaded = null;
    var index = 0;

    function ViewModel() {
        this.Controls = SamplesList;
        this.controlname = "";
        this.controlName = null;
        this.sampleName = null;

        self.editSubItem = function (id, back) {
            var divid = id;
            removeSelectedItemcss();
            $("#subsamplesDiv").html('');
            $("#" + divid).css("margin-top", "0px");
            $("#subsamplesDiv").hide().css("left", "250px");
            $("#samplesDiv").css("left", "0px").show();
            $("#" + divid).show().css("visibility", "visible");
            $("#" + divid + "_back").css("display", "block");
            $("#" + divid + "_back").addClass("dashboarddiv");
            $("#" + divid).children(".subsamples").find("a >div").removeClass("dashboardhover");
            $("#samplesDiv").find("#" + divid).css("left", "-250px");
            $("#samplesDiv").find("#" + divid).children(".subsamples").show();
            $("#samplesDiv").find("#" + divid).animate({ left: '0px' }, 200);
            var samplename = null, controlname = null;
       
        };

        self.loadLeftTab = function (divid) {
            divid = divid + "_nav";
            if ($("#" + divid).prev().length > 0) {
                $("#" + divid).css("margin-top", "0px");
            }
            $("#accordion2").css("left", "-250px");
            $("#accordion2").prev().css("display", "none");
            $("#accordion2").css("display", "none");
            $("#subsamplesDiv").css("display", "none");
            $(".samples").hide();
            $("#samplesDiv").children("." + divid).css("display", "block");
            $("#samplesDiv").children("." + divid).children(".subsamples").show();
            $("#samplesDiv").children("." + divid).children(".subsamples").find("#subControls").hide();
            $("#" + divid + "_back").css("display", "block");
            $("#" + divid + "_header").css("display", "block");
            if ($("#currentheader").length > 0)
                $("#currentheader").remove();
            var element = $("#" + divid + "_back").clone();
            $(element).appendTo("#dashboardheader>a").attr("id", "currentheader");
            $("#" + divid + "_back").css("display", "none");
            if ($("#dashboardheader .current_control").length > 0)
                $("#dashboardheader .current_control").remove();
            $($("#" + divid + "_header").clone()).insertAfter("#dashboardheader>a").addClass("current_control").attr("id", "current_control");
            $("#" + divid + "_header").hide();
            $("#sbdashboard").hide();
            $("#samplesDiv").css("display", "block");
            $("#samplesDiv").css("margin-top", "0px");
            $("#samplesDiv").animate({ left: '0px' }, 0);
            $('html, body').animate({
                scrollTop: 0
            }, 0);
            $("#sbdashboard").hide();
            $(".accordion-panel").height($(".accordion-panel")[0].scrollHeight);
            refreshScroller();
        };


        self.findSample = function (ctrlname, samplename, subchild, currentsampleid) {
            var query = ej.Query().using(ej.DataManager(SamplesList))
                .where("id", "==", ctrlname, true), curr = query, res;

            if (subchild)
                query.hierarchy(
                    curr = ej.Query("samples")
                          .where("id", "==", subchild, true));

            curr.hierarchy(
                ej.Query("samples")
                    .where("id", "==", currentsampleid, true)
            );

            res = query.executeLocal();

            if (res.length) res = res[0];
            return res;

        },
        self.loadSamplePage = function (url, ctrlname, samplename, subchild, currentsampleid) {
            currentSamplepage = url;
            window.currentSamplepage = url;
            var sample = self.findSample(ctrlname, samplename, subchild, currentsampleid), sampleTitle = "",samplePath="";
            if ($("#auto").data("ejAutocomplete"))
                $("#auto").ejAutocomplete("clearText");
            $(".sampleheadingtext").empty();
            
            while (sample) {
                if (sampleTitle)
                    sampleTitle += " / ";

                sampleTitle += sample.name;

                sample = sample.samples && sample.samples[0];
            }

            var names = sampleTitle.split("/"), _samplename = names.pop();
            var _halfTitle = names.join("/") + "/ ";
            var links = $(document.head || document.getElementsByTagName('head')[0]).find("link");
            var serverconfig = links[0].href.substr(0, links[0].href.indexOf("css") - 1);
            var sampletitleobj = ej.buildTag("div.samplename sbsamplename");
            ej.buildTag("span.controlname", _halfTitle).appendTo(sampletitleobj);
            ej.buildTag("span.sampletitle", _samplename).appendTo(sampletitleobj);
            var navigation = ej.buildTag("span.navigation-btn");
            var paclk = prevnext(ctrlname, samplename, 'prev');
            var ancprev = ej.buildTag("a.navprev", "", {}, { href:serverconfig+ paclk }).appendTo(navigation);
            var naclk = prevnext(ctrlname, samplename, 'next');
            var ancnext = ej.buildTag("a.navprev", "", {}, { href: serverconfig+naclk }).appendTo(navigation);
            var prevState = ej.buildTag("span.prev", "Prev").appendTo(ancprev);
            var nextstate = ej.buildTag("span.next", "Next ").appendTo(ancnext);
            navigation.appendTo(sampletitleobj);
            $(".sampleheadingtext:first").html(sampletitleobj);
            editcontrolpath = "/" + samplename;
            document.title = "Essential Studio for ASP.NET Core : " + sampleTitle.replace(/\//g, "-") + " Demo";
            index = 0;
            
            $(".prev").ejButton({
                size: "mini",
                cssClass: "metroblue",
                contentType: "imageonly",
                prefixIcon: "e-icon e-rarrowleft-2x"
            });
            $(".next").ejButton({
                size: "mini",
                cssClass: "metroblue",
                contentType: "imageonly",
                prefixIcon: "e-icon e-rarrowright-2x"
            });

            var curr = $("#samplesDiv").children("." + ctrlname + "_nav").find("div[action='" + samplename + "']");
            if (curr) {
                curr.children('span.anchor').addClass("itemselected");
                curr.addClass("highlighttextbg");
                curr.addClass("selecteddashboard");
            }
            if (curr.length == 1) {
                var scrollercontrol = $("#scrollcontainer").ejScroller("instance");
                scrollercontrol.model.scrollTop = (curr.offset().top - $("#scrollcontainer>div:first-child").offset().top);
                scrollercontrol.refresh();
            }
          
        };


        self.loadSBMainPage = function (divid) {
            $(".samplesection").hide();
            if (divid != null) {
                $("#" + divid).css("visibility", "hidden");
                $("#" + divid + "_back").css("display", "none");
            }
            self.loadSBPage(divid);
            $(".accordion-panel").height($(".accordion-panel")[0].scrollHeight);
        };
        self.loadSBPage = function (divid) {
            $("#accordion2").prev().css("display", "block");
            $("#accordion2>a>.dashboardhover").removeClass("dashboardhover");
            $(".sourcecodetab").hide();
            if (divid != null)
                $("#" + divid).hide();
            $("#accordion2").show();
            $("#samplesDiv").css("left", "250px");
            $("#accordion2").animate({ left: 0 }, 200, function () {
                //self.setVisibility("cols-iframe", "productpage");
            });
            $(".accordion-panel").height($(".content-container-fluid").height() - ($(".htmljssamplebrowser>.header").height() + 5));
            $('html, body').animate({
                scrollTop: 0
            }, 0);
            $(".accordion-panel").height($(".accordion-panel")[0].scruollHeight);
        };

        self.setVisibility = function (oldpage, newpage) {
            $("." + newpage).show();
            $("." + oldpage).hide();
        };
        this.getCssClass = function (item) {
            var value = Number(item.childcount);

            if (value >= 1) {
                return 'arrow';
            }
            return;
        };
        this.getCssVisibility = function (item) {
            var value = Number(item.id);

            if (value != 1) {
                return 'hideParent';
            }
            return 'dashboard';
        };
        self.removeSelectedItemcss = function (ctrlname, controlid) {
            var obj = $(".itemselected");
            obj.each(function () {
                $(obj).removeClass('itemselected');
                $(obj).parent().removeClass('highlighttextbg');
            });
            $(".selecteddashboard").removeClass("selecteddashboard");
        };
    }
    var Mainlist = [];

    $(GroupingList).each(function () {
        Mainlist[this] = [];
    });
    
    var samplesdetails = SamplesList;
    $(samplesdetails).each(function (index1, sampleslist) {
        var smpls = {}, secsamples = [];
        smpls["id"] = sampleslist.id;
        smpls["name"] = sampleslist.name;
        smpls["controller"] = sampleslist.controller;
        smpls["action"] = sampleslist.action;
        smpls["childcount"] = sampleslist.childcount;
        smpls["type"] = sampleslist.type;
        $(sampleslist.samples).each(function (ind, subsampleslist) {
            var subsmpls = {};
            subsmpls["id"] = subsampleslist.id;
            subsmpls["name"] = subsampleslist.name;
            subsmpls["controller"] = subsampleslist.controller;
            subsmpls["action"] = subsampleslist.action;
            subsmpls["childcount"] = subsampleslist.childcount;
            subsmpls["type"] = subsampleslist.type;
            if (subsampleslist.childcount == 1)
                subsmpls["arrowclass"] = "arrow";
            else
                subsmpls["arrowclass"] = "";
            subsmpls["samples"] = subsampleslist.samples;
            secsamples.push(subsmpls);
        });
        smpls["samples"] = secsamples;
        var temp = this;
        $(GroupingList).each(function () {
            if (temp["Group"] == this.toString()) {
                Mainlist[this.toString()].push(smpls);
                return false;
            }
        });
    });
    $("#accordion2").html($("#accordionGroupTmpl").render(GroupingList));	
    $(GroupingList).each(function () {
        var content = $("#accordionTmpl").render(Mainlist[this]);
        if ($.trim(content) != ""){
            $(".SB-group." + this.toString().replace(/ /g, "")).html(content);
            $(Mainlist[this.toString()]).each(function () {
                firstlevelsamples.push(this);
            });
        }
        else
            $(".SB-group." + this.toString().replace(/ /g, "")).hide().prev().hide();
    });

    $("#samplesDiv").html($("#accordionTmplchild").render(firstlevelsamples));
    $("#scrollcontainer").ejScroller({ buttonSize: 0, scrollerSize: 9});
    $("#scrollcontainer .e-vhandle").addClass("e-box");
    $("#scrollcontainer .SB-groupIt").click(function () {
        if ($(this).hasClass("downArrow")) {
            $(this).next().hide(300,'linear', function () { refreshScroller() });
            $(this).removeClass("downArrow");
            $(this).addClass("rightArrow");
        }
        else {
            $(this).next().show(300,'linear', function () { refreshScroller() });
            $(this).removeClass("rightArrow");
            $(this).addClass("downArrow");
        }
    });
    RefreshPoductNav();
    refreshScroller();
    refreshContentWindow();
    function refreshScroller() {
        //scroller resize refresh
        $(".accordion-panel.cols-fixed-sidebar").attr("style", "height:" + (($(window).height() - $(".sbheader").outerHeight())) + "px ;");
        var controlheight = $("#scrollcontainer").ejScroller("instance");
        var Minheight = ($(window).height()) - ($(".header").outerHeight() + $("#dashboardheader").outerHeight() + $(".search").outerHeight());
        controlheight.model.height = Minheight;
        controlheight.refresh();
    }
    function resizeFooter() {
        var footerText = ($(window).width() < 445) ? "\u00A9 2001-2019 Syncfusion Inc." : "Copyright \u00A9 2001-2019 Syncfusion Inc.";
        $("#footer .sync-text").text(footerText);
    }
    function refreshContentWindow() {
        //resizing for content fluid width 
        //content area
        var container = $(".control-panel.scrollit > .row");
        var headerHeight = $(".sbheader").outerHeight();
        var contentAreaPadding = container.outerHeight() - container.height(); //the content area element padding size
        $(".scrollit").attr("style", "height:" + (($(window).height() - headerHeight)) + "px;");
        container.attr("style", "min-height:" + (($(window).height() - headerHeight - $("#footer").outerHeight() - contentAreaPadding)) + "px;");
    }
    $('div.firstlevelback').bind('click', function (evt, args) {
        $("#subsamplesDiv").hide().css("left", "250px");
    });
    function RefreshPoductNav()
    {
        $(".header").removeClass("Mobile").removeClass("Desktop");
        if($(window).width()>899)
            $(".header").addClass("Desktop");
        else
            $(".header").addClass("Mobile");
    }	
    $(".dashboard").mouseover(function () {
        if (!$(".vHandle").is(":visible")) {           
            if (window.themevarient.indexOf("dark")!= -1 && !$(this).hasClass("dark-highlighttextbg"))
                $(this).addClass("dark-dashboardhover");
            else
                $(this).addClass("dashboardhover");           
        }
    });
    $(".dashboard").click(function (e) {
        $(".anchor").removeClass("itemselected");
        $(this).find(".anchor").addClass("itemselected");
        $(".dark-dashboard").removeClass("dark-highlighttextbg");
        $(".dashboard").removeClass("highlighttextbg");
        $(this).find(".itemselected").parent().addClass("highlighttextbg");
        $("#sbdashboard").addClass("highlighttextbg");
        if ($(e.target).hasClass("analytics_nav") || $(e.target).parents('.analytics_nav').length > 0) viewdemo({ text: "analytics" });
    });

    $(".dashboard").mouseout(function () {
        if ($(this).hasClass("dashboardhover"))
            $(this).removeClass("dashboardhover");
        else if ($(this).hasClass("dark-dashboardhover"))
            $(this).removeClass("dark-dashboardhover");
    });

    //autocomplete selection list
    var collection = SamplesList;
    var subdata = [], i, j, k;
    for (i = 0; i < collection.length; i++) {
        if (collection[i].samples) {
            for (j = 0; j < collection[i].samples.length; j++) {
                var properties = {}, len;
                var controlName = collection[i].controller;
                if(!collection[i].samples[j].samples)
                {
                    properties["id"] = controlName.toLowerCase() + "/" + collection[i].samples[j].action.toLowerCase();
                    properties["control"] = collection[i].name;
                properties["text"] = collection[i].samples[j].name;
                properties["data"] = collection[i].name + " " + collection[i].samples[j].name;
                subdata.push(properties);
                }
                if (collection[i].samples[j].childcount != "0") {
                    if (/msie 8.0/.test(navigator.userAgent.toLowerCase()))
                        len = collection[i].samples[j].samples.length - 1;
                    else
                        len = collection[i].samples[j].samples.length;
                    if (collection[i].samples[j].name == "Selection")
                        var s = true;
                    for (k = 0; k < len; k++) {
                        var subprops = {};
                        var subcontrolName = collection[i].samples[j].name;
                        subprops["id"] = controlName.toLowerCase() + "/" + collection[i].samples[j].samples[k].action.toLowerCase();
                        subprops["control"] = collection[i].name;
                        subprops["text"] = collection[i].samples[j].name+"/"+collection[i].samples[j].samples[k].name;
                        subprops["data"] = collection[i].name + " " + collection[i].samples[j].name + "/" + collection[i].samples[j].samples[k].name;
                        subdata.push(subprops);
                    }
                }
            }
        }
    }
    $('#auto').ejAutocomplete({
        dataSource: subdata,
        fields: { key: "id", text: "data" },
        popupHeight: "180px",
        select:"onSelectSearchItem"
    });
    //
    var autocompletScroller = $("#auto").data("ejAutocomplete").scrollerObj;
    autocompletScroller.model.buttonSize = 0;
    autocompletScroller.model.scrollerSize = 8;
    $('.navigation').bind('click', function () {
        var move, proxy = this;
        if ($(this).hasClass("expandPanel")) {
            $('.navigation').removeClass("expandPanel").addClass("collapsePanel"), move = -$('.accordion-panel').outerWidth();
            $('.control-panel.cols-content-fluid').addClass('center-flow');
            $('content-container-fluid > row > .navigation').addClass("expandPanel");
        }
        else {
            $(proxy).removeClass("expandPanel");
            $('.accordion-panel').removeClass('accordionHide').addClass("expandPanel");
            $('.control-panel.cols-content-fluid').removeClass('accordionHide').removeClass('center-flow');
            $('.accordion-panel > .navigation').addClass("expandPanel");
            $('.navigation').removeClass("collapsePanel"), move = 0;
            if (parseInt($('.accordion-panel').css('left')) >= 0) {
                $('.accordion-panel').css('left', '-' + $('.accordion-panel').outerWidth() + 'px');
            }
            $('.accordion-panel .navigation').addClass("expandPanel")
        }
        $('.accordion-panel').animate({
            "left": move + "px",
        }, 500, function () {
            if ($('.navigation').hasClass("collapsePanel")) {
                $('.accordion-panel').addClass('accordionHide');
                $('.navigation').show();

            }
            if ($(proxy).hasClass("expandPanel")) {
                $('.accordion-panel').addClass("expandPanel");
            }
        });
        refreshScroller();
    });
    resizeFooter();
    $(window).bind("resize", function () {
        var viewportWidth = $(window).width();
        resizeFooter();
        if (viewportWidth < 981) {
            $('.content-container-fluid .row > .navigation').addClass('collapsePanel');
            $('.accordion-panel').removeClass("expandPanel");
        }
		RefreshPoductNav();
        refreshScroller();
        refreshContentWindow();
		resizeMenu();
    });

    $(document).click(function (evt) {
        if ($("#sbtooltipbox").ejDialog("isOpened"))
            $("#sbtooltipbox").ejDialog("close");
        var ele = false;
        var chromebrowser = /chrome/.test(navigator.userAgent.toLowerCase());
        var safaribrowser = /safari/.test(navigator.userAgent.toLowerCase());
        if (chromebrowser || safaribrowser)
            if(evt.target && evt.target.parentElement != null && evt.target.parentElement.parentElement != null && evt.target.parentElement.parentElement.id != null && evt.target.parentElement.parentElement.id == "themebutton")
            
            if (evt.target && evt.target.parentElement!=null && evt.target.parentElement.parentElement!=null && evt.target.parentElement.parentElement.id != null && evt.target.parentElement.parentElement.id == "themebutton")
                ele = true;        
        if ($(window).width() < 918 && $("#Res-prodnav").hasClass("selectIt")) {
            $(".product-naviation").removeClass("hideIt");
            $("#Res-prodnav").removeClass("selectIt");
            $(".product-naviation").attr("style", "margin-left:" + ($(window).width() - 141) + "px;");
        }
        else
            $(".product-naviation").addClass("hideIt");
    });

    window.setTimeout(function () {
        var waitingPopup = $(".e-waitingpopup.e-js"), timeout;
        if (waitingPopup.length > 0) {
            $(".scrollit").scroll(function () {
			var waitingObj = $(".e-waitingpopup.e-js").data("ejWaitingPopup");
			if (waitingObj && waitingObj.model.showOnInit) {
                    if (timeout) clearTimeout(timeout);
                    timeout = setTimeout(function () { waitingObj.refresh(); }, 20);
                }
            });
        }
    }, 10);
      
});


function preparetheme() {
    var themename = "";
    if (window.theme.indexOf('dark') != -1 && window.themevarient != 'light')
        window.themevarient = "dark";
    if (window.theme.indexOf('gradient') != -1 && window.themestyle != 'flat')
        window.themestyle = "gradient";
    if (window.themevarient == "dark") {
        if (window.themestyle == "gradient")
            themename = window.themestyle + window.themecolor + window.themevarient;
        else
            themename = (window.themecolor != "") ? window.themecolor + window.themevarient : window.themestyle + window.themevarient;

    }
    else {
        if (window.themestyle == "gradient")
            themename = window.themestyle + window.themecolor;
        else
            themename = (window.themecolor != "") ? window.themecolor : window.themestyle;
    }
    if (window.theme.indexOf( "bootstrap")>=0){
        themename = window.theme;
		window.themestyle = "flat";
        window.themevarient = "light";
    }
    if (window.theme.indexOf("high-contrast-01") != -1) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "dark";
    }
    if (window.theme.indexOf("high-contrast-02") != -1) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "dark";
    }
    if (window.theme.indexOf("material") != -1) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "light";
    }
    if (window.theme.indexOf("office-365") != -1) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "light";
    }
    window.theme = themename;
}

function updateTheme(selcolor) {
    preparetheme();
    replacebg(window.themevarient == "dark");
    replaceTheme();
}
var themes = {
    "flat": "/css/ejthemes/default-theme/ej.theme.min.css",
    "flatdark": "/css/ejthemes/flat-azure-dark/ej.theme.min.css",
    "azure": "/css/ejthemes/default-theme/ej.theme.min.css",
    "azuredark": "/css/ejthemes/flat-azure-dark/ej.theme.min.css",
    "lime": "/css/ejthemes/flat-lime/ej.theme.min.css",
    "limedark": "/css/ejthemes/flat-lime-dark/ej.theme.min.css",
    "saffron": "/css/ejthemes/flat-saffron/ej.theme.min.css",
    "saffrondark": "/css/ejthemes/flat-saffron-dark/ej.theme.min.css",
    "gradient": "/css/ejthemes/gradient-azure/ej.theme.min.css",
    "gradientdark": "/css/ejthemes/gradient-azure-dark/ej.theme.min.css",
    "gradientazure": "/css/ejthemes/gradient-azure/ej.theme.min.css",
    "gradientazuredark": "/css/ejthemes/gradient-azure-dark/ej.theme.min.css",
    "gradientlime": "/css/ejthemes/gradient-lime/ej.theme.min.css",
    "gradientlimedark": "/css/ejthemes/gradient-lime-dark/ej.theme.min.css",
    "gradientsaffron": "/css/ejthemes/gradient-saffron/ej.theme.min.css",
    "gradientsaffrondark": "/css/ejthemes/gradient-saffron-dark/ej.theme.min.css",
    "bootstrap": "/css/ejthemes/bootstrap-theme/ej.theme.min.css",
	"high-contrast-01": "/css/ejthemes/high-contrast-01/ej.theme.min.css",
    "high-contrast-02": "/css/ejthemes/high-contrast-02/ej.theme.min.css",
    "material": "/css/ejthemes/material/ej.theme.min.css",
    "office-365": "/css/ejthemes/office-365/ej.theme.min.css"
};
var core = {
    "bootstrap": "/css/ejthemes/ej.widgets.core.bootstrap.min.css",
	"material": "/css/ejthemes/ej.widgets.core.material.min.css",
    "office-365": "/css/ejthemes/ej.widgets.core.office-365.min.css"
};
var rptDesignerThemes = {
    "flat": "/css/ejthemes/default-theme/ej.reportdesigner.theme.min.css",
    "flatdark": "/css/ejthemes/flat-azure-dark/ej.reportdesigner.theme.min.css",
    "azure": "/css/ejthemes/default-theme/ej.reportdesigner.theme.min.css",
    "azuredark": "/css/ejthemes/flat-azure-dark/ej.reportdesigner.theme.min.css",
    "lime": "/css/ejthemes/flat-lime/ej.reportdesigner.theme.min.css",
    "limedark": "/css/ejthemes/flat-lime-dark/ej.reportdesigner.theme.min.css",
    "saffron": "/css/ejthemes/flat-saffron/ej.reportdesigner.theme.min.css",
    "saffrondark": "/css/ejthemes/flat-saffron-dark/ej.reportdesigner.theme.min.css",
    "gradient": "/css/ejthemes/gradient-azure/ej.reportdesigner.theme.min.css",
    "gradientdark": "/css/ejthemes/gradient-azure-dark/ej.reportdesigner.theme.min.css",
    "gradientazure": "/css/ejthemes/gradient-azure/ej.reportdesigner.theme.min.css",
    "gradientazuredark": "/css/ejthemes/gradient-azure-dark/ej.reportdesigner.theme.min.css",
    "gradientlime": "/css/ejthemes/gradient-lime/ej.reportdesigner.theme.min.css",
    "gradientlimedark": "/css/ejthemes/gradient-lime-dark/ej.reportdesigner.theme.min.css",
    "gradientsaffron": "/css/ejthemes/gradient-saffron/ej.reportdesigner.theme.min.css",
    "gradientsaffrondark": "/css/ejthemes/gradient-saffron-dark/ej.reportdesigner.theme.min.css",
    "bootstrap": "/css/ejthemes/bootstrap-theme/ej.reportdesigner.theme.min.css",
    "high-contrast-01": "/css/ejthemes/high-contrast-01/ej.reportdesigner.theme.min.css",
    "high-contrast-02": "/css/ejthemes/high-contrast-02/ej.reportdesigner.theme.min.css",
    "material": "/css/ejthemes/material/ej.reportdesigner.theme.min.css",
    "office-365": "/css/ejthemes/office-365/ej.reportdesigner.theme.min.css"
};
var rptDesignerCore = {
    "bootstrap": "/css/ejthemes/ej.reportdesigner.core.bootstrap.min.css",
    "material": "/css/ejthemes/ej.reportdesigner.core.material.min.css",
    "office-365": "/css/ejthemes/ej.reportdesigner.core.office-365.min.css"
};
function refreshdata() {
    var Mainlist = [];
    var mulsamples = [];

    $(GroupingList).each(function () {
        Mainlist[this] = [];
    });

    $(SamplesList).each(function (index1, sampleslist) {
        var temp = this;
        $(GroupingList).each(function () {
            if (temp["Group"] == this.toString()) {
                Mainlist[this.toString()].push(temp);
                return false;
            }
        });

    });
    $(GroupingList).each(function () {
        $(Mainlist[this]).each(function () {
            mulsamples.push(this);
        });
    });
    return mulsamples;
}
function replaceTheme() {
    if ((window.theme.indexOf("lime") != -1) || (window.theme.indexOf('lime') != -1 && window.themecolor != 'azure' && window.themecolor != "saffron"))
        window.themecolor = 'lime';
    else if ((window.theme.indexOf('saffron') != -1) || (window.theme.indexOf('saffron') != -1 && window.themecolor != 'azure' && window.themecolor != 'lime'))
        window.themecolor = 'saffron';
    else if ((window.theme.indexOf('high-contrast-01') != -1))
        window.themecolor = 'high-contrast-01';
    else if ((window.theme.indexOf('high-contrast-02') != -1))
        window.themecolor = 'high-contrast-02';
    else if ((window.theme.indexOf('material') != -1))
        window.themecolor = 'material';
    else if ((window.theme.indexOf('office-365') != -1))
        window.themecolor = 'office-365';
    var selcolor = (window.themecolor == "") ? "saffron" : window.themecolor;

    $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + selcolor);
    var urlread = window.location.toString();
    var links = $(document.head || document.getElementsByTagName('head')[0]).find("link");
    for (var i = 0; i < links.length; i++) {
        if (links[i].href.indexOf("ej.theme.min.css") != -1) {
            var cssref = links[i].href,serverconfig = cssref.substr(0, cssref.indexOf("css")-1),
			fileref = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + themes[theme] + '" />');
            if (window.theme == "bootstrap") {
                var corefile = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + core[theme] + '" />');
                $(corefile).insertBefore(links[i]);
                if ($(".e-prop").length) $(".e-prop").addClass("e-bootstrap");
            }
            else {
                if (links[i-1].href.indexOf("ej.widgets.core.bootstrap.min.css") != -1)
                    $(links[i - 1]).remove();
				if (links[i-1].href.indexOf("ej.widgets.core.office-365.min.css") != -1)
                    $(links[i - 1]).remove();
				if (links[i-1].href.indexOf("ej.widgets.core.material.min.css") != -1)
                    $(links[i - 1]).remove();
                if ($(".e-prop").length && $(".e-prop").hasClass("e-bootstrap")) $(".e-prop").removeClass("e-bootstrap");
            }
			if(window.theme == "material" || window.theme == "office-365" ){
				var newCoreFile = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + core[theme] + '" />');
				$(newCoreFile).insertBefore(links[i]);
			}
            $(fileref).insertAfter(links[i]);
            $(links[i]).remove();
            window.theme == "material" || window.theme == "office-365" ? document.styleSheets[1].disabled = true : document.styleSheets[1].disabled = false;
        }
        else if (links[i].href.indexOf("ej.reportdesigner.theme.min.css") != -1) {
            var cssref = links[i].href, serverconfig = cssref.substr(0, cssref.indexOf("css") - 1),
			fileref = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + rptDesignerThemes[theme] + '" />');
            if (window.theme == "bootstrap") {
                var corefile = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + rptDesignerCore[theme] + '" />');
                $(corefile).insertBefore(links[i]);
                if ($(".e-prop").length) $(".e-prop").addClass("e-bootstrap");
            }
            else {
                if (links[i - 1].href.indexOf("ej.reportdesigner.core.bootstrap.min.css") != -1)
                    $(links[i - 1]).remove();
                if (links[i - 1].href.indexOf("ej.reportdesigner.core.office-365.min.css") != -1)
                    $(links[i - 1]).remove();
                if (links[i - 1].href.indexOf("ej.reportdesigner.core.material.min.css") != -1)
                    $(links[i - 1]).remove();
                if ($(".e-prop").length && $(".e-prop").hasClass("e-bootstrap")) $(".e-prop").removeClass("e-bootstrap");
            }
            if (window.theme == "material" || window.theme == "office-365") {
                var newCoreFile = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + rptDesignerCore[theme] + '" />');
                $(newCoreFile).insertBefore(links[i]);
            }
            $(fileref).insertAfter(links[i]);
            $(links[i]).remove();
            window.theme == "material" || window.theme == "office-365" ? document.styleSheets[1].disabled = true : document.styleSheets[1].disabled = false;
        }
    }
    window.setTimeout(function () {
        if ($(".cols-sample-area").find(".e-rte.e-js").length) $(".cols-sample-area").find(".e-rte.e-js").data("ejRTE").refresh();
        if ($(".cols-sample-area").find(".e-fileexplorer.e-js").length) $(".cols-sample-area").find(".e-fileexplorer.e-js").data("ejFileExplorer").adjustSize();
    }, 500);
    //gauge chart and others
    if (urlread.toLowerCase().indexOf("gauge") >= 0) {
        loadGaugeTheme();
    }
    else if ((urlread.indexOf("chart") >= 0) || (urlread.indexOf("Client") >= 0) || (urlread.indexOf("client") >= 0) || (urlread.indexOf("rangenavigator") >= 0)) {
        loadTheme(undefined);
    }
    else if (urlread.indexOf("graph") >= 0) {
        loadBulletTheme();
    }
    else if (urlread.indexOf("Grid/Adaptive") >= 0 || urlread.indexOf("grid/adaptive") >= 0) {
        loadGridFrameTheme();
    }
    else if (urlread.indexOf("schedule/adaptive") >= 0) {
        loadScheduleFrameTheme();
    }
    resetCookies();
}
function replacebg(enable) {
	$("body").removeAttr("class");
    if (enable)
        $("body").addClass("darktheme");
    else
        $("body").removeClass("darktheme");
	$("body").addClass(window.theme);
}

function themebtnClick(args) {
    if (args.ID != 1) {
        this.element.find('li.e-active').removeClass('e-active');
    }
    showThemeDialog(args);
}
function showTooltipbox() {
    var $btnelement = $("#themebutton");
    var pos = $btnelement.offset();
    var left = $("#sbtooltipbox_wrapper").width() + pos.left;
    left = (pos.left + ($btnelement.width() / 2)) - $("#sbtooltipbox_wrapper").width();
    $("#sbtooltipbox").ejDialog("option", "position", { X: left + 10, Y: $(".header").height() + 7 });
    $("#sbtooltipbox").ejDialog("open");
}
function showThemeDialog(args) {
    var color;
    if (args.ID == 1) {
        var $btnelement = $("#themebutton");
        var pos = $btnelement.offset();
        var left = $btnelement.width() - $(".e-custom-theme .e-horizontal .e-list>ul").width();
        $(".e-custom-theme .e-horizontal .e-list>ul").css('left', left);
    } else {
        if ((args.text).toLowerCase().indexOf("bootstrap") !== -1) {
            window.themecolor = "azure";
            window.theme = "bootstrap";
            color = window.theme;
        } else {
            $("#themebutton >li >a > .e-icon:first").removeClass('azure office-365 material high-contrast-02 high-contrast-01 lime saffron');
            if ((args.text).toLowerCase().indexOf("gradient") !== -1) window.themestyle = "gradient";
            else window.themestyle = "flat";
            if ((args.text).toLowerCase().indexOf("dark") !== -1) window.themevarient = "dark";
            else window.themevarient = "light";
            if ((args.text).toLowerCase().indexOf("azure") !== -1) {
                window.themecolor = window.theme = "azure";
                $("#themebutton >li >a > .e-icon:first").addClass("azure");
            }
            else if ((args.text).toLowerCase().indexOf("lime") !== -1) {
                window.themecolor = window.theme = "lime";
                $("#themebutton >li >a > .e-icon:first").addClass("lime");
            }
            else if ((args.text).toLowerCase().indexOf("saffron") !== -1) {
                window.themecolor = window.theme = "saffron";
                $("#themebutton >li >a > .e-icon:first").addClass("saffron");
            }
			else if ((args.text).toLowerCase().indexOf("office-365") !== -1){ 
				 window.themecolor = window.theme = "office-365";
				 $("#themebutton >li >a > .e-icon:first").addClass("office-365");
			}
			else if ((args.text).toLowerCase().indexOf("material") !== -1) {
				window.themecolor = window.theme = "material";
				$("#themebutton >li >a > .e-icon:first").addClass("material");
			}
			else if ((args.text).toLowerCase().indexOf("high-contrast-02") !== -1) {
				window.themecolor = window.theme = "high-contrast-02";
				$("#themebutton >li >a > .e-icon:first").addClass("high-contrast-02");
			}
			else if ((args.text).toLowerCase().indexOf("high-contrast-01") !== -1) {
				window.themecolor = window.theme = "high-contrast-01";
				$("#themebutton >li >a > .e-icon:first").addClass("high-contrast-01");
			}
            color = window.themecolor;
        }
        updateTheme(color);
        $(args.element).addClass("e-active");
    }
}

function themeButtonSelect() {
    //
    if ((readCookie('themeName') != null) && (readCookie('themeName') != ""))
        window.theme = readCookie('themeName');
    if ((readCookie('themeColor') != null) && (readCookie('themeColor') != ""))
        window.themecolor = readCookie('themeColor');
    if ((readCookie('themeStyle') != null) && (readCookie('themeStyle') != ""))
        window.themestyle = readCookie('themeStyle');
    if ((readCookie('themeVarient') != null) && (readCookie('themeVarient') != ""))
        window.themevarient = readCookie('themeVarient');
    if ((window.theme.indexOf("lime") != -1) || (window.theme.indexOf('lime') != -1)) window.themecolor = 'lime';    
    else if ((window.theme.indexOf("saffron") != -1) || (window.theme.indexOf('saffron') != -1)) window.themecolor = 'saffron';
    else window.themecolor = 'azure';
}

//next previous location
function prevnext(name, cursample, navloc) {
    var cursampitem, prevsampitem, nextsampitem, cursamplist, prevsamplist, nextsamplist, chx, tempsample, cursampquery, anchref, newlist = refreshdata();
    for (i = 0; i < newlist.length; i++) {
        chx = newlist[i].id;
        if (chx.toLowerCase() == name.toLowerCase()) {
            cursampitem = newlist[i];
            prevsampitem = newlist[i - 1];
            nextsampitem = newlist[i + 1];
            break;
        }
    }
    cursamplist = retrivesamplkist(cursampitem);
    prevsamplist = retrivesamplkist(prevsampitem);
    nextsamplist = retrivesamplkist(nextsampitem);
    if (navloc == "next") {
        for (i = 0; i < cursamplist.length; i++) {
            if (cursamplist[i].action == cursample) {
                if (i == cursamplist.length - 1) {
                    if (nextsamplist.length == 0) {
                        anchref = "/Introduction/Index";
                    }
                    else {
                        anchref = "/" + nextsamplist[0].controller + "/" + nextsamplist[0].action;
                    }
                }
                else if (i < cursamplist.length - 1) {
                    anchref = "/" + cursamplist[i + 1].controller + "/" + cursamplist[i + 1].action;
                }
                break;
            }
        }
    }
    else if (navloc == "prev") {
        for (i = 0; i < cursamplist.length; i++) {
            if (cursamplist[i].action == cursample) {
                if (i == 0) {
                    if (prevsamplist.length == 0) {
                        anchref = "/Introduction/Index";
                    }
                    else {
                        anchref = "/" + prevsamplist[prevsamplist.length - 1].controller + "/" + prevsamplist[prevsamplist.length - 1].action;
                    }
                }
                else if (i > 0 && i < cursamplist.length) {
                    anchref = "/" + cursamplist[i - 1].controller + "/" + cursamplist[i - 1].action;
                }
                break;
            }
        }
    }
    return anchref.toLowerCase();
}
function retrivesamplkist(cursampitem) {
    var cursamplist = [];
    if (cursampitem && !ej.isNullOrUndefined(cursampitem.samples)) {
        for (i = 0; i < cursampitem.samples.length; i++) {
            if (cursampitem.samples[i].childcount == "0") {
                cursamplist.push(cursampitem.samples[i]);
            }
            else if (cursampitem.samples[i].samples.length != 0) {
                for (j = 0; j < cursampitem.samples[i].samples.length; j++) {
                    if (cursampitem.samples[i].samples[j].childcount == "0")
                        cursamplist.push(cursampitem.samples[i].samples[j]);
                }
            }
        }
    }
    return cursamplist;
}
//cookies
function createCookies(name, value, days) {
    var expires;

    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (3 * 60 * 1000));
        expires = "; expires=" + date.toGMTString();
    } else {
        expires = "";
    }
    document.cookie = escape(name) + "=" + escape(value) + expires + "; path=/";
}

function readCookie(name) {
    var nameEQ = escape(name) + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) === 0) return unescape(c.substring(nameEQ.length, c.length));
    }
    return null;
}

function eraseCookie(name) {
    createCookies(name, "", -1);
}




/* Launching Other Products*/
function viewdemo(args) {
    var text = 'Handler/StartDevServer.ashx', product = $.trim(args.text).toLowerCase(), prot = window.location.protocol, hostname = window.location.host;
	var links = $(document.head || document.getElementsByTagName('head')[0]).find("link");
    var serverconfig = links[0].href.substr(0, links[0].href.indexOf("css") - 1);
    if (typeof (iisPrefixLink) != "undefined" && iisPrefixLink != null) {
        if (product == "mobile") window.location = "//localhost:"+window.location.port+"/sfejmobilemvcsamplebrowser"; 
        else if (product == "analytics") window.open("//localhost:"+window.location.port+"/sfejmvcanalyticssamplebrowser");
        else return false;        
    }
    else if (product == "mobile" || product == "analytics") {
        $.ajax({
            url: serverconfig + "/" + text + "?product=" + product,
            success: function (data) {
                if (product == "mobile") window.location = data;
                if (product == "analytics") window.open(data);
            }
        });
    }
}
//autocomplete
function onSelectSearchItem(args) {
    var links = $(document.head || document.getElementsByTagName('head')[0]).find("link");
    var serverconfig = links[0].href.substr(0, links[0].href.indexOf("css") - 1);
    var url = serverconfig+ "/" + args.key;
    window.location = url.toString().toLowerCase();
    this.clearText();
}

function resetCookies() {
    eraseCookie("themeName");
    createCookies('themeName', window.theme, 1);
    eraseCookie("themeColor");
    createCookies('themeColor', window.themecolor, 1);
    eraseCookie("themeStyle");
    createCookies('themeStyle', window.themestyle, 1);
    eraseCookie("themeVarient");
    createCookies('themeVarient', window.themevarient, 1);
}

//Downlink function 
function downlinkclick(e){
	window.open("//www.syncfusion.com/downloads/aspnetcore","_blank");
}
//themestudio function 
function paintTheme(e){
	window.open("//js.syncfusion.com/themestudio/","_blank");
}
function ej2Samples(e) {
    window.open("//ej2.syncfusion.com/home/aspnetcore.html?utm_source=ej1&utm_medium=banner&utm_campaign=migrate","_blank");
}
window.menuData = [{ id: 1, text: "", parentId: null, spriteCssClass: "e-icon" },
                    { id: "azure", text: "Flat-Azure", parentId: 1, spriteCssClass: "SB-theme SB-flat-azure" },
                    { id: "azuredark", text: "Flat-Azure-Dark", parentId: 1, spriteCssClass: "SB-theme SB-flat-azure-dark" },
                    { id: "lime", text: "Flat-Lime", parentId: 1, spriteCssClass: "SB-theme SB-flat-lime" },
                    { id: "limedark", text: "Flat-Lime-Dark", parentId: 1, spriteCssClass: "SB-theme SB-flat-lime-dark" },
                    { id: "saffron", text: "Flat-Saffron", parentId: 1, spriteCssClass: "SB-theme SB-flat-saffron" },
                    { id: "saffrondark", text: "Flat-Saffron-Dark", parentId: 1, spriteCssClass: "SB-theme SB-flat-saffron-dark" },
                    { id: "gradientazure", text: "Gradient-Azure", parentId: 1, spriteCssClass: "SB-theme SB-gradient-azure" },
                    { id: "gradientazuredark", text: "Gradient-Azure-Dark", parentId: 1, spriteCssClass: "SB-theme SB-gradient-azure-dark" },
                    { id: "gradientlime", text: "Gradient-Lime", parentId: 1, spriteCssClass: "SB-theme SB-gradient-lime" },
                    { id: "gradientlimedark", text: "Gradient-Lime-Dark", parentId: 1, spriteCssClass: "SB-theme SB-gradient-lime-dark" },
                    { id: "gradientsaffron", text: "Gradient-Saffron", parentId: 1, spriteCssClass: "SB-theme SB-gradient-saffron" },
                    { id: "gradientsaffrondark", text: "Gradient-Saffron-Dark", parentId: 1,spriteCssClass: "SB-theme SB-gradient-saffron-dark" },
                    { id: "bootstrap", text: "Bootstrap", parentId: 1, spriteCssClass: "SB-theme SB-bootstrap" },
					{ id: "high-contrast-01", text: "High-Contrast-01", parentId: 1, spriteCssClass: "SB-theme SB-high-contrast-01" },
					{ id: "high-contrast-02", text: "High-Contrast-02", parentId: 1, spriteCssClass: "SB-theme SB-high-contrast-02"},
					{ id: "material", text: "Material", parentId: 1, spriteCssClass: "SB-theme SB-material"},
					{ id: "office-365", text: "Office-365", parentId: 1, spriteCssClass: "SB-theme SB-office365"}
];
// To get cookie value
function getCookieValue(cookieName) {
	var name = cookieName + "=";
	var decodedCookie = decodeURIComponent(document.cookie);
	var cookieValues = decodedCookie.split(';');
	for (var i = 0; i < cookieValues.length; i++) {
		var cookie = cookieValues[i];
		while (cookie.charAt(0) == ' ') {
			cookie = cookie.substring(1);
		}
		if (cookie.indexOf(name) == 0) {
			return cookie.substring(name.length, cookie.length);
		}
	}
	return "";
}
