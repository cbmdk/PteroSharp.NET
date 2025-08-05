using System;
namespace PteroSharp.NET.Utils
{


    public class RandomMinecraftServerGenerator
    {
        private static readonly string[] wordlist1 = {
        "Kingdom", "Kingdoms", "Survival", "City", "Town", "Village", "Zombie", "Creeper", "Ghast", "Blaze", "Nether", "Skeleton", "Elite", "Awesome", "Cool", "Gold", "Epic", "Dungeon", "Cow", "Pig", "Raid", "Battle", "Brawl", "Castle", "Fort", "Fortress", "Green", "Archer", "Hardcore", "Shady", "Massive", "Colossal", "Giant", "Waffle", "Pancake", "Lava", "Magma", "Water", "Obsidian", "Wood", "Dirt", "Bedrock", "Stone", "Cryptic", "Hunger", "Mine", "Mystic", "Ender", "Roleplay", "RPG", "Wicked", "Army", "Ultimate", "Emerald", "Conflict", "Ore", "Legendary", "Legends", "Legend", "Venomous", "Poison", "Combat", "Apocalypse", "Apocalyptic", "Raiding", "Grief", "Griefing", "Industrial", "Machine", "Robot", "Economy", "Unreal", "My", "Cake", "Beef", "Pork", "Porkchop", "Standard", "Redstone", "Gold", "Diamond", "Diamonds", "Iron", "Build", "Construct", "Construction", "Home", "House", "Craft", "Noble", "Shadow", "Havoc", "Chaos", "Madness", "Sparta", "Spartan", "Spartans", "Reflex", "Storm", "Sky", "Cube", "Infinite", "Infinity", "Hyper", "Hero", "Mine", "Miner", "Miners", "Robotic", "Advanced", "Pro", "Professional", "Royal", "Winter", "Quest", "Simple", "Evil", "Miracle", "Rainbow", "Fun", "Modded", "Freedom", "Anarchy", "Deadly", "LOL", "Lol", "Gladiator", "Warrior", "Adventure", "Adventurer", "Dream", "Nightmare", "Sandstone", "Legacy", "Storm", "Galactic", "Nexus", "Nuclear", "Atomic", "Nuke", "Blitz", "Spooky", "Ghost", "Supernatural", "Paranormal", "Haunted", "Haunt", "Crimson", "Brutal", "Dusk", "Dawn", "Night", "Day", "Rage", "Tactical", "Evil", "Sinister", "Nyan", "Funky", "Doom", "Legit", "Dark", "Amnesia", "Enderman", "Epik", "Dragon", "Enderdragon", "Nether", "Aether", "Technology", "Rad", "Factions", "Techno", "Faction", "Uber", "Super", "Best", "Prime", "1337", "Super", "Legit", "Unique", "Industry", "Industrial", "Wither", "Craft", "Troll", "Raze", "Destroy", "Evil", "Sinister", "Storm", "Construct", "Survival", "Survive", "Hope", "Hopeless", "Sheep", "Wool", "Factory", "Future", "Modern", "Prehistoric", "Kingdom", "Derp", "Strange", "Eerie", "Creep", "Creepy", "Waffle", "Assault", "Everything", "All-in-one", "Prison", "High-Tech", "RPG", "Roleplay", "Magic", "Dark", "Darkness", "Insane", "Tech", "Technology", "Smart", "Island", "Desert", "Jungle", "Forest", "Biome", "Villager", "Secure", "Insecure", "Security", "Freedom", "Fun", "Infinite", "Infinity", "Unlimited", "Limited", "Universe", "Twilight", "Dub", "Dubstep", "Subliminal", "Electronic", "Electro", "Rock", "Stone", "Urban", "Danger", "Dangerous", "Disaster", "Modded", "Vanilla", "Chocolate", "Imagine", "Imagination", "Metro", "Apocalypse", "Apoc", "Post-Apoc", "Apocalyptic", "Undead", "Post-Apocalyptic", "Tree", "Block", "Brick", "Place", "Uber", "Outrageous", "Outstanding", "Grief", "Griefer", "Griefers", "Griefer's", "TNT", "Innocent", "Dream", "Nightmare", "Killer", "Pasta", "Legends", "Knight", "Warrior", "Archer", "Halo", "FPS", "Lava", "Magma", "Hell", "Minecart", "Cart", "Shop", "Economy", "Food", "Shelter", "Hunt", "Wilderness", "Unknown", "Assassin", "Murder", "Massacre", "Free", "Blocky", "Funny", "Military", "Death", "Epicness", "Original", "MC"
    };

        private static readonly string[] wordlist2 = {
        "Craft", "Build", "Haven", "Heaven", "Realm", "Realms", "World", "Worlds", "Land", "Lands", "Kingdom", "MC", "PvP", "Raid", "PvP/Raid", "Nation", "Freebuild", "Gasm", "Wars", "Server", "Tekkit", "Bukkit", "Games", "Survival", "Vanilla", "Games", "Survival", "Kingdoms", "Skyblock", "Island", "Society", "Roleplay", "RPG", "Legends", "Empire", "Siege", "Warzone", "Time", "Adventure", "Adventures", "Scape", "Outpost", "Creative", "Hardcore", "sVanilla", "Factions", "CTF", "McMMO", "PvE", "Economy", "Assault", "Hell", "Army", "Lands", "Legion", "Clan", "Club", "Worlds", "Universe", "Galaxy", "Dimension", "Town", "City", "Dimensions", "Islands", "Mining", "Mine", "Factions"
    };

        private readonly Random random;

        public RandomMinecraftServerGenerator()
        {
            random = new Random();
        }

        public RandomMinecraftServerGenerator(int seed)
        {
            random = new Random(seed);
        }

        public string GenerateRandomName()
        {
            string word1 = wordlist1[random.Next(wordlist1.Length)];
            string word2 = wordlist2[random.Next(wordlist2.Length)];
            return $"{word1}{word2}";
        }

        public string GenerateRandomNameWithSeparator(string separator = " ")
        {
            string word1 = wordlist1[random.Next(wordlist1.Length)];
            string word2 = wordlist2[random.Next(wordlist2.Length)];
            return $"{word1}{separator}{word2}";
        }
    }

    // Example usage:
    // var nameGenerator = new RandomMinecraftServerGenerator();
    // string randomName = nameGenerator.GenerateRandomName(); // e.g., "EpicCraft"
    // string randomNameWithSpace = nameGenerator.GenerateRandomNameWithSeparator(" "); // e.g., "Epic Craft"

}
