@echo off
Set /p server=Enter your server:
Set /p user=Enter your user:
Set /p pwd=Enter your password:
osql -S "%server%" -U "%user%" -P "%pwd%" -Q "sp_detach_db 'cdc' select name from sysdatabases"

pause