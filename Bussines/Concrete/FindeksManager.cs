using Bussines.Abstract;
using Core.Utilities.Results;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class FindeksManager : IFindeksService
    {
        public IDataResult<FindeksDto> GetFindekPointByUserId(int userId)
        {
            Random random = new Random();
            FindeksDto findeksDto = new FindeksDto();

            findeksDto.Id = 1;
            findeksDto.FindeksPoint = random.Next(0, 1901);

            return new SuccessDataResult<FindeksDto>(findeksDto);
        }
    }
}
