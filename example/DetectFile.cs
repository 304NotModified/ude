// Udetect.cs created with MonoDevelop
//
// Author:
//    Rudi Pettazzi <rudi.pettazzi@gmail.com>
//    J. Verdurmen
//

using System;
using System.Text;
using UtfUnknown;

namespace ConsoleExample
{
    public class DetectFile
    {
        /// <summary>
        /// Command line example: detects the encoding of the given file.
        /// </summary>
        /// <param name="args">a filename</param>
        public static void Main(String[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: udetect <filename>");
                return;
            }

            string filename = args[0];

            var result = CharsetDetector.DetectFromFile(filename);

            if (result.Detected != null)
            {
                Console.WriteLine("Charset: {0}, confidence: {1}", result.Detected.EncodingName, result.Detected.Confidence);
            }
            else
            {
                Console.WriteLine("Detection failed.");
            }
        }
    }
}
