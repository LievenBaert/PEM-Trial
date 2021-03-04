**WebProject buildscripts**

These buildscripts are made to be included in .NET projects to enable our current build service ( TFS )  to launch the required commands for building node-based frontend applications.

We have several build scripts to build your application: pre-build*.bat
These should be used to generate the desired output folder to be packaged further in the process ( Wix Installer)

Delivering npm packages is different:
There we refer to the script npmpublish.bat to publish a package to the feed.

All other scripts are helper scripts!


Flow of the build:

Check and maybe install global dependencies ( .rc files and tools like gulp or webpack)
Install packages  ( mostly npm  but older builds still have  bower and typings)
Build command  ( gulp or webpack)

publish package ( in case of npm publish script)


Publishing packages has an other concern added. 
We need to version packages ourselves because the information is stored in the package.json file instead of 

