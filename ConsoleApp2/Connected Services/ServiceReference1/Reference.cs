//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransferTest1", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class TransferTest1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.TestServiceSoap")]
    public interface TestServiceSoap {
        
        // CODEGEN: Generating message contract since element name queueTestResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/queueTest", ReplyAction="*")]
        ConsoleApp2.ServiceReference1.queueTestResponse queueTest(ConsoleApp2.ServiceReference1.queueTestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/queueTest", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.queueTestResponse> queueTestAsync(ConsoleApp2.ServiceReference1.queueTestRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queueTestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queueTest", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp2.ServiceReference1.queueTestRequestBody Body;
        
        public queueTestRequest() {
        }
        
        public queueTestRequest(ConsoleApp2.ServiceReference1.queueTestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class queueTestRequestBody {
        
        public queueTestRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queueTestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queueTestResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp2.ServiceReference1.queueTestResponseBody Body;
        
        public queueTestResponse() {
        }
        
        public queueTestResponse(ConsoleApp2.ServiceReference1.queueTestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class queueTestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsoleApp2.ServiceReference1.TransferTest1[] queueTestResult;
        
        public queueTestResponseBody() {
        }
        
        public queueTestResponseBody(ConsoleApp2.ServiceReference1.TransferTest1[] queueTestResult) {
            this.queueTestResult = queueTestResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TestServiceSoapChannel : ConsoleApp2.ServiceReference1.TestServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestServiceSoapClient : System.ServiceModel.ClientBase<ConsoleApp2.ServiceReference1.TestServiceSoap>, ConsoleApp2.ServiceReference1.TestServiceSoap {
        
        public TestServiceSoapClient() {
        }
        
        public TestServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp2.ServiceReference1.queueTestResponse ConsoleApp2.ServiceReference1.TestServiceSoap.queueTest(ConsoleApp2.ServiceReference1.queueTestRequest request) {
            return base.Channel.queueTest(request);
        }
        
        public ConsoleApp2.ServiceReference1.TransferTest1[] queueTest() {
            ConsoleApp2.ServiceReference1.queueTestRequest inValue = new ConsoleApp2.ServiceReference1.queueTestRequest();
            inValue.Body = new ConsoleApp2.ServiceReference1.queueTestRequestBody();
            ConsoleApp2.ServiceReference1.queueTestResponse retVal = ((ConsoleApp2.ServiceReference1.TestServiceSoap)(this)).queueTest(inValue);
            return retVal.Body.queueTestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.queueTestResponse> ConsoleApp2.ServiceReference1.TestServiceSoap.queueTestAsync(ConsoleApp2.ServiceReference1.queueTestRequest request) {
            return base.Channel.queueTestAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.queueTestResponse> queueTestAsync() {
            ConsoleApp2.ServiceReference1.queueTestRequest inValue = new ConsoleApp2.ServiceReference1.queueTestRequest();
            inValue.Body = new ConsoleApp2.ServiceReference1.queueTestRequestBody();
            return ((ConsoleApp2.ServiceReference1.TestServiceSoap)(this)).queueTestAsync(inValue);
        }
    }
}
