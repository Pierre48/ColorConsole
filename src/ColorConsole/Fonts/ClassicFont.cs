using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ColorConsole.Fonts
{
    public class ClassicFont : Font
    {
        #region Static definition

        static string definitionTxt = " !abcdefghijklmnopqrstuvwxyz";
        /// <summary>
        /// from http://patorjk.com
        /// </summary>
        static string definitionString =
@"   " + Environment.NewLine +
@"   " + Environment.NewLine +
@"   " + Environment.NewLine +
@"   " + Environment.NewLine +
@"   " + Environment.NewLine +
@"   " + Environment.NewLine +
@"   " + Environment.NewLine +
@"   " + Environment.NewLine +

@" _ " + Environment.NewLine +
@"| |" + Environment.NewLine +
@"| |" + Environment.NewLine +
@"| |" + Environment.NewLine +
@"|_|" + Environment.NewLine +
@"(_)" + Environment.NewLine +
@"   " + Environment.NewLine +
@"   " + Environment.NewLine +

@"       " + Environment.NewLine + 
@"       " + Environment.NewLine+ 
@"  __ _ " + Environment.NewLine+ 
@" / _` |" + Environment.NewLine+ 
@"| (_| |" + Environment.NewLine+ 
@" \__,_|" + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 

@" _     " + Environment.NewLine+ 
@"| |    " + Environment.NewLine+ 
@"| |__  " + Environment.NewLine+ 
@"| '_ \ " + Environment.NewLine+ 
@"| |_) |" + Environment.NewLine+ 
@"|_.__/ " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+
            
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"  ___  " + Environment.NewLine+ 
@" / __| " + Environment.NewLine+ 
@"| (__  " + Environment.NewLine+ 
@" \___| " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 

@"     _ " + Environment.NewLine+ 
@"    | |" + Environment.NewLine+ 
@"  __| |" + Environment.NewLine+ 
@" / _` |" + Environment.NewLine+ 
@"| (_| |" + Environment.NewLine+ 
@" \__,_|" + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+
            
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"  ___  " + Environment.NewLine+ 
@" / _ \ " + Environment.NewLine+ 
@"|  __/ " + Environment.NewLine+ 
@" \___| " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+
            
@"  __   " + Environment.NewLine+ 
@" / _|  " + Environment.NewLine+ 
@"| |_   " + Environment.NewLine+ 
@"|  _|  " + Environment.NewLine+ 
@"| |    " + Environment.NewLine+ 
@"|_|    " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 

@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"  __ _ " + Environment.NewLine+ 
@" / _` |" + Environment.NewLine+ 
@"| (_| |" + Environment.NewLine+ 
@" \__, |" + Environment.NewLine+ 
@"  __/ |" + Environment.NewLine+ 
@" |___/ " + Environment.NewLine+
            
@" _     " + Environment.NewLine+ 
@"| |    " + Environment.NewLine+ 
@"| |__  " + Environment.NewLine+ 
@"| '_ \ " + Environment.NewLine+ 
@"| | | |" + Environment.NewLine+ 
@"|_| |_|" + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 

@" _ " + Environment.NewLine+ 
@"(_)" + Environment.NewLine+ 
@" _ " + Environment.NewLine+ 
@"| |" + Environment.NewLine+ 
@"| |" + Environment.NewLine+ 
@"|_|" + Environment.NewLine+ 
@"   " + Environment.NewLine+ 
@"   " + Environment.NewLine+
            
@"   _ " + Environment.NewLine+ 
@"  (_)" + Environment.NewLine+ 
@"   _ " + Environment.NewLine+ 
@"  | |" + Environment.NewLine+ 
@"  | |" + Environment.NewLine+ 
@"  | |" + Environment.NewLine+ 
@" _/ |" + Environment.NewLine+ 
@"|__/ " + Environment.NewLine+ 

@" _     " + Environment.NewLine+ 
@"| |    " + Environment.NewLine+ 
@"| | __ " + Environment.NewLine+ 
@"| |/ / " + Environment.NewLine+ 
@"|   <  " + Environment.NewLine+ 
@"|_|\_\ " + Environment.NewLine+ 
@"       " + Environment.NewLine+ 
@"       " + Environment.NewLine+
            
@" _ " + Environment.NewLine+ 
@"| |" + Environment.NewLine+ 
@"| |" + Environment.NewLine+ 
@"| |" + Environment.NewLine+ 
@"| |" + Environment.NewLine+ 
@"|_|" + Environment.NewLine+ 
@"   " + Environment.NewLine+ 
@"   " + Environment.NewLine+ 

@"           " + Environment.NewLine +
@"           " + Environment.NewLine+
@" _ __ ___  " + Environment.NewLine+
@"| '_ ` _ \ " + Environment.NewLine+
@"| | | | | |" + Environment.NewLine+
@"|_| |_| |_|" + Environment.NewLine+
@"           " + Environment.NewLine+
@"           " + Environment.NewLine+

@"        " + Environment.NewLine+
@"        " + Environment.NewLine+
@" _ __   " + Environment.NewLine+
@"| '_ \  " + Environment.NewLine+
@"| | | | " + Environment.NewLine+
@"|_| |_| " + Environment.NewLine+
@"        " + Environment.NewLine+
@"        " + Environment.NewLine+

@"       " + Environment.NewLine+
@"       " + Environment.NewLine+
@"  ___  " + Environment.NewLine+
@" / _ \ " + Environment.NewLine+
@"| (_) |" + Environment.NewLine+
@" \___/ " + Environment.NewLine+
@"       " + Environment.NewLine+
@"       " + Environment.NewLine+

@"        " + Environment.NewLine+
@"        " + Environment.NewLine+
@" _ __   " + Environment.NewLine+
@"| '_ \  " + Environment.NewLine+
@"| |_) | " + Environment.NewLine+
@"| .__/  " + Environment.NewLine+
@"| |     " + Environment.NewLine+
@"|_|     " + Environment.NewLine+

@"        " + Environment.NewLine+
@"        " + Environment.NewLine+
@"  __ _  " + Environment.NewLine+
@" / _` | " + Environment.NewLine+
@"| (_| | " + Environment.NewLine+
@" \__, | " + Environment.NewLine+
@"    | | " + Environment.NewLine+
@"    |_| " + Environment.NewLine+

@"      " + Environment.NewLine+
@"      " + Environment.NewLine+
@" _ __ " + Environment.NewLine+
@"| '__|" + Environment.NewLine+
@"| |   " + Environment.NewLine+
@"|_|   " + Environment.NewLine+
@"      " + Environment.NewLine+
@"      " + Environment.NewLine+

@"        " + Environment.NewLine+
@"        " + Environment.NewLine+
@" ___    " + Environment.NewLine+
@"/ __|   " + Environment.NewLine+
@"\__ \   " + Environment.NewLine+
@"|___/   " + Environment.NewLine+
@"        " + Environment.NewLine+
@"        " + Environment.NewLine+
@" _   " + Environment.NewLine+
@"| |  " + Environment.NewLine+
@"| |_ " + Environment.NewLine+
@"| __|" + Environment.NewLine+
@"| |_ " + Environment.NewLine+
@" \__|" + Environment.NewLine+
@"     " + Environment.NewLine+
@"     " + Environment.NewLine+
@"       " + Environment.NewLine+
@"       " + Environment.NewLine+
@" _ _   " + Environment.NewLine+
@"| | | |" + Environment.NewLine+
@"| |_| |" + Environment.NewLine+
@" \__,_|" + Environment.NewLine+
@"       " + Environment.NewLine+
@"       " + Environment.NewLine+
@"        " + Environment.NewLine+
@"        " + Environment.NewLine+
@"__ __   " + Environment.NewLine+
@"\ \ / / " + Environment.NewLine+
@" \ V /  " + Environment.NewLine+
@"  \_/   " + Environment.NewLine+
@"        " + Environment.NewLine+
@"        " + Environment.NewLine+
@"           " + Environment.NewLine +
@"           " + Environment.NewLine +
@"__      __ "+ Environment.NewLine+
@"\ \ /\ / / "+ Environment.NewLine+
@" \ V V  /  "+ Environment.NewLine+
@"  \_/\_/   "+ Environment.NewLine+
@"           "+ Environment.NewLine+
@"           "+ Environment.NewLine+
@"       " + Environment.NewLine +
@"       " + Environment.NewLine+
@"__ __  " + Environment.NewLine+
@"\ \/ / " + Environment.NewLine+
@" >  <  " + Environment.NewLine+
@"/_/\_\ " + Environment.NewLine+
@"       " + Environment.NewLine+
@"       " + Environment.NewLine+
@"       " + Environment.NewLine+
@"       " + Environment.NewLine+
@" _   _ " + Environment.NewLine+
@"| | | |" + Environment.NewLine+
@"| |_| |" + Environment.NewLine+
@" \__, |" + Environment.NewLine+
@"  __/ |" + Environment.NewLine+
@" |___/ " + Environment.NewLine+
@"      " + Environment.NewLine+
@"      " + Environment.NewLine+
@" ____ " + Environment.NewLine+
@"|_  / " + Environment.NewLine+
@" / /  " + Environment.NewLine+
@"/___| " + Environment.NewLine+
@"      " + Environment.NewLine+
@"      ";
        static Dictionary<char, List<string>> _dico = new Dictionary<char, List<string>> () ;
        static  ClassicFont()
        {
            StringReader strReader = new StringReader(definitionString);
            foreach (var c in definitionTxt)
            {
                var ascii = new List<string> { "", "", "", "", "", "", "", "" };
                ascii[0] += strReader.ReadLine();
                ascii[1] += strReader.ReadLine();
                ascii[2] += strReader.ReadLine();
                ascii[3] += strReader.ReadLine();
                ascii[4] += strReader.ReadLine();
                ascii[5] += strReader.ReadLine();
                ascii[6] += strReader.ReadLine();
                ascii[7] += strReader.ReadLine();
                _dico.Add(c, ascii);
            }
        }
        #endregion

        public override string Convert(string str, FontDefinition fontDefinition)
        {

            var ascii = new List<string>()
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            };

            foreach (var c in str.ToLower())
            {
                if (_dico.ContainsKey(c))
                {
                    ascii[0] += _dico[c][0] + " ";
                    ascii[1] += _dico[c][1] + " ";
                    ascii[2] += _dico[c][2] + " ";
                    ascii[3] += _dico[c][3] + " ";
                    ascii[4] += _dico[c][4] + " ";
                    ascii[5] += _dico[c][5] + " ";
                    ascii[6] += _dico[c][6] + " ";
                    ascii[7] += _dico[c][7] + " ";
                }
            }

            return ascii[0] + Environment.NewLine +
               ascii[1] + Environment.NewLine +
               ascii[2] + Environment.NewLine +
               ascii[3] + Environment.NewLine +
               ascii[4] + Environment.NewLine +
               ascii[5] + Environment.NewLine +
               ascii[6] + Environment.NewLine +
               ascii[7] + Environment.NewLine;
        }
    }
}
