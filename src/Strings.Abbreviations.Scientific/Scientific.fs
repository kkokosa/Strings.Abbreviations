namespace String.Abbreviations

module Scientific =

    [<CompiledName("CalculateCompressionRatio")>]
    let calculateCompressionRatio (abbr:string) (phrase:string) =
        decimal abbr.Length / decimal phrase.Length