// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Specifies the Linux operating system settings on the virtual machine. &lt;br&gt;&lt;br&gt;For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) &lt;br&gt;&lt;br&gt; For running non-endorsed distributions, see [Information for Non-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json). </summary>
    public partial class LinuxConfiguration
    {
        /// <summary> Initializes a new instance of LinuxConfiguration. </summary>
        public LinuxConfiguration()
        {
        }

        /// <summary> Initializes a new instance of LinuxConfiguration. </summary>
        /// <param name="disablePasswordAuthentication"> Specifies whether password authentication should be disabled. </param>
        /// <param name="ssh"> Specifies the ssh key configuration for a Linux OS. </param>
        /// <param name="provisionVMAgent"> Indicates whether virtual machine agent should be provisioned on the virtual machine. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. </param>
        internal LinuxConfiguration(bool? disablePasswordAuthentication, SshConfiguration ssh, bool? provisionVMAgent)
        {
            DisablePasswordAuthentication = disablePasswordAuthentication;
            Ssh = ssh;
            ProvisionVMAgent = provisionVMAgent;
        }

        /// <summary> Specifies whether password authentication should be disabled. </summary>
        public bool? DisablePasswordAuthentication { get; set; }
        /// <summary> Specifies the ssh key configuration for a Linux OS. </summary>
        public SshConfiguration Ssh { get; set; }
        /// <summary> Indicates whether virtual machine agent should be provisioned on the virtual machine. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. </summary>
        public bool? ProvisionVMAgent { get; set; }
    }
}
