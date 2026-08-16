# ImageCompressor

A small Windows desktop app (WinForms, .NET Framework 4.8) for batch-compressing images.

Pick a set of image files, choose an output folder and a quality level, and it re-encodes
each one as JPEG at that quality, saving the result as `out-<filename>` in the output
folder. If the compressed version would end up larger than the original, the original is
copied through unchanged instead.

## Features

- Batch-select multiple images at once
- Supported input formats: `.jpg`, `.jpeg`, `.png`, `.gif`, `.tif`, `.tiff`, `.bmp`
- Adjustable JPEG quality (0-100)
- Skips compression when it wouldn't actually save space
- Progress bar for batch runs

## Building from source

Requirements:

- Windows
- Visual Studio 2019+ (or the MSBuild / Build Tools equivalent) with the
  ".NET desktop development" workload

Open `ImageCompression.sln` in Visual Studio and build, or from a Developer Command Prompt:

```
msbuild ImageCompression.sln /p:Configuration=Release /p:Platform="Any CPU"
```

The compiled app will be in `ImageCompression\bin\Release\`.

## Releases

Prebuilt binaries are published on the [Releases](../../releases) page. A new release is
built and published automatically whenever a tag matching `v*.*.*` (e.g. `v1.0.0`) is
pushed, via the workflow in `.github/workflows/release.yml`.
