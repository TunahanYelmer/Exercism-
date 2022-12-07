using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
public static class CryptoSquare
{
    public static string NormalizedPlaintext(string plaintext)
    {
        return plaintext.ToLower().ReplaceX(@"[^\w\s]|\s", string.Empty).Trim();
    }
    public static IEnumerable<string> PlaintextSegments(string plaintext)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
    public static string Encoded(string plaintext)
    {
        var len = plaintext.Length;
        var rowCnt = (int)Math.Sqrt(len);
        var colCnt = (rowCnt * rowCnt >= len) ? rowCnt : rowCnt + 1;
        rowCnt = (rowCnt * colCnt < len) ? rowCnt + 1 : rowCnt;
        /*
            len    r   r*r>len   c  init(r,c)   r*c>len   r + 1   (r,c)  enough?
         *            
         *    9    3        O    3
         *   54    7        X    8         56      O
         *    8    2        X    3  (2,3) = 6      X         3     (3,3)   O
         * 
         * */
        var square = plaintext.PadRight(rowCnt * colCnt, ' '); /* fill as a square length */
        var encodeStr = new StringBuilder();
        for (var sCol = 0; sCol < colCnt; sCol++)
        {
            for (var sRow = 0; sRow < rowCnt; sRow++)
            {
                encodeStr.Append(square[sCol + sRow * colCnt]);
            }
            encodeStr.Append(' ');
        }
        return encodeStr.ToString().Remove(encodeStr.Length - 1);
    }
    public static string Ciphertext(string plaintext)
    {
        if (plaintext.Length == 0)
        {
            return string.Empty;
        }
        var rResult = NormalizedPlaintext(plaintext);
        if (rResult.Length == 1)
        {
            return rResult;
        }
        var sb = Encoded(rResult);
        return sb;
    }
    private static string ReplaceX(this string text, string pattern, string replacement)
    {
        return Regex.Replace(text, pattern, replacement);
    }
}