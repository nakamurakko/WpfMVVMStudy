using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleModule.DataTypes
{
    public class User : BindableBase
    {

        private int _id;
        /// <summary>
        /// ID
        /// </summary>
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }


        private string _name;
        /// <summary>
        /// 名前
        /// </summary>
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}
