REM copy file to GreenShot folder
@echo off
cls

set GreenShotPath=%1
set PlugInPath="\Plugins\GreenshotFlickrPlugin"

MD %GreenShotPath%%PlugInPath%
copy "bin\Release\GreenshotFlickrPlugin.gsp" %GreenShotPath%%PlugInPath%\GreenshotFlickrPlugin.gsp

MD %GreenShotPath%\Languages\%PlugInPath%
copy "Languages\*.*" %GreenShotPath%\Languages\%PlugInPath%