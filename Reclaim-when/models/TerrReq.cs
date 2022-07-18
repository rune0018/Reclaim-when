using Newtonsoft.Json;

namespace Reclaim_when.models
{ 
    // Root myDeserializedClass = JsonConvert.Deserializeobject?<Root>(myJsonResponse);
    public class TerrReq
    {
        public Territories territories { get; set; }
        public Request request { get; set; }
    }

    public class Request
    {
        public int timestamp { get; set; }
        public int version { get; set; }
    }

    public class GenericTerr : Terr
    {
        public string territory { get; set; }
        public string guild { get; set; }
        public string acquired { get; set; }
        public object? attacker { get; set; }
        public Location location { get; set; }
    }
    public class Territories
    {
        [JsonProperty("Ragni Main Entrance")]
        public GenericTerr RagniMainEntrance { get; set; }

        [JsonProperty("Nivla Woods Entrance")]
        public GenericTerr NivlaWoodsEntrance { get; set; }

        [JsonProperty("Katoa Ranch")]
        public GenericTerr KatoaRanch { get; set; }

        [JsonProperty("Ragni East Suburbs")]
        public GenericTerr RagniEastSuburbs { get; set; }

        [JsonProperty("Coastal Trail")]
        public GenericTerr CoastalTrail { get; set; }
        public GenericTerr Maltic { get; set; }
        public GenericTerr Plains { get; set; }

        [JsonProperty("Pigmen Ravines")]
        public GenericTerr PigmenRavines { get; set; }

        [JsonProperty("Little Wood")]
        public GenericTerr LittleWood { get; set; }

        [JsonProperty("Abandoned Farm")]
        public GenericTerr AbandonedFarm { get; set; }

        [JsonProperty("Road to Time Valley")]
        public GenericTerr RoadToTimeValley { get; set; }

        [JsonProperty("Nemract Quarry")]
        public GenericTerr NemractQuarry { get; set; }

        [JsonProperty("Nivla Woods Exit")]
        public GenericTerr NivlaWoodsExit { get; set; }

        [JsonProperty("North Nivla Woods")]
        public GenericTerr NorthNivlaWoods { get; set; }

        [JsonProperty("Road to Elkurn")]
        public GenericTerr RoadToElkurn { get; set; }

        [JsonProperty("Nether Gate")]
        public GenericTerr NetherGate { get; set; }

        [JsonProperty("Detlas Suburbs")]
        public GenericTerr DetlasSuburbs { get; set; }
        public GenericTerr Detlas { get; set; }

        [JsonProperty("North Farmers Valley")]
        public GenericTerr NorthFarmersValley { get; set; }

        [JsonProperty("Nivla Woods Edge")]
        public GenericTerr NivlaWoodsEdge { get; set; }

        [JsonProperty("Half Moon Island")]
        public GenericTerr HalfMoonIsland { get; set; }

        [JsonProperty("Twain Lake")]
        public GenericTerr TwainLake { get; set; }

        [JsonProperty("Bob's Tomb")]
        public GenericTerr BobSTomb { get; set; }

        [JsonProperty("Nesaak Plains South West")]
        public GenericTerr NesaakPlainsSouthWest { get; set; }

        [JsonProperty("Nesaak Plains Lower North West")]
        public GenericTerr NesaakPlainsLowerNorthWest { get; set; }

        [JsonProperty("Nesaak Village")]
        public GenericTerr NesaakVillage { get; set; }

        [JsonProperty("Nesaak Plains Mid North West")]
        public GenericTerr NesaakPlainsMidNorthWest { get; set; }

        [JsonProperty("Great Bridge Jungle")]
        public GenericTerr GreatBridgeJungle { get; set; }

        [JsonProperty("Jungle Mid")]
        public GenericTerr JungleMid { get; set; }

        [JsonProperty("Jungle Lake")]
        public GenericTerr JungleLake { get; set; }

        [JsonProperty("City of Troms")]
        public GenericTerr CityOfTroms { get; set; }

        [JsonProperty("Rymek East Mid")]
        public GenericTerr RymekEastMid { get; set; }

        [JsonProperty("Rymek West Lower")]
        public GenericTerr RymekWestLower { get; set; }

        [JsonProperty("Rymek West Upper")]
        public GenericTerr RymekWestUpper { get; set; }

        [JsonProperty("Desert East Mid")]
        public GenericTerr DesertEastMid { get; set; }

        [JsonProperty("Desert Upper")]
        public GenericTerr DesertUpper { get; set; }

        [JsonProperty("Desert Mid-Lower")]
        public GenericTerr DesertMidLower { get; set; }

        [JsonProperty("Almuj City")]
        public GenericTerr AlmujCity { get; set; }

        [JsonProperty("Desert West Upper")]
        public GenericTerr DesertWestUpper { get; set; }

        [JsonProperty("Savannah East Lower")]
        public GenericTerr SavannahEastLower { get; set; }

        [JsonProperty("Savannah West Lower")]
        public GenericTerr SavannahWestLower { get; set; }
        public GenericTerr Bremminglar { get; set; }

        [JsonProperty("Nemract Town")]
        public GenericTerr NemractTown { get; set; }

        [JsonProperty("Nemract Road")]
        public GenericTerr NemractRoad { get; set; }

        [JsonProperty("Nemract Plains East")]
        public GenericTerr NemractPlainsEast { get; set; }

        [JsonProperty("Nemract Cathedral")]
        public GenericTerr NemractCathedral { get; set; }

        [JsonProperty("The Bear Zoo")]
        public GenericTerr TheBearZoo { get; set; }

        [JsonProperty("Zhight Island")]
        public GenericTerr ZhightIsland { get; set; }

        [JsonProperty("Durum Isles Center")]
        public GenericTerr DurumIslesCenter { get; set; }

        [JsonProperty("Durum Isles East")]
        public GenericTerr DurumIslesEast { get; set; }

        [JsonProperty("Pirate Town")]
        public GenericTerr PirateTown { get; set; }

        [JsonProperty("Dujgon Nation")]
        public GenericTerr DujgonNation { get; set; }

        [JsonProperty("Dead Island North East")]
        public GenericTerr DeadIslandNorthEast { get; set; }

        [JsonProperty("Dead Island North West")]
        public GenericTerr DeadIslandNorthWest { get; set; }

        [JsonProperty("Maro Peaks")]
        public GenericTerr MaroPeaks { get; set; }

        [JsonProperty("Volcano Lower")]
        public GenericTerr VolcanoLower { get; set; }
        public GenericTerr Ternaves { get; set; }

        [JsonProperty("Ternaves Plains Lower")]
        public GenericTerr TernavesPlainsLower { get; set; }

        [JsonProperty("Mining Base Lower")]
        public GenericTerr MiningBaseLower { get; set; }

        [JsonProperty("Desolate Valley")]
        public GenericTerr DesolateValley { get; set; }

        [JsonProperty("Plains Lake")]
        public GenericTerr PlainsLake { get; set; }

        [JsonProperty("Detlas Savannah Transition")]
        public GenericTerr DetlasSavannahTransition { get; set; }

        [JsonProperty("Detlas Trail East Plains")]
        public GenericTerr DetlasTrailEastPlains { get; set; }

        [JsonProperty("Llevigar Entrance")]
        public GenericTerr LlevigarEntrance { get; set; }

        [JsonProperty("Llevigar Gate West")]
        public GenericTerr LlevigarGateWest { get; set; }

        [JsonProperty("Llevigar Farm Plains West")]
        public GenericTerr LlevigarFarmPlainsWest { get; set; }
        public GenericTerr Cinfras { get; set; }

        [JsonProperty("Llevigar Plains West Lower")]
        public GenericTerr LlevigarPlainsWestLower { get; set; }

        [JsonProperty("Llevigar Plains East Upper")]
        public GenericTerr LlevigarPlainsEastUpper { get; set; }

        [JsonProperty("Swamp East Lower")]
        public GenericTerr SwampEastLower { get; set; }

        [JsonProperty("Swamp West Mid")]
        public GenericTerr SwampWestMid { get; set; }

        [JsonProperty("Swamp East Mid-Upper")]
        public GenericTerr SwampEastMidUpper { get; set; }

        [JsonProperty("Swamp East Upper")]
        public GenericTerr SwampEastUpper { get; set; }

        [JsonProperty("Swamp Dark Forest Transition Mid")]
        public GenericTerr SwampDarkForestTransitionMid { get; set; }

        [JsonProperty("Swamp Lower")]
        public GenericTerr SwampLower { get; set; }
        public GenericTerr Olux { get; set; }

        [JsonProperty("Swamp Plains Basin")]
        public GenericTerr SwampPlainsBasin { get; set; }

        [JsonProperty("Swamp Mountain Transition Mid")]
        public GenericTerr SwampMountainTransitionMid { get; set; }

        [JsonProperty("Swamp Mountain Transition Upper")]
        public GenericTerr SwampMountainTransitionUpper { get; set; }

        [JsonProperty("Quartz Mines South East")]
        public GenericTerr QuartzMinesSouthEast { get; set; }

        [JsonProperty("Quartz Mines North East")]
        public GenericTerr QuartzMinesNorthEast { get; set; }

        [JsonProperty("Orc Lake")]
        public GenericTerr OrcLake { get; set; }

        [JsonProperty("Meteor Crater")]
        public GenericTerr MeteorCrater { get; set; }

        [JsonProperty("Loamsprout Camp")]
        public GenericTerr LoamsproutCamp { get; set; }

        [JsonProperty("Goblin Plains West")]
        public GenericTerr GoblinPlainsWest { get; set; }

        [JsonProperty("Forgotten Path")]
        public GenericTerr ForgottenPath { get; set; }

        [JsonProperty("Pre-Light Forest Transition")]
        public GenericTerr PreLightForestTransition { get; set; }

        [JsonProperty("Road To Light Forest")]
        public GenericTerr RoadToLightForest { get; set; }

        [JsonProperty("Efilim South Plains")]
        public GenericTerr EfilimSouthPlains { get; set; }

        [JsonProperty("Efilim South East Plains")]
        public GenericTerr EfilimSouthEastPlains { get; set; }

        [JsonProperty("Light Forest Entrance")]
        public GenericTerr LightForestEntrance { get; set; }

        [JsonProperty("Aldorei Valley West Entrance")]
        public GenericTerr AldoreiValleyWestEntrance { get; set; }

        [JsonProperty("Light Forest North Exit")]
        public GenericTerr LightForestNorthExit { get; set; }

        [JsonProperty("Light Forest West Mid")]
        public GenericTerr LightForestWestMid { get; set; }

        [JsonProperty("Light Forest East Upper")]
        public GenericTerr LightForestEastUpper { get; set; }

        [JsonProperty("Light Forest East Lower")]
        public GenericTerr LightForestEastLower { get; set; }

        [JsonProperty("Mantis Nest")]
        public GenericTerr MantisNest { get; set; }

        [JsonProperty("Path to Cinfras")]
        public GenericTerr PathToCinfras { get; set; }
        public GenericTerr Gelibord { get; set; }

        [JsonProperty("Gelibord Castle")]
        public GenericTerr GelibordCastle { get; set; }

        [JsonProperty("Fortress North")]
        public GenericTerr FortressNorth { get; set; }

        [JsonProperty("Mansion of Insanity")]
        public GenericTerr MansionOfInsanity { get; set; }

        [JsonProperty("Lexdales Prison")]
        public GenericTerr LexdalesPrison { get; set; }

        [JsonProperty("Entrance to Kander")]
        public GenericTerr EntranceToKander { get; set; }

        [JsonProperty("Mesquis Tower")]
        public GenericTerr MesquisTower { get; set; }

        [JsonProperty("Path to Talor")]
        public GenericTerr PathToTalor { get; set; }

        [JsonProperty("Dark Forest Village")]
        public GenericTerr DarkForestVillage { get; set; }

        [JsonProperty("Old Crossroads North")]
        public GenericTerr OldCrossroadsNorth { get; set; }

        [JsonProperty("Fungal Grove")]
        public GenericTerr FungalGrove { get; set; }

        [JsonProperty("Heart of Decay")]
        public GenericTerr HeartOfDecay { get; set; }

        [JsonProperty("Mushroom Hill")]
        public GenericTerr MushroomHill { get; set; }

        [JsonProperty("Dark Forest Cinfras Transition")]
        public GenericTerr DarkForestCinfrasTransition { get; set; }

        [JsonProperty("Aldorei Valley South Entrance")]
        public GenericTerr AldoreiValleySouthEntrance { get; set; }

        [JsonProperty("Cinfras County Lower")]
        public GenericTerr CinfrasCountyLower { get; set; }

        [JsonProperty("Cinfras County Mid-Upper")]
        public GenericTerr CinfrasCountyMidUpper { get; set; }

        [JsonProperty("Gylia Lake South East")]
        public GenericTerr GyliaLakeSouthEast { get; set; }

        [JsonProperty("Gylia Lake North West")]
        public GenericTerr GyliaLakeNorthWest { get; set; }

        [JsonProperty("Gert Camp")]
        public GenericTerr GertCamp { get; set; }

        [JsonProperty("Aldorei Valley Lower")]
        public GenericTerr AldoreiValleyLower { get; set; }

        [JsonProperty("Aldorei Valley Upper")]
        public GenericTerr AldoreiValleyUpper { get; set; }

        [JsonProperty("Aldorei's Waterfall")]
        public GenericTerr AldoreiSWaterfall { get; set; }

        [JsonProperty("Aldorei's Arch")]
        public GenericTerr AldoreiSArch { get; set; }

        [JsonProperty("Ghostly Path")]
        public GenericTerr GhostlyPath { get; set; }

        [JsonProperty("Burning Airship")]
        public GenericTerr BurningAirship { get; set; }
        public GenericTerr Thanos { get; set; }

        [JsonProperty("Path To Military Base")]
        public GenericTerr PathToMilitaryBase { get; set; }

        [JsonProperty("Military Base Upper")]
        public GenericTerr MilitaryBaseUpper { get; set; }

        [JsonProperty("Path To Ozoth's Spire Lower")]
        public GenericTerr PathToOzothSSpireLower { get; set; }

        [JsonProperty("Path To Ozoth's Spire Upper")]
        public GenericTerr PathToOzothSSpireUpper { get; set; }

        [JsonProperty("Bandit Cave Upper")]
        public GenericTerr BanditCaveUpper { get; set; }

        [JsonProperty("Canyon Path North West")]
        public GenericTerr CanyonPathNorthWest { get; set; }

        [JsonProperty("Canyon Waterfall North")]
        public GenericTerr CanyonWaterfallNorth { get; set; }

        [JsonProperty("Canyon Lower South East")]
        public GenericTerr CanyonLowerSouthEast { get; set; }

        [JsonProperty("Canyon Path North Mid")]
        public GenericTerr CanyonPathNorthMid { get; set; }

        [JsonProperty("Canyon Valley South")]
        public GenericTerr CanyonValleySouth { get; set; }

        [JsonProperty("Thanos Exit")]
        public GenericTerr ThanosExit { get; set; }

        [JsonProperty("Canyon Mountain East")]
        public GenericTerr CanyonMountainEast { get; set; }

        [JsonProperty("Canyon Waterfall Mid North")]
        public GenericTerr CanyonWaterfallMidNorth { get; set; }

        [JsonProperty("Canyon Survivor")]
        public GenericTerr CanyonSurvivor { get; set; }

        [JsonProperty("Thanos Exit Upper")]
        public GenericTerr ThanosExitUpper { get; set; }

        [JsonProperty("Wizard Tower North")]
        public GenericTerr WizardTowerNorth { get; set; }

        [JsonProperty("Mountain Edge")]
        public GenericTerr MountainEdge { get; set; }

        [JsonProperty("Valley of the Lost")]
        public GenericTerr ValleyOfTheLost { get; set; }

        [JsonProperty("Krolton's Cave")]
        public GenericTerr KroltonSCave { get; set; }

        [JsonProperty("Canyon High Path")]
        public GenericTerr CanyonHighPath { get; set; }

        [JsonProperty("Cliffside Valley")]
        public GenericTerr CliffsideValley { get; set; }

        [JsonProperty("Air Temple Upper")]
        public GenericTerr AirTempleUpper { get; set; }

        [JsonProperty("Canyon Of The Lost")]
        public GenericTerr CanyonOfTheLost { get; set; }

        [JsonProperty("Kandon Farm")]
        public GenericTerr KandonFarm { get; set; }

        [JsonProperty("Cliffside Passage North")]
        public GenericTerr CliffsidePassageNorth { get; set; }

        [JsonProperty("Entrance to Thesead South")]
        public GenericTerr EntranceToTheseadSouth { get; set; }

        [JsonProperty("Cherry Blossom Forest")]
        public GenericTerr CherryBlossomForest { get; set; }

        [JsonProperty("Thesead Suburbs")]
        public GenericTerr TheseadSuburbs { get; set; }

        [JsonProperty("Entrance to Rodoroc")]
        public GenericTerr EntranceToRodoroc { get; set; }

        [JsonProperty("Molten Heights Portal")]
        public GenericTerr MoltenHeightsPortal { get; set; }

        [JsonProperty("Lava Lake Bridge")]
        public GenericTerr LavaLakeBridge { get; set; }

        [JsonProperty("Active Volcano")]
        public GenericTerr ActiveVolcano { get; set; }
        public GenericTerr Ahmsord { get; set; }

        [JsonProperty("Snail Island")]
        public GenericTerr SnailIsland { get; set; }

        [JsonProperty("Dernel Jungle Mid")]
        public GenericTerr DernelJungleMid { get; set; }

        [JsonProperty("Corkus City")]
        public GenericTerr CorkusCity { get; set; }

        [JsonProperty("Corkus City South")]
        public GenericTerr CorkusCitySouth { get; set; }

        [JsonProperty("Road To Mine")]
        public GenericTerr RoadToMine { get; set; }

        [JsonProperty("Legendary Island")]
        public GenericTerr LegendaryIsland { get; set; }

        [JsonProperty("Corkus Forest South")]
        public GenericTerr CorkusForestSouth { get; set; }

        [JsonProperty("Corkus Mountain")]
        public GenericTerr CorkusMountain { get; set; }

        [JsonProperty("Corkus Docks")]
        public GenericTerr CorkusDocks { get; set; }

        [JsonProperty("Corkus Sea Port")]
        public GenericTerr CorkusSeaPort { get; set; }

        [JsonProperty("Corkus Statue")]
        public GenericTerr CorkusStatue { get; set; }

        [JsonProperty("Bloody Beach")]
        public GenericTerr BloodyBeach { get; set; }

        [JsonProperty("Frozen Fort")]
        public GenericTerr FrozenFort { get; set; }

        [JsonProperty("Path to Ahmsord Lower")]
        public GenericTerr PathToAhmsordLower { get; set; }

        [JsonProperty("Kandon Ridge")]
        public GenericTerr KandonRidge { get; set; }

        [JsonProperty("Dragonling Nests")]
        public GenericTerr DragonlingNests { get; set; }

        [JsonProperty("Molten Reach")]
        public GenericTerr MoltenReach { get; set; }

        [JsonProperty("Swamp Island")]
        public GenericTerr SwampIsland { get; set; }

        [JsonProperty("Wybel Island")]
        public GenericTerr WybelIsland { get; set; }

        [JsonProperty("Sky Island Ascent")]
        public GenericTerr SkyIslandAscent { get; set; }

        [JsonProperty("Raider's Base Upper")]
        public GenericTerr RaiderSBaseUpper { get; set; }

        [JsonProperty("Jofash Tunnel")]
        public GenericTerr JofashTunnel { get; set; }

        [JsonProperty("Santa's Hideout")]
        public GenericTerr SantaSHideout { get; set; }

        [JsonProperty("Icy Descent")]
        public GenericTerr IcyDescent { get; set; }

        [JsonProperty("Aldorei Lowlands")]
        public GenericTerr AldoreiLowlands { get; set; }
        public GenericTerr Rodoroc { get; set; }

        [JsonProperty("Regular Island")]
        public GenericTerr RegularIsland { get; set; }

        [JsonProperty("Twisted Ridge")]
        public GenericTerr TwistedRidge { get; set; }

        [JsonProperty("Royal Gate")]
        public GenericTerr RoyalGate { get; set; }

        [JsonProperty("Orc Battlegrounds")]
        public GenericTerr OrcBattlegrounds { get; set; }

        [JsonProperty("Lost Atoll")]
        public GenericTerr LostAtoll { get; set; }

        [JsonProperty("Lighthouse Plateau")]
        public GenericTerr LighthousePlateau { get; set; }

        [JsonProperty("The Silent Road")]
        public GenericTerr TheSilentRoad { get; set; }

        [JsonProperty("Worm Tunnel")]
        public GenericTerr WormTunnel { get; set; }

        [JsonProperty("Forgotten Town")]
        public GenericTerr ForgottenTown { get; set; }

        [JsonProperty("Sinister Forest")]
        public GenericTerr SinisterForest { get; set; }

        [JsonProperty("Paths of Sludge")]
        public GenericTerr PathsOfSludge { get; set; }

        [JsonProperty("Toxic Caves")]
        public GenericTerr ToxicCaves { get; set; }

        [JsonProperty("Void Valley")]
        public GenericTerr VoidValley { get; set; }

        [JsonProperty("Bizarre Passage")]
        public GenericTerr BizarrePassage { get; set; }

        [JsonProperty("Heavenly Ingress")]
        public GenericTerr HeavenlyIngress { get; set; }

        [JsonProperty("Primal Fen")]
        public GenericTerr PrimalFen { get; set; }

        [JsonProperty("Otherwordly Monolith")]
        public GenericTerr OtherwordlyMonolith { get; set; }

        [JsonProperty("Nexus of Light")]
        public GenericTerr NexusOfLight { get; set; }

        [JsonProperty("Field of Life")]
        public GenericTerr FieldOfLife { get; set; }
        public GenericTerr Ragni { get; set; }

        [JsonProperty("Ragni North Entrance")]
        public GenericTerr RagniNorthEntrance { get; set; }

        [JsonProperty("Ragni Plains")]
        public GenericTerr RagniPlains { get; set; }

        [JsonProperty("Maltic Plains")]
        public GenericTerr MalticPlains { get; set; }

        [JsonProperty("South Pigmen Ravines")]
        public GenericTerr SouthPigmenRavines { get; set; }

        [JsonProperty("Sanctuary Bridge")]
        public GenericTerr SanctuaryBridge { get; set; }

        [JsonProperty("Nivla Woods")]
        public GenericTerr NivlaWoods { get; set; }
        public GenericTerr Elkurn { get; set; }

        [JsonProperty("Detlas Far Suburbs")]
        public GenericTerr DetlasFarSuburbs { get; set; }

        [JsonProperty("South Farmers Valley")]
        public GenericTerr SouthFarmersValley { get; set; }

        [JsonProperty("Tower of Ascension")]
        public GenericTerr TowerOfAscension { get; set; }

        [JsonProperty("Twain Mansion")]
        public GenericTerr TwainMansion { get; set; }

        [JsonProperty("Nesaak Plains North East")]
        public GenericTerr NesaakPlainsNorthEast { get; set; }

        [JsonProperty("Nesaak Bridge Transition")]
        public GenericTerr NesaakBridgeTransition { get; set; }

        [JsonProperty("Jungle Lower")]
        public GenericTerr JungleLower { get; set; }

        [JsonProperty("Temple of Legends")]
        public GenericTerr TempleOfLegends { get; set; }

        [JsonProperty("Rymek East Upper")]
        public GenericTerr RymekEastUpper { get; set; }

        [JsonProperty("Desert East Upper")]
        public GenericTerr DesertEastUpper { get; set; }

        [JsonProperty("Desert Mid-Upper")]
        public GenericTerr DesertMidUpper { get; set; }

        [JsonProperty("Mummy's Tomb")]
        public GenericTerr MummySTomb { get; set; }

        [JsonProperty("Savannah East Upper")]
        public GenericTerr SavannahEastUpper { get; set; }

        [JsonProperty("Lion Lair")]
        public GenericTerr LionLair { get; set; }

        [JsonProperty("Nemract Plains West")]
        public GenericTerr NemractPlainsWest { get; set; }

        [JsonProperty("Cathedral Harbour")]
        public GenericTerr CathedralHarbour { get; set; }
        public GenericTerr Selchar { get; set; }

        [JsonProperty("Durum Isles Lower")]
        public GenericTerr DurumIslesLower { get; set; }

        [JsonProperty("Nodguj Nation")]
        public GenericTerr NodgujNation { get; set; }

        [JsonProperty("Dead Island South West")]
        public GenericTerr DeadIslandSouthWest { get; set; }

        [JsonProperty("Tree Island")]
        public GenericTerr TreeIsland { get; set; }

        [JsonProperty("Mining Base Upper")]
        public GenericTerr MiningBaseUpper { get; set; }

        [JsonProperty("Nether Plains Lower")]
        public GenericTerr NetherPlainsLower { get; set; }

        [JsonProperty("Nether Plains Upper")]
        public GenericTerr NetherPlainsUpper { get; set; }

        [JsonProperty("Llevigar Gate East")]
        public GenericTerr LlevigarGateEast { get; set; }
        public GenericTerr Hive { get; set; }

        [JsonProperty("Llevigar Plains West Upper")]
        public GenericTerr LlevigarPlainsWestUpper { get; set; }

        [JsonProperty("Swamp East Mid")]
        public GenericTerr SwampEastMid { get; set; }

        [JsonProperty("Swamp West Upper")]
        public GenericTerr SwampWestUpper { get; set; }

        [JsonProperty("Swamp Dark Forest Transition Upper")]
        public GenericTerr SwampDarkForestTransitionUpper { get; set; }

        [JsonProperty("Swamp Mountain Base")]
        public GenericTerr SwampMountainBase { get; set; }

        [JsonProperty("Swamp Mountain Transition Mid-Upper")]
        public GenericTerr SwampMountainTransitionMidUpper { get; set; }

        [JsonProperty("Quartz Mines North West")]
        public GenericTerr QuartzMinesNorthWest { get; set; }

        [JsonProperty("Orc Road")]
        public GenericTerr OrcRoad { get; set; }

        [JsonProperty("Iron Road")]
        public GenericTerr IronRoad { get; set; }

        [JsonProperty("Goblin Plains East")]
        public GenericTerr GoblinPlainsEast { get; set; }

        [JsonProperty("Efilim Village")]
        public GenericTerr EfilimVillage { get; set; }

        [JsonProperty("Light Forest North Entrance")]
        public GenericTerr LightForestNorthEntrance { get; set; }

        [JsonProperty("Light Forest South Exit")]
        public GenericTerr LightForestSouthExit { get; set; }

        [JsonProperty("Light Forest West Upper")]
        public GenericTerr LightForestWestUpper { get; set; }

        [JsonProperty("Hobbit River")]
        public GenericTerr HobbitRiver { get; set; }

        [JsonProperty("Lone Farmstead")]
        public GenericTerr LoneFarmstead { get; set; }

        [JsonProperty("Taproot Descent")]
        public GenericTerr TaprootDescent { get; set; }

        [JsonProperty("Twisted Housing")]
        public GenericTerr TwistedHousing { get; set; }

        [JsonProperty("Abandoned Manor")]
        public GenericTerr AbandonedManor { get; set; }

        [JsonProperty("Viscera Pits East")]
        public GenericTerr VisceraPitsEast { get; set; }
        public GenericTerr Lexdale { get; set; }

        [JsonProperty("Cinfras Entrance")]
        public GenericTerr CinfrasEntrance { get; set; }

        [JsonProperty("Guild Hall")]
        public GenericTerr GuildHall { get; set; }

        [JsonProperty("Cinfras County Mid-Lower")]
        public GenericTerr CinfrasCountyMidLower { get; set; }

        [JsonProperty("Gylia Lake South West")]
        public GenericTerr GyliaLakeSouthWest { get; set; }

        [JsonProperty("Jitak's Farm")]
        public GenericTerr JitakSFarm { get; set; }

        [JsonProperty("Aldorei's River")]
        public GenericTerr AldoreiSRiver { get; set; }

        [JsonProperty("Path To The Arch")]
        public GenericTerr PathToTheArch { get; set; }

        [JsonProperty("Cinfras Thanos Transition")]
        public GenericTerr CinfrasThanosTransition { get; set; }

        [JsonProperty("Military Base")]
        public GenericTerr MilitaryBase { get; set; }

        [JsonProperty("Path To Ozoth's Spire Mid")]
        public GenericTerr PathToOzothSSpireMid { get; set; }

        [JsonProperty("Canyon Entrance Waterfall")]
        public GenericTerr CanyonEntranceWaterfall { get; set; }

        [JsonProperty("Canyon Upper North West")]
        public GenericTerr CanyonUpperNorthWest { get; set; }

        [JsonProperty("Bandit Camp Exit")]
        public GenericTerr BanditCampExit { get; set; }

        [JsonProperty("Canyon Walk Way")]
        public GenericTerr CanyonWalkWay { get; set; }

        [JsonProperty("Canyon Fortress")]
        public GenericTerr CanyonFortress { get; set; }

        [JsonProperty("Bandits Toll")]
        public GenericTerr BanditsToll { get; set; }

        [JsonProperty("Cliff Side of the Lost")]
        public GenericTerr CliffSideOfTheLost { get; set; }

        [JsonProperty("Hive South")]
        public GenericTerr HiveSouth { get; set; }

        [JsonProperty("Air Temple Lower")]
        public GenericTerr AirTempleLower { get; set; }

        [JsonProperty("Kandon-Beda")]
        public GenericTerr KandonBeda { get; set; }

        [JsonProperty("Entrance to Thesead North")]
        public GenericTerr EntranceToTheseadNorth { get; set; }

        [JsonProperty("Ranol's Farm")]
        public GenericTerr RanolSFarm { get; set; }
        public GenericTerr Eltom { get; set; }

        [JsonProperty("Crater Descent")]
        public GenericTerr CraterDescent { get; set; }

        [JsonProperty("Temple Island")]
        public GenericTerr TempleIsland { get; set; }

        [JsonProperty("Dernel Jungle Upper")]
        public GenericTerr DernelJungleUpper { get; set; }

        [JsonProperty("Fallen Factory")]
        public GenericTerr FallenFactory { get; set; }

        [JsonProperty("Factory Entrance")]
        public GenericTerr FactoryEntrance { get; set; }

        [JsonProperty("Avos Workshop")]
        public GenericTerr AvosWorkshop { get; set; }

        [JsonProperty("Ruined Houses")]
        public GenericTerr RuinedHouses { get; set; }

        [JsonProperty("Corkus Outskirts")]
        public GenericTerr CorkusOutskirts { get; set; }

        [JsonProperty("Path to Ahmsord Upper")]
        public GenericTerr PathToAhmsordUpper { get; set; }

        [JsonProperty("Astraulus' Tower")]
        public GenericTerr AstraulusTower { get; set; }

        [JsonProperty("Angel Refuge")]
        public GenericTerr AngelRefuge { get; set; }

        [JsonProperty("Sky Falls")]
        public GenericTerr SkyFalls { get; set; }

        [JsonProperty("Jofash Docks")]
        public GenericTerr JofashDocks { get; set; }

        [JsonProperty("Phinas Farm")]
        public GenericTerr PhinasFarm { get; set; }
        public GenericTerr Llevigar { get; set; }

        [JsonProperty("Icy Island")]
        public GenericTerr IcyIsland { get; set; }

        [JsonProperty("Abandoned Pass")]
        public GenericTerr AbandonedPass { get; set; }

        [JsonProperty("Corkus Sea Cove")]
        public GenericTerr CorkusSeaCove { get; set; }

        [JsonProperty("Grey Ruins")]
        public GenericTerr GreyRuins { get; set; }
        public GenericTerr Lutho { get; set; }

        [JsonProperty("Gateway to Nothing")]
        public GenericTerr GatewayToNothing { get; set; }

        [JsonProperty("The Gate")]
        public GenericTerr TheGate { get; set; }

        [JsonProperty("Azure Frontier")]
        public GenericTerr AzureFrontier { get; set; }

        [JsonProperty("Light Peninsula")]
        public GenericTerr LightPeninsula { get; set; }

        [JsonProperty("Ragni North Suburbs")]
        public GenericTerr RagniNorthSuburbs { get; set; }

        [JsonProperty("Pigmen Ravines Entrance")]
        public GenericTerr PigmenRavinesEntrance { get; set; }

        [JsonProperty("Elkurn Fields")]
        public GenericTerr ElkurnFields { get; set; }

        [JsonProperty("Corrupted Road")]
        public GenericTerr CorruptedRoad { get; set; }

        [JsonProperty("Arachnid Route")]
        public GenericTerr ArachnidRoute { get; set; }

        [JsonProperty("Nesaak Plains South East")]
        public GenericTerr NesaakPlainsSouthEast { get; set; }

        [JsonProperty("Great Bridge Nesaak")]
        public GenericTerr GreatBridgeNesaak { get; set; }

        [JsonProperty("Rymek East Lower")]
        public GenericTerr RymekEastLower { get; set; }

        [JsonProperty("Desert East Lower")]
        public GenericTerr DesertEastLower { get; set; }

        [JsonProperty("Desert West Lower")]
        public GenericTerr DesertWestLower { get; set; }

        [JsonProperty("Plains Coast")]
        public GenericTerr PlainsCoast { get; set; }

        [JsonProperty("Rooster Island")]
        public GenericTerr RoosterIsland { get; set; }

        [JsonProperty("Skiens Island")]
        public GenericTerr SkiensIsland { get; set; }

        [JsonProperty("Volcano Upper")]
        public GenericTerr VolcanoUpper { get; set; }

        [JsonProperty("Nesaak Transition")]
        public GenericTerr NesaakTransition { get; set; }

        [JsonProperty("Detlas Trail West Plains")]
        public GenericTerr DetlasTrailWestPlains { get; set; }

        [JsonProperty("Llevigar Plains East Lower")]
        public GenericTerr LlevigarPlainsEastLower { get; set; }

        [JsonProperty("Swamp West Mid-Upper")]
        public GenericTerr SwampWestMidUpper { get; set; }

        [JsonProperty("Entrance to Olux")]
        public GenericTerr EntranceToOlux { get; set; }

        [JsonProperty("Quartz Mines South West")]
        public GenericTerr QuartzMinesSouthWest { get; set; }

        [JsonProperty("Sablestone Camp")]
        public GenericTerr SablestoneCamp { get; set; }

        [JsonProperty("Leadin Fortress")]
        public GenericTerr LeadinFortress { get; set; }

        [JsonProperty("Light Forest South Entrance")]
        public GenericTerr LightForestSouthEntrance { get; set; }

        [JsonProperty("Light Forest East Mid")]
        public GenericTerr LightForestEastMid { get; set; }

        [JsonProperty("Gelibord Corrupted Farm")]
        public GenericTerr GelibordCorruptedFarm { get; set; }

        [JsonProperty("Viscera Pits West")]
        public GenericTerr VisceraPitsWest { get; set; }

        [JsonProperty("Old Crossroads South")]
        public GenericTerr OldCrossroadsSouth { get; set; }

        [JsonProperty("Fallen Village")]
        public GenericTerr FallenVillage { get; set; }

        [JsonProperty("Cinfras County Upper")]
        public GenericTerr CinfrasCountyUpper { get; set; }

        [JsonProperty("Aldorei Valley Mid")]
        public GenericTerr AldoreiValleyMid { get; set; }

        [JsonProperty("Burning Farm")]
        public GenericTerr BurningFarm { get; set; }

        [JsonProperty("Military Base Lower")]
        public GenericTerr MilitaryBaseLower { get; set; }

        [JsonProperty("Canyon Path South East")]
        public GenericTerr CanyonPathSouthEast { get; set; }

        [JsonProperty("Thanos Valley West")]
        public GenericTerr ThanosValleyWest { get; set; }

        [JsonProperty("Canyon Dropoff")]
        public GenericTerr CanyonDropoff { get; set; }

        [JsonProperty("Temple of the Lost East")]
        public GenericTerr TempleOfTheLostEast { get; set; }

        [JsonProperty("Cliffside Lake")]
        public GenericTerr CliffsideLake { get; set; }

        [JsonProperty("Chained House")]
        public GenericTerr ChainedHouse { get; set; }

        [JsonProperty("Lava Lake")]
        public GenericTerr LavaLake { get; set; }

        [JsonProperty("Dernel Jungle Lower")]
        public GenericTerr DernelJungleLower { get; set; }

        [JsonProperty("Corkus City Mine")]
        public GenericTerr CorkusCityMine { get; set; }

        [JsonProperty("Corkus Countryside")]
        public GenericTerr CorkusCountryside { get; set; }

        [JsonProperty("Sky Castle")]
        public GenericTerr SkyCastle { get; set; }

        [JsonProperty("Ahmsord Outskirts")]
        public GenericTerr AhmsordOutskirts { get; set; }

        [JsonProperty("Raider's Base Lower")]
        public GenericTerr RaiderSBaseLower { get; set; }

        [JsonProperty("Cinfras Outskirts")]
        public GenericTerr CinfrasOutskirts { get; set; }

        [JsonProperty("Fleris Trail")]
        public GenericTerr FlerisTrail { get; set; }

        [JsonProperty("The Broken Road")]
        public GenericTerr TheBrokenRoad { get; set; }

        [JsonProperty("Toxic Drip")]
        public GenericTerr ToxicDrip { get; set; }

        [JsonProperty("Luminous Plateau")]
        public GenericTerr LuminousPlateau { get; set; }

        [JsonProperty("Emerald Trail")]
        public GenericTerr EmeraldTrail { get; set; }

        [JsonProperty("Time Valley")]
        public GenericTerr TimeValley { get; set; }

        [JsonProperty("Detlas Close Suburbs")]
        public GenericTerr DetlasCloseSuburbs { get; set; }

        [JsonProperty("Nesaak Plains Upper North West")]
        public GenericTerr NesaakPlainsUpperNorthWest { get; set; }

        [JsonProperty("Rymek West Mid")]
        public GenericTerr RymekWestMid { get; set; }

        [JsonProperty("Savannah West Upper")]
        public GenericTerr SavannahWestUpper { get; set; }

        [JsonProperty("Durum Isles Upper")]
        public GenericTerr DurumIslesUpper { get; set; }

        [JsonProperty("Ternaves Plains Upper")]
        public GenericTerr TernavesPlainsUpper { get; set; }

        [JsonProperty("Llevigar Farm Plains East")]
        public GenericTerr LlevigarFarmPlainsEast { get; set; }

        [JsonProperty("Swamp Dark Forest Transition Lower")]
        public GenericTerr SwampDarkForestTransitionLower { get; set; }

        [JsonProperty("Sunspark Camp")]
        public GenericTerr SunsparkCamp { get; set; }

        [JsonProperty("Efilim East Plains")]
        public GenericTerr EfilimEastPlains { get; set; }

        [JsonProperty("Light Forest Canyon")]
        public GenericTerr LightForestCanyon { get; set; }

        [JsonProperty("Kander Mines")]
        public GenericTerr KanderMines { get; set; }

        [JsonProperty("Cinfras's Small Farm")]
        public GenericTerr CinfrasSSmallFarm { get; set; }

        [JsonProperty("Aldorei's North Exit")]
        public GenericTerr AldoreiSNorthExit { get; set; }

        [JsonProperty("Bandit Cave Lower")]
        public GenericTerr BanditCaveLower { get; set; }

        [JsonProperty("Canyon Mountain South")]
        public GenericTerr CanyonMountainSouth { get; set; }

        [JsonProperty("Cliffside Waterfall")]
        public GenericTerr CliffsideWaterfall { get; set; }
        public GenericTerr Thesead { get; set; }

        [JsonProperty("Corkus Castle")]
        public GenericTerr CorkusCastle { get; set; }

        [JsonProperty("Avos Temple")]
        public GenericTerr AvosTemple { get; set; }

        [JsonProperty("Central Islands")]
        public GenericTerr CentralIslands { get; set; }

        [JsonProperty("Herb Cave")]
        public GenericTerr HerbCave { get; set; }

        [JsonProperty("Forest of Eyes")]
        public GenericTerr ForestOfEyes { get; set; }

        [JsonProperty("Path to Light")]
        public GenericTerr PathToLight { get; set; }

        [JsonProperty("Maltic Coast")]
        public GenericTerr MalticCoast { get; set; }

        [JsonProperty("Mage Island")]
        public GenericTerr MageIsland { get; set; }

        [JsonProperty("Desert Lower")]
        public GenericTerr DesertLower { get; set; }

        [JsonProperty("Dead Island South East")]
        public GenericTerr DeadIslandSouthEast { get; set; }

        [JsonProperty("Swamp West Lower")]
        public GenericTerr SwampWestLower { get; set; }

        [JsonProperty("Llevigar Farm")]
        public GenericTerr LlevigarFarm { get; set; }

        [JsonProperty("Fortress South")]
        public GenericTerr FortressSouth { get; set; }

        [JsonProperty("Gylia Lake North East")]
        public GenericTerr GyliaLakeNorthEast { get; set; }

        [JsonProperty("Canyon Path South West")]
        public GenericTerr CanyonPathSouthWest { get; set; }

        [JsonProperty("Cliffside Passage")]
        public GenericTerr CliffsidePassage { get; set; }

        [JsonProperty("Corkus Forest North")]
        public GenericTerr CorkusForestNorth { get; set; }
        public GenericTerr Lusuco { get; set; }

        [JsonProperty("Final Step")]
        public GenericTerr FinalStep { get; set; }

        [JsonProperty("Jungle Upper")]
        public GenericTerr JungleUpper { get; set; }

        [JsonProperty("Mine Base Plains")]
        public GenericTerr MineBasePlains { get; set; }

        [JsonProperty("Light Forest West Lower")]
        public GenericTerr LightForestWestLower { get; set; }

        [JsonProperty("Path To Thanos")]
        public GenericTerr PathToThanos { get; set; }

        [JsonProperty("Volcanic Slope")]
        public GenericTerr VolcanicSlope { get; set; }

        [JsonProperty("Southern Outpost")]
        public GenericTerr SouthernOutpost { get; set; }

        [JsonProperty("Ancient Nemract")]
        public GenericTerr AncientNemract { get; set; }

        [JsonProperty("Decayed Basin")]
        public GenericTerr DecayedBasin { get; set; }

        [JsonProperty("Old Coal Mine")]
        public GenericTerr OldCoalMine { get; set; }

        [JsonProperty("South Nivla Woods")]
        public GenericTerr SouthNivlaWoods { get; set; }

        [JsonProperty("Mountain Path")]
        public GenericTerr MountainPath { get; set; }

        [JsonProperty("Swamp Mountain Transition Lower")]
        public GenericTerr SwampMountainTransitionLower { get; set; }
    }

    public class Location
    {
        public int startX { get; set; }
        public int startY { get; set; }
        public int endX { get; set; }
        public int endY { get; set; }
    }

}
