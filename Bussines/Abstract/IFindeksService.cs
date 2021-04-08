using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Dtos;

namespace Bussines.Abstract
{
    public interface IFindeksService
    {
        IDataResult<FindeksDto> GetFindekPointByUserId(int userId);
    }
}
