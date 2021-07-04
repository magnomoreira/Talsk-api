
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace TalksApi.Atribute

{

	[AttributeUsage(validOn: AttributeTargets.Class)]
	public class ApikeyAtribute : Attribute, IAsyncActionFilter
	{

		private const string APIKEY_HAPE = "ApiKey";

		public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			if(!context.HttpContext.Request.Headers.TryGetValue(APIKEY_HAPE, out var exttracteApiKey))
			{
				context.Result = new ContentResult()
				{
					StatusCode = 401,
					Content = "Api key has not provide"
				};
				return;
			}

			var appTings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

			var apiKey = appTings.GetValue<string>(APIKEY_HAPE);

			if (!apiKey.Equals(exttracteApiKey))
			{
				context.Result = new ContentResult()
				{
					StatusCode = 401,
					Content = "Api Key is not valid"
				};
				return;
			}

			await next();
		}

	}
}
