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
    
    public class IMessageContractAddInAdapter
    {
        internal static ExperienceMenu.Views.IMessageContract ContractToViewAdapter(Start9.Api.Contracts.IMessageContractContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IMessageContractViewToContractAddInAdapter))))
            {
                return ((IMessageContractViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IMessageContractContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IMessageContractContract ViewToContractAdapter(ExperienceMenu.Views.IMessageContract view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IMessageContractContractToViewAddInAdapter)))
            {
                return ((IMessageContractContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IMessageContractViewToContractAddInAdapter(view);
            }
        }
    }
}

