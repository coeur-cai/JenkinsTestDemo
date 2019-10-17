@echo off
@set unity="D:\install\Unity2017\Unity\Editor\Unity.exe"
@set projectPath="C:\Users\caimin.caimin\JenkinsTestDemo"
echo buildJenkinsAPK
echo 正在生成apk文件....
%unity% -batchmode -quit -nographics -executeMethod BuildAPK.BuildJenkinsAndroid -logFile D:\JenkinsEditor.log -projectPath %projectPath%
echo APK生成完毕
pause