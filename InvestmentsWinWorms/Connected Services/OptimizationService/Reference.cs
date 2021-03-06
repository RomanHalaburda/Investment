﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvestmentsWinWorms.OptimizationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OptimizationService.IOptimizationService")]
    public interface IOptimizationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOptimizationService/DoSimplex", ReplyAction="http://tempuri.org/IOptimizationService/DoSimplexResponse")]
        double[] DoSimplex(double _sum, double _ratio, double _divA, double _divB, double _limA, double _limB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOptimizationService/DoSimplex", ReplyAction="http://tempuri.org/IOptimizationService/DoSimplexResponse")]
        System.Threading.Tasks.Task<double[]> DoSimplexAsync(double _sum, double _ratio, double _divA, double _divB, double _limA, double _limB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOptimizationService/DoBionic", ReplyAction="http://tempuri.org/IOptimizationService/DoBionicResponse")]
        double[] DoBionic(int N, int G, double _sum, double _ratio, double _divA, double _divB, double _limA, double _limB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOptimizationService/DoBionic", ReplyAction="http://tempuri.org/IOptimizationService/DoBionicResponse")]
        System.Threading.Tasks.Task<double[]> DoBionicAsync(int N, int G, double _sum, double _ratio, double _divA, double _divB, double _limA, double _limB);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOptimizationServiceChannel : InvestmentsWinWorms.OptimizationService.IOptimizationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OptimizationServiceClient : System.ServiceModel.ClientBase<InvestmentsWinWorms.OptimizationService.IOptimizationService>, InvestmentsWinWorms.OptimizationService.IOptimizationService {
        
        public OptimizationServiceClient() {
        }
        
        public OptimizationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OptimizationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OptimizationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OptimizationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double[] DoSimplex(double _sum, double _ratio, double _divA, double _divB, double _limA, double _limB) {
            return base.Channel.DoSimplex(_sum, _ratio, _divA, _divB, _limA, _limB);
        }
        
        public System.Threading.Tasks.Task<double[]> DoSimplexAsync(double _sum, double _ratio, double _divA, double _divB, double _limA, double _limB) {
            return base.Channel.DoSimplexAsync(_sum, _ratio, _divA, _divB, _limA, _limB);
        }
        
        public double[] DoBionic(int N, int G, double _sum, double _ratio, double _divA, double _divB, double _limA, double _limB) {
            return base.Channel.DoBionic(N, G, _sum, _ratio, _divA, _divB, _limA, _limB);
        }
        
        public System.Threading.Tasks.Task<double[]> DoBionicAsync(int N, int G, double _sum, double _ratio, double _divA, double _divB, double _limA, double _limB) {
            return base.Channel.DoBionicAsync(N, G, _sum, _ratio, _divA, _divB, _limA, _limB);
        }
    }
}
