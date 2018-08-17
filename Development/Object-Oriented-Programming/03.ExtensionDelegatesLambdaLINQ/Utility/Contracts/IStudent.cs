// <copyright file=IStudent company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/18/2018 1:54:04 PM</date>
// <summary>Representing a IStudent interface</summary>

namespace Utility.Contracts
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        long FaculteteNumber { get; set; }
        string Telephone { get; set; }
        string Email { get; set; }
        IList<int> Marks { get; set; }
        int GroupNumber { get; set; }
    }
}