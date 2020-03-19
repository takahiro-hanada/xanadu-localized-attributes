using System;
using System.ComponentModel;
using System.Resources;

namespace Xanadu
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Event | AttributeTargets.Property)]
    public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        readonly string _resourceKey;

        readonly ResourceManager _resourceManager;

        public LocalizedDisplayNameAttribute(string resourceKey, Type resourceType) : base(resourceKey)
        {
            _resourceKey = resourceKey ?? throw new ArgumentNullException(nameof(resourceKey));

            _resourceManager = new ResourceManager(resourceType ?? throw new ArgumentNullException(nameof(resourceType)));
        }

        public override string DisplayName => _resourceManager.GetString(_resourceKey);
    }
}