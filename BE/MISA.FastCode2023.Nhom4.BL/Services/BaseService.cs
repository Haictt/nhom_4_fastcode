using AutoMapper;
using MISA.FastCode2023.Nhom04.BL.Interfaces;
using MISA.FastCode2023.Nhom04.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.FastCode2023.Nhom04.BL.Services
{
    public abstract class BaseService<TEntity, TEntityFilter, TEntityPostDto> : IBaseService<TEntity, TEntityFilter, TEntityPostDto>
    {
        protected readonly IBaseRepository<TEntity, TEntityFilter> _baseRepository;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity, TEntityFilter> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
