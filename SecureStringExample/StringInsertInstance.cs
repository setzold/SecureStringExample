using System.Security;
using SecureStringExample.Contract;

namespace SecureStringExample
{
    public class StringInsertInstance : IStringInsert
    {
        public string GetText(string input)
        {
            return $"The insert text was {input}.";
        }

        public string GetTextForSecureString(SecureString input)
        {
            return $"The insert (secure) text was {input}.";
        }
    }
}
