using SampleModule.DataTypes;
using SampleModule.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestSampleModule;

/// <summary>
/// SampleModel �N���X�̃e�X�g�B
/// </summary>
public sealed class SampleModelTest
{
    /// <summary>
    /// ���݂���ID�����������ꍇ�̃e�X�g�B
    /// </summary>
    [Fact]
    public void TestGetUser1()
    {
        List<User> users = SampleModel.GetUsers();

        Assert.False(users.Count == 0, "�e�X�g�O�Ƀf�[�^�o�^���K�v�B");

        bool tryGetUserResult = SampleModel.TryGetUser(users[0].Id, out User user);

        Assert.True(tryGetUserResult);
        Assert.True(user != null);
        Assert.Equal(user.Id, users[0].Id);
        Assert.Equal(user.Name, users[0].Name);
    }

    /// <summary>
    /// ���݂��Ȃ�ID�����������ꍇ�̃e�X�g�B
    /// </summary>
    [Fact]
    public void TestGetUser2()
    {
        List<User> users = SampleModel.GetUsers();

        User user;
        bool tryGetUserResult = SampleModel.TryGetUser(users.Count == 0 ? 1 : users.Max(x => x.Id) + 1, out user);

        Assert.True(!tryGetUserResult);
        Assert.True(user == null);
    }
}
