using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace MUGPeru.API.Filters
{
    public class MapperFilterResultAttribute: ResultFilterAttribute
    {
        private readonly Type _toType;
        private readonly Type _fromType;
        public MapperFilterResultAttribute(Type toType, Type fromType)
        {
            _toType = toType;
            _fromType = fromType;
        }
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var resultFromAction = context.Result as ObjectResult;
            if (resultFromAction?.Value == null
               || resultFromAction.StatusCode < 200
               || resultFromAction.StatusCode >= 300)
            {
                await next();
                return;
            }

            var mapper = context.HttpContext.RequestServices.GetService<IMapper>();
            resultFromAction.Value = mapper.Map(resultFromAction.Value,_fromType, _toType);

            await next();
        }
    }
}
