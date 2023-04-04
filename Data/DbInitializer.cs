using DTpureback.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
                Description = "A red potion that smells of cinnamon and nutmeg. Heals a little."
            };

            var chainmail = new Item
            {
                name = "Chainmail Armor",
                ItemStat = 3,
                Price = 60,
                Slot = "body",
                Description = "Toughened leather that protects against both elements and enemies."
            };

            var items = new Item[]
            {
                scythe,
                minHealthPot,
                chainmail
            };
            context.Items.AddRange(items);

            var crae = new PlayerCharacter
            {
                Name = "Craelios",
                LifeTimeCurrency = 0,
                CurrentCurrency = 0,
                Backpack = null,
                //EquippedItems = null,
                Strength = 13,
                Dexterity = 15,
                Intelligence = 13,
                Constitution = 16,
                MaxHP = 32,
                MaxMP = 26,
                Weapon = scythe,
                WeaponDamage = scythe.ItemStat,
                Damage = scythe.ItemStat + 6,
                CurrentHP = 31,
                CurrentMP = 25,
                ArmorValue = 0,
                ResistanceValue = 0,
                EvadePercentage = 15,
                AttackValue = 0,
                DamageValue = 21,
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
                EnterText = "Here we are in town",
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

            //{ id: "A", name: "Alchemist's Shop", enterText: "Welcome to the alchemist's shop", exitText: "", options: ["T", "O"], enemies: []},
            //{ id: "I", name: "Inn", enterText: "", exitText: "Welcome to the inn", options: ["T", "S"], enemies: []},
            //{ id: "U", name: "Thagrag's Hope", enterText: "Entering Thagrag's Hope", exitText: "", options: ["T", "W"], enemies: []},
            //{ id: "W", name: "Web of Depths", enterText: "Web of Depths", exitText: "", options: ["T", "G"], enemies: []},
            //{ id: "G", name: "Graith's Grotto", enterText: "Graith's Grotto", exitText: "", options: ["T", "Q"], enemies: []},
            //{ id: "Q", name: "Graith Queen's Lair", enterText: "Entering the Graith Queen's Lair", exitText: "", options: ["T"], enemies: []},
            //{ id: "S", name: "Kratab's Folly", enterText: "Entering Kratab's Folly", exitText: "", options: ["T", "D"], enemies: []},
            //{ id: "D", name: "Dripping Death", enterText: "Entering the Dripping Death", exitText: "", options: ["T", "P"], enemies: []},
            //{
            //            id: "P", name: `{ character.name}
            //                's Respite`, enterText: "Enjoying a Brief Respite", exitText: "", options:["T", "TTD"], enemies: []},
            //{ id: "TTD", name: "Tail of the Dragon", enterText: "Tail of the Dragon", exitText: "", options: ["T", "C"], enemies: []},
            //{ id: "combat?", name: "Combat", enterText: "", exitText: "", options: [""], enemies: []}
            var locations = new Location[]
            {
                town,
                blacksmith,
            };

            context.Locations.AddRange(locations);
                    //System.Diagnostics.Debug.WriteLine(blues);
                    //System.Diagnostics.Debug.WriteLine(closer);

                    context.SaveChanges();
        }
    }
}
