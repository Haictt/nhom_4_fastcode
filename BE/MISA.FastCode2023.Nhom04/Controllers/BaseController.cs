using Microsoft.AspNetCore.Mvc;
using MISA.FastCode2023.Nhom04.BL.Interfaces;

namespace MISA.FastCode2023.Nhom04.API.Controllers
{
    [ApiController]
    public abstract class BaseController<TEntity, TEntityFilter, TEntityPostDto> : ControllerBase
    {
        protected readonly IBaseService<TEntity, TEntityFilter, TEntityPostDto> _baseService;

        public BaseController(IBaseService<TEntity, TEntityFilter, TEntityPostDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
