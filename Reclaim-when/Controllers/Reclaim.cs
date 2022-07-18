using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Reclaim_when.models;
using System.Net.Http.Json;

namespace Reclaim_when.Controllers
{
    [Route("Reclaim")]
    [ApiController]
    public class Reclaim : ControllerBase
    {
        private TerrReq _terrReqData { get; set; }
        private List<Terr> _Terrobserve { get; set; } = new List<Terr>();
        private static List<Terr> Terrobserve { get; set; } = new List<Terr>();
        private const string observing = "Gang of Fools";
        private static HttpClient _httpClient = new HttpClient();
        private string attackers = "";
        private static DateTime _lastPing = DateTime.Now;

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            DiscordHook discordHook = new DiscordHook();
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
                    //bliver ramt når noget ikke matcher hvad vi har
                    whatToReclaim += terr.territory + " ,\n";
                    reclaimNeeded = true;
                    if (!attackers.Contains(terr.guild))
                    {
                        attackers += terr.guild+" ,";
                    }
                }
            }

            if (reclaimNeeded && DateTime.Compare(_lastPing,DateTime.Now.AddSeconds(10)) == -1)
            {
                _lastPing = DateTime.Now;
                Console.WriteLine($"Reclaim {whatToReclaim}");
                long roleid = 934871908346908682;
                //discordHook.content = $"<@&{roleid}> {whatToReclaim}";
                discordHook.content = $"Reclaim: {whatToReclaim} From {attackers}";
                discordHook.embeds.Add(
                    new Embed
                    {
                        color = 16711680,
                        image = new Image
                        {
                            url = "https://media.discordapp.net/attachments/865036089257623592/884971677258248192/image0.gif"
                        }
                    }
                    );
                DiscordMessege(discordHook);
                return Ok($"Yes Reclaim {whatToReclaim}");
            }
            Console.WriteLine("intet fundet");
            discordHook.content = "intet fundet";
            DiscordMessege(discordHook);
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
            _Terrobserve.Add(_terrReqData.territories.NivlaWoodsExit);
            _Terrobserve.Add(_terrReqData.territories.GelibordCastle);
        }

        [NonAction]
        public static async Task<List<Terr>> setupStatic()
        {
            List<Terr> l = new List<Terr>();
            HttpResponseMessage response = await _httpClient.GetAsync("https://api.wynncraft.com/public_api.php?action=territoryList");
            response.EnsureSuccessStatusCode();
            //_terrReq = response.Content.ReadFromJsonAsync<TerrReq>().GetAwaiter().GetResult();
            var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            TerrReq _terrReqData = JsonConvert.DeserializeObject<TerrReq>(json);
            l.Add(_terrReqData.territories.SouthPigmenRavines);
            l.Add(_terrReqData.territories.LittleWood);
            l.Add(_terrReqData.territories.CityOfTroms);
            l.Add(_terrReqData.territories.TempleOfLegends);
            l.Add(_terrReqData.territories.JungleLake);
            l.Add(_terrReqData.territories.JungleLower);
            l.Add(_terrReqData.territories.JungleMid);
            l.Add(_terrReqData.territories.JungleUpper);
            l.Add(_terrReqData.territories.DernelJungleLower);
            l.Add(_terrReqData.territories.DernelJungleMid);
            l.Add(_terrReqData.territories.DernelJungleUpper);
            l.Add(_terrReqData.territories.HerbCave);
            l.Add(_terrReqData.territories.GreatBridgeJungle);
            l.Add(_terrReqData.territories.GreatBridgeNesaak);
            return l;
        }


        [NonAction]
        public async void DiscordMessege(DiscordHook dis)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("https://discord.com/api/webhooks/998286387155570738/mRC1jfhTkixHBlcgE2RYC7Kr9UYxEZLcR3O4hAkmmsg-fZmYjr0o5bw5-P9OyjoY_Irw",dis);
        }

        [NonAction]
        public static async void InitialLoop(object hell)
        {
            string attackers = "";
            const string observing = "Gang of Fools";
            List<Terr> _Terrobserve = setupStatic().Result;
            DiscordHook discordHook = new DiscordHook();
            bool reclaimNeeded = false;
            string whatToReclaim = "";
            foreach (Terr terr in _Terrobserve)
            {
                if (terr.guild != observing)
                {
                    //bliver ramt når noget ikke matcher hvad vi har
                    whatToReclaim += terr.territory + " ,\n";
                    reclaimNeeded = true;
                    if (!attackers.Contains(terr.guild))
                    {
                        attackers += terr.guild + " ,";
                    }
                }
            }

            if (reclaimNeeded && DateTime.Compare(_lastPing, DateTime.Now.AddSeconds(10)) == 1)
            {
                _lastPing = DateTime.Now;
                Console.WriteLine($"Reclaim {whatToReclaim}");
                long roleid = 934871908346908682;
                //discordHook.content = $"<@&{roleid}> {whatToReclaim}";
                discordHook.content = $"Reclaim: {whatToReclaim} From {attackers}";
                discordHook.embeds.Add(
                    new Embed
                    {
                        color = 16711680,
                        image = new Image
                        {
                            url = "https://media.discordapp.net/attachments/865036089257623592/884971677258248192/image0.gif"
                        }
                    }
                    );
                new Reclaim().DiscordMessege(discordHook);
            }
            Console.WriteLine("intet fundet");
        }
        //discord sent
  //      {
  //"content": "hejsa",
  //"embeds": null,
  //"attachments": []
  //  }
    }
}
