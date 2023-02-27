# Transliterator

[![.NET](https://github.com/kastaniotis/Iconic.Transliterator/actions/workflows/dotnet.yml/badge.svg)](https://github.com/kastaniotis/Iconic.Transliterator/actions/workflows/dotnet.yml) 
[![GitHub tag (latest SemVer)](https://img.shields.io/github/v/tag/kastaniotis/Iconic.Transliterator?color=%2331c854&label=Version%20&sort=semver)](https://github.com/kastaniotis/Iconic.Transliterator/releases)

A library that can help with any text transliteration, like slug creation.
It supports multiple languages and can accept new ones very easily.

Latest changes:  
Support for Cyrilic languages. **Please help me improve this conversion**

## Usage

You can install the library through NuGet

```
NuGet\Install-Package Iconic.Transliterator -Version 1.0.0
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

You can add all the conversions that you want, and they will be applied in series.

## Languages

New conversions can be added by creating a new class and implementing the ConversionInterface.
The functionality splits letters into three categories.

- Plain letters that are replaced with their corresponding latin one-to-one. For example the Greek β corresponds to b.
- Combinations of more than one letters that are pronounced differently according to what comes before or after them. 
  For example ευ is pronounced ef if it is followed by κ, and ev if it is followed by α. The combinations can be many, and you
  need to include them all, for example ευα corresponds to eva, and ευκ corresponds to efk.
- Letters that can be represented by dual latins. For example the German ä which sounds something like ae.

The reason for this distinction is that those categories have to be transliterated separately and in series 
in order to not corrupt the composite ones.

The transliterator first replaces the Combinations, then the plain letters, and finally the dual ones. That way, the combinations
are not destroyed by plain letter replacements, and the replaced Duals are not destroyed by accidental letter or combination occurances
in the already transliterated text.

Letter and combination matches should be defined in lower case. The transliterator will try to replace and maintain capitalization
of occurances that are either all lower case, all caps, or capitalized. Any weird capitalization like mid-word caps can cause weird
misses or hits.

The final part of the Conversion Interface defines a general purpose transformation for the entire text. Can be used for things like ToLower() etc.

This way, we can create conversion classes to do whatever transformations we need.
For example, we could create a Profanity class, and replace all nasty words in our Profanity DB table with ******.

There are currently classes for GreekToEnglish, GermanToEnglish and EnglishToSlug.
Conversion choices are not meant to be proper Romanization, but rather what would be easy to understand in social
media. What is usually known as Greeklish.
I don't speak German, so I can't verify the functionality or completeness of the class. I just used it as an example to test Dual letters.
**Please help if you see something wrong**.
The Slug is a pseudo language that defines the replacement rules to produce proper slugs. It currently eliminates multiple spaces, replaces them with dashes, and converts everything to lower case.

## TODO:

- Add functionality to allow more complex conversions like markdown to html
