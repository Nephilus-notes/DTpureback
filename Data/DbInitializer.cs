﻿using DTpureback.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using MessagePack;
using static NuGet.Packaging.PackagingConstants;
using NuGet.Packaging.Signing;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using NuGet.Protocol.Plugins;
using System.Security.Policy;
using System.Threading;

namespace DTpureback.Data
{
    public class DbInitializer
    {
        public static void Initialize(DragonsTailContext context)
        {
            if(context.PlayerCharacters.Any())
            {
                return;
            }

            var charles = new User
            {
                Name = "Charles",
                Email = "Cmhmcc@gmail.com",
                Password = "Sup",
            };

            var shawn = new User
            {
                Name = "Shawn",
                Email = "smoethin@s.com",
                Password = "Sup",
            };

            var users = new User[]
            {
                charles,
                shawn
            };

            context.Users.AddRange(users);

            var scythe = new Item
            {
                name = "Death's Scythe",
                ItemStat = 15,
                Price = 500,
                Slot = "hand",
                Description = " A powerful scythe thrumming with magical energy." +
                " Whenever you touch this weapon you can hear faint whispers all around you."
            };

            var minHealthPot = new Item
            {
                name = "Minor Health Potion",
                ItemStat = 2,
                Price = 10,
                Slot = "consumable",
                Description = "A small red potion that smells of cinnamon and nutmeg. It heals a small amount of health."
            };

            var HealthPot = new Item
            {
                name = "Health Potion",
                ItemStat = 5,
                Price = 200,
                Slot = "consumable",
                Description = "A small orange potion that smells of mint and orange.  It heals some health."
            };
            var majHealthPot = new Item
            {
                name = "Major Health Potion",
                ItemStat = 8,
                Price = 40,
                Slot = "consumable",
                Description = "A small yellow potion that smells of lemon and fresh air. It heals a substantial amount of health."
            };

            var chainmail = new Item
            {
                name = "Chainmail Armor",
                ItemStat = 3,
                Price = 60,
                Slot = "body",
                Description = "A jacket made of steel rings.  It provides great protection without limiting your movement."
            };
            var dagger = new Item
            {
                name = "Dagger",
                ItemStat = 1,
                Price = 10,
                Slot = "hand",
                Description = "A simple dagger with a leatherwrapped bone hilt. It's good for cutting things and taking on large rodents."
            };
            var sword = new Item
            {
                name = "Sword",
                ItemStat = 3,
                Price = 50,
                Slot = "hand",
                Description = "A well-made shortsword that can be used to fight against any foe."
            };
            var axe = new Item
            {
                name = "Axe",
                ItemStat = 4,
                Price = 90,
                Slot = "hand",
                Description = "A polished axe that can easily take chunks out of full grown trees."
            };
            var leather = new Item
            {
                name = "Leather Armor",
                ItemStat = 1,
                Price = 20,
                Slot = "body",
                Description = "A jacket made of toughened leather, it provides some protection against the elements and enemies alike."
            };

            var brigandine = new Item
            {
                name = "Brigandine",
                ItemStat = 4,
                Price = 100,
                Slot = "body",
                Description = "Plates of steel bolted onto a leather and chain tunic, this armor gives almost unparellelled protection" +
                " without sacrificing mobility or size."
                
            };
            var bone = new Item
            {
                name = "Bone Mail",
                ItemStat = 6,
                Price = 150,
                Slot = "body",
                Description = "Someone's prized posession, this armor is made of the the bones of their ancestors. " +
                "The black bones are stronger than steel and you can almost feel a protective aura when you put it on."
            };

            var items = new Item[]
            {
                dagger,
                sword,
                axe,
                scythe,

                leather, 
                chainmail, 
                brigandine,
                bone, 
                minHealthPot,
                HealthPot,
                majHealthPot

            };
            context.Items.AddRange(items);

            var kraktRat = new Character
            {
                Name = "Kratkt Rat",
                Level = 1,
                CurrentCurrency = 0,
                Strength = 0,
                Dexterity = 10,
                Intelligence = 0,
                Constitution = 4,
                Armor = 0,
                EvadePercentage = 10,
                DamageValue = 2,
                Resistance = 3
            };

            var brabaBat = new Character
            {
                Name = "Braba Bat",
                Level = 1,
                CurrentCurrency = 0,
                Strength = 0,
                Dexterity = 10,
                Intelligence = 0,
                Constitution = 4,
                Armor = 0,
                EvadePercentage = 10,
                DamageValue = 2,
                Resistance = 3
            };

            var venKtathSpider = new Character
            {
                Name = "Ven'ktath Spider",
                Level = 2,
                CurrentCurrency = 0,
                Strength = 4,
                Dexterity = 10,
                Intelligence = 0,
                Constitution = 4,
                Armor = 0,
                EvadePercentage = 10,
                DamageValue = 2,
                Resistance = 3
            };

            var graithGeshLizard = new Character
            {
                Name = "Graith'Gesh Lizard",
                Level = 5,
                CurrentCurrency = 0,
                Strength = 14,
                Dexterity = 4,
                Intelligence = 0,
                Constitution = 10,
                Armor = 4,
                EvadePercentage = 4,
                DamageValue = 7,
                Resistance = 3
            };

            var graithGeshQueen = new Character
            {
                Name = "Graith'Gesh Queen",
                Level = 6,
                CurrentCurrency = 0,
                Strength = 18,
                Dexterity = 14,
                Intelligence = 0,
                Constitution = 14,
                Armor = 6,
                EvadePercentage = 4,
                DamageValue = 7,
                Resistance = 3
            };

            var graktaWolf = new Character
            {
                Name = "Grakta Wolf",
                Level = 4,
                CurrentCurrency = 0,
                Strength = 10,
                Dexterity = 10,
                Intelligence = 4,
                Constitution = 10,
                Armor = 6,
                EvadePercentage = 4,
                DamageValue = 7,
                Resistance = 3
            };

            var graithTree = new Character
            {
                Name = "Graith Tree",
                Level = 4,
                CurrentCurrency = 0,
                Strength = 14,
                Dexterity = 4,
                Intelligence = 0,
                Constitution = 14,
                Armor = 4,
                EvadePercentage = 4,
                DamageValue = 7,
                Resistance = 1
            };
            var graithAppleTree = new Character
            {
                Name = "Grakta Wolf",
                Level = 6,
                CurrentCurrency = 0,
                Strength = 18,
                Dexterity = 18,
                Intelligence = 10,
                Constitution = 18,
                Armor = 4,
                EvadePercentage = 18,
                DamageValue = 7,
                Resistance = 3
            };
            var shadeFireFox = new Character
            {
                Name = "Shadefire Fox",
                Level = 6,
                CurrentCurrency = 0,
                Strength = 10,
                Dexterity = 18,
                Intelligence = 10,
                Constitution = 10,
                Armor = 3,
                EvadePercentage = 4,
                DamageValue = 7,
                Resistance = 6
            };



            var NPC = new Character[]
            {
                kraktRat,
                brabaBat,
                venKtathSpider,
                graithGeshLizard,
                graithGeshQueen,
                graktaWolf,
                graithTree,
                graithAppleTree,
                shadeFireFox
            };

            context.Characters.AddRange(NPC);

            var backpack = new Item [] {
                dagger, majHealthPot
            };

            var crae = new PlayerCharacter
            {
                Name = "Craelios",
                LifeTimeCurrency = 0,
                CurrentCurrency = 0,
                Level = 4,
                Backpack = backpack,
                //EquippedItems = null,
                Strength = 13,
                Dexterity = 15,
                Intelligence = 13,
                Constitution = 16,

                Weapon = scythe,

                CurrentHP = 31,
                CurrentMP = 25,
                DamageValue = 21, 
                ArmorValue = 0,
                //MaxHP = 32,
                //MaxMP = 26,  
                //ResistanceValue = 0,
                //EvadePercentage = 15,
                //AttackValue = 0,
                //WeaponDamage = scythe.ItemStat,
                //Damage = scythe.ItemStat + 6,               
            };

           var playerCharacters = new PlayerCharacter[]
           {
               crae,
           };

            context.PlayerCharacters.AddRange(playerCharacters);

            //string[] moveOptions = { "B", "A", "I", "U", "S" };
            var town = new Location
            {
                ID = "T",
                Name = "Town",
                EnterText = "You have arrived back home in Grik'tath.  You can hear the beating of iron coming from the blacksmith, " +
                "smell grass and sky coming from the dark windows of the alchemist's shop, and see the calming glow of people in the " +
                "inn.  There's also a path deeper underground into The Underbelly, or the tunnel outside to the Shining Forest. ",
                ExitText = "",
                MoveOptions = "B,A,I,U,S",
            };

            var blacksmith = new Location
            {
                ID = "B",
                Name = "Blacksmith's Shop",
                EnterText = "You step into a shop with black and silver shining at you from " +
                "all around as arms and armor coat the walls. " +
                "The blacksmith's face shines at you from over the counter.",
                ExitText = "",
                MoveOptions = "T,O",
            };

            var alchemist = new Location
            {
                ID = "A",
                Name = "Alchemist's Shop",
                EnterText = "You duck your head as you step into the alchemists shop.  Dried bundles of fungi, sticks, " +
                "and even flowers festoon the walls and Garthak the Brewer is humming to himself as he grinds " +
                "something with a pestle. Looking up he flashes his sharp teeth in a smile.",
                ExitText = "",
                MoveOptions = "T,O",
            };

            var inn = new Location
            {
                ID = "I",
                Name = "Inn",
                EnterText = "Welcome to the inn",
                ExitText = "",
                MoveOptions = "T,S",
            };

            var thagragsHope = new Location
            {
                ID = "U",
                Name = "Thagrag's Hope",
                EnterText = "You enter the Underbelly and wend your way through the crevasses and crags of Thagrag's Hope.",
                ExitText = "",
                MoveOptions = "T,O",
                Next = "W"
            };

            var webOfDepths = new Location
            {
                ID = "W",
                Name = "Web of Depths",
                EnterText = "A waterfall deafens you as you enter the Web of the Depths. "+
                "Every surface is slick with moisture in this series of interwoven tunnels created by underground rivers.",
                ExitText = "",
                MoveOptions = "T,G",
                Next = "G"
            };

            var graithsGrotto = new Location
            {
                ID = "G",
                Name = "Graith's Grotto",
                EnterText = "Out of range of any natural light you navigate purely by your own light as you enter Graith's Grotto. "+
                "Home to the lizards your people have learned to domesticate, none you might find here will be friendly.",
                ExitText = "",
                MoveOptions = "T,Q",
                Next = "Q"
            };
            var graithQueensLair = new Location
            {
                ID = "Q",
                Name = "Graith Queen's Lair",
                EnterText = "You tread even more softly as you pass into the deepest reaches of the Underbelly." +
                "Back at the inn you'd heard whispers of a monstrous creature, far larger than any normal Graith'gesh Lizard. " +
                "Your heart beats faster with equal parts excitement and fear " +
                "as the walls close in around you and you enter the Graith Queen's Lair.",
                ExitText = "",
                MoveOptions = "T",
            };
            var kratabsFolly = new Location
            {
                ID = "S",
                Name = "Kratab's Folly",
                EnterText = "You walk towards the surface, leaving behind the familiar tunnels as the crisp mountain air and afternoon sunlight hit your face. " +
                "Your eyes take a moment to adjust before you can see the mountains of Kratab's Folly. " +
                "Towering mountains feel almost familiar but their twisted peaks point upwards into the vastness of the brilliant blue sky. " +
                "It will take some time before you can appreciate the savage beauty of the mountaintops as you do the roots of the mountain.",
                ExitText = "",
                MoveOptions = "T,D",
                Next = "D"
            };

            var drippingDeath = new Location
            {
                ID = "D",
                Name = "Dripping Death",
                EnterText = "The mountains finally level out into a shining mirrorlike plain, broken only " +
                "by the malformed trunks of the trees that managed to claw their way to survival. " +
                "Dripping Death the elders called it.A marsh that that separates the Goblins from " +
                "the rest of our brothers to the north.Where anything can hide and everything " +
                "would be happy to make you a dead little Goblin. " +
                "The hanging moss swaying in the breeze almost causing you to bolt. " +
                "How long til the Graith Trees come for you? ",
                ExitText = "",
                MoveOptions = "T,P",
                Next = "P"
            };
            var playersRespite = new Location
            {
                ID = "P",
                Name = $"Player's Respite", // Add correct formatting to display character's name
                EnterText = "Dry land! After fighting your way through the marsh it's hard to keep " +
                "from kissing the solid earth.As you finish wringing out your clothes " +
                "you mentally name the forest { player.name }'s Respite. " +  // Add correct formatting to display character's name
                "A bold move considering the Graith Trees will have more camouflage when creeping up " +
                "on you but after the dismal, " +
                "glaring grey of the marsh the sunlit green of forest " +
                "feels like a godsend,even if it holds demons.",
                ExitText = "",
                MoveOptions = "T,TTD",
                Next = "TTD"
            };

            var tailOfTheDragon = new Location
            {
                ID = "TTD",
                Name = "Tail of the Dragon",
                EnterText = "Your steps quicken as the ground starts to slope upwards again. " +
                "These mountains are the final barrier between you and your brothers and sisters to the north. " +
                "Even as you pick up the pace, " +
                "your eyes continue to scan your surroundings feverishly. " +
                 "While the trees are growing more scarce, there are plenty of stands for the Graith to hide. " +
                "As wend your way to a pass you see a magnificent gnarled fruit tree spreading over the path. " +
                "Your steps slow as you realize you haven't seen any other fruit trees in miles. " +
                "Unfortunately there is no way around where the tree sits, its branches laden " +
                "with bright red fruits that wink out like malevolent eyes from under its leaves.",
                ExitText = "",
                MoveOptions = "T,C",
            };

            //{ id: "combat?", name: "Combat", enterText: "", exitText: "", options: [""], enemies: []}
            var locations = new Location[]
            {
                town,
                blacksmith,
                inn,
                alchemist, 
                kratabsFolly,
                drippingDeath,
                playersRespite,
                tailOfTheDragon,
                thagragsHope, 
                webOfDepths,
                graithsGrotto,
                graithQueensLair
            };

            context.Locations.AddRange(locations);
                    //System.Diagnostics.Debug.WriteLine(blues);
                    //System.Diagnostics.Debug.WriteLine(closer);

                    context.SaveChanges();
        }
    }
}
