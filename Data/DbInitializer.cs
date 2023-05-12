using DTpureback.Models;
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
using DTpureback.Models.Resources;
using Newtonsoft.Json;
using DTpureback.Interfaces;
using Azure;

namespace DTpureback.Data
{
    public class DbInitializer
    {
        public static void Initialize(DragonsTailContext context)
        {
            if (context.PlayerCharacters.Any())
            {
                return;
            }


            var attack = new Ability
            {
                ID = 1,
                Name = "Attack",
                Effect = "damage",
                Description = "strikes at",
                AffectedAttribute = "",
                Modifier = 1,
                Duration = 0
            };

            var flee = new Ability
            {
                ID = 2,
                Name = "Flee",
                Effect = "buff",
                Description = "attempts to retreat from combat.",
                AffectedAttribute = "",
                Modifier = 0,
                Duration = 0
            };

            var strengthen = new Ability
            {
                ID = 3,
                Name = "Strengthen",
                Effect = "buff",
                Description = "prepares to a massive strike",
                AffectedAttribute = "damageValue",
                Modifier = 0,
                Duration = 0,
            };

            var evade = new Ability
            {
                ID = 4,
                Name = "Evade",
                Effect = "buff",
                Description = "focuses on footwork to increase evasion.",
                AffectedAttribute = "evading",
                Modifier = 0,
                Duration = 0
            };

            var defend = new Ability
            {
                ID = 5,
                Name = "Defend",
                Effect = "buff",
                Description = "concentrates energy on deflecting attacks for 2 rounds, increasing armor.",
                AffectedAttribute = "defending",
                Modifier = 0,
                Duration = 0,
            };

            var aim = new Ability
            {
                ID = 6,
                Name = "Aim",
                Effect = "buff",
                Description = "Focusing on footwork to increase evasion.",
                AffectedAttribute = "focusing",
                Modifier = 0,
                Duration = 0,
            };

            var heal = new Ability
            {
                Name = "Heal I",
                Effect = "heal",
                Description = "heals the target.",
                AffectedAttribute = "",
                Modifier = 1,
                Duration = 0,
            };

            var abilities = new Ability[]
            {
                attack,
                flee,
                strengthen,
                evade,
                defend,
                aim
            };

            //for (var i = 0; i < abilities.Length; i++)
            //{
            //    context.Ability.Add(abilities[i]);
            //    context.SaveChanges();
            //}


            var naka = new CharacterDefault
            {
                ID = "PC_B",
                Name = "Nakat'th",
                Strength = 12,
                Dexterity = 8,
                Constitution = 10,
                Intelligence = 8,
                Job = "Blacksmith",
                Ability = strengthen,
                Description = "Toughened by years of heating metal and bone to melting, you are strong " + 
                "and willing to put your body on the line for your people. [Increased Strength and Constitution]"
            };


            var clich = new CharacterDefault
            {
                ID = "PC_S",
                Name = "Clichtka",
                Strength = 8,
                Dexterity = 12,
                Constitution = 10,
                Intelligence = 8,
                Job = "Scavenger",
                Ability = evade,
                Description = " Years of hiding from the predators in your home tunnels have made you quick and agile, faster than many of the creatures " +
                "that roam the dark. [Increased Dexterity and Constitution]"
            };

            var bort = new CharacterDefault
            {
                ID = "PC_E",
                Name = "Bortorb",
                Strength = 8,
                Dexterity = 10,
                Constitution = 12,
                Intelligence = 8,
                 Job = "Explorer",
                 Ability = defend,
                Description = "Few have gone as far into the darkness as you, and even fewer have ventured as far into the light.You are a hardy explorer, " +
                "often using the rivers both above and belowground as highways. [Increased Constitution and Dexterity]"
            };

            var grag = new CharacterDefault
            {
                ID = "PC_A",
                Name = "Gragta'th",
                Strength = 8,
                Dexterity = 10,
                Constitution = 8,
                Intelligence = 12,
                Job = "Herbalist",
                Ability = aim,
                Description = "As an apprentice to Naer'shob, the town healer, you have learned much about herbs and magic. " +
                "Practical applications are much harder but it will come in time. [Increased Intelligence and Dexterity]"
            };

            var characterDefaults = new CharacterDefault[]
            {
                naka,
                bort,
                grag,
                clich
            };

            context.AddRange(characterDefaults);
            context.SaveChanges();

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
                Price = 20,
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

            for (var i = 0; i < items.Length; i++)
            {
                context.Items.Add(items[i]);
                context.SaveChanges();
            }
            var otherList = new List<int>();

            otherList.Add(1);
            otherList.Add(2);
            otherList.Add(3);

            var gameStart = new Location
            {
                ID = "SG",
                Name = "GameStart",
                EnterText = "Many years ago the Goblins lived peacefully above ground, in harmony with nature and the gods. " +

                    "But then there was a Reckoning when the gods turned their backs on us, sending the Graith'Gesh, " +
                    "unnaturals trees that could live in stone, walk, and even kill. They savaged our " +
                    "people and forced them into the darkness of the tunnels. " +

                    "We did not despair, for we found a light in the darkness. A light within ourselves " +
                    "that grew to encompass almost all of us.  That light we call the God's Glow, the " +
                    "surest sign that we will one day return to the land of the light. " +

                    "And I think you may be the one to lead us. " +

                    "Humble beginnings for someone who will do so much. " +
                "What were they again?",
                MiddleText = "Apprentice Alchemist(A), Apprentice Blacksmith(B), Tunnel Explorer(E), or Tunnel Scavenger(S)",
                ExitText = "\"And the task you have chosen for your Enlightening?\" Elder Gragta'th rumbles.\r\n\r\n\"To find our brothers and sisters to the north."+
                "To reunite us with our lost people.\"\r\nYour words surprise you, but they feel right.\r\n\r\nWhispers erupt"+
                "from the gathered Goblins before Bortorb silences them and asks, \r\n\"Are you sure? There are many other ways to prove your worth."+
                "Many shorter paths.\"\r\nYou see the worry in his eyes as you nod, not trusting yourself to speak.\r\n\r\n\"Very well then!\" Nakat'th cuts in,"+
                "\"If that is your goal I will grant you access to me\r\nand my forge as if you were a true Goblin.  "+
                "Anyone with the guts enough to take on the \r\nGraith are going to need some help.\"\r\n\r\n\"You may also avail yourself of my knowledge "+
                "and potions in your endeavors.\" Gragta'th\r\ngrowls gently, his light swirling slightly."+
                "\r\n\r\n\"Then may the gods bless this quest that will bring us so much closer to them.\" \r\nBortorb entoned, " +
                "continuing with the ritual.\r\n\r\nIn the end you don't feel that different but you have a new goal:\r\nTo travel through the Shining Forest, "+
                "in a world full of light and terrible bloodthirsty creatures,\r\nto bring your people up from the Dragon's Tail." ,
                MoveOptions = "A,B,E,S",
                OtherList = otherList
            };

            //string[] moveOptions = { "B", "A", "I", "U", "S" };
            var town = new Location
            {
                ID = "T",
                Name = "Town",
                EnterText = "You have arrived back home in Grik'tath.  You can hear the beating of iron coming from the blacksmith(B), " +
                "smell grass and sky coming from the dark windows of the alchemist's shop(A), and see the calming glow of people in the " +
                "inn(I).  There's also a path deeper underground into The Underbelly(U), or the tunnel outside to the Shining Forest(S). " +
                "[To navigate the game use the input field below or the buttons in this sector.  Each option below will correspond to a character " +
                " you can enter to navigate to a related part of the world. For example, T = Town]",
                ExitText = "",
                MoveOptions = "B,A,I,U,S",
            };

            var blacksmith = new Location
            {
                ID = "B",
                Name = "Blacksmith's Shop",
                EnterText = "You step into a shop with black and silver shining at you from " +
                "all around as arms and armor coat the walls. " +
                "The blacksmith's face shines at you from over the counter.  [T - Town, S - Shop]",
                ExitText = "",
                MoveOptions = "T,S",
                Next = "T"
            };

            var alchemist = new Location
            {
                ID = "A",
                Name = "Alchemist's Shop",
                EnterText = "You duck your head as you step into the alchemists shop.  Dried bundles of fungi, sticks, " +
                "and even flowers festoon the walls and Garthak the Brewer is humming to himself as he grinds " +
                "something with a pestle. Looking up he flashes his sharp teeth in a smile.  [T - Town, S - Shop]",
                ExitText = "",
                MoveOptions = "T,S",
                Next = "T"

            };

            var inn = new Location
            {
                ID = "I",
                Name = "Inn",
                EnterText = "A din of welcoming chatter washes over you as you enter the inn.  While the tunnels between buildings can " +
                "be fairly cramped, the common room of the inn is wide open and full of goblins of various ages sprawled all over couches, " +
                "chairs, and, occasionally, the tables. Here at the beating heart of your town you see your community. Friends and neighbors " +
                "who watched you grow up, tiny children learning how to dim their skin's glow, and even elders watching their charges with hope " +
                "and joy in their hearts. [T - Town, S - Shop]",
                ExitText = "",
                MoveOptions = "T,S",
            };

            var thagragsHope = new Location
            {
                ID = "U",
                Name = "Thagrag's Hope",
                EnterText = "You enter the Underbelly and wend your way through the crevasses and crags of Thagrag's Hope. [T - Town, C - Continue]",
                ExitText = "",
                MoveOptions = "T,C",
                Next = "W",
                CommonNPC = 2,
                UncommonNPC = 1,
                RareNPC = 3,
                SecretNPC = 9
            };

            var webOfDepths = new Location
            {
                ID = "W",
                Name = "Web of Depths",
                EnterText = "A waterfall deafens you as you enter the Web of the Depths. " +
                "Every surface is slick with moisture in this series of interwoven tunnels created by underground rivers. [T - Town, C - Continue]",
                ExitText = "",
                MoveOptions = "T,C",
                Next = "G",
                CommonNPC = 2,
                UncommonNPC = 3,
                RareNPC = 4,
                SecretNPC = 9
            };

            var graithsGrotto = new Location
            {
                ID = "G",
                Name = "Graith's Grotto",
                EnterText = "Out of range of any natural light you navigate purely by your own light as you enter Graith's Grotto. " +
                "Home to the lizards your people have learned to domesticate, none you might find here will be friendly. [T - Town, C - Continue]",
                ExitText = "",
                MoveOptions = "T,C",
                Next = "Q",
                CommonNPC = 3,
                UncommonNPC = 4,
                RareNPC = 4,
                SecretNPC = 9
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
                CommonNPC = 4,
                UncommonNPC = 5,
                RareNPC = 2,
                SecretNPC = 9
            };
            var kratabsFolly = new Location
            {
                ID = "S",
                Name = "Kratab's Folly",
                EnterText = "You walk towards the surface, leaving behind the familiar tunnels as the crisp mountain air and afternoon sunlight hit your face. " +
                "Your eyes take a moment to adjust before you can see the mountains of Kratab's Folly. " +
                "Towering mountains feel almost familiar but their twisted peaks point upwards into the vastness of the brilliant blue sky. " +
                "It will take some time before you can appreciate the savage beauty of the mountaintops as you do the roots of the mountain. [T - Town, C - Continue]",
                ExitText = "",
                MoveOptions = "T,C",
                Next = "D",
                 CommonNPC = 1,
                UncommonNPC = 3,
                RareNPC = 6,
                SecretNPC = 9
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
                "How long til the Graith Trees come for you? [T - Town, C - Continue]",
                ExitText = "",
                MoveOptions = "T,C",
                Next = "P",
                CommonNPC = 3,
                UncommonNPC = 6,
                RareNPC = 7,
                SecretNPC = 9
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
                "feels like a godsend,even if it holds demons. [T - Town, C - Continue]",
                ExitText = "",
                MoveOptions = "T,C",
                Next = "TTD",
                CommonNPC = 3,
                UncommonNPC = 6,
                RareNPC = 7,
                SecretNPC = 9
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
                "with bright red fruits that wink out like malevolent eyes from under its leaves. [T - Town, C - Continue]",
                ExitText = "",
                MoveOptions = "T,C",
                CommonNPC = 8,
                UncommonNPC = 8,
                RareNPC = 8,
                SecretNPC = 8
            };

            //{ id: "combat?", name: "Combat", enterText: "", exitText: "", options: [""], enemies: []}
            var locations = new Location[]
            {
                gameStart,
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
            try
            {

                context.SaveChanges();
            }
            catch
            {
                throw (new Exception("location's failed"));
            }

            var kraktRat = new NPC
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

            var brabaBat = new NPC
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

            var venKtathSpider = new NPC
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

            var graithGeshLizard = new NPC
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

            var graithGeshQueen = new NPC
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

            var graktaWolf = new NPC
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

            var graithTree = new NPC
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
            var graithAppleTree = new NPC
            {
                Name = "Graith Apple Tree",
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
            var shadeFireFox = new NPC
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



            var NPCs = new NPC[]
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

            context.NPC?.AddRange(NPCs);
            try
            {

                context.SaveChanges();
            }
            catch
            {
                throw (new Exception("NPC's failed"));
            }


            var backpack = new Item[] {
              dagger,
                majHealthPot
            };

            var EQ = new IEquipment
            {
                Head=null,
                    Body= null,
                    Hand= scythe
            };


            var crae = new PlayerCharacter
            {
                Name = "Craelios",
                LifeTimeCurrency = 0,
                CurrentCurrency = 0,
                Level = 4,
                Items = backpack,

                Strength = 13,
                Dexterity = 15,
                Intelligence = 13,
                Constitution = 16,

                EquippedItems = EQ,

                CurrentHP = 31,
                CurrentMP = 25,
                DamageValue = 21, 
                ArmorValue = 0,
                MaxMP = 26,  
                MaxHP = 32,
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
            try
            {

                context.SaveChanges();
            }
            catch
            {
                throw (new Exception("PC's failed"));
            }


          

                //System.Diagnostics.Debug.WriteLine(blues);
                //System.Diagnostics.Debug.WriteLine(closer);

                var save1 = new SaveFile
            {
                UserID = "google-oauth2|113473413986135090152",
                PlayerCharacterID = 1,
                LocationID = "T",
                CharacterName = "Craelios"
            };
            var save2 = new SaveFile
            {
                UserID = "google-oauth2|113473413986135090152",
                PlayerCharacterID = 1,
                LocationID = "I",
                CharacterName = "Craelios"
            };

            var saves = new SaveFile[]
            {
            save1,
            save2
            };

            context.SaveFiles.AddRange(saves);
  

            context.SaveChanges();
        }
    }
}
