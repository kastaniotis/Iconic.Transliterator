using Iconic.Transliterator;
using Iconic.Transliterator.Conversion;
using System.Diagnostics;

string toBeConverted = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία ";
toBeConverted = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία ";
//toBeConverted = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία ";
//toBeConverted = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία ";

var watch = Stopwatch.StartNew();
var converter2 = new Transliterator();
watch.Stop();
Console.WriteLine($"Initiated converter: {watch.Elapsed.Ticks}ns");
watch.Restart();
converter2.AddConversions(new GreekToEnglish());
watch.Stop();
Console.WriteLine($"Added Greeklish: {watch.Elapsed.Ticks}ns");
watch.Restart();
converter2.AddConversions(new EnglishToSlug());
watch.Stop();
Console.WriteLine($"Added Slug: {watch.Elapsed.Ticks}ns");
watch.Restart();
string greeklish3 = converter2.Convert(toBeConverted);
watch.Stop();
Console.WriteLine($"converted {toBeConverted} to {greeklish3}: {watch.Elapsed.Ticks}ns");