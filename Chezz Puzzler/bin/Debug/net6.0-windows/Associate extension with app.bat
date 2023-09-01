@echo off
setlocal enabledelayedexpansion

:: Define the file extension and application executable
set "fileExtension=.pzq"
set "appName=PuzzQ.exe"

:: Check if the association already exists
assoc %fileExtension% >nul 2>&1
if %errorlevel% equ 0 (
    echo %fileExtension% is already associated with an application.
) else (
    :: Create the association
    assoc %fileExtension%=YourApp.Document
    ftype YourApp.Document="%appName%" "%%1"
    
    echo %fileExtension% is now associated with %appName%.
)

:: Pause to see the output
pause