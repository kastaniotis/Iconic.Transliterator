# <img src="https://github.com/kastaniotis/Iconic.Transliterator/raw/master/Iconic.Transliterator/icon.png" style="width:35px; vertica-align:bottom;"> Transliterator

[![.NET](https://github.com/kastaniotis/Iconic.Transliterator/actions/workflows/dotnet.yml/badge.svg)](https://github.com/kastaniotis/Iconic.Transliterator/actions/workflows/dotnet.yml) 
[![GitHub tag (latest SemVer)](https://img.shields.io/github/v/tag/kastaniotis/Iconic.Transliterator?color=%2331c854&label=Version%20&sort=semver)](https://github.com/kastaniotis/Iconic.Transliterator/releases) 
[![Nuget](https://img.shields.io/nuget/v/Iconic.Transliterator)](https://www.nuget.org/packages/Iconic.Transliterator/)

A library that can help with any text transliteration, like slug creation.
It supports multiple languages and can accept new ones very easily.

Latest changes:  
V2 minimized the library's memory and cpu footprint and simplified the Conversion Classes

## Usage

You can install the library through NuGet

```
NuGet\Install-Package Iconic.Transliterator -Version 2.0.0
```

Here is a brief sample of how you can use the library

``` c#
var transliterator = new Transliterator();
transliterator.addConversion(new GreekToEnglish());

var message = "Σεβόμαστε την ιδιωτικότητά σας";
var transliterated = transliterator.convert(message);  // "Sevomaste tin idiotikotita sas"

transliterator.addConversion(new EnglishToSlug());

var slug = transliterator.convert(message); // "sevomaste-tin-idiotikotita-sas"
```

You can add all the conversions that you want. The combinations are sorted by length. Larger matches are applied first, so that smaller matches do not 
ruin larger them.

## Languages

New conversions can be added by creating a new class and implementing the IConversion Interface.

V2 simplified the Conversion classes. The combinations are now kept in a single Dictionary which is internally sorted by match length.

Combination matches should be defined in lower case. The transliterator handles capitalization automatically.

The final part of the IConversion Interface defines a general purpose transformation for the entire text. Can be used for things like ToLower() etc.

This way, we can create conversion classes to do whatever transformations we need.
For example, we could create a Profanity class, and replace all nasty words in our Profanity DB table with ******.

There are currently classes for GreekToEnglish, GermanToEnglish, CyrillicToEnglish and EnglishToSlug.
Conversion choices are not meant to be proper Romanization, but rather what would be easy to understand in social
media. 
I don't speak German or any language that uses the Cyrillic alphabet, so I can't verify the functionality or completeness of those classes. 
**Please help if you see something wrong**.
The Slug is a pseudo language that defines the replacement rules to produce proper slugs. It currently eliminates multiple spaces, replaces them with dashes, and converts everything to lower case.

## TODO:

- Add functionality to allow more complex conversions like markdown to html
