using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using vams_onair_api.Helpers;
using vams_onair_api.Models;

namespace vams_onair_api.Controllers
{
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public CompanyController(ILogger<CompanyController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Route("company/{companyId}/{apiKey}")]
        public async Task<ActionResult<Company>> GetCompanyAsync(Guid companyId, Guid apiKey)
        {
            companyId = Guid.Parse("f9b9b246-f69b-4be1-b22f-d44bb8afa483");

            if (companyId == Guid.Empty)
                throw new ArgumentNullException(nameof(companyId));
            if (apiKey == Guid.Empty)
                throw new ArgumentNullException(nameof(apiKey));

            try
            {
                var httpClient = _httpClientFactory.CreateClient("OnAirApi");
                httpClient.DefaultRequestHeaders.Add("oa-apikey", apiKey.ToString());

                var url = "company/" + companyId;
                var responseString = await httpClient.GetStringAsync(url);

                var company = JsonConvert.DeserializeObject<Company>(responseString, new CompanyConverter());
                return company;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An un expected error occured while attempting to retrieve company information: {companyId}.", companyId);
                return StatusCode(500, ex);
            }
        }
    }
}
