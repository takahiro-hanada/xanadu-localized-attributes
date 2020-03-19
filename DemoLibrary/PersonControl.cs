using System.Windows.Forms;
using DemoLibrary.Properties;
using Xanadu;

namespace DemoLibrary
{
    public sealed class PersonControl: Control
    {
        [LocalizedDisplayName(nameof(Resources.DemoControl_Age_DisplayName), typeof(Resources))]
        [LocalizedDescription(nameof(Resources.DemoControl_Age_Description), typeof(Resources))]
        [LocalizedCategory(nameof(Resources.DemoControl_Age_Category), typeof(Resources))]
        public ushort Age { get; set; }
    }
}
