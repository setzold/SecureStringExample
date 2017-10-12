﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecureStringServiceClient.StringInsertServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StringInsertServiceRef.IStringInsert")]
    public interface IStringInsert {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringInsert/GetText", ReplyAction="http://tempuri.org/IStringInsert/GetTextResponse")]
        string GetText(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringInsert/GetTextForSecureString", ReplyAction="http://tempuri.org/IStringInsert/GetTextForSecureStringResponse")]
        string GetTextForSecureString(System.Security.SecureString input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStringInsertChannel : SecureStringServiceClient.StringInsertServiceRef.IStringInsert, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StringInsertClient : System.ServiceModel.ClientBase<SecureStringServiceClient.StringInsertServiceRef.IStringInsert>, SecureStringServiceClient.StringInsertServiceRef.IStringInsert {
        
        public StringInsertClient() {
        }
        
        public StringInsertClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StringInsertClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StringInsertClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StringInsertClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetText(string input) {
            return base.Channel.GetText(input);
        }
        
        public string GetTextForSecureString(System.Security.SecureString input) {
            return base.Channel.GetTextForSecureString(input);
        }
    }
}