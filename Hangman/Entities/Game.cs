using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Entities
{
    internal class Game
    {
        public string Word { get; private set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public int WordLength { get; private set; }
        public int Tries { get; set; }
        public List<char> GuessedLetters = new List<char>();
        public List<char> GuessedLettersAlphabetic = new List<char>();
        public Game()
        {
            string[] possibleWords = new string[]
            {
                "abandon",
                "ability",
                "absolve",
                "account",
                "advance",
                "adventure",
                "advocate",
                "aesthetic",
                "airport",
                "amazing",
                "analyze",
                "ancient",
                "android",
                "animal",
                "animate",
                "antique",
                "appeal",
                "applaud",
                "applied",
                "arrange",
                "article",
                "artisan",
                "ascend",
                "assault",
                "attempt",
                "auction",
                "author",
                "average",
                "awesome",
                "balance",
                "balloon",
                "banker",
                "battle",
                "beacon",
                "benefit",
                "bicycle",
                "biology",
                "blanket",
                "boredom",
                "borrow",
                "bravery",
                "breeze",
                "bridge",
                "bright",
                "brother",
                "budget",
                "builder",
                "burial",
                "button",
                "cabinet",
                "capture",
                "caramel",
                "career",
                "carried",
                "cartoon",
                "cascade",
                "castle",
                "catcher",
                "caution",
                "ceiling",
                "century",
                "chamber",
                "chance",
                "channel",
                "charity",
                "chatter",
                "chosen",
                "classic",
                "climate",
                "closet",
                "cluster",
                "coastal",
                "collect",
                "college",
                "comfort",
                "command",
                "comment",
                "company",
                "compare",
                "compete",
                "complex",
                "compose",
                "compute",
                "concern",
                "conduct",
                "connect",
                "consent",
                "console",
                "contact",
                "contest",
                "control",
                "convert",
                "correct",
                "costume",
                "courage",
                "create",
                "creature",
                "crumble",
                "culture",
                "curious",
                "custom",
                "danger",
                "daring",
                "dazzle",
                "declare",
                "defeat",
                "defend",
                "delight",
                "deliver",
                "dentist",
                "desert",
                "design",
                "desire",
                "develop",
                "diamond",
                "digital",
                "dilemma",
                "distant",
                "disturb",
                "dolphin",
                "drawing",
                "dresser",
                "drizzle",
                "driving",
                "drought",
                "dynamic",
                "eastern",
                "eccentric",
                "ecology",
                "economy",
                "editor",
                "elegant",
                "element",
                "elevate",
                "elusive",
                "emerald",
                "emotion",
                "empathy",
                "endorse",
                "energy",
                "engage",
                "enjoyed",
                "enlarge",
                "enrich",
                "enslave",
                "entered",
                "enthral",
                "episode",
                "escape",
                "esteem",
                "eternal",
                "ethics",
                "evening",
                "example",
                "exceed",
                "excited",
                "exclude",
                "execute",
                "exhibit",
                "expense",
                "expert",
                "explode",
                "explore",
                "express",
                "extreme",
                "failure",
                "fantasy",
                "farmer",
                "fashion",
                "feature",
                "federal",
                "feeling",
                "fellow",
                "fiction",
                "fighter",
                "finance",
                "finding",
                "fitness",
                "flannel",
                "flatter",
                "flight",
                "flower",
                "flutter",
                "foreign",
                "forget",
                "fortune",
                "freedom",
                "fresher",
                "friction",
                "friendly",
                "frontier",
                "frustrate",
                "fulfill",
                "funeral",
                "furious",
                "future",
                "galaxy",
                "gamble",
                "garden",
                "gateway",
                "general",
                "genuine",
                "gesture",
                "gigantic",
                "glacier",
                "glimpse",
                "glorious",
                "glowworm",
                "goddess",
                "goodbye",
                "grammar",
                "gravity",
                "greeting",
                "grocery",
                "guardian",
                "habitat",
                "haircut",
                "hallway",
                "harmony",
                "harvest",
                "healthy",
                "hearing",
                "heavenly",
                "helpful",
                "heroine",
                "highway",
                "horizon",
                "hostile",
                "however",
                "hundred",
                "husband",
                "hydrant",
                "iceberg",
                "iconic",
                "ignite",
                "illegal",
                "imagine",
                "impress",
                "include",
                "inflict",
                "insight",
                "install",
                "intense",
                "inventor",
                "ironing",
                "isolate",
                "jackpot",
                "january",
                "jealous",
                "journey",
                "justice",
                "juvenile",
                "kangaroo",
                "karaoke",
                "keyboard",
                "kingdom",
                "kitchen",
                "knitted",
                "knowing",
                "labelled",
                "laptop",
                "lateral",
                "laughter",
                "lawful",
                "leader",
                "library",
                "lighten",
                "limited",
                "listen",
                "lobster",
                "logical",
                "machine",
                "magical",
                "maintain",
                "manager",
                "marble",
                "market",
                "married",
                "massive",
                "maximum",
                "measure",
                "meddling",
                "mention",
                "message",
                "midnight",
                "million",
                "mineral",
                "miracle",
                "mixture",
                "monster",
                "morning",
                "mystery",
                "narrowly",
                "natural",
                "necklace",
                "negative",
                "network",
                "neutral",
                "notable",
                "nothing",
                "novelty",
                "nowhere",
                "numeric",
                "nurture",
                "oakwood",
                "obedient",
                "obscure",
                "observe",
                "obvious",
                "officer",
                "opening",
                "operate",
                "opinion",
                "optical",
                "organic",
                "outcome",
                "outside",
                "overcome",
                "package",
                "painful",
                "palace",
                "paradox",
                "partial",
                "passion",
                "patient",
                "pattern",
                "payable",
                "peaceful",
                "penalty",
                "perfect",
                "perform",
                "perhaps",
                "picture",
                "planet",
                "plastic",
                "platform",
                "pleasant",
                "popular",
                "portion",
                "precise",
                "predict",
                "prepare",
                "present",
                "prevent",
                "primary",
                "printer",
                "private",
                "problem",
                "process",
                "produce",
                "program",
                "promise",
                "protect",
                "purpose",
                "pyramid",
                "qualify",
                "quality",
                "quantum",
                "quarter",
                "question",
                "quickly",
                "quietly",
                "radical",
                "rainbow",
                "random",
                "rapidly",
                "raspberry",
                "reactor",
                "reality",
                "receipt",
                "receive",
                "recover",
                "reflect",
                "refusal",
                "refused",
                "regular",
                "rejoice",
                "related",
                "release",
                "removal",
                "remorse",
                "replace",
                "request",
                "respect",
                "respond",
                "retired",
                "reunion",
                "revenue",
                "reverse",
                "revival",
                "reward",
                "rhythm",
                "richest",
                "rivalry",
                "roadway",
                "robbery",
                "rocket",
                "romance",
                "routine",
                "rubbish",
                "runaway",
                "running",
                "rupture",
                "rusting",
                "sacred",
                "safety",
                "sailing",
                "salient",
                "satisfy",
                "scanner",
                "scenery",
                "schedule",
                "science",
                "scratch",
                "season",
                "secrecy",
                "section",
                "segment",
                "selfish",
                "senator",
                "separate",
                "serious",
                "service",
                "settled",
                "shadow",
                "sharing",
                "shimmer",
                "shorten",
                "shoulder",
                "showcase",
                "shudder",
                "signals",
                "silence",
                "similar",
                "sincere",
                "skilled",
                "slippery",
                "smarter",
                "smiling",
                "smoothly",
                "social",
                "softest",
                "solving",
                "somehow",
                "soonest",
                "sparkle",
                "special",
                "spectra",
                "splendid",
                "sponsor",
                "sports",
                "sprayed",
                "stamina",
                "station",
                "stellar",
                "stomach",
                "storage",
                "strange",
                "stressed",
                "student",
                "stumble",
                "stylish",
                "subject",
                "success",
                "suggest",
                "suitable",
                "sunrise",
                "surface",
                "survive",
                "suspect",
                "swiftly",
                "symbol",
                "symphony",
                "synapse",
                "system",
                "tableau",
                "tactics",
                "tailored",
                "talents",
                "teacher",
                "teamwork",
                "temple",
                "tension",
                "theater",
                "thought",
                "through",
                "thunder",
                "tighten",
                "tonight",
                "topical",
                "torment",
                "torrent",
                "towards",
                "traffic",
                "transform",
                "transmit",
                "travel",
                "treason",
                "treasure",
                "tremble",
                "triangle",
                "trigger",
                "trouble",
                "trustee",
                "truthful",
                "tuesday",
                "turmoil",
                "typical",
                "unaware",
                "unclear",
                "unequal",
                "unfold",
                "unified",
                "unknown",
                "unspoken",
                "unusual",
                "upgrade",
                "upwards",
                "urgency",
                "useable",
                "usually",
                "utility",
                "vacancy",
                "vaccine",
                "vagrant",
                "valiant",
                "valuable",
                "vanilla",
                "variety",
                "various",
                "vastest",
                "venture",
                "verdict",
                "version",
                "vessel",
                "victory",
                "village",
                "violent",
                "virtual",
                "visible",
                "visitor",
                "vividly",
                "volcano",
                "voyager",
                "wageearner",
                "waiting",
                "walking",
                "wanderer",
                "warrior",
                "weather",
                "welfare",
                "western",
                "whistle",
                "willing",
                "windows",
                "winner",
                "wisdom",
                "wishing",
                "witness",
                "wonder",
                "work"
            };
            Random random = new Random();
            int x = random.Next(0, 560);
            Word = possibleWords[x];

            List<char> wordLetters = new List<char>();
            foreach (char let in Word)
            {
                char exists = wordLetters.Find(letter => letter == let);
                if (exists == '\0')
                {
                    wordLetters.Add(let);
                }
            }

            Score = 0;
            MaxScore = wordLetters.Count;
            WordLength = possibleWords[x].Length - 1;
            Tries = 6;
        }

        public string ManHanging()
        {
            switch (Tries)
            {
                case 0:
                    return "— — — —"
                    + "\n|     |"
                    + "\n|     O"
                    + "\n|    /|\\"
                    + "\n|    / \\"
                    + "\n|_ _ _ _ _ _";
                    break;
                case 1:
                    return "— — — —"
                    + "\n|     |"
                    + "\n|     O"
                    + "\n|    /|\\"
                    + "\n|    / "
                    + "\n|_ _ _ _ ";
                    break;
                case 2:
                    return "— — — —"
                    + "\n|     |"
                    + "\n|     O"
                    + "\n|    /|\\"
                    + "\n|     "
                    + "\n|_ _ _ _ ";
                    break;
                case 3:
                    return "— — — —"
                    + "\n|     |"
                    + "\n|     O"
                    + "\n|    /|"
                    + "\n|     "
                    + "\n|_ _ _ _ ";
                    break;
                case 4:
                    return "— — — —"
                    + "\n|     |"
                    + "\n|     O"
                    + "\n|     |"
                    + "\n|     "
                    + "\n|_ _ _ _";
                    break;
                case 5:
                    return "— — — —"
                    + "\n|     |"
                    + "\n|     O"
                    + "\n|     "
                    + "\n|     "
                    + "\n|_ _ _ _";
                    break;
                case 6:
                    return "— — — —"
                    + "\n|     |"
                    + "\n|     "
                    + "\n|     "
                    + "\n|     "
                    + "\n|_ _ _ _";
                    break;
                default:
                    return "Tries is invalid, jisdhfidshfk";
                    break;
            }
        }

        public bool GuessHasBeenGuessed(char guess)
        {
            char c = GuessedLetters.Find(let => let == guess);
            return c != '\0';
        }

       

        public void AddScore(char letter)
        {
            char repetition = GuessedLetters.Find(let => let == letter);
            bool addScore = false;
            if (repetition == '\0')
            {
                GuessedLetters.Add(letter);
                foreach (char c in Word)
                {
                    if (c == letter && addScore == false)
                    {
                        Score++;
                        addScore = true;
                    }
                }
                foreach (char c in GuessedLetters)
                {
                    GuessedLettersAlphabetic.Remove(c);
                }
                foreach (char c in GuessedLetters)
                {
                    GuessedLettersAlphabetic.Add(c);
                }
            }
            if (!addScore)
            {
                Tries--;
            }
        }

        public string Guess(char letter)
        {
            StringBuilder s = new StringBuilder();

            foreach (char l in Word)
            {
                char exists = GuessedLetters.Find(let => let == l);
                if (exists != '\0')
                {
                    s.Append(exists + " ");
                }
                else
                {
                    s.Append("_ ");
                }
            }
            return s.ToString();
        }

        public string Guess()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 1; i <= Word.Length; i++)
            {
                s.Append("_ ");
            }
            return s.ToString();
        }

        public bool GameEnded()
        {
            return (Tries == 0 || Score == MaxScore);
        }
    }
}
