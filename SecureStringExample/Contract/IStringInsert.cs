using System.Security;
using System.ServiceModel;

namespace SecureStringExample.Contract
{
    [ServiceContract]
    public interface IStringInsert
    {
        [OperationContract]
        string GetText(string input);

        [OperationContract]
        string GetTextForSecureString(SecureString input);
    }
}
