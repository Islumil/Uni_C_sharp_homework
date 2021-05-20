using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD_Character_Creation
{
    class Character_Details
    {
        public static void Class_Description()
        {
            if (frm_main.details_val == "Barbarian")
            {
                frm_main.details_val = "The relentless combatant, fueled by fury or it's totem bonds with animals. In tune with the natural order.";
                frm_main.details_val2 = "D12";
            }
            else if(frm_main.details_val == "Bard")
            {
                frm_main.details_val = "A story teller or musician using his wits, magic, and lore to get out of (or avoid) tight situations";
                frm_main.details_val2 = "D8";
            }
            else if (frm_main.details_val == "Cleric")
            {
                frm_main.details_val = "A Holy man devoted to a deity. capable of bolstering the party and heal their wounds, or laying low their enemies with divine wrath.";
                frm_main.details_val2 = "D8";
            }
            else if (frm_main.details_val == "Druid")
            {
                frm_main.details_val = "A nomad devoted to the world and the powers of Nature. Capable of adopting the form of a beast for battle or utility. capable of bolstering the party and heal their wounds, or laying low their enemies with nature's wrath";
                frm_main.details_val2 = "D8";
            }
            else if (frm_main.details_val == "Fighter")
            {
                frm_main.details_val = "Skilled combatant or strategist typically relying on his heavy armor and weapons to cut down their enemies. His training gives him unique abilities";
                frm_main.details_val2 = "D10";
            }
            else if (frm_main.details_val == "Paladin")
            {
                frm_main.details_val = "Nearly as skilled as the Fighter but bolsters his efforts with divine magic. through his devotion he gains special boons from his god.";
                frm_main.details_val2 = "D10";
            }
            else if (frm_main.details_val == "Rogue")
            {
                frm_main.details_val = "A thief, assassin or stealthy character who has a knack for picking out his enemies weaknesses and exploiting them.";
                frm_main.details_val2 = "D8";
            }
            else if (frm_main.details_val == "Warlock")
            {
                frm_main.details_val = "Pacted to a powerful entity the warlock trades favors for boons and spells.";
                frm_main.details_val2 = "D8";
            }
            else if (frm_main.details_val == "Wizard")
            {
                frm_main.details_val = "Keeper of arcane secrets and forgotten knowledge, the wizard manipulates magic and spells with cunning.";
                frm_main.details_val2 = "D6";
            }
            else
            {
                frm_main.details_val = "";
                frm_main.details_val2 = "";
            }
        }

        public static void Race_Description()
        {
            if (frm_main.details_val == "Aarakocra")
            {
                frm_main.details_val = "Seqestered in high mountains atop tall trees, the aarakocra sometimes called birdfolk, evoke fear and wonder.";
            }
            else if (frm_main.details_val == "Dwarf")
            {
                frm_main.details_val = "Bold and hardy, dwarves are known as skilled warriors, miners, and workers of stone and metal.";
            }
            else if (frm_main.details_val == "Elf")
            {
                frm_main.details_val = "Elves are a magical people of otherwordly grace, living in the world but not entirely part of it.";
            }
            else if (frm_main.details_val == "Gnome")
            {
                frm_main.details_val = "A gnome's energy and enthusiasm for living shines through every inch of his or her body.";
            }
            else if (frm_main.details_val == "Goliath")
            {
                frm_main.details_val = "Strong and reclusive, every day brings a new challange to a goliath";
            }
            else if (frm_main.details_val == "HalfOrc")
            {
                frm_main.details_val = "Half-orcs' grayish pigmentation, sloping foreheads, jutting jaws, prominent teeth, and towering build make their orcish heritage plain for all to see";
            }
            else if (frm_main.details_val == "Halfling")
            {
                frm_main.details_val = "The diminutive halflings survive in a world full of larger creatures by avoiding notice or, barring that avoiding offense.";
            }
            else if (frm_main.details_val == "Human")
            {
                frm_main.details_val = "Humans are the most adaptable and ambitious people among the common races. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds";
            }
            else if (frm_main.details_val == "Tiefling")
            {
                frm_main.details_val = "To be greeted with stares and whispers, to suffer violence and insult on the street, to see mistrust and fear in every eye: this is the lot of the tiefling";
            }
            else if (frm_main.details_val == "Dragonborn")
            {
                frm_main.details_val = "Dragonborn look very much like dragons standing erect in humanoid form, though they lack wings or a tail.";
            }
            else
            {
                frm_main.details_val = "";
            }
        }

        public static void Ability_BaseValues()
        {
            if (frm_main.details_val == "15")
                frm_main.details_val = "9";
            else if (frm_main.details_val == "14")
                frm_main.details_val = "7";
            else if (frm_main.details_val == "13")
                frm_main.details_val = "5";
            else if (frm_main.details_val == "12")
                frm_main.details_val = "4";
            else if (frm_main.details_val == "11")
                frm_main.details_val = "3";
            else if (frm_main.details_val == "10")
                frm_main.details_val = "2";
            else if (frm_main.details_val == "9")
                frm_main.details_val = "1";
            else if (frm_main.details_val == "8")
                frm_main.details_val = "0";
            else
            {
                frm_main.details_val2 = "-- Choose --";
                frm_main.details_val = "0";
            }
        }
        
        public static void Ability_Modifiers()
        {
            if (frm_main.details_val == "")
            {
                frm_main.details_val = "";
            }
            else if (Convert.ToInt32(frm_main.details_val) < 2)
                frm_main.details_val = "-5";
            else if (Convert.ToInt32(frm_main.details_val) < 4)
                frm_main.details_val = "-4";
            else if (Convert.ToInt32(frm_main.details_val) < 6)
                frm_main.details_val = "-3";
            else if (Convert.ToInt32(frm_main.details_val) < 8)
                frm_main.details_val = "-2";
            else if (Convert.ToInt32(frm_main.details_val) < 10)
                frm_main.details_val = "-1";
            else if (Convert.ToInt32(frm_main.details_val) < 12)
                frm_main.details_val = "0";
            else if (Convert.ToInt32(frm_main.details_val) < 14)
                frm_main.details_val = "1";
            else if (Convert.ToInt32(frm_main.details_val) < 16)
                frm_main.details_val = "2";
            else if (Convert.ToInt32(frm_main.details_val) < 18)
                frm_main.details_val = "3";
            else
            {
                frm_main.details_val = "4";
            }
        }
        
        public static void Background_Details()
        {
            if (frm_main.details_val == "")
            {
                frm_main.details_val = "";
            }
            else if (frm_main.details_val == "Charlatan")
            {
                frm_main.details_val = "This feature is basically a free license to accurately forge documents. If you can’t think of some nefarious applications of this, you’re not thinking hard enough.";
            }
            else if (frm_main.details_val == "Entertainer")
            {
                frm_main.details_val = "This feature is like the acolyte feature in that you can usually leverage it into free room and board. You can also get somewhat popular and liked in places you perform. Usually a feature for bards, it’s situational at best, but very flavorful.";
            }
            else if (frm_main.details_val == "Outlander")
            {
                frm_main.details_val = "This feature lets you get a little taste of Ranger as any other class. It only comes up in the rare survival style adventures, but when it does come up, you’ll be glad you have it.";
            }
            else if (frm_main.details_val == "Sage")
            {
                frm_main.details_val = "This is the obligatory wizard feature. It’s another feature that comes up the most often, and you can generally use it to figure out plot-relevant information whenever you’re stuck.";
            }
            else if (frm_main.details_val == "Sailor")
            {
                frm_main.details_val = "It’s very situational, and often ignored down the line, but in early levels getting a free naval passage can be helpful.";
            }
            else if (frm_main.details_val == "Soldier")
            {
                frm_main.details_val = "A very situational feature that really depends on the adventure. You gain the rank and military knowhow to access military installations, sort of. Generally, you’ll be linked to a single military, meaning the feature does literal nothing beyond your nation’s borders.";
            }
            else if (frm_main.details_val == "Noble")
            {
                frm_main.details_val = "This feature essentially allows you to enjoy some privilege, get an in with nobility and it generally gives you an excuse to lord it over people. Use with caution, as your fellow players are unlikely to tolerate much snooty behavior.";
            }
        }

        public static void Proficiencies_Details()
        {
            if (frm_main.details_val == "")
            {
                frm_main.details_val = "";
            }
            else if (frm_main.details_val == "Acrobatics")
            {
                frm_main.details_val = "Acrobatics covers your attempt to stay on your feet in a tricky situation, such as when you’re trying to run across a sheet of ice, balance on a tightrope, or stay upright on a rocking ship’s deck.";
            }
            else if (frm_main.details_val == "Animal Handling")
            {
                frm_main.details_val = "When there is any question whether you can calm down a domesticated animal, keep a mount from getting spooked, or intuit an animal’s intentions, the GM might call for an Animal Handling check. You also make an Animal Handling check to control your mount when you attempt a risky maneuver.";
            }
            else if (frm_main.details_val == "Arcana")
            {
                frm_main.details_val = "Arcana measures your ability to recall lore about spells, magic items, eldritch symbols, magical traditions, the planes of existence, and the inhabitants of those planes.";
            }
            else if (frm_main.details_val == "Athletics")
            {
                frm_main.details_val = "Athletics covers difficult situations you encounter while climbing, jumping, or swimming.";
            }
            else if (frm_main.details_val == "Deception")
            {
                frm_main.details_val = "Deception lets you convincingly hide the truth, either verbally or through your actions. This deception can encompass everything from misleading others through ambiguity to telling outright lies.";
            }
            else if (frm_main.details_val == "History")
            {
                frm_main.details_val = "History is your ability to recall lore about historical events, legendary people, ancient kingdoms, past disputes, recent wars, and lost civilizations.";
            }
            else if (frm_main.details_val == "Insight")
            {
                frm_main.details_val = "Insight is the ability to determine the true intentions of a creature, such as when searching out a lie or predicting someone’s next move. Doing so involves gleaning clues from body language, speech habits, and changes in mannerisms.";
            }
            else if (frm_main.details_val == "Intimidation")
            {
                frm_main.details_val = "When you attempt to influence someone through overt threats, hostile actions, and physical violence, the GM might ask you to make an Intimidation check.";
            }
            else if (frm_main.details_val == "Investigation")
            {
                frm_main.details_val = "When you look around for clues and make deductions based on those clues, you make an Investigation check.";
            }
            else if (frm_main.details_val == "Medicine")
            {
                frm_main.details_val = "Medicine lets you try to stabilize a dying companion or diagnose an illness.";
            }
            else if (frm_main.details_val == "Nature")
            {
                frm_main.details_val = "Nature measures your ability to recall lore about terrain, plants and animals, the weather, and natural cycles.";
            }
            else if (frm_main.details_val == "Perception")
            {
                frm_main.details_val = "Your Perception lets you spot, hear, or otherwise detect the presence of something. It measures your general awareness of your surroundings and the keenness of your senses.";
            }
            else if (frm_main.details_val == "Performance")
            {
                frm_main.details_val = "Performance determines how well you can delight an audience with music, dance, acting, storytelling, or some other form of entertainment.";
            }
            else if (frm_main.details_val == "Persuasion")
            {
                frm_main.details_val = "When you attempt to influence someone or a group of people with tact, social graces, or good nature, the GM might ask you to make a Persuasion check. ";
            }
            else if (frm_main.details_val == "Religion")
            {
                frm_main.details_val = "Religion measures your ability to recall lore about deities, rites and prayers, religious hierarchies, holy symbols, and the practices of secret cults.";
            }
            else if (frm_main.details_val == "Sleight of Hand.")
            {
                frm_main.details_val = "Whenever you attempt an act of legerdemain or manual trickery, such as planting something on someone else or concealing an object on your person, make a Sleight of Hand check. ";
            }
            else if (frm_main.details_val == "Stealth")
            {
                frm_main.details_val = "Make a Stealth check when you attempt to conceal yourself from enemies, slink past guards, slip away without being noticed, or sneak up on someone without being seen or heard.";
            }
            else if (frm_main.details_val == "Survival")
            {
                frm_main.details_val = "The GM might ask you to make a Survival check to follow tracks, hunt wild game, guide your group through frozen wastelands, identify signs that owlbears live nearby, predict the weather, or avoid quicksand and other natural hazards.";
            }
        }
    }
}
