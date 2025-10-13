# Commit Messages by softworkz

## Commit: bef7a42fbb717033c9eabd22d79d593f4ee33b55

**Date:** 2025-10-14 00:17:05 +0200

**Subject:** Update nuke build with the following changes:

**Message:**

- Remove obsolete sample targets
- Restore and build solution (.Lean) instead of projects
- Read version from common.props, compare with latest changelog version
  and fail if not equal
- Keep PostFix separate from version (AssemblyVersion may not have
  a postfix), so the postfix will go into the package version and
  file name as well as the informational version (visible in file
  properties dialog on Windows)
- Add "ElectronNET.Core " as prefix to GitHub release names (to
  disambiguate with earlier versions)

---

## Commit: 50b49068d8e01e030e064d3db0225418a66bf81d

**Date:** 2025-10-14 00:12:05 +0200

**Subject:** Add VersionPostFix to common.props

---

## Commit: cf879042102fb4f83bd7e01307e2fdf3ff6ec39d

**Date:** 2025-10-13 23:56:14 +0200

**Subject:** Mark ElectronNET.Build as non-packable

---

## Commit: 0b05b2f5a48dbb2217903fabae95ef49dd7ece32

**Date:** 2025-10-13 23:55:46 +0200

**Subject:** Add solution ElectronNET.Lean for building core projects/packages only

---

## Commit: 1ea4c1343d7c36d58a9dd3527565521380a8234a

**Date:** 2025-10-13 23:54:56 +0200

**Subject:** Add nuke project to solution

---

## Commit: 5d5e0b848c21434fda01a2323161910790f7ce59

**Date:** 2025-10-13 21:00:38 +0200

**Subject:** Reset changelog

---

## Commit: 2d626ab319ce4d5a3efea936b1ca042b2b228108

**Date:** 2025-10-13 20:14:18 +0200

**Subject:** Reduce pinned dotnet version to 8.0.305 and rollForward to 'feature'

---

## Commit: 2e051762dd67731ec0da49579a01164746a33099

**Date:** 2025-10-13 15:23:59 +0200

**Subject:** Fix typos

---

## Commit: 96063bbe7dc6b97d5dc2ff47540bb5ed57ef0db2

**Date:** 2025-10-13 14:28:47 +0200

**Subject:** ElectronNET.Core: Update solution file

---

## Commit: 471289813a44f13fa2cb39dd1f84a2ff1b0d7b15

**Date:** 2025-10-13 14:34:43 +0200

**Subject:** Check in version 0.0.18 packages for convenient testing

---

## Commit: d0d214cd24b5be89b59089629efce33b95bdc3bb

**Date:** 2025-10-13 14:28:34 +0200

**Subject:** Introduce a common.props file, which provides version and other package metadata

**Message:**

...in a single place.

There's some special sauce for myself, but we'll find a better way
eventually, so that it can be removed.

---

## Commit: 43ce20d60fd8183a535eeac107dbab3e3eb2818f

**Date:** 2025-10-13 14:25:57 +0200

**Subject:** Add ElectronNET.ConsoleApp test project

---

## Commit: 40d6558613e5244e109fb895b37b1def6ccbabf5

**Date:** 2025-10-13 14:33:36 +0200

**Subject:** ElectronNET.WebApp: Update project file with these changes:

**Message:**

- Add a ElectronNetDevMode property at the top
  This allows switching the project between using the nuget packages
  and consuming the core code directly via project references and
  direct imports or .props and .targets files
- Add the project data which was previously in the manifest file
- Add the Microsoft.TypeScript.MSBuild package
  This overrides the ASP.Net built-in TS support which is currently
  at version 5.6 only. With this package, we get 5.9.3 everywhere, so
  everything is consistent now.
  The only caveat is that it requires exclusion of folders (especially
  node_modules), so that they don't get attempted to be compiled

---

## Commit: ae12eb49ee7ae136e8da69d6d0c34eb49f0a28b6

**Date:** 2025-10-13 14:17:02 +0200

**Subject:** ElectronNET.WebApp: Adjust startup to use new onAppReady callback

---

## Commit: 2a26b46f91b74e7071b2301ab39dcc66e0683106

**Date:** 2025-10-13 14:16:39 +0200

**Subject:** ElectronNET.WebApp: Add builder.json, launchsettings and publish profiles

---

## Commit: 78b59f62c9faac6ee1d0ae46919ecb2ab8a8979b

**Date:** 2025-10-13 14:15:47 +0200

**Subject:** ElectronNET.WebApp: Adjust controllers for API changes

---

## Commit: 667a1b290e260bc1c2d90bfa17624359310b1587

**Date:** 2025-10-13 14:15:12 +0200

**Subject:** ElectronNET.WebApp: Remove manifest file (not needed anymore)

---

## Commit: c5d9ba0e43090e7680b76fddb46163ad708bca1c

**Date:** 2025-10-13 14:14:17 +0200

**Subject:** ElectronNET.WebApp: Remove invalid property in appSettings

---

## Commit: f81424978e31df140999353d1ca77725f0ef2231

**Date:** 2025-10-13 14:13:47 +0200

**Subject:** ElectronNET.WebApp: HostHook: Make it compile properly

---

## Commit: 7fcb2f05bd9fbbae5c9d02412924f6d97aff7336

**Date:** 2025-10-13 14:12:56 +0200

**Subject:** ElectronNET.WebApp: HostHook: Add missing deps, update same like Host code

---

## Commit: 69129a6f022ea5bb5a697e84157d9238122d491f

**Date:** 2025-10-13 14:08:36 +0200

**Subject:** ElectronNET.WebApp: nav.js and demo-btns.js: Increase timeouts

**Message:**

These were too short when debugging on WSL

---

## Commit: bcde1032af9f0e235a83f73436bf7a2f2daa8f40

**Date:** 2025-10-13 13:27:25 +0200

**Subject:** ElectronNET.AspNet: Add WebApplicationBuilderExtensions (new ASP.Net builders)

---

## Commit: 3a42c479dd2deb8177f96dabb0eadb321f1ee220

**Date:** 2025-10-13 13:26:26 +0200

**Subject:** Add ElectronNET.AspNet project (ASP.Net specific runtime code)

---

## Commit: c6c73a7c8a33e46a659ea25804db265815dc13fa

**Date:** 2025-10-13 13:24:53 +0200

**Subject:** ElectronNET.API: Update project file

---

## Commit: d1db92822299e657268f5f205c71bb200e8b9706

**Date:** 2025-10-13 13:24:28 +0200

**Subject:** ElectronNET.API: Add new runtime code (for launch, lifecycle and service orchestration)

---

## Commit: b06d20450beadcf3435da8ef3028231154c8db61

**Date:** 2025-10-13 13:23:10 +0200

**Subject:** ElectronNET.API: Add ProcessRunner (for running electron from dotnet)

---

## Commit: 3811b7ea20881caa808ab25ff350cabb75366d57

**Date:** 2025-10-13 13:22:37 +0200

**Subject:** ElectronNET.API: Re-add moved types

---

## Commit: 9275f2a7654a56282b5ff71fe3d07cbb4391f74c

**Date:** 2025-10-13 13:21:35 +0200

**Subject:** ElectronNET.API: Add WebRequest API

---

## Commit: feddf5f8f47e072b860d1812c1abf98d4e5bfccd

**Date:** 2025-10-13 13:20:23 +0200

**Subject:** ElectronNET.API: Move API code to subfolder

---

## Commit: e4ce61c9655a2dbc2222fd914f65bf4eb7306000

**Date:** 2025-10-13 14:05:33 +0200

**Subject:** ElectronNET.Host: Update compiled files

---

## Commit: 1e93d91e66078425ccfc1ff39299e9cc40586472

**Date:** 2025-10-13 14:04:36 +0200

**Subject:** ElectronNET.Host: Fix TS compilation error webcontents.ts

**Message:**

The crashed event has been removed in Electron 29 - just let TS ignore
that error

---

## Commit: 77efea50ed2ed8d22ed82d4d4525d6a9220f0e0c

**Date:** 2025-10-13 14:03:13 +0200

**Subject:** ElectronNET.Host: Fix TS compilation error in tray.js

**Message:**

This probably stems from newer ts definition or the newer ts version.
It errored because it cannot determine the event name and so it
considers argv[] as empty.

---

## Commit: 5ea368bb16a5672311c16b7700080144f9759316

**Date:** 2025-10-13 13:59:20 +0200

**Subject:** ElectronNET.Host: Update main.js with these changes:

**Message:**

- Consume host-hook as a module
- Use package.json instead of electron-manifest.json
- Support new commandline flags:
  - unpackedelectron
    running in debug mode, electron first, so must launch dotnet
  - unpackeddotnet
    running in debug mode, dotnet first, do not launch dotnet
  - dotnetpacked
    running from electron-builder output, dotnet first, do not launch
  - {none of the above flags}
    running from electron-builder output, electron first, launch dotnet
  - electronforcedport
    specified by dotnet when dotnet-first, port is validated to be free
- Removed 'watch' functionality (regular debugging is working now)
- New feature to load a custom_main.js file, if present
- Removed the 'electronWebPort' handling
  When ASP.Net is launched first, then the information which port it
  should use would be coming too late; anyway, there's no need for
  letting the port number round-trip all the way through the manifest
  file, loaded by main.js and then sent to dotnet.
- Reworked handling of 'quit' message

---

## Commit: 0dca0e90f9dc64a22ebdb81bbbf685da2597a46f

**Date:** 2025-10-13 13:16:10 +0200

**Subject:** ElectronNET.Host: Update build configuration - changes:

**Message:**

- Update all packages to their latest version
- Drop tslint (replaced by eslint)
- Update node types to 22 => nodejs => 22 is minimum now
- Also use latest TypeScript version
- Finally, reference ElectronHostHook has a package dependency
  this avoids conflicts of dependency versions between main code
  and host-hook code, by letting npm resolve them

---

## Commit: c0c3aaebdced3cdb173dc0e76eab143753eaf008

**Date:** 2025-10-13 13:08:17 +0200

**Subject:** ElectronNET.Host: Remove build-helper and manifest (no longer needed)

---

## Commit: 14722e1f639f1be6ee1668f488dcd6431bf6012a

**Date:** 2025-10-13 13:06:50 +0200

**Subject:** Remove ElectronNET.CLI project

---

## Commit: d6e39fef24b78da6c7ef2a830cf460ec8f0f9c88

**Date:** 2025-10-13 13:06:20 +0200

**Subject:** Add ElectronNET.Build project (dll with custom MSBuild tasks)

---

## Commit: 74b80b31771a045ac3d6f3ee8142787710956379

**Date:** 2025-10-13 13:05:34 +0200

**Subject:** Add ElectronNET project (all build functionality)

---

## Commit: 0f3f29eae340e644447cf43890f0db040a7a80bd

**Date:** 2025-10-13 13:04:24 +0200

**Subject:** global.json: Pin .net SDK

---

## Commit: f634dc45ed93f83cb2acd21cd278753ab4b2c59c

**Date:** 2025-10-13 13:03:53 +0200

**Subject:** Update NuGet.config

---

## Commit: c6b9de2afa608b39668b89b4c708b56d458ccbd1

**Date:** 2025-10-13 13:03:36 +0200

**Subject:** Update .gitignore

---

## Commit: 73a3e331dc670c20ba24bac3010d798e96bee234

**Date:** 2023-09-24 16:36:49 +0200

**Subject:** Add  executeJavaScript method to WebContents

---

## Commit: a15db713ad092ea5627985caadfec3b63305c7de

**Date:** 2023-09-24 16:36:41 +0200

**Subject:** Add dom-ready event for WebContents

---

