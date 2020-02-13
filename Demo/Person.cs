using Demo.Properties;
using Xanadu;

namespace Demo
{
    public class Person
    {
        [LocalizedDisplayName(nameof(Resources.Person_Name_DisplayName), typeof(Resources))]
        [LocalizedDescription(nameof(Resources.Person_Name_Description), typeof(Resources))]
        [LocalizedCategory(nameof(Resources.Person_Name_Category), typeof(Resources))]
        public string Name { get; set; }
    }
}
