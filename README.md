
The following table shows whether XUnit/NUnit Console.WriteLine output shows when running in various scenarios.

|                                            | XUnit | NUnit |
|--------------------------------------------|-------|-------|
| dotnet test (SDK 3.1.101, Windows)         | No    | Yes\* |
| dotnet test (SDK 3.1.101, Linux)           | Yes   | Yes\* |
| JetBrains Rider (2019.3.3 Linux & Windows) | No    | Yes   |
| VS 16.4.5 + Resharper 2019.3.3             | No    | Yes   |
| VS 16.4.5 (native test runner)             | No    | Yes   |

\* Requires NUnit3TestAdapter 3.17.0-dev-01324 and `dotnet test -v n`
