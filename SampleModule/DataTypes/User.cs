using Prism.Mvvm;

namespace SampleModule.DataTypes;

public class User : BindableBase
{

    private int _id;
    /// <summary>
    /// ID
    /// </summary>
    public int Id
    {
        get => this._id;
        set => this.SetProperty(ref _id, value);
    }


    private string _name;
    /// <summary>
    /// 名前
    /// </summary>
    public string Name
    {
        get => this._name;
        set => this.SetProperty(ref _name, value);
    }
}
