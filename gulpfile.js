'use strict';

var gulp = require('gulp');
var connect = require('gulp-connect');

gulp.task('copyfiles', function(){
	gulp.src('node_modules/syncfusion-javascript/Scripts/ej/web/ej.web.all.min.js')
        .pipe(gulp.dest('samplebrowser/wwwroot/scripts'));
	gulp.src('node_modules/syncfusion-javascript/Scripts/ej/web/ej.reportdesigner.min.js')
        .pipe(gulp.dest('samplebrowser/wwwroot/scripts'));
    gulp.src('node_modules/syncfusion-ej-global/i18n/*.js')
        .pipe(gulp.dest('samplebrowser/wwwroot/scripts/cultures'));
	gulp.src('node_modules/syncfusion-javascript/Content/ej/web/**')
        .pipe(gulp.dest('samplebrowser/wwwroot/css/ejthemes'));
});