﻿using System;namespace API.DTOs{    public class SpellExecutionRequest    {        public int CharacterId { get; set; } // The ID of the character performing the action        public string? SpellName { get; set; } // The name of the action to be executed    }}