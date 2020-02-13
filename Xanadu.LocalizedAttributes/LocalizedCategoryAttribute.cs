using System;
using System.ComponentModel;
using System.Resources;

namespace Xanadu
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class LocalizedCategoryAttribute : CategoryAttribute
    {
        readonly string _resourceKey;

        readonly ResourceManager _resourceManager;

        public LocalizedCategoryAttribute(string resourceKey, Type resourceType)
        {
            _resourceKey = resourceKey ?? throw new ArgumentNullException(nameof(resourceKey));

            _resourceManager = new ResourceManager(resourceType ?? throw new ArgumentNullException(nameof(resourceType)));
        }

        protected override string GetLocalizedString(string value) => _resourceManager.GetString(_resourceKey);
    }
}