using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Reclaim_when;
using System.Net.Http.Json;

namespace Reclaim_when.Controllers
{
    [Route("Reclaim")]
    [ApiController]
    public class Reclaim : ControllerBase
    {
        private TerrReq _terrReqData { get; set; }
        private List<Terr> _Terrobserve { get; set; } = new List<Terr>();
        private const string observing = "Gang of Fools";
        private static HttpClient _httpClient = new HttpClient();
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            bool reclaimNeeded = false;
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://api.wynncraft.com/public_api.php?action=territoryList");
                response.EnsureSuccessStatusCode();
                //_terrReq = response.Content.ReadFromJsonAsync<TerrReq>().GetAwaiter().GetResult();
                var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                _terrReqData = JsonConvert.DeserializeObject<TerrReq>(json);

                await Task.Run(()=> setup());
            }
            catch (Exception)
            {
                return NotFound();
            }
            string whatToReclaim = "";
            foreach(Terr terr in _Terrobserve)
            {
                if (terr.guild != observing)
                {
                    whatToReclaim += terr.territory + " ,\n";
                    reclaimNeeded = true;
                }
            }

            if (reclaimNeeded)
            {
                return Ok($"Yes Reclaim {whatToReclaim}");
            }
            return Ok();
        }

        [NonAction]
        public void setup()
        {
            _Terrobserve.Add(_terrReqData.territories.SouthPigmenRavines);
            _Terrobserve.Add(_terrReqData.territories.LittleWood);
            _Terrobserve.Add(_terrReqData.territories.CityOfTroms);
            _Terrobserve.Add(_terrReqData.territories.TempleOfLegends);
            _Terrobserve.Add(_terrReqData.territories.JungleLake);
            _Terrobserve.Add(_terrReqData.territories.JungleLower);
            _Terrobserve.Add(_terrReqData.territories.JungleMid);
            _Terrobserve.Add(_terrReqData.territories.JungleUpper);
            _Terrobserve.Add(_terrReqData.territories.DernelJungleLower);
            _Terrobserve.Add(_terrReqData.territories.DernelJungleMid);
            _Terrobserve.Add(_terrReqData.territories.DernelJungleUpper);
            _Terrobserve.Add(_terrReqData.territories.HerbCave);
            _Terrobserve.Add(_terrReqData.territories.GreatBridgeJungle);
            _Terrobserve.Add(_terrReqData.territories.GreatBridgeNesaak);
        }
    }
}
