# CheckForJavaW
Utility to monitor number of executed Progress Developer Studio for OpenEdge instances. 

The utility displays the number of executed javaw.exe processes (likely Progress Developer Studio for OpenEdge or OpenEdge architect) in the windows system tray.

Shutting down Windows or logging off form a Windows Terminal Server session while Progress Developer Studio is still executed may cause in abnormal shutdown of the PDSOE tool. As PDSOE sometimes takes minutes to shut down completely after the workbench window has been closed this may be hard to track.

Killing PDSOE instances may severly impact a workspaces health and performance while using the development environment. 

Some of the issues that developers may encounter are described here:

https://community.progress.com/technicalusers/f/19/t/11072.aspx

# Installation

The CheckForJavaW.exe may be executed from a shortcut in the Windows Autostart folder.

For Windows 8, the Autostart folder may be found here: http://www.addictivetips.com/windows-tips/where-is-startup-folder-how-to-edit-startup-items-in-windows-8/

The tool creates an icon on the Windows System tray. Windows System tray icons visibility can be controlled as described here: http://www.makeuseof.com/tag/manage-and-tidy-the-windows-7-system-tray/

For best use, the icon of the utility should always be shown on the system tray.
