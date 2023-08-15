using SampleModule.DataTypes;
using System.Collections.Generic;
using System.Linq;

namespace SampleModule.Models;

/// <summary>
/// サンプル Model クラス。
/// </summary>
public sealed class SampleModel
{
    private static List<User> Users = new List<User>()
    {
        new User() { Id = 1, Name = "田中太郎" },
        new User() { Id = 2, Name = "高橋次郎" }
    };

    /// <summary>
    /// コンストラクター。非公開。
    /// </summary>
    private SampleModel()
    {

    }

    /// <summary>
    /// ユーザー情報を取得する。
    /// </summary>
    /// <param name="id">対象のユーザーID。</param>
    /// <param name="user">対象のユーザー。</param>
    /// <returns>Idが引数と一致するユーザーがあればTrueを返す。</returns>
    public static bool TryGetUser(int id, out User user)
    {
        User u = Users.Where(x => x.Id == id).FirstOrDefault();

        if (u == null)
        {
            user = null;
            return false;
        }

        user = new User() { Id = u.Id, Name = u.Name };
        return true;
    }

    /// <summary>
    /// ユーザー情報の一覧を取得する。
    /// </summary>
    /// <returns>ユーザー情報の一覧を返す。</returns>
    public static List<User> GetUsers()
    {
        List<User> result = new List<User>();

        foreach (User user in Users)
        {
            result.Add(new User() { Id = user.Id, Name = user.Name });
        }

        return result;
    }
}
