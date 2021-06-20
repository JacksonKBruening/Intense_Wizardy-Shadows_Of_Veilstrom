using IntenseWizardy_ShadowsOfVeilstorm.Models;
using IntenseWizardy_ShadowsOfVeilstorm.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntenseWizardy_ShadowsOfVeilstorm.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharactersDatabaseController : ControllerBase
    {
        public CharactersDatabaseController(JsonFileCharactersService charactersService)
        {
            this.CharactersService = charactersService;
        }

        public JsonFileCharactersService CharactersService { get; }

        [HttpGet]
        public IEnumerable<NPCharacters> Get()
        {
            return CharactersService.GetCharacters();
        }
    }
}
