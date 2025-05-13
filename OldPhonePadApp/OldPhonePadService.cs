using System.Text;

namespace OldPhonePadApp
{
    public class OldPhonePadService
    {
        private readonly Dictionary<char, string> _keyMapping = new()
        {
            { '1', "" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        /// return Decoded output text
        public string Decode(string input)
        {
            StringBuilder output = new();
            StringBuilder currentKeyPress = new();

            foreach (char c in input)
            {
                if (c == '#')
                {
                    break;
                }
                else if (c == '*')
                {
                    CommitKeyPress(currentKeyPress, output);
                    if (output.Length > 0)
                        output.Remove(output.Length - 1, 1);
                }
                else if (c == ' ')
                {
                    CommitKeyPress(currentKeyPress, output);
                }
                else
                {
                    if (currentKeyPress.Length > 0 && currentKeyPress[0] != c)
                    {
                        CommitKeyPress(currentKeyPress, output);
                    }
                    currentKeyPress.Append(c);
                }
            }

            CommitKeyPress(currentKeyPress, output);

            return output.ToString();
        }

        private void CommitKeyPress(StringBuilder keyPress, StringBuilder output)
        {
            if (keyPress.Length == 0)
                return;

            char key = keyPress[0];
            int count = keyPress.Length;

            if (_keyMapping.ContainsKey(key) && _keyMapping[key].Length > 0)
            {
                string letters = _keyMapping[key];
                char letter = letters[(count - 1) % letters.Length];
                output.Append(letter);
            }

            keyPress.Clear();
        }
    }
}
