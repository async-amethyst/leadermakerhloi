﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Reflection;

namespace leadermakerhloi
{
    internal class readConfig
    {
        public static ConfigFile ReadConfigFile()
        {
            string jsonString = File.ReadAllText((Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"config.json")));
            ConfigFile config = JsonSerializer.Deserialize<ConfigFile>(jsonString);
            return config;
        }
    }
    public class ConfigFile
    {
        public bool useTraits { get; set; }
        public string expirationDate { get; set; }
        public bool useMultipleDDSNames { get; set; }
        public string ddsName { get; set; }
        public bool useExternalFiles { get; set; }
        public string[] tags { get; set; } = new string[100];
        public string[] names { get; set; } = new string[100];
        public Traits[] traits { get; set; } = new Traits[100];
        public string[] ddsNames { get; set; } = new string[200];
        public string[] ideologies { get; set; } = new string[100];
    }
    public class Traits
    {
        public string name { get; set; }
        public string[] nationsWithTrait { get; set; } = new string[100];
    }
}
