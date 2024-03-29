![Build and test](https://github.com/kkokosa/Strings.Abbreviations/workflows/Build%20and%20test/badge.svg)
[![NuGet](https://img.shields.io/nuget/v/Strings.Abbreviations)](https://www.nuget.org/packages/Strings.Abbreviations/)
[![Downloads](https://img.shields.io/nuget/dt/Strings.Abbreviations)](https://www.nuget.org/packages/Strings.Abbreviations/)
[![Stars](https://img.shields.io/github/stars/kkokosa/Strings.Abbreviations)](https://github.com/kkokosa/Strings.Abbreviations/stargazers)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md)

# Strings.Abbreviations

A set of predefined static methods for popular abbreviations. While this is (barely) useful by itself, it mostly serves as:
* playground for fresh open source contributors
* **Minimum Viable Product** and **set of best practices** for creating your own library that is automatically tested/versioned and published as a NuGet package
  * it should not contain things not really needed to make such MVP, especially on the workflows level
  * workflows should be as clean as possible to serve as a starting point when creating a new .NET library

We will see where it will brings us with the contributions!

## Usage

This is just a bunch of static method that return an interned abbreviation equivalents, like:

```cs
Console.WriteLine(Strings.BRB());
```

will print:

```
Be right back
```

An additional option is to use "title casing":

```cs
Console.WriteLine(Strings.BRB(titleCase: true));
```

will print:

```
Be Right Back
```

If you want to know how much you gain using the abbreviation, we've got you covered.
You can calculate the ratio between the abbreviation and the actual phrase like so:

```cs
Strings.GetCompressionRatio("BRB", Strings.BRB());
```

## Currently supported abbreviations

* BRB - "Be right back"
* IMHO - "In my humble oppinion"
* LMAO - "Laughing my ass off"
* ROTFL - "Rolling on the floor laughing"
* AMA - "Ask me anything"
* YOLO - "You only live once"
* LGTM - "Looks good to me"
* TFW - "That feel when"

## CI/CD process

`Strings.Abbreviations` is build, tested and published as a NuGet package with the use of [Github Actions](https://github.com/features/actions). They implement a minimum set of desirable features from the library author point of view.

Currently there are two "pipelines" defined:
* [building and testing](.github/workflows/build-and-test.yml) - every push and PR to `master` will trigger building and unit testing the whole repository. Thanks to that the result of the tests are available as an additional PR check. And we have a "badge" available on the top of this file.
* [building and publishing a NuGet package](.github/workflows/publish-nuget.yml) - every push to `master` **that bumps up `Version` in the `csproj` file** will trigger building and publishing a new NuGet package. Additionally, a new git tag will be added with the same version. It uses [Publish NuGet custom Github Action](https://github.com/marketplace/actions/publish-nuget)
* [creating a release](.github/workflows/create-release.yml) - after a new tag (with version) has been pushed in the `publish-nuget.yml` workflow, this one will create a new release with this version

## How to contribute?

Your contributions to this library is more than welcome. This is a playground, we need to keep the logic working, but feel free to suggest any new features (I count on your creativity!) or fix any bugs (unlikely there are any!). Or, if you would like to help with already reported bugs or features, check out the [list of issues](https://github.com/kkokosa/String.Abbreviations/issues) and grab one.
