//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExperienceMenu.Adapters
{
    
    public class IMessageEventHandlerViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IMessageEventHandlerContract
    {
        private object _view;
        private System.Reflection.MethodInfo _event;
        public IMessageEventHandlerViewToContractAddInAdapter(object view, System.Reflection.MethodInfo eventProp)
        {
            _view = view;
            _event = eventProp;
        }
        public void Handler(Start9.Api.Contracts.IMessageReceivedEventArgsContract args)
        {
            ExperienceMenu.Views.MessageReceivedEventArgs adaptedArgs;
            adaptedArgs = ExperienceMenu.Adapters.MessageReceivedEventArgsAddInAdapter.ContractToViewAdapter(args);
            object[] argsArray = new object[1];
            argsArray[0] = adaptedArgs;
            _event.Invoke(_view, argsArray);
        }
        internal object GetSourceView()
        {
            return _view;
        }
    }
}

