using IntenseWizardy_ShadowsOfVeilstorm.Models;
using IntenseWizardy_ShadowsOfVeilstorm.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntenseWizardy_ShadowsOfVeilstorm.Pages
{
    public class CharactersModel : PageModel
    {
        private readonly ILogger<CharactersModel> _logger;
        public JsonFileCharactersService CharactersService;

        public IEnumerable<NPCharacters> characterList { get; private set; }

        public CharactersModel(ILogger<CharactersModel> logger, JsonFileCharactersService charactersService)
        {
            _logger = logger;
            CharactersService = charactersService;
        }

        public void OnGet()
        {
            characterList = CharactersService.GetCharacters();
        }
    }
}