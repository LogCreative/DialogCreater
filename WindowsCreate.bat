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
title ���׶Ի��򴴽���
color 0f
::echo WindowsCreat	%RANDOM%		%date%  %time:~0,8%>>.\runlog.txt
:mainmenu
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo �˵�
echo 1.�½�һ������
echo 2.ʹ��ģ��
echo 3.����
echo 4.�˳�
echo.
set/p menu=����š�
if %menu%==1 (goto start)
if %menu%==2 (goto muban)
if %menu%==3 (goto about)
if %menu%==4 (goto exitsys)
:start
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
set/p wtitle=�����ڱ��⡿
echo �����ô��ڱ���Ϊ [ %wtitle% ] ��
echo.
set/p warticle=���������ݡ�
echo �����ô�������Ϊ [ %warticle% ] ��
echo.
pause
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo 0 = vbOKOnly - ֻ��ʾȷ����ť��
echo 1 = vbOKCancel - ��ʾȷ����ȡ����ť��
echo 2 = vbAbortRetryIgnore - ��ʾ���������Ժͺ��԰�ť��
echo 3 = vbYesNoCancel - ��ʾ�ǡ����ȡ����ť��
echo 4 = vbYesNo - ��ʾ�Ǻͷ�ť��
echo 5 = vbRetryCancel - ��ʾ���Ժ�ȡ����ť��
echo 16 = vbCritical - ��ʾ�ٽ���Ϣͼ�ꡣ
echo 32 = vbQuestion - ��ʾ�����ѯͼ�ꡣ
echo 48 = vbExclamation - ��ʾ������Ϣͼ�ꡣ
echo 64 = vbInformation - ��ʾ��Ϣ��Ϣͼ�ꡣ
echo.
set/p wmode=��ģʽѡ�񣨴��룩��
if %wmode%==0 (set wmodew=ֻ��ʾȷ����ť )
if %wmode%==1 (set wmodew=��ʾȷ����ȡ����ť )
if %wmode%==2 (set wmodew=��ʾ���������Ժͺ��԰�ť )
if %wmode%==3 (set wmodew=��ʾ�ǡ����ȡ����ť )
if %wmode%==4 (set wmodew=��ʾ�Ǻͷ�ť )
if %wmode%==5 (set wmodew=��ʾ���Ժ�ȡ����ť )
if %wmode%==16 (set wmodew=��ʾ�ٽ���Ϣͼ�� )
if %wmode%==32 (set wmodew=��ʾ�����ѯͼ�� )
if %wmode%==48 (set wmodew=��ʾ������Ϣͼ�� )
if %wmode%==64 (set wmodew=��ʾ��Ϣ��Ϣͼ�� )
echo ������ģʽΪ [ %wmodew% ] ��
echo.
pause
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo ��������...
echo.
ping -n 2 localhost>nul
goto window
:window
mshta vbscript:msgbox("%warticle%",%wmode%,"%wtitle%")(window.close)
goto sle
:sle
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo bat���룺
echo mshta vbscript:msgbox("%warticle%",%wmode%,"%wtitle%")(window.close)
echo.
echo 1 = ���ز˵�
echo 2 = ������ʾ
echo 3 = ��������
echo.
set/p d=��ѡ�
if %d%==1 (goto mainmenu)
if %d%==2 (goto window)
if %d%==3 (goto start)
:about
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo �汾��1.3.0.0211
echo.
echo �ʺ�Windows�汾��Windows ALL��ȫ���汾��
echo.
echo ʱ�䣺
echo %date%  %time:~0,8%
echo.
pause
goto mainmenu
:muban
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo ģ��
echo 1.Windows ����
echo 2.�ٷ�
echo 3.Windows AI
echo 4.���ز˵�
echo.
set/p mubannum=����š�
if %mubannum%==1 (goto winwrong)
if %mubannum%==2 (goto gf)
if %mubannum%==3 (goto ai)
if %mubannum%==4 (goto mainmenu)
:winwrong
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo Windows ����
echo 1.��ʽ1
echo 2.��ʽ2
echo 3.������һ��
echo.
set/p wrongnum=����š�
if %wrongnum%==1 (goto wrongys1)
if %wrongnum%==2 (goto wrongys2)
if %wrongnum%==3 (goto muban)
:wrongys1
mshta vbscript:msgbox("��0x7eaf9883��ָ�����õġ�0x02043a98���ڴ档���ڴ治��Ϊ��read����Ҫ��ֹ�����뵥����ȷ������",16,"DDE Sever Window:iexplore.exe - Ӧ�ó������")(window.close)
goto winwrong
:wrongys2
mshta vbscript:msgbox("Runtime Error��                        Program:C:\windows\system32\rundll32.exe This application has requested the Runtime to terminate it in an unusual way. Please contrat the application's support team for more information.",16,"Microsoft Visual C++ Runtime Library")(window.close)
goto winwrong
:gf
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo �ٷ�
echo 1.��ʽ1
echo 2.��ʽ2
echo 3.������һ��
echo.
set/p zgnum=����š�
if %zgnum%==1 (goto zgys1)
if %zgnum%==2 (goto zgys2)
if %zgnum%==3 (goto muban)
:zgys1
mshta vbscript:msgbox("��Ϊ���Ĵ�����������ļ�������� 90 ���ڹرա�",16,"Windows")(window.close)
goto gf
:zgys2
mshta vbscript:msgbox("���Ļ�����Ƿ10000Ԫ��",48,"����")(window.close)
goto gf
:ai
cls
echo.
echo ���׶Ի��򴴽���
echo LogCreative ����
echo.
echo Windows AI
echo 1.��ʽ1
echo 2.��ʽ2
echo 3.������һ��
echo.
set/p ainum=����š�
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
@REM echo ���׶Ի��򴴽���
@REM echo LogCreative ����
@REM echo.
@REM echo ����
@REM echo 1.�˳�
@REM echo 2.������OSS
@REM echo 3.��������������
@REM echo 4.������ȫ������
@REM echo 5.���ز˵�
@REM echo.
@REM set/p back=����š�
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
@REM echo ���ģ�1�� or Ӣ�ģ�2����
@REM set/p ossl=����š�
@REM if %ossl%==1 (goto chineseoss)
@REM if %ossl%==1 (goto englishoss)
@REM :chineseoss
@REM ".\mode\OSSChinese.bat"
@REM :englishoss
@REM ".\mode\OSS.bat"
@REM :backCCC
@REM echo.
@REM echo ���ģ�1�� or Ӣ�ģ�2����
@REM set/p CCCl=����š�
@REM if %CCCl%==1 (goto chineseCCC)
@REM if %CCCl%==1 (goto englishCCC)
@REM :chineseCCC
@REM ".\main\CCCommandChinese.bat"
@REM :englishCCC
@REM ".\main\CCCommand.bat"
@REM :backallc
@REM ".\main\allcommand.bat"