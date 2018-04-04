cd .\example

for %%i in (*.proto) do (  
	echo %%i 
    "..\protoc.exe" --plugin=protoc-gen-lua="..\plugin\build.bat" --lua_out=..\lua %%i      
) 

pause