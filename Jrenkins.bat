@echo off
@set unity="D:\install\Unity2017\Unity\Editor\Unity.exe"
@set projectPath="C:\Users\caimin.caimin\JenkinsTestDemo"
echo buildJenkinsAPK
echo ��������apk�ļ�....
%unity% -batchmode -quit -nographics -executeMethod BuildAPK.BuildJenkinsAndroid -logFile D:\JenkinsEditor.log -projectPath %projectPath%
echo APK�������
pause