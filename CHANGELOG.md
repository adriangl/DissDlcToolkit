# Changelog
All notable changes to this project will be documented in this file.
Only changes between relevant releases (aka: released to production in Google Play Store) will be listed in this document.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
### Added
- No new features!
### Changed
- No changed features!
### Deprecated
- No deprecated features!
### Removed
- No removed features!
### Fixed
- No fixed issues!
### Security
- No security issues fixed!

## [1.1.2] - 2016-2-14
### Added
- Support for high DPI screens
### Changed
- BGM DLC Generation
  - Remove 36 characters limitation in song names. Now the user will be notified that exceeding that size may not render the name properly in-game. Thanks to convalise for the suggestion!
### Fixed
- BGM DLC Generation
  - Fix bug that generated wrong names for songs with hex numbers that contained uppercase letters. Thanks to Lugia2009 & convalise for the bug report!

## [1.1.1] - 2015-4-4
### Added
- New Settings menu in the File menu
- Character DLC Generation
  - Add manikin costume slot
  - Add 'Manikin effects' checkbox
- BGM DLC Generation: create custom DLC packs!
- Swap DLC slots: change DLC slots for Player/Assist/Attachment data or BGM Data!
- DLC Reporter
  - Add support for BGM Reporting
### Removed
- DLC Reporter
  - Remove "Export as text" button

## [1.0.0] - 2015-01-05
### Added
- Create & link DLC attachments
- Add a log file for easier bug reporting
- Character DLC Generation
  - Add Normal, Alt.1 & Alt.2 options for all characters that support them
  - Add more character-specific security checks (ex: Aerith can only use Normal, Alt.1 & Alt.2 costume slots)
### Changed
- Port codebase to .NET
- DLC Reporter 
  - Report .objx files' names for easier extraction
  - Improve Excel spreadsheet formatting

[Unreleased]: https://github.com/adriangl/DissDlcToolkit/compare/1.0.70...HEAD
[1.0.70]: https://github.com/adriangl/DissDlcToolkit/compare/1.0.62...1.0.70
[1.0.62]: https://github.com/adriangl/DissDlcToolkit/compare/1.0.53...1.0.62
[1.0.53]: https://github.com/adriangl/DissDlcToolkit/compare/1.0.27...1.0.53
[1.0.27]: https://github.com/adriangl/DissDlcToolkit/compare/1.0.18...1.0.27
[1.0.18]: https://github.com/adriangl/DissDlcToolkit/compare/1.0.0...1.0.18
[1.0.0]: https://github.com/adriangl/DissDlcToolkit/compare/0.1.0...1.0.0
[0.1.0]: https://github.com/adriangl/DissDlcToolkit/releases/tag/0.1.0