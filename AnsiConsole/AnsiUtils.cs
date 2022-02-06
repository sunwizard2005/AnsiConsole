using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AnsiConsole
{
    public static class AnsiUtils
    {
        private static string escape = "\u001b";
        private static string beep = "\u0007";

        private static SortedDictionary<string, string> codes = new SortedDictionary<string, string>
        {
            // basic codes
            { "normal", "e[0m" },
            { "beep", "b" },
            { "null", "" },

            // ansi foregrounds
            { "black", "e[30m" },
            { "gray", "e[1;30m" },
            { "grey", "e[1;30m" },
            { "red", "e[31m" },
            { "green", "e[32m" },
            { "yellow", "e[33m" },
            { "blue", "e[34m" },
            { "purple", "e[35m" },
            { "magenta", "e[35m" },
            { "cyan", "e[36m" },
            { "white", "e[37m" },
            { "random", "" },

            // ansi backgrounds
            { "bgblack", "e[40m" },
            { "bgred", "e[41m" },
            { "bggreen", "e[42m" },
            { "bgyellow", "e[43m" },
            { "bgblue", "e[44m" },
            { "bgpurple", "e[45m" },
            { "bgmagenta", "e[45m" },
            { "bgcyan", "e[46m" },
            { "bggray", "e[47m" },
            { "bgwhite", "e[47m" },
            { "bggrey", "e[47m" },

            // bold codes
            { "bold", "e[1m" },
            { "unbold", "e[22m" },
            { "bright", "e[1m" },
            { "unbright", "e[22m" },

            // blink codes
            { "blink", "e[5m" },
            { "unblink", "e[25m" },

            // font attributes
            { "inverse", "e[7m" },
            { "underline", "e[4m" },

            // 8-bit grayscale
            { "gray00", "e[38;5;232m" },
            { "gray01", "e[38;5;233m" },
            { "gray02", "e[38;5;234m" },
            { "gray03", "e[38;5;235m" },
            { "gray04", "e[38;5;236m" },
            { "gray05", "e[38;5;237m" },
            { "gray06", "e[38;5;238m" },
            { "gray07", "e[38;5;239m" },
            { "gray08", "e[38;5;240m" },
            { "gray09", "e[38;5;241m" },
            { "gray10", "e[38;5;242m" },
            { "gray11", "e[38;5;243m" },
            { "gray12", "e[38;5;244m" },
            { "gray13", "e[38;5;245m" },
            { "gray14", "e[38;5;246m" },
            { "gray15", "e[38;5;247m" },
            { "gray16", "e[38;5;248m" },
            { "gray17", "e[38;5;249m" },
            { "gray18", "e[38;5;250m" },
            { "gray19", "e[38;5;251m" },
            { "gray20", "e[38;5;252m" },
            { "gray21", "e[38;5;253m" },
            { "gray22", "e[38;5;254m" },
            { "gray23", "e[38;5;255m" },
            { "grey00", "e[38;5;232m" },
            { "grey01", "e[38;5;233m" },
            { "grey02", "e[38;5;234m" },
            { "grey03", "e[38;5;235m" },
            { "grey04", "e[38;5;236m" },
            { "grey05", "e[38;5;237m" },
            { "grey06", "e[38;5;238m" },
            { "grey07", "e[38;5;239m" },
            { "grey08", "e[38;5;240m" },
            { "grey09", "e[38;5;241m" },
            { "grey10", "e[38;5;242m" },
            { "grey11", "e[38;5;243m" },
            { "grey12", "e[38;5;244m" },
            { "grey13", "e[38;5;245m" },
            { "grey14", "e[38;5;246m" },
            { "grey15", "e[38;5;247m" },
            { "grey16", "e[38;5;248m" },
            { "grey17", "e[38;5;249m" },
            { "grey18", "e[38;5;250m" },
            { "grey19", "e[38;5;251m" },
            { "grey20", "e[38;5;252m" },
            { "grey21", "e[38;5;253m" },
            { "grey22", "e[38;5;254m" },
            { "grey23", "e[38;5;255m" },

            // background grayscale
            { "bggray00", "e[48;5;232m" },
            { "bggray01", "e[48;5;233m" },
            { "bggray02", "e[48;5;234m" },
            { "bggray03", "e[48;5;235m" },
            { "bggray04", "e[48;5;236m" },
            { "bggray05", "e[48;5;237m" },
            { "bggray06", "e[48;5;238m" },
            { "bggray07", "e[48;5;239m" },
            { "bggray08", "e[48;5;240m" },
            { "bggray09", "e[48;5;241m" },
            { "bggray10", "e[48;5;242m" },
            { "bggray11", "e[48;5;243m" },
            { "bggray12", "e[48;5;244m" },
            { "bggray13", "e[48;5;245m" },
            { "bggray14", "e[48;5;246m" },
            { "bggray15", "e[48;5;247m" },
            { "bggray16", "e[48;5;248m" },
            { "bggray17", "e[48;5;249m" },
            { "bggray18", "e[48;5;250m" },
            { "bggray19", "e[48;5;251m" },
            { "bggray20", "e[48;5;252m" },
            { "bggray21", "e[48;5;253m" },
            { "bggray22", "e[48;5;254m" },
            { "bggray23", "e[48;5;255m" },
            { "bggrey00", "e[48;5;232m" },
            { "bggrey01", "e[48;5;233m" },
            { "bggrey02", "e[48;5;234m" },
            { "bggrey03", "e[48;5;235m" },
            { "bggrey04", "e[48;5;236m" },
            { "bggrey05", "e[48;5;237m" },
            { "bggrey06", "e[48;5;238m" },
            { "bggrey07", "e[48;5;239m" },
            { "bggrey08", "e[48;5;240m" },
            { "bggrey09", "e[48;5;241m" },
            { "bggrey10", "e[48;5;242m" },
            { "bggrey11", "e[48;5;243m" },
            { "bggrey12", "e[48;5;244m" },
            { "bggrey13", "e[48;5;245m" },
            { "bggrey14", "e[48;5;246m" },
            { "bggrey15", "e[48;5;247m" },
            { "bggrey16", "e[48;5;248m" },
            { "bggrey17", "e[48;5;249m" },
            { "bggrey18", "e[48;5;250m" },
            { "bggrey19", "e[48;5;251m" },
            { "bggrey20", "e[48;5;252m" },
            { "bggrey21", "e[48;5;253m" },
            { "bggrey22", "e[48;5;254m" },
            { "bggrey23", "e[48;5;255m" }
        };

        // optimization to not retry not-found codes
        private static SortedSet<string> notFound = new SortedSet<string>();

        static AnsiUtils()
        {
            SortedDictionary<string, string> newCodes = new SortedDictionary<string, string>();
            // fixup shorthand replacements above
            foreach (KeyValuePair<string, string> kv in codes)
            {
                newCodes[kv.Key] = kv.Value.Replace("e", escape).Replace("b", beep);
            }
            codes = newCodes;
        }

        public static AnsiRender AnsiRender { get; set; } = AnsiRender.Interpret;
        public static string CodePrefix { get; set; } = "[";
        public static string CodeSuffix { get; set; } = "]";

        public static char[] TransformAnsi(this char[] buffer)
        {
            string s = new string(buffer);
            return s.TransformAnsi().ToCharArray();
        }

        public static char[] TransformAnsi(this char[] buffer, int index, int count)
        {
            string s = new string(buffer, index, count);
            return s.TransformAnsi().ToCharArray();
        }

        public static object TransformAnsi(this object obj)
        {
            if (obj is string @string) return @string.TransformAnsi();
            if (obj is char[] charArr) return charArr.TransformAnsi();
            return obj;
        }

        public static string TransformAnsi(string format, object arg0) => string.Format(format, arg0).TransformAnsi();
        public static string TransformAnsi(string format, object arg0, object arg1) => string.Format(format, arg0, arg1).TransformAnsi();
        public static string TransformAnsi(string format, object arg0, object arg1, object arg2) => string.Format(format, arg0, arg1, arg2).TransformAnsi();
        public static string TransformAnsi(string format, params object[] arg) => string.Format(format, arg).TransformAnsi();

        public static string TransformAnsi(this string str)
        {
            return ProcessAnsi(str, AnsiRender);
        }

        public static string RemoveAnsi(this string str)
        {
            return ProcessAnsi(str, AnsiRender.Remove);
        }

        private static string ProcessAnsi(string str, AnsiRender render)
        {
            // don't try to process if ignoring codes
            if (render == AnsiRender.Ignore) return str;

            StringBuilder builder = new StringBuilder();
            int s = 0;

            do
            {

                int i = str.IndexOf(CodePrefix, s);
                int j = str.IndexOf(CodePrefix, i + 1);
                int k = str.IndexOf(CodeSuffix, i + 1);

                while (j < k && j > -1)
                {
                    i = j;
                    j = str.IndexOf(CodePrefix, i + 1);
                }

                // divide into 3 spans
                string preCode = string.Empty;
                string code = string.Empty;
                // postCode is everything after code, if anything, and processed on next loop
                if (i >= s && k > i && i != k - 1)
                {
                    if (i > s) preCode = str[s..i];
                    code = str[(i + 1)..k];

                    s = k + 1;

                    if (RetrieveAnsiCode(code, out string ansiCode))
                    {
                        builder.Append(preCode);
                        builder.Append(ansiCode);
                    }
                    else
                    {
                        builder.Append(str[s..k]);
                    }
                }
                else
                {
                    builder.Append(str[s..^0]);
                    break;
                }
            } while (s < str.Length);

            return builder.ToString();
        }

        private static bool RetrieveAnsiCode(string code, out string ansiCode)
        {
            ansiCode = null;
            if (codes.TryGetValue(code, out ansiCode)) return true;
            if (notFound.Contains(code)) return false;

            byte r, g, b;
            bool isForegroundColor;

            var hicolor = code.Split(":");
            isForegroundColor = hicolor[0].ToLower() != "bg";

            if (hicolor.Length == 4 && hicolor[0].Length == 2)
            {
                if (hicolor[1].Length == 1 && hicolor[2].Length == 1 && hicolor[3].Length == 1)
                {
                    try
                    {
                        // 8-bit
                        var r8 = byte.Parse(hicolor[1]);
                        var g8 = byte.Parse(hicolor[2]);
                        var b8 = byte.Parse(hicolor[3]);

                        ansiCode = $"{escape}[{(isForegroundColor ? 38 : 48)};5;{16 + 36 * r8 + 6 * g8 + b8}m";
                        codes[code] = ansiCode;
                        return true;
                    }
                    catch
                    {
                        notFound.Add(code);
                        return false;
                    }
                }

                // 24-bit
                try
                {
                    r = Convert.ToByte(hicolor[1], 16);
                    g = Convert.ToByte(hicolor[2], 16);
                    b = Convert.ToByte(hicolor[3], 16);
                }
                catch
                {
                    notFound.Add(code);
                    return false;
                }
            }
            else
            if (hicolor.Length > 2 || (hicolor.Length > 1 && hicolor[0] != "fg" && hicolor[0] != "bg"))
            {
                notFound.Add(code);
                return false;
            }
            else
            {
                string colorName = hicolor[^1];

                var type = typeof(Color);
                var prop = type?.GetProperty(colorName, typeof(Color));

                if (prop == null)
                {
                    notFound.Add(code);
                    return false;
                }

                Color color = (Color)prop.GetValue(null);

                if (color.A != 0xFF)
                {
                    notFound.Add(code);
                    return false;
                }

                r = color.R;
                g = color.G;
                b = color.B;
            }

            ansiCode = $"{escape}[{(isForegroundColor ? 38 : 48)};2;{r};{g};{b}m";

            codes[code] = ansiCode;
            return true;
        }
    }

    public enum AnsiRender
    {
        Interpret,
        Ignore,
        Remove
    }
}