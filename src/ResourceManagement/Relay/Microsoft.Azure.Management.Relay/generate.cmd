::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
set autoRestVersion=0.17.0-Nightly20161012
if  "%1" == "" (
    set specFile="D:\SwaggerWork\v-ajnava_Fork\azure-rest-api-specs\arm-relay\2016-07-01\swagger\relay.json"
) else (
    set specFile="%1"
)
set repoRoot=%~dp0..\..\..\..
set generateFolder=%~dp0Generated

if exist %generateFolder% rd /S /Q  %generateFolder%
call "%repoRoot%\tools\autorest.gen.cmd" %specFile% Microsoft.Azure.Management.Relay %autoRestVersion% %generateFolder% 