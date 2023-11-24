using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleModule.DataTypes;

public partial class User : ObservableObject
{
    /// <summary>
    /// ID。
    /// </summary>
    [ObservableProperty]
    private int _id;

    /// <summary>
    /// 名前。
    /// </summary>
    [ObservableProperty]
    private string _name;
}
