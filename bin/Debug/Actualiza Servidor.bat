REM runas.exe /user:promowork\judith /savecred Gestion.exe

xcopy Gestion.exe "\\servidor_promow\DATOS\Gestion\" /d /y

REM xcopy \\servidor_promow\DATOS\Gestion\Gestion.exe.config c:\Gestion\ /d /y
REM xcopy \\servidor_promow\DATOS\Gestion\*.dll c:\Gestion\ /d /y

rem start /b c:\Gestion\Gestion.exe
exit