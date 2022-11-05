﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalesOfTribute
{
    /// <summary>
    /// I'm 99% sure I shouldn't do it that way but it's easier to work with this than read JSON file,
    /// because of the folder management in VS :(
    /// </summary>
    public class cards_config
    {
        public const string CARDS_JSON = @"[
    {
       ""id"":0,
       ""Name"":""Currency Exchange"",
       ""Deck"":""Hlaalu"",
       ""Cost"":7,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 6 AND Remove 2"",
       ""Combo 2"":""Patron 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":1,
       ""Name"":""Luxury Exports"",
       ""Deck"":""Hlaalu"",
       ""Cost"":2,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 3"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":2,
       ""Name"":""Oathman"",
       ""Deck"":""Hlaalu"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":2,
       ""Activation"":""Coin 2"",
       ""Combo 2"":""Acquire 6"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":3,
       ""Name"":""Ebony Mine"",
       ""Deck"":""Hlaalu"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":null,
       ""Combo 3"":""Coin 4"",
       ""Combo 4"":null
    },
    {
       ""id"":4,
       ""Name"":""Hlaalu Councilor"",
       ""Deck"":""Hlaalu"",
       ""Cost"":10,
       ""Type"":""Agent"",
       ""HP"":2,
       ""Activation"":""Acquire 9"",
       ""Combo 2"":""Remove 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":5
    },
    {
       ""id"":5,
       ""Name"":""Hlaalu Kinsman"",
       ""Deck"":""Hlaalu"",
       ""Cost"":10,
       ""Type"":""Agent"",
       ""HP"":1,
       ""Activation"":""Acquire 9"",
       ""Combo 2"":""Remove 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":5
    },
    {
       ""id"":6,
       ""Name"":""House Embassy"",
       ""Deck"":""Hlaalu"",
       ""Cost"":8,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 7"",
       ""Combo 2"":""Acquire 7"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":7
    },
    {
       ""id"":7,
       ""Name"":""House Marketplace"",
       ""Deck"":""Hlaalu"",
       ""Cost"":8,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 6 AND Remove 2"",
       ""Combo 2"":""Acquire 7"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":7
    },
    {
       ""id"":8,
       ""Name"":""Kwama Egg Mine"",
       ""Deck"":""Hlaalu"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":null,
       ""Combo 3"":""Coin 3"",
       ""Combo 4"":null
    },
    {
       ""id"":9,
       ""Name"":""Hireling"",
       ""Deck"":""Hlaalu"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":2,
       ""Activation"":""Coin 2"",
       ""Combo 2"":""Acquire 5"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":10,
       ""Name"":""Hostile Takeover"",
       ""Deck"":""Hlaalu"",
       ""Cost"":5,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 1"",
       ""Combo 2"":""Acquire 7"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":11,
       ""Name"":""Customs Seizure"",
       ""Deck"":""Hlaalu"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Acquire 5"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":12,
       ""Name"":""Goods Shipment"",
       ""Deck"":""Hlaalu"",
       ""Cost"":0,
       ""Type"":""Starter"",
       ""HP"":-1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":13,
       ""Name"":""Midnight Raid"",
       ""Deck"":""Red Eagle"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 3"",
       ""Combo 2"":""Power 2"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":14,
       ""Name"":""Blood Sacrifice"",
       ""Deck"":""Red Eagle"",
       ""Cost"":6,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Power 3 AND Destroy 1"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"": 15
    },
    {
       ""id"":15,
       ""Name"":""Bloody Offering"",
       ""Deck"":""Red Eagle"",
       ""Cost"":6,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Power 2 AND Destroy 1"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":15
    },
    {
       ""id"":16,
       ""Name"":""Bonfire"",
       ""Deck"":""Red Eagle"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Destroy 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":17,
       ""Name"":""Briarheart Ritual"",
       ""Deck"":""Red Eagle"",
       ""Cost"":5,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Power 1 AND Destroy 2"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":18,
       ""Name"":""Clan-Witch"",
       ""Deck"":""Red Eagle"",
       ""Cost"":6,
       ""Type"":""Contract Agent"",
       ""HP"":4,
       ""Activation"":""Destroy 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":19,
       ""Name"":""Elder Witch"",
       ""Deck"":""Red Eagle"",
       ""Cost"":6,
       ""Type"":""Contract Agent"",
       ""HP"":4,
       ""Activation"":""Destroy 1"",
       ""Combo 2"":""Remove 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":20,
       ""Name"":""Hagraven"",
       ""Deck"":""Red Eagle"",
       ""Cost"":9,
       ""Type"":""Agent"",
       ""HP"":4,
       ""Activation"":""Destroy 1"",
       ""Combo 2"":""Power 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":20
    },
    {
       ""id"":21,
       ""Name"":""Hagraven Matron"",
       ""Deck"":""Red Eagle"",
       ""Cost"":9,
       ""Type"":""Agent"",
       ""HP"":4,
       ""Activation"":""Destroy 1"",
       ""Combo 2"":""Power 3"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":20
    },
    {
       ""id"":22,
       ""Name"":""Imperial Plunder"",
       ""Deck"":""Red Eagle"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Remove 2"",
       ""Combo 2"":""Coin 2"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":23,
       ""Name"":""Imperial Spoils"",
       ""Deck"":""Red Eagle"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Remove 2"",
       ""Combo 2"":""Coin 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":24,
       ""Name"":""Karth Man-Hunter"",
       ""Deck"":""Red Eagle"",
       ""Cost"":5,
       ""Type"":""Contract Agent"",
       ""HP"":2,
       ""Activation"":""Power 1"",
       ""Combo 2"":""Destroy 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":25,
       ""Name"":""War Song"",
       ""Deck"":""Red Eagle"",
       ""Cost"":0,
       ""Type"":""Starter"",
       ""HP"":-1,
       ""Activation"":""Power 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":26,
       ""Name"":""Blackfeather Knave"",
       ""Deck"":""Crows"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":2,
       ""Activation"":""Coin 2"",
       ""Combo 2"":null,
       ""Combo 3"":""Draw 1"",
       ""Combo 4"":null,
       ""Family"": 36,
    },
    {
       ""id"":27,
       ""Name"":""Plunder"",
       ""Deck"":""Crows"",
       ""Cost"":6,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Draw 1"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":null,
       ""Combo 4"":""Draw 1""
    },
    {
       ""id"":28,
       ""Name"":""Toll of Flesh"",
       ""Deck"":""Crows"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":29,
       ""Name"":""Toll of Silver"",
       ""Deck"":""Crows"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":""Coin 1"",
       ""Combo 4"":null
    },
    {
       ""id"":30,
       ""Name"":""Murder of Crows"",
       ""Deck"":""Crows"",
       ""Cost"":6,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":""Coin 2 AND Power 2"",
       ""Combo 3"":""Power 2"",
       ""Combo 4"":null,
       ""Family"":35
    },
    {
       ""id"":31,
       ""Name"":""Pilfer"",
       ""Deck"":""Crows"",
       ""Cost"":5,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Draw 1"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":32,
       ""Name"":""Squawking Oratory"",
       ""Deck"":""Crows"",
       ""Cost"":6,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Draw 1"",
       ""Combo 2"":null,
       ""Combo 3"":""Draw 1"",
       ""Combo 4"":""Power 4""
    },
    {
       ""id"":33,
       ""Name"":""Law of Sovereign Roost"",
       ""Deck"":""Crows"",
       ""Cost"":4,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Draw 1"",
       ""Combo 2"":null,
       ""Combo 3"":""Discard 1"",
       ""Combo 4"":null
    },
    {
       ""id"":34,
       ""Name"":""Pool of Shadow"",
       ""Deck"":""Crows"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 1"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":null,
       ""Combo 4"":""Coin 3""
    },
    {
       ""id"":35,
       ""Name"":""Scratch"",
       ""Deck"":""Crows"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":""Coin 2 AND Power 2"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":35
    },
    {
       ""id"":36,
       ""Name"":""Blackfeather Brigand"",
       ""Deck"":""Crows"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":2,
       ""Activation"":""Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":""Draw 1"",
       ""Combo 4"":null,
       ""Family"": 36
    },
    {
       ""id"":37,
       ""Name"":""Blackfeather Knight"",
       ""Deck"":""Crows"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":3,
       ""Activation"":""Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":""Coin 2 AND Power 2"",
       ""Combo 4"":null
    },
    {
       ""id"":38,
       ""Name"":""Peck"",
       ""Deck"":""Crows"",
       ""Cost"":0,
       ""Type"":""Starter"",
       ""HP"":-1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":39,
       ""Name"":""Conquest"",
       ""Deck"":""Ansei"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 3 OR Acquire 4"",
       ""Combo 2"":""Power 2"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":40,
       ""Name"":""Grand Oratory"",
       ""Deck"":""Ansei"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Power 2 OR Return 1"",
       ""Combo 2"":""Coin 2"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":48
    },
    {
       ""id"":41,
       ""Name"":""Hira's End"",
       ""Deck"":""Ansei"",
       ""Cost"":6,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 4 OR Return 3"",
       ""Combo 2"":null,
       ""Combo 3"":""Power 3"",
       ""Combo 4"":null
    },
    {
       ""id"":42,
       ""Name"":""Hel Shira Herald"",
       ""Deck"":""Ansei"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":3,
       ""Activation"":""Return 2"",
       ""Combo 2"":""Power 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":43,
       ""Name"":""March on Hattu"",
       ""Deck"":""Ansei"",
       ""Cost"":6,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 4 OR Return 3"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":44,
       ""Name"":""Shehai Summoning"",
       ""Deck"":""Ansei"",
       ""Cost"":5,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Return 2 OR Acquire 5"",
       ""Combo 2"":""Return 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":45,
       ""Name"":""Warrior Wave"",
       ""Deck"":""Ansei"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 3 OR Acquire 4"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":46,
       ""Name"":""Ansei Assault"",
       ""Deck"":""Ansei"",
       ""Cost"":9,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 5 OR Acquire 9"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":46,
   },
   {
       ""id"":47,
       ""Name"":""Ansei's Victory"",
       ""Deck"":""Ansei"",
       ""Cost"":9,
        ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 6 OR Acquire 10"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":46,
    },
    {
       ""id"":48,
       ""Name"":""Battle Meditation"",
       ""Deck"":""Ansei"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Power 2 OR Return 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":48
    },
    {
       ""id"":49,
       ""Name"":""No Shira Poet"",
       ""Deck"":""Ansei"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":3,
       ""Activation"":""Return 1"",
       ""Combo 2"":""Power 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":50,
       ""Name"":""Way of the Sword"",
       ""Deck"":""Ansei"",
       ""Cost"":0,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 1 OR Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":51,
       ""Name"":""Prophesy"",
       ""Deck"":""Psijic"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 3 AND Remove 2"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":52,
       ""Name"":""Scrying Globe"",
       ""Deck"":""Psijic"",
       ""Cost"":2,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2 AND Toss 2"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":53,
       ""Name"":""The Dreaming Cave"",
       ""Deck"":""Psijic"",
       ""Cost"":6,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Draw 1 AND Toss 4"",
       ""Combo 2"":""Power 2"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":54,
       ""Name"":""Augur's Counsel"",
       ""Deck"":""Psijic"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Toss 3"",
       ""Combo 2"":""Power 2"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":55,
       ""Name"":""Psijic Relicmaster"",
       ""Deck"":""Psijic"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":3,
       ""Activation"":""Toss 4 AND Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":58
    },
    {
       ""id"":56,
       ""Name"":""Sage Counsel"",
       ""Deck"":""Psijic"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Toss 3"",
       ""Combo 2"":""Power 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":57,
       ""Name"":""Prescience"",
       ""Deck"":""Psijic"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 3 AND Remove 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":58,
       ""Name"":""Psijic Apprentice"",
       ""Deck"":""Psijic"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":3,
       ""Activation"":""Toss 4"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":58
    },
    {
       ""id"":59,
       ""Name"":""Ceporah's Insight"",
       ""Deck"":""Psijic"",
       ""Cost"":5,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Toss 4 AND Remove 1"",
       ""Combo 2"":""Power 3"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":60
    },
    {
       ""id"":60,
       ""Name"":""Psijic's Insight"",
       ""Deck"":""Psijic"",
       ""Cost"":5,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Toss 4 AND Remove 1"",
       ""Combo 2"":""Power 2"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":60
    },
    {
       ""id"":61,
       ""Name"":""Time Mastery"",
       ""Deck"":""Psijic"",
       ""Cost"":3,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Toss 4"",
       ""Combo 2"":""Coin 2"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":62,
       ""Name"":""Mainland Inquiries"",
       ""Deck"":""Psijic"",
       ""Cost"":0,
       ""Type"":""Starter"",
       ""HP"":-1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":63,
       ""Name"":""Rally"",
       ""Deck"":""Pelin"",
       ""Cost"":8,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 6"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":64,
       ""Name"":""Siege Weapon Volley"",
       ""Deck"":""Pelin"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 4"",
       ""Combo 2"":""Coin 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":65,
       ""Name"":""The Armory"",
       ""Deck"":""Pelin"",
       ""Cost"":6,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 5 AND Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":66,
       ""Name"":""Banneret"",
       ""Deck"":""Pelin"",
       ""Cost"":9,
       ""Type"":""Agent"",
       ""HP"":5,
       ""Activation"":""Taunt AND Power 3"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":66
    },
    {
       ""id"":67,
       ""Name"":""Knight Commander"",
       ""Deck"":""Pelin"",
       ""Cost"":9,
       ""Type"":""Agent"",
       ""HP"":5,
       ""Activation"":""Taunt AND Power 3"",
       ""Combo 2"":""Heal 2"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":66
    },
    {
       ""id"":68,
       ""Name"":""Reinforcements"",
       ""Deck"":""Pelin"",
       ""Cost"":3,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":""Power 2"",
       ""Combo 3"":""Power 1"",
       ""Combo 4"":null,
       ""Family"":68
    },
    {
       ""id"":69,
       ""Name"":""Archers' Volley"",
       ""Deck"":""Pelin"",
       ""Cost"":4,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 3"",
       ""Combo 2"":""Coin 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":70,
       ""Name"":""Legion's Arrival"",
       ""Deck"":""Pelin"",
       ""Cost"":3,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":""Power 3"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":68
    },
    {
       ""id"":71,
       ""Name"":""Shield Bearer"",
       ""Deck"":""Pelin"",
       ""Cost"":6,
       ""Type"":""Contract Agent"",
       ""HP"":5,
       ""Activation"":""Taunt AND Power 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":72,
       ""Name"":""Bangkorai Sentries"",
       ""Deck"":""Pelin"",
       ""Cost"":7,
       ""Type"":""Agent"",
       ""HP"":4,
       ""Activation"":""Taunt AND Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":72
    },
    {
       ""id"":73,
       ""Name"":""Knights of Saint Pelin"",
       ""Deck"":""Pelin"",
       ""Cost"":7,
       ""Type"":""Agent"",
       ""HP"":4,
       ""Activation"":""Taunt AND Coin 1"",
       ""Combo 2"":""Power 2"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":72
    },
    {
       ""id"":74,
       ""Name"":""The Portcullis"",
       ""Deck"":""Pelin"",
       ""Cost"":2,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 2"",
       ""Combo 2"":""Coin 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":75,
       ""Name"":""Fortify"",
       ""Deck"":""Pelin"",
       ""Cost"":0,
       ""Type"":""Starter"",
       ""HP"":-1,
       ""Activation"":""Power 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":76,
       ""Name"":""Bag of Tricks"",
       ""Deck"":""Rajhin"",
       ""Cost"":7,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Discard 1"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":""Discard 1"",
       ""Combo 4"":null,
       ""Family"":76
    },
    {
       ""id"":77,
       ""Name"":""Bewilderment"",
       ""Deck"":""Rajhin"",
       ""Cost"":0,
       ""Type"":""Curse"",
       ""HP"":-1,
       ""Activation"":null,
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":78,
       ""Name"":""Grand Larceny"",
       ""Deck"":""Rajhin"",
       ""Cost"":5,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 5"",
       ""Combo 2"":""KnockOut 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":82,
    },
    {
       ""id"":79,
       ""Name"":""Jarring Lullaby"",
       ""Deck"":""Rajhin"",
       ""Cost"":7,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""KnockOut 2 AND Coin 1"",
       ""Combo 2"":""Coin 3"",
       ""Combo 3"":""Discard 1"",
       ""Combo 4"":null
    },
    {
       ""id"":80,
       ""Name"":""Jeering Shadow"",
       ""Deck"":""Rajhin"",
       ""Cost"":5,
       ""Type"":""Agent"",
       ""HP"":1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":""OppPrestige -1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":81,
       ""Name"":""Moonlit Illusion"",
       ""Deck"":""Rajhin"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Destroy 1"",
       ""Combo 2"":""OppPrestige -1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":82,
       ""Name"":""Pounce and Profit"",
       ""Deck"":""Rajhin"",
       ""Cost"":5,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 4"",
       ""Combo 2"":""KnockOut 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":82
    },
    {
       ""id"":83,
       ""Name"":""Prowling Shadow"",
       ""Deck"":""Rajhin"",
       ""Cost"":4,
       ""Type"":""Agent"",
       ""HP"":1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":""OppPrestige -1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":84,
       ""Name"":""Ring's Guile"",
       ""Deck"":""Rajhin"",
       ""Cost"":7,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Discard 1"",
       ""Combo 2"":""Draw 1"",
       ""Combo 3"":""Draw 1 Discard 1"",
       ""Combo 4"":null,
       ""Family"":76
    },
    {
       ""id"":85,
       ""Name"":""Shadow's Slumber"",
       ""Deck"":""Rajhin"",
       ""Cost"":7,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""KnockOut 2 AND Coin 1"",
       ""Combo 2"":""Coin 4"",
       ""Combo 3"":""Discard 1"",
       ""Combo 4"":null
    },
    {
       ""id"":86,
       ""Name"":""Slight of Hand"",
       ""Deck"":""Rajhin"",
       ""Cost"":2,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":""Remove 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":87,
       ""Name"":""Stubborn Shadow"",
       ""Deck"":""Rajhin"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":3,
       ""Activation"":null,
       ""Combo 2"":""OppPrestige -2"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":88,
       ""Name"":""Swipe"",
       ""Deck"":""Rajhin"",
       ""Cost"":0,
       ""Type"":""Starter"",
       ""HP"":-1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":89,
       ""Name"":""Twilight Revelry"",
       ""Deck"":""Rajhin"",
       ""Cost"":10,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Discard 1"",
       ""Combo 2"":""Remove 3"",
       ""Combo 3"":""OppPrestige -3"",
       ""Combo 4"":""Draw 3""
    },
    {
       ""id"":90,
       ""Name"":""Ghostscale Sea Serpent"",
       ""Deck"":""Orgnum"",
       ""Cost"":2,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 1 AND Prestige 1"",
       ""Combo 2"":""Power 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":91,
       ""Name"":""King Orgnum's Command"",
       ""Deck"":""Orgnum"",
       ""Cost"":2,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Patron 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":92,
       ""Name"":""Maormer Boarding Party"",
       ""Deck"":""Orgnum"",
       ""Cost"":2,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Prestige 2"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":92
    },
    {
       ""id"":93,
       ""Name"":""Maormer Cutter"",
       ""Deck"":""Orgnum"",
       ""Cost"":2,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Power 1"",
       ""Combo 2"":""Power 1"",
       ""Combo 3"":""Power 2"",
       ""Combo 4"":null
    },
    {
       ""id"":94,
       ""Name"":""Pyandonean War Fleet"",
       ""Deck"":""Orgnum"",
       ""Cost"":3,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 2"",
       ""Combo 2"":null,
       ""Combo 3"":""Power 3"",
       ""Combo 4"":null
    },
    {
       ""id"":95,
       ""Name"":""Sea Elf Raid"",
       ""Deck"":""Orgnum"",
       ""Cost"":0,
       ""Type"":""Starter"",
       ""HP"":-1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":""Power 1"",
       ""Combo 4"":null
    },
    {
       ""id"":96,
       ""Name"":""Sea Raider's Glory"",
       ""Deck"":""Orgnum"",
       ""Cost"":2,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Prestige 1"",
       ""Combo 2"":null,
       ""Combo 3"":""Prestige 3"",
       ""Combo 4"":null
    },
    {
       ""id"":97,
       ""Name"":""Sea Serpent Colossus"",
       ""Deck"":""Orgnum"",
       ""Cost"":2,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 1 AND Prestige 1"",
       ""Combo 2"":""Power 2"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":98,
       ""Name"":""Serpentguard Rider"",
       ""Deck"":""Orgnum"",
       ""Cost"":5,
       ""Type"":""Agent"",
       ""HP"":2,
       ""Activation"":""Power 1"",
       ""Combo 2"":""Remove 2"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":101
    },
    {
       ""id"":99,
       ""Name"":""Serpentprow Schooner"",
       ""Deck"":""Orgnum"",
       ""Cost"":3,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Power 2"",
       ""Combo 2"":null,
       ""Combo 3"":""Power 2"",
       ""Combo 4"":null
    },
    {
       ""id"":100,
       ""Name"":""Snakeskin Freebooter"",
       ""Deck"":""Orgnum"",
       ""Cost"":6,
       ""Type"":""Agent"",
       ""HP"":3,
       ""Activation"":""Coin 1"",
       ""Combo 2"":""Create 1"",
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":101,
       ""Name"":""Storm Shark Wavecaller"",
       ""Deck"":""Orgnum"",
       ""Cost"":5,
       ""Type"":""Agent"",
       ""HP"":2,
       ""Activation"":""Power 1"",
       ""Combo 2"":""Remove 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":101
    },
    {
       ""id"":102,
       ""Name"":""Summerset Sacking"",
       ""Deck"":""Orgnum"",
       ""Cost"":2,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Prestige 2"",
       ""Combo 2"":""Coin 1"",
       ""Combo 3"":null,
       ""Combo 4"":null,
       ""Family"":92
    },
    {
       ""id"":103,
       ""Name"":""Ambush"",
       ""Deck"":""Treasury"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""KnockOut 2"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":104,
       ""Name"":""Barterer"",
       ""Deck"":""Treasury"",
       ""Cost"":1,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Remove 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":105,
       ""Name"":""Black Sacrament"",
       ""Deck"":""Treasury"",
       ""Cost"":2,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""KnockOut 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":106,
       ""Name"":""Blackmail"",
       ""Deck"":""Treasury"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Power 2"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":107,
       ""Name"":""Gold"",
       ""Deck"":""Treasury"",
       ""Cost"":0,
       ""Type"":""Starter"",
       ""HP"":-1,
       ""Activation"":""Coin 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":108,
       ""Name"":""Harvest Season"",
       ""Deck"":""Treasury"",
       ""Cost"":2,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Draw 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":109,
       ""Name"":""Imprisonment"",
       ""Deck"":""Treasury"",
       ""Cost"":5,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Power 4"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":110,
       ""Name"":""Ragpicker"",
       ""Deck"":""Treasury"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Destroy 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":111,
       ""Name"":""Tithe"",
       ""Deck"":""Treasury"",
       ""Cost"":3,
       ""Type"":""Contract Action"",
       ""HP"":-1,
       ""Activation"":""Patron 1"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    },
    {
       ""id"":112,
       ""Name"":""Writ of Coin"",
       ""Deck"":""Treasury"",
       ""Cost"":0,
       ""Type"":""Action"",
       ""HP"":-1,
       ""Activation"":""Coin 2"",
       ""Combo 2"":null,
       ""Combo 3"":null,
       ""Combo 4"":null
    }
 ]";
    }
}
