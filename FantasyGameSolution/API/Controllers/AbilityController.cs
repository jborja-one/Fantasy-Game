﻿using System;using System.Collections.Generic;using System.Linq;using System.Threading.Tasks;using API.DTOs;using API.Services;using Microsoft.AspNetCore.Mvc;// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860namespace API.Controllers{    [ApiController]    [Route("api/[controller]")]    public class AbilityController : ControllerBase    {        private readonly AbilityService _abilityService;        public AbilityController(AbilityService abilityService)        {            _abilityService = abilityService;        }        //[HttpPost]        //public IActionResult ExecuteAbility([FromBody] AbilityExecutionRequest request)        //{        //    var result = _abilityService.ExecuteAbility(request.CharacterId, request.AbilityName);        //    if(!result.Success)        //    {        //        return BadRequest(result.Message);        //    }        //    return Ok(result);        //}    }}