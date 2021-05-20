using SampleModule.DataTypes;
using SampleModule.Models;
using System;
using System.Linq;
using Xunit;

namespace TestSampleModule
{
    /// <summary>
    /// SampleModel �N���X�̃e�X�g�B
    /// </summary>
    public class SampleModelTest
    {
        /// <summary>
        /// ���݂���ID�����������ꍇ�̃e�X�g�B
        /// </summary>
        [Fact]
        public void TestGetUser1()
        {
            var users = SampleModel.GetUsers();

            Assert.False(users.Count == 0, "�e�X�g�O�Ƀf�[�^�o�^���K�v�B");

            User user;
            var tryGetUserResult = SampleModel.TryGetUser(users[0].Id, out user);

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
            var users = SampleModel.GetUsers();

            User user;
            var tryGetUserResult = SampleModel.TryGetUser(users.Count == 0 ? 1 : users.Max(x => x.Id) + 1, out user);

            Assert.True(!tryGetUserResult);
            Assert.True(user == null);
        }
    }
}
