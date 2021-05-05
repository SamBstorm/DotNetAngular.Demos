using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAngular.Demos.DAL.Common.Models
{
    public interface IDataModel<TId>
    {
        TId Id { get; }
    }
}
