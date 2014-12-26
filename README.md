syberside.Kooboo.CMS.Content.UserKeyGenerator.Unicode
=====================================================

This is very simple user key generator.

It uses [UnidecodeSharpFork](https://bitbucket.org/DimaStefantsov/unidecodesharpfork) by Dima Stefantsov for transliteration.

Was tested with Russian char set. Also applicable with every language, which can be safety transliterated to english unicode charset.

To use generator in your project:
 1. Clone repo.
 2. Open solution in VS.
 3. Package Manager Console will promt you to restore missing packages. Click "Restore" button.
 4. Compile project.
 5. Copy assemblies "syberside.Kooboo.CMS.Content.UserKeyGenerator.Unicode.dll" and "UnidecodeSharpFork.dll" to your KoobooCMS's "bin" folder.
 6. Restart you web site.
 7. 
 


Also awailable as [nuget package](https://www.nuget.org/packages/syberside.Kooboo.CMS.Content.UserKeyGenerator.Unicode).
