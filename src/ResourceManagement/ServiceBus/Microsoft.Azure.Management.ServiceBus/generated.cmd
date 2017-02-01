::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
set autoRestVersion=0.16.0-Nightly20160426 
if  "%1" == "" (
    set specFile="D:\SwaggerWork\v-ajnava_Fork\azure-rest-api-specs\arm-servicebus\2015-08-01\swagger\servicebus_test.json"
) else (
    set specFile="%1"
)
set repoRoot=%~dp0..\..\..\..
set generateFolder=%~dp0Generated

if exist %generateFolder% rd /S /Q  %generateFolder%
call "%repoRoot%\tools\autorest.gen.cmd" %specFile% Microsoft.Azure.Management.ServiceBus %autoRestVersion% %generateFolder% 
