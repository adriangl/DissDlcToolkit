DissDlcToolkit
==============

Dissidia Duodecim Final Fantasy DLC Toolkit

Hi everyone!
This is a very simple DLC Toolkit for Dissidia Duodecim: Final Fantasy!

Requirements:
- .NET Framework 4.0 (Should be compatible from Windows XP SP3 onwards)

Changelog:
- 4/4/2015  -	Version 1.1.1
    - General:
        - Bugfixes & improved stability
        - Added "Settings" menu in "File" menu
    - Character Generation tab:
        - Added Manikin costume slot
        - Added 'Manikin effects' checkbox
    - BGM Generation Tab:
        - You can now create BGM packs with ease!
    - Swap DLC Slots tab:
        - You can now change DLC slots for Player/Assist/Attachment data or BGM Data
    - .exex edit tab:
        - Minor improvements
    - Reporter tab:
        - Added support for BGM reporting
        - Removed "Export as text" button
- 1/5/2015  -	Version 1.0
    - Ported all existing code from JRuby to .NET (that's why I jumped to v1.0 :P)
    - DLC Generation tab:
        - Added Normal, Alt.1 & Alt.2 options for all characters that support them
        - Added more character-specific security checks (ex: Aerith can only use Normal, Alt.1 & Alt.2 costume slots)
    - Support for creating & linking DLC attachments
    - DLC Reporter tab:
        - Now reports .objx files' names for easier extraction
        - Minor improvements in Excel spreadsheet formatting
    - Added log file for easier bug reporting
    - Code uploaded to GitHub

Contains code from the following projects:
- SharpCompress BZip2 CRC routine: http://sharpcompress.codeplex.com/
- csharp-ArgbColorDialog: https://github.com/bvssvni/csharp-ArgbColorDialog
- EPPlus: http://epplus.codeplex.com/
