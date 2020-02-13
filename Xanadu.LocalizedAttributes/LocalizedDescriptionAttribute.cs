using System;
using System.ComponentModel;
using System.Resources;

namespace Xanadu
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        readonly string _resourceKey;

        readonly ResourceManager _resourceManager;

        public LocalizedDescriptionAttribute(string resourceKey, Type resourceType)
        {
            _resourceKey = resourceKey ?? throw new ArgumentNullException(nameof(resourceKey));

            _resourceManager = new ResourceManager(resourceType ?? throw new ArgumentNullException(nameof(resourceType)));
        }

        public override string Description => _resourceManager.GetString(_resourceKey);
    }
}
