using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capoeira.Application.Dtos;

namespace Capoeira.Application.Contratos
{
    public interface ITokenService
    {
        Task<string> CreateToken(UserUpdateDto userUpdateDto);
    }
}