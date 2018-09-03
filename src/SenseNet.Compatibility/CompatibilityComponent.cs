using System;
using SenseNet.ContentRepository;

namespace SenseNet.Compatibility
{
    /// <summary>
    /// Component class for the Compatibility package.
    /// The existence of this component class makes sure the system checks that the Compatibility
    /// component is actually installed - which is true only if the repository was upgraded
    /// from version 6.
    /// </summary>
    internal class CompatibilityComponent : SnComponent
    {
        public override string ComponentId => "SenseNet.Compatibility";
        public override Version SupportedVersion => new Version(7, 3, 3);
    }
}
