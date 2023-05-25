﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEST.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISAP_XRISK")]
    public interface ISAP_XRISK {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/SaveConnection", ReplyAction="http://tempuri.org/ISAP_XRISK/SaveConnectionResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="msg")]
        string SaveConnection(string Connection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/SaveConnection", ReplyAction="http://tempuri.org/ISAP_XRISK/SaveConnectionResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="msg")]
        System.Threading.Tasks.Task<string> SaveConnectionAsync(string Connection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/GetConnection", ReplyAction="http://tempuri.org/ISAP_XRISK/GetConnectionResponse")]
        string GetConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/GetConnection", ReplyAction="http://tempuri.org/ISAP_XRISK/GetConnectionResponse")]
        System.Threading.Tasks.Task<string> GetConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/GetXmlandVersion", ReplyAction="http://tempuri.org/ISAP_XRISK/GetXmlandVersionResponse")]
        TEST.ServiceReference1.GetXmlandVersionResponse GetXmlandVersion(TEST.ServiceReference1.GetXmlandVersionRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/GetXmlandVersion", ReplyAction="http://tempuri.org/ISAP_XRISK/GetXmlandVersionResponse")]
        System.Threading.Tasks.Task<TEST.ServiceReference1.GetXmlandVersionResponse> GetXmlandVersionAsync(TEST.ServiceReference1.GetXmlandVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/addChangeTracks", ReplyAction="http://tempuri.org/ISAP_XRISK/addChangeTracksResponse")]
        bool addChangeTracks(string objcode, string start, string end, string trtype);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/addChangeTracks", ReplyAction="http://tempuri.org/ISAP_XRISK/addChangeTracksResponse")]
        System.Threading.Tasks.Task<bool> addChangeTracksAsync(string objcode, string start, string end, string trtype);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/getSchema", ReplyAction="http://tempuri.org/ISAP_XRISK/getSchemaResponse")]
        string getSchema(int VersionNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/getSchema", ReplyAction="http://tempuri.org/ISAP_XRISK/getSchemaResponse")]
        System.Threading.Tasks.Task<string> getSchemaAsync(int VersionNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/XRiskToSap", ReplyAction="http://tempuri.org/ISAP_XRISK/XRiskToSapResponse")]
        TEST.ServiceReference1.XRiskToSapResponse XRiskToSap(TEST.ServiceReference1.XRiskToSapRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISAP_XRISK/XRiskToSap", ReplyAction="http://tempuri.org/ISAP_XRISK/XRiskToSapResponse")]
        System.Threading.Tasks.Task<TEST.ServiceReference1.XRiskToSapResponse> XRiskToSapAsync(TEST.ServiceReference1.XRiskToSapRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetXmlandVersion", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetXmlandVersionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int version;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string objectCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string criteria;
        
        public GetXmlandVersionRequest() {
        }
        
        public GetXmlandVersionRequest(int version, string objectCode, string criteria) {
            this.version = version;
            this.objectCode = objectCode;
            this.criteria = criteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetXmlandVersionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetXmlandVersionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int GetXmlandVersionResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string xmlobj;
        
        public GetXmlandVersionResponse() {
        }
        
        public GetXmlandVersionResponse(int GetXmlandVersionResult, string xmlobj) {
            this.GetXmlandVersionResult = GetXmlandVersionResult;
            this.xmlobj = xmlobj;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="XRiskToSap", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class XRiskToSapRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string xml;
        
        public XRiskToSapRequest() {
        }
        
        public XRiskToSapRequest(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="XRiskToSapResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class XRiskToSapResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool XRiskToSapResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string msg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string KeyValue;
        
        public XRiskToSapResponse() {
        }
        
        public XRiskToSapResponse(bool XRiskToSapResult, string msg, string KeyValue) {
            this.XRiskToSapResult = XRiskToSapResult;
            this.msg = msg;
            this.KeyValue = KeyValue;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISAP_XRISKChannel : TEST.ServiceReference1.ISAP_XRISK, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SAP_XRISKClient : System.ServiceModel.ClientBase<TEST.ServiceReference1.ISAP_XRISK>, TEST.ServiceReference1.ISAP_XRISK {
        
        public SAP_XRISKClient() {
        }
        
        public SAP_XRISKClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SAP_XRISKClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SAP_XRISKClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SAP_XRISKClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SaveConnection(string Connection) {
            return base.Channel.SaveConnection(Connection);
        }
        
        public System.Threading.Tasks.Task<string> SaveConnectionAsync(string Connection) {
            return base.Channel.SaveConnectionAsync(Connection);
        }
        
        public string GetConnection() {
            return base.Channel.GetConnection();
        }
        
        public System.Threading.Tasks.Task<string> GetConnectionAsync() {
            return base.Channel.GetConnectionAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TEST.ServiceReference1.GetXmlandVersionResponse TEST.ServiceReference1.ISAP_XRISK.GetXmlandVersion(TEST.ServiceReference1.GetXmlandVersionRequest request) {
            return base.Channel.GetXmlandVersion(request);
        }
        
        public int GetXmlandVersion(int version, string objectCode, string criteria, out string xmlobj) {
            TEST.ServiceReference1.GetXmlandVersionRequest inValue = new TEST.ServiceReference1.GetXmlandVersionRequest();
            inValue.version = version;
            inValue.objectCode = objectCode;
            inValue.criteria = criteria;
            TEST.ServiceReference1.GetXmlandVersionResponse retVal = ((TEST.ServiceReference1.ISAP_XRISK)(this)).GetXmlandVersion(inValue);
            xmlobj = retVal.xmlobj;
            return retVal.GetXmlandVersionResult;
        }
        
        public System.Threading.Tasks.Task<TEST.ServiceReference1.GetXmlandVersionResponse> GetXmlandVersionAsync(TEST.ServiceReference1.GetXmlandVersionRequest request) {
            return base.Channel.GetXmlandVersionAsync(request);
        }
        
        public bool addChangeTracks(string objcode, string start, string end, string trtype) {
            return base.Channel.addChangeTracks(objcode, start, end, trtype);
        }
        
        public System.Threading.Tasks.Task<bool> addChangeTracksAsync(string objcode, string start, string end, string trtype) {
            return base.Channel.addChangeTracksAsync(objcode, start, end, trtype);
        }
        
        public string getSchema(int VersionNumber) {
            return base.Channel.getSchema(VersionNumber);
        }
        
        public System.Threading.Tasks.Task<string> getSchemaAsync(int VersionNumber) {
            return base.Channel.getSchemaAsync(VersionNumber);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TEST.ServiceReference1.XRiskToSapResponse TEST.ServiceReference1.ISAP_XRISK.XRiskToSap(TEST.ServiceReference1.XRiskToSapRequest request) {
            return base.Channel.XRiskToSap(request);
        }
        
        public bool XRiskToSap(string xml, out string msg, out string KeyValue) {
            TEST.ServiceReference1.XRiskToSapRequest inValue = new TEST.ServiceReference1.XRiskToSapRequest();
            inValue.xml = xml;
            TEST.ServiceReference1.XRiskToSapResponse retVal = ((TEST.ServiceReference1.ISAP_XRISK)(this)).XRiskToSap(inValue);
            msg = retVal.msg;
            KeyValue = retVal.KeyValue;
            return retVal.XRiskToSapResult;
        }
        
        public System.Threading.Tasks.Task<TEST.ServiceReference1.XRiskToSapResponse> XRiskToSapAsync(TEST.ServiceReference1.XRiskToSapRequest request) {
            return base.Channel.XRiskToSapAsync(request);
        }
    }
}