REM runas.exe /user:promowork\judith /savecred Gestion.exe

xcopy "\\servidor_promow\DATOS\Gestion\*.*" c:\Gestion\ /d /y

REM xcopy \\servidor_promow\DATOS\Gestion\Gestion.exe.config c:\Gestion\ /d /y
REM xcopy \\servidor_promow\DATOS\Gestion\*.dll c:\Gestion\ /d /y

start /b c:\Gestion\Gestion.exe
exit