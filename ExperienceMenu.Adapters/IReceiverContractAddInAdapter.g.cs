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
    
    public class IReceiverContractAddInAdapter
    {
        internal static ExperienceMenu.Views.IReceiverContract ContractToViewAdapter(Start9.Api.Contracts.IReceiverContractContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IReceiverContractViewToContractAddInAdapter))))
            {
                return ((IReceiverContractViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IReceiverContractContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IReceiverContractContract ViewToContractAdapter(ExperienceMenu.Views.IReceiverContract view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IReceiverContractContractToViewAddInAdapter)))
            {
                return ((IReceiverContractContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IReceiverContractViewToContractAddInAdapter(view);
            }
        }
    }
}

