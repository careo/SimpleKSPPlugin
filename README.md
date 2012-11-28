# SimpleKSPPlugin

Authors:

  * careo <careo@exsurgent.com>


## Setup

You need to setup a couple of symbolic links (supported in Windows since Vista) within the project:
  
  * `Library/KSP` -- the directory with the DLLs shipped with KSP.
  * `Build/Plugins` --  wherever you want your compiled DLL. I have it pointing to the `Plugins` directory of a "lite" version of KSP I use for development.

### OS X Setup

`Library/KSP` should be a symlnk to `<kspdir>/KSP.app/Contents/Data/Managed/`.

Open a terminal window and `cd` to this project's root directory, and (substituting `<kspdir>` for the path to whichever KSP install you want):

    ln -s <kspdir>/KSP.app/Contents/Data/Managed/ ./Library/KSP


### Windows Setup

`Library/KSP` should be a symlnk to `<kspdir>/KSP_data/Managed/`

Open a terminal window and `cd` to this project's root directory, and (substituting `<kspdir>` for the path to whichever KSP install you want):

    mklink /D <kspdir>\KSP_data\Managed Library\KSP

Alternately, you can use the "link shell extension" (TODO: can anyone verify this, provide a link to it?).


## Contributors

 * cybutek <admin@cybutek.net> for the initial PartModule boilerplate that got this all started!



## License
  
    SimpleKSPPlugin - Simple boilerplate for a KSP Plugin
    Copyright (C) 2012 careo <careo@exsurgent.com>

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.