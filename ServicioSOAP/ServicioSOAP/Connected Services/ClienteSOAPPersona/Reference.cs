//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioSOAP.ClienteSOAPPersona {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apellidoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.apellidoField, value) != true)) {
                    this.apellidoField = value;
                    this.RaisePropertyChanged("apellido");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteSOAPPersona.SOAPPersonaSoap")]
    public interface SOAPPersonaSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento PrimerServicioSOAPResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PrimerServicioSOAP", ReplyAction="*")]
        ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPResponse PrimerServicioSOAP(ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PrimerServicioSOAP", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPResponse> PrimerServicioSOAPAsync(ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SegundoServicioSOAP", ReplyAction="*")]
        int SegundoServicioSOAP();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SegundoServicioSOAP", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SegundoServicioSOAPAsync();
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CuartoServicioSOAPResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CuartoServicioSOAP", ReplyAction="*")]
        ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPResponse CuartoServicioSOAP(ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CuartoServicioSOAP", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPResponse> CuartoServicioSOAPAsync(ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento QuintoServicioSOAPResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QuintoServicioSOAP", ReplyAction="*")]
        ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPResponse QuintoServicioSOAP(ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QuintoServicioSOAP", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPResponse> QuintoServicioSOAPAsync(ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PrimerServicioSOAPRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PrimerServicioSOAP", Namespace="http://tempuri.org/", Order=0)]
        public ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequestBody Body;
        
        public PrimerServicioSOAPRequest() {
        }
        
        public PrimerServicioSOAPRequest(ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class PrimerServicioSOAPRequestBody {
        
        public PrimerServicioSOAPRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PrimerServicioSOAPResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PrimerServicioSOAPResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPResponseBody Body;
        
        public PrimerServicioSOAPResponse() {
        }
        
        public PrimerServicioSOAPResponse(ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PrimerServicioSOAPResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PrimerServicioSOAPResult;
        
        public PrimerServicioSOAPResponseBody() {
        }
        
        public PrimerServicioSOAPResponseBody(string PrimerServicioSOAPResult) {
            this.PrimerServicioSOAPResult = PrimerServicioSOAPResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CuartoServicioSOAPRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CuartoServicioSOAP", Namespace="http://tempuri.org/", Order=0)]
        public ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequestBody Body;
        
        public CuartoServicioSOAPRequest() {
        }
        
        public CuartoServicioSOAPRequest(ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CuartoServicioSOAPRequestBody {
        
        public CuartoServicioSOAPRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CuartoServicioSOAPResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CuartoServicioSOAPResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPResponseBody Body;
        
        public CuartoServicioSOAPResponse() {
        }
        
        public CuartoServicioSOAPResponse(ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CuartoServicioSOAPResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CuartoServicioSOAPResult;
        
        public CuartoServicioSOAPResponseBody() {
        }
        
        public CuartoServicioSOAPResponseBody(string CuartoServicioSOAPResult) {
            this.CuartoServicioSOAPResult = CuartoServicioSOAPResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QuintoServicioSOAPRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QuintoServicioSOAP", Namespace="http://tempuri.org/", Order=0)]
        public ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequestBody Body;
        
        public QuintoServicioSOAPRequest() {
        }
        
        public QuintoServicioSOAPRequest(ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class QuintoServicioSOAPRequestBody {
        
        public QuintoServicioSOAPRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QuintoServicioSOAPResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QuintoServicioSOAPResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPResponseBody Body;
        
        public QuintoServicioSOAPResponse() {
        }
        
        public QuintoServicioSOAPResponse(ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QuintoServicioSOAPResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioSOAP.ClienteSOAPPersona.Persona QuintoServicioSOAPResult;
        
        public QuintoServicioSOAPResponseBody() {
        }
        
        public QuintoServicioSOAPResponseBody(ServicioSOAP.ClienteSOAPPersona.Persona QuintoServicioSOAPResult) {
            this.QuintoServicioSOAPResult = QuintoServicioSOAPResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SOAPPersonaSoapChannel : ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SOAPPersonaSoapClient : System.ServiceModel.ClientBase<ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap>, ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap {
        
        public SOAPPersonaSoapClient() {
        }
        
        public SOAPPersonaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SOAPPersonaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SOAPPersonaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SOAPPersonaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPResponse ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap.PrimerServicioSOAP(ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequest request) {
            return base.Channel.PrimerServicioSOAP(request);
        }
        
        public string PrimerServicioSOAP() {
            ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequest inValue = new ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequest();
            inValue.Body = new ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequestBody();
            ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPResponse retVal = ((ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap)(this)).PrimerServicioSOAP(inValue);
            return retVal.Body.PrimerServicioSOAPResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPResponse> ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap.PrimerServicioSOAPAsync(ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequest request) {
            return base.Channel.PrimerServicioSOAPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPResponse> PrimerServicioSOAPAsync() {
            ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequest inValue = new ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequest();
            inValue.Body = new ServicioSOAP.ClienteSOAPPersona.PrimerServicioSOAPRequestBody();
            return ((ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap)(this)).PrimerServicioSOAPAsync(inValue);
        }
        
        public int SegundoServicioSOAP() {
            return base.Channel.SegundoServicioSOAP();
        }
        
        public System.Threading.Tasks.Task<int> SegundoServicioSOAPAsync() {
            return base.Channel.SegundoServicioSOAPAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPResponse ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap.CuartoServicioSOAP(ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequest request) {
            return base.Channel.CuartoServicioSOAP(request);
        }
        
        public string CuartoServicioSOAP() {
            ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequest inValue = new ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequest();
            inValue.Body = new ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequestBody();
            ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPResponse retVal = ((ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap)(this)).CuartoServicioSOAP(inValue);
            return retVal.Body.CuartoServicioSOAPResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPResponse> ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap.CuartoServicioSOAPAsync(ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequest request) {
            return base.Channel.CuartoServicioSOAPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPResponse> CuartoServicioSOAPAsync() {
            ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequest inValue = new ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequest();
            inValue.Body = new ServicioSOAP.ClienteSOAPPersona.CuartoServicioSOAPRequestBody();
            return ((ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap)(this)).CuartoServicioSOAPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPResponse ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap.QuintoServicioSOAP(ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequest request) {
            return base.Channel.QuintoServicioSOAP(request);
        }
        
        public ServicioSOAP.ClienteSOAPPersona.Persona QuintoServicioSOAP() {
            ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequest inValue = new ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequest();
            inValue.Body = new ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequestBody();
            ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPResponse retVal = ((ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap)(this)).QuintoServicioSOAP(inValue);
            return retVal.Body.QuintoServicioSOAPResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPResponse> ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap.QuintoServicioSOAPAsync(ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequest request) {
            return base.Channel.QuintoServicioSOAPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPResponse> QuintoServicioSOAPAsync() {
            ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequest inValue = new ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequest();
            inValue.Body = new ServicioSOAP.ClienteSOAPPersona.QuintoServicioSOAPRequestBody();
            return ((ServicioSOAP.ClienteSOAPPersona.SOAPPersonaSoap)(this)).QuintoServicioSOAPAsync(inValue);
        }
    }
}
