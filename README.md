# OldPhonePadApp

[![.NET Build and Test](https://github.com/neylynn/OldPhonePadApp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/neylynn/OldPhonePadApp/actions)

A C# console app simulating an old mobile phone keypad.

## Structure
- `Program.cs` : Console UI
- `OldPhonePadService.cs` : Business logic (key decoding)
- `OldPhonePadApp.Tests` : xUnit tests

## Setup

```bash
dotnet build
dotnet run --project OldPhonePadApp
