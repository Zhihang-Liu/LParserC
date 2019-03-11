namespace LParserCUnitTest

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open LParserC.LParserC

[<TestClass>]
type TestClass () =
    [<TestMethod>]
    member this.TestUintParser () =
        let r = Some (createStrStream "123") |> parseUint
        Assert.AreNotEqual(None, r)

    [<TestMethod>]
    member this.TestIntParser () =
        let r = Some (createStrStream "-123") |> parseInt
        Assert.AreNotEqual(None, r)
        let r = Some (createStrStream "+123") |> parseInt
        Assert.AreNotEqual(None, r)

    [<TestMethod>]
    member this.TestFloatParser () =
        let r = Some (createStrStream "-123.456") |> parseFloat
        Assert.AreNotEqual(None, r)
        let r = Some (createStrStream "+123.456") |> parseFloat
        Assert.AreNotEqual(None, r)

    [<TestMethod>]
    member this.TestCharParser () =
        let r = Some (createStrStream "\'\\b\'") |> parseChar
        Assert.AreNotEqual(None, r)
        let r = Some (createStrStream "\'a\'") |> parseChar
        Assert.AreNotEqual(None, r)

    [<TestMethod>]
    member this.TestStringParser () =
        let r = Some (createStrStream "\"gugugu\"") |> parseChar
        Assert.AreNotEqual(None, None)
        let r = Some (createStrStream "\"ab\\cde\"") |> parseChar
        Assert.AreNotEqual(None, r)