﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Funkcja1", ReplyAction="http://tempuri.org/IService1/Funkcja1Response")]
        void Funkcja1(string s1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Funkcja1", ReplyAction="http://tempuri.org/IService1/Funkcja1Response")]
        System.Threading.Tasks.Task Funkcja1Async(string s1);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/Funkcja2")]
        void Funkcja2(string s2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/Funkcja2")]
        System.Threading.Tasks.Task Funkcja2Async(string s2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Funkcja1(string s1) {
            base.Channel.Funkcja1(s1);
        }
        
        public System.Threading.Tasks.Task Funkcja1Async(string s1) {
            return base.Channel.Funkcja1Async(s1);
        }
        
        public void Funkcja2(string s2) {
            base.Channel.Funkcja2(s2);
        }
        
        public System.Threading.Tasks.Task Funkcja2Async(string s2) {
            return base.Channel.Funkcja2Async(s2);
        }
    }
}
