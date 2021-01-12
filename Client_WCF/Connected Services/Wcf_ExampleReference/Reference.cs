﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_WCF.Wcf_ExampleReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Wcf_ExampleReference.IEmailService")]
    public interface IEmailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/ValidateEmail", ReplyAction="http://tempuri.org/IEmailService/ValidateEmailResponse")]
        bool ValidateEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/ValidateEmail", ReplyAction="http://tempuri.org/IEmailService/ValidateEmailResponse")]
        System.Threading.Tasks.Task<bool> ValidateEmailAsync(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailServiceChannel : Client_WCF.Wcf_ExampleReference.IEmailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailServiceClient : System.ServiceModel.ClientBase<Client_WCF.Wcf_ExampleReference.IEmailService>, Client_WCF.Wcf_ExampleReference.IEmailService {
        
        public EmailServiceClient() {
        }
        
        public EmailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ValidateEmail(string email) {
            return base.Channel.ValidateEmail(email);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateEmailAsync(string email) {
            return base.Channel.ValidateEmailAsync(email);
        }
    }
}
