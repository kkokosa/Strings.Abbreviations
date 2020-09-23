namespace String.Abbreviations

module Scientific =

    let calculateCompressionRatio (abbr:string) (phrase:string) =
        decimal abbr.Length / decimal phrase.Length