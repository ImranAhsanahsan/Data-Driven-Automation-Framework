@ECHO OFF
ECHO Demo Automation Executed Started.

set testcategory=Login
set dllpath=C:\Users\ImranAhsan\source\repos\SQA04imranexam\SQA04imranexam\bin\Debug\SQA04imranexam.dll
set trxtoHTML=C:\Users\ImranAhsan\source\repos\SQA04imranexam\SQA04imranexam\bin\Debug\
set testsummaryreportPath=C:\Users\ImranAhsan\source\repos\SQA04imranexam\SQA04imranexam\bin

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename=%testcategory%_%DTS:~0,4%%DTS:~4,2%%DTS:~6,2%%DTS:~8,2%%DTS:~10,2%%DTS:~12,2%
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\Tools\VsDevCmd.bat"
cd %testsummaryreportPath%


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%testsummaryreportPath%\%filename%\%filename%.trx"

cd %trxtoHTML%
TrxToHTML.exe %testsummaryreportPath%%filename%\

PAUSE




