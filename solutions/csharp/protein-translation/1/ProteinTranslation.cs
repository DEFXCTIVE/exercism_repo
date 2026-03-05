public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string> output = new List<string>();
        Dictionary<string, string> Codons = new Dictionary<string, string>();
        Codons["AUG"] = "Methionine";
        Codons["UUU"] = "Phenylalanine";
        Codons["UUC"] = "Phenylalanine";
        Codons["UUA"] = "Leucine";
        Codons["UUG"] = "Leucine";
        Codons["UCU"] = "Serine";
        Codons["UCC"] = "Serine";
        Codons["UCA"] = "Serine";
        Codons["UCG"] = "Serine";
        Codons["UAU"] = "Tyrosine";
        Codons["UAC"] = "Tyrosine";
        Codons["UGU"] = "Cysteine";
        Codons["UGC"] = "Cysteine";
        Codons["UGG"] = "Tryptophan";
        Codons["UAA"] = "STOP";
        Codons["UAG"] = "STOP";
        Codons["UGA"] = "STOP";
        int offset = 0;
        while (offset <= strand.Length-3) {
            string codon =  Codons[strand.Substring(offset,3)];
            if (codon == "STOP") break;
            output.Add(codon);
            offset+=3;
        }
        return output.ToArray();
    }
}