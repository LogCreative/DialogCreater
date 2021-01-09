@echo off
Setlocal enabledelayedexpansion
::-------------------TIP-----------------------
::CODER BY li POWERD BY iBAT 1.6
::Li Copyright(LC) 2013-2014,all rights reserved.
::LogCreative 2020 Modified for 1.3
::(LC)No.0043
::Please open this file with the encoding of GB 2312
::---------------------------------------------
cls
title 简易对话框创建器
color 0f
::echo WindowsCreat	%RANDOM%		%date%  %time:~0,8%>>.\runlog.txt
:mainmenu
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo 菜单
echo 1.新建一个窗口
echo 2.使用模板
echo 3.关于
echo 4.退出
echo.
set/p menu=【编号】
if %menu%==1 (goto start)
if %menu%==2 (goto muban)
if %menu%==3 (goto about)
if %menu%==4 (goto exitsys)
:start
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
set/p wtitle=【窗口标题】
echo 已设置窗口标题为 [ %wtitle% ] 。
echo.
set/p warticle=【窗口内容】
echo 已设置窗口内容为 [ %warticle% ] 。
echo.
pause
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo 0 = vbOKOnly - 只显示确定按钮。
echo 1 = vbOKCancel - 显示确定和取消按钮。
echo 2 = vbAbortRetryIgnore - 显示放弃、重试和忽略按钮。
echo 3 = vbYesNoCancel - 显示是、否和取消按钮。
echo 4 = vbYesNo - 显示是和否按钮。
echo 5 = vbRetryCancel - 显示重试和取消按钮。
echo 16 = vbCritical - 显示临界信息图标。
echo 32 = vbQuestion - 显示警告查询图标。
echo 48 = vbExclamation - 显示警告消息图标。
echo 64 = vbInformation - 显示信息消息图标。
echo.
set/p wmode=【模式选择（代码）】
if %wmode%==0 (set wmodew=只显示确定按钮 )
if %wmode%==1 (set wmodew=显示确定和取消按钮 )
if %wmode%==2 (set wmodew=显示放弃、重试和忽略按钮 )
if %wmode%==3 (set wmodew=显示是、否和取消按钮 )
if %wmode%==4 (set wmodew=显示是和否按钮 )
if %wmode%==5 (set wmodew=显示重试和取消按钮 )
if %wmode%==16 (set wmodew=显示临界信息图标 )
if %wmode%==32 (set wmodew=显示警告查询图标 )
if %wmode%==48 (set wmodew=显示警告消息图标 )
if %wmode%==64 (set wmodew=显示信息消息图标 )
echo 已设置模式为 [ %wmodew% ] 。
echo.
pause
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo 正在生成...
echo.
ping -n 2 localhost>nul
goto window
:window
mshta vbscript:msgbox("%warticle%",%wmode%,"%wtitle%")(window.close)
goto sle
:sle
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo bat代码：
echo mshta vbscript:msgbox("%warticle%",%wmode%,"%wtitle%")(window.close)
echo.
echo 1 = 返回菜单
echo 2 = 重新显示
echo 3 = 重新制作
echo.
set/p d=【选项】
if %d%==1 (goto mainmenu)
if %d%==2 (goto window)
if %d%==3 (goto start)
:about
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo 版本：1.3.0.0211
echo.
echo 适合Windows版本：Windows ALL（全部版本）
echo.
echo 时间：
echo %date%  %time:~0,8%
echo.
pause
goto mainmenu
:muban
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo 模板
echo 1.Windows 错误
echo 2.官方
echo 3.Windows AI
echo 4.返回菜单
echo.
set/p mubannum=【编号】
if %mubannum%==1 (goto winwrong)
if %mubannum%==2 (goto gf)
if %mubannum%==3 (goto ai)
if %mubannum%==4 (goto mainmenu)
:winwrong
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo Windows 错误
echo 1.样式1
echo 2.样式2
echo 3.返回上一级
echo.
set/p wrongnum=【编号】
if %wrongnum%==1 (goto wrongys1)
if %wrongnum%==2 (goto wrongys2)
if %wrongnum%==3 (goto muban)
:wrongys1
mshta vbscript:msgbox("“0x7eaf9883”指令引用的“0x02043a98”内存。该内存不能为“read”。要终止程序，请单击“确定”。",16,"DDE Sever Window:iexplore.exe - 应用程序错误")(window.close)
goto winwrong
:wrongys2
mshta vbscript:msgbox("Runtime Error！                        Program:C:\windows\system32\rundll32.exe This application has requested the Runtime to terminate it in an unusual way. Please contrat the application's support team for more information.",16,"Microsoft Visual C++ Runtime Library")(window.close)
goto winwrong
:gf
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo 官方
echo 1.样式1
echo 2.样式2
echo 3.返回上一级
echo.
set/p zgnum=【编号】
if %zgnum%==1 (goto zgys1)
if %zgnum%==2 (goto zgys2)
if %zgnum%==3 (goto muban)
:zgys1
mshta vbscript:msgbox("因为您的错误操作，您的计算机将在 90 秒内关闭。",16,"Windows")(window.close)
goto gf
:zgys2
mshta vbscript:msgbox("您的花呗已欠10000元。",48,"花呗")(window.close)
goto gf
:ai
cls
echo.
echo 简易对话框创建器
echo LogCreative 制作
echo.
echo Windows AI
echo 1.样式1
echo 2.样式2
echo 3.返回上一级
echo.
set/p ainum=【编号】
if %ainum%==1 (goto aiys1)
if %ainum%==2 (goto aiys2)
if %ainum%==3 (goto muban)
:aiys1
mshta vbscript:msgbox("To be or not to be, it is a question.",64,"Windows AI")(window.close)
goto ai
:aiys2
mshta vbscript:msgbox("I will close your system immediately!",32,"Windows AI")(window.close)
goto ai
@REM :exitm
@REM cls
@REM echo.
@REM echo 简易对话框创建器
@REM echo LogCreative 制作
@REM echo.
@REM echo 返回
@REM echo 1.退出
@REM echo 2.返回至OSS
@REM echo 3.返回至控制中心
@REM echo 4.返回至全部命令
@REM echo 5.返回菜单
@REM echo.
@REM set/p back=【编号】
@REM if %back%==1 (goto exitsys)
@REM if %back%==2 (goto backoss)
@REM if %back%==3 (goto backCCC)
@REM if %back%==4 (goto backallc)
@REM if %back%==5 (goto mainmenu)
:exitsys
for /l %%a in (25 -1 3) do (
	set /a "cols=30+%%a*2"
	call mode con:cols=%%cols%% lines=%%a
)
exit
@REM :backoss
@REM echo.
@REM echo 中文（1） or 英文（2）？
@REM set/p ossl=【编号】
@REM if %ossl%==1 (goto chineseoss)
@REM if %ossl%==1 (goto englishoss)
@REM :chineseoss
@REM ".\mode\OSSChinese.bat"
@REM :englishoss
@REM ".\mode\OSS.bat"
@REM :backCCC
@REM echo.
@REM echo 中文（1） or 英文（2）？
@REM set/p CCCl=【编号】
@REM if %CCCl%==1 (goto chineseCCC)
@REM if %CCCl%==1 (goto englishCCC)
@REM :chineseCCC
@REM ".\main\CCCommandChinese.bat"
@REM :englishCCC
@REM ".\main\CCCommand.bat"
@REM :backallc
@REM ".\main\allcommand.bat"