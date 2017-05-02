using DNDUtilities;
using DNDUtilitiesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICharacterCreation
{

    public partial class skillSelection : Form
    {
        public bool valid;
        List<Label> ClassSkillLabels;
        List<Label> SkillNamelabels;
        List<ComboBox> SubSkillComboBox;
        List<NumericUpDown> SkillRankUD;
        List<Label> AttributeModLabels;
        List<Label> miscModLabels;
        List<Label> totalModLabels;
        List<int> IDinPos;          // this is "what skill ID is using this spot in the UI", 52 spot array
        int effectiveIntMod;        // stuff. 
        int pointsToSpend;          // keeps track of how many are left
        List<int> attributes;
        List<int> attribMods;
        List<int> attributeModForSkill; // maintains track of math things
        List<int> MiscModForSkills;     // same as above, but more likely to be 0. 
        List<int> totalModForSkills;
        List<int> oldUDValues;          // holds prior skill ranks for the sake of point calculations
        public List<Character_skills> result;

        public skillSelection(int characterID)
        {
            List<NameKey> characterSkills = Character_skills.retrieveAllSkills(characterID);    // List<namekey> of Modified skills for Character
                                                                                                // populate based on this at some point aaaaaaa
                                                                                                // this is EDIT functionality, new chars just overwrite
        }

        public skillSelection(int classID, int raceID, List<int> abilityScores, List<Character_skills> SkillInput)
        {
            universalInitialization2(classID, raceID, abilityScores);           // do the generic stuff
            blankCharacterData(classID, raceID);                                // populate the skeleton
            foreach (Character_skills input in SkillInput)
            {
                for(int i = 0; i < ClassSkillLabels.Count; i++)
                {
                    if (IDinPos[i] == input.skill_id)
                    {
                        SkillRankUD[i].Value = input.skill_rank;
                        attributeModForSkill[i] = input.ability_modifier;
                        MiscModForSkills[i] = input.misc_modifier;
                        totalModForSkills[i] = input.skill_modifier;
                        pointsToSpend = 0;      // you can only get here with 0 points to spend using this method. 
                        break;
                    }
                }
            }
        }
        public skillSelection(string typing, int classID, int raceID, List<int> abilityScores)
        {
            universalInitialization2(classID, raceID, abilityScores);
            // ------------------------------------------- Populate form Lists! ------------------------------------------ //
            initArr();
            if (typing == "new")
            {
                // this function is going to be picked apart to help make things happen
                blankCharacterData(classID, raceID);
            }
            else
            {
                // view stuff/code
                // some day Q.Q
            }



            // typing = view:       Disable controls and just allow viewing. 
            // typing = edit:       enable conrt5olls, have a policy of "spend all skillpoints, or void changes", this is for char level ups. 
            // typing = new:        Editable, But point calculations are different. 

            // ------------------Free point Calculations-----------------//
            // if a character doesnt have attribute scores yet, throw an error
            // Main page will have to check if attribute scores still support skills chosen, if not, throw an error
            // also if race changes to/from human, throw an error
            // just throw a shitton of errors. 
            // as for point calculation, Compare old level to new level, grant ClassSkillPoints+int Mod (minimum 1) + race modifier
            // for new characters, provide (class Skillpoints+int mod (minimum 1) + race Modifier) * 4

            // ------------------ List Population -----------------------//
            // if Subtyping == "NO" then only print the skill once
            // if Subtyping == "Yes" then print the skill 4 times, with a dropdown for subSkills
            //      if Skill = "Speak language" give it a special interface cause it's fucking dumb. 
            // 52 total entry blips :c


        }
        public void initArr()
        {
            // we call this on load to keep things dynamic. 
            // we put it here because honestly, it looks better. 
            // we're reliant on the c# to keep this from biting us. 
            ClassSkillLabels = new List<Label>()
            {
                labelClassSkill1,   labelClassSkill2,   labelClassSkill3,   labelClassSkill4,
                labelClassSkill5,   labelClassSkill6,   labelClassSkill7,   labelClassSkill8,
                labelClassSkill9,   labelClassSkill10,  labelClassSkill11,  labelClassSkill12,
                labelClassSkill13,  labelClassSkill14,  labelClassSkill15,  labelClassSkill16,
                labelClassSkill17,  labelClassSkill18,  labelClassSkill19,  labelClassSkill20,
                labelClassSkill21,  labelClassSkill22,  labelClassSkill23,  labelClassSkill24,
                labelClassSkill25,  labelClassSkill26,  labelClassSkill27,  labelClassSkill28,
                labelClassSkill29,  labelClassSkill30,  labelClassSkill31,  labelClassSkill32,
                labelClassSkill33,  labelClassSkill34,  labelClassSkill35,  labelClassSkill36,
                labelClassSkill37,  labelClassSkill38,  labelClassSkill39,  labelClassSkill40,
                labelClassSkill41,  labelClassSkill42,  labelClassSkill43,  labelClassSkill44,
                labelClassSkill45,  labelClassSkill46,  labelClassSkill47,  labelClassSkill48,
                labelClassSkill49,  labelClassSkill50,  labelClassSkill51,  labelClassSkill52
            };

            SkillNamelabels = new List<Label>()
            {
                labelSkillName1,   labelSkillName2,   labelSkillName3,   labelSkillName4,
                labelSkillName5,   labelSkillName6,   labelSkillName7,   labelSkillName8,
                labelSkillName9,   labelSkillName10,  labelSkillName11,  labelSkillName12,
                labelSkillName13,  labelSkillName14,  labelSkillName15,  labelSkillName16,
                labelSkillName17,  labelSkillName18,  labelSkillName19,  labelSkillName20,
                labelSkillName21,  labelSkillName22,  labelSkillName23,  labelSkillName24,
                labelSkillName25,  labelSkillName26,  labelSkillName27,  labelSkillName28,
                labelSkillName29,  labelSkillName30,  labelSkillName31,  labelSkillName32,
                labelSkillName33,  labelSkillName34,  labelSkillName35,  labelSkillName36,
                labelSkillName37,  labelSkillName38,  labelSkillName39,  labelSkillName40,
                labelSkillName41,  labelSkillName42,  labelSkillName43,  labelSkillName44,
                labelSkillName45,  labelSkillName46,  labelSkillName47,  labelSkillName48,
                labelSkillName49,  labelSkillName50,  labelSkillName51,  labelSkillName52
            };

            SubSkillComboBox = new List<ComboBox>()
            {
                subskill1,   subskill2,   subskill3,   subskill4,
                subskill5,   subskill6,   subskill7,   subskill8,
                subskill9,   subskill10,  subskill11,  subskill12,
                subskill13,  subskill14,  subskill15,  subskill16,
                subskill17,  subskill18,  subskill19,  subskill20,
                subskill21,  subskill22,  subskill23,  subskill24,
                subskill25,  subskill26,  subskill27,  subskill28,
                subskill29,  subskill30,  subskill31,  subskill32,
                subskill33,  subskill34,  subskill35,  subskill36,
                subskill37,  subskill38,  subskill39,  subskill40,
                subskill41,  subskill42,  subskill43,  subskill44,
                subskill45,  subskill46,  subskill47,  subskill48,
                subskill49,  subskill50,  subskill51,  subskill52
            };

            SkillRankUD = new List<NumericUpDown>()
            {
                skilrankUD1,   skilrankUD2,   skilrankUD3,   skilrankUD4,
                skilrankUD5,   skilrankUD6,   skilrankUD7,   skilrankUD8,
                skilrankUD9,   skilrankUD10,  skilrankUD11,  skilrankUD12,
                skilrankUD13,  skilrankUD14,  skilrankUD15,  skilrankUD16,
                skilrankUD17,  skilrankUD18,  skilrankUD19,  skilrankUD20,
                skilrankUD21,  skilrankUD22,  skilrankUD23,  skilrankUD24,
                skilrankUD25,  skilrankUD26,  skilrankUD27,  skilrankUD28,
                skilrankUD29,  skilrankUD30,  skilrankUD31,  skilrankUD32,
                skilrankUD33,  skilrankUD34,  skilrankUD35,  skilrankUD36,
                skilrankUD37,  skilrankUD38,  skilrankUD39,  skilrankUD40,
                skilrankUD41,  skilrankUD42,  skilrankUD43,  skilrankUD44,
                skilrankUD45,  skilrankUD46,  skilrankUD47,  skilrankUD48,
                skilrankUD49,  skilrankUD50,  skilrankUD51,  skilrankUD52
            };
            AttributeModLabels = new List<Label>()
            {
                attribMod1,   attribMod2,   attribMod3,   attribMod4,
                attribMod5,   attribMod6,   attribMod7,   attribMod8,
                attribMod9,   attribMod10,  attribMod11,  attribMod12,
                attribMod13,  attribMod14,  attribMod15,  attribMod16,
                attribMod17,  attribMod18,  attribMod19,  attribMod20,
                attribMod21,  attribMod22,  attribMod23,  attribMod24,
                attribMod25,  attribMod26,  attribMod27,  attribMod28,
                attribMod29,  attribMod30,  attribMod31,  attribMod32,
                attribMod33,  attribMod34,  attribMod35,  attribMod36,
                attribMod37,  attribMod38,  attribMod39,  attribMod40,
                attribMod41,  attribMod42,  attribMod43,  attribMod44,
                attribMod45,  attribMod46,  attribMod47,  attribMod48,
                attribMod49,  attribMod50,  attribMod51,  attribMod52
            };
            miscModLabels = new List<Label>()
            {
                miscMod1,   miscMod2,   miscMod3,   miscMod4,
                miscMod5,   miscMod6,   miscMod7,   miscMod8,
                miscMod9,   miscMod10,  miscMod11,  miscMod12,
                miscMod13,  miscMod14,  miscMod15,  miscMod16,
                miscMod17,  miscMod18,  miscMod19,  miscMod20,
                miscMod21,  miscMod22,  miscMod23,  miscMod24,
                miscMod25,  miscMod26,  miscMod27,  miscMod28,
                miscMod29,  miscMod30,  miscMod31,  miscMod32,
                miscMod33,  miscMod34,  miscMod35,  miscMod36,
                miscMod37,  miscMod38,  miscMod39,  miscMod40,
                miscMod41,  miscMod42,  miscMod43,  miscMod44,
                miscMod45,  miscMod46,  miscMod47,  miscMod48,
                miscMod49,  miscMod50,  miscMod51,  miscMod52

            };
            totalModLabels = new List<Label>()
            {
                totalMod1,   totalMod2,   totalMod3,   totalMod4,
                totalMod5,   totalMod6,   totalMod7,   totalMod8,
                totalMod9,   totalMod10,  totalMod11,  totalMod12,
                totalMod13,  totalMod14,  totalMod15,  totalMod16,
                totalMod17,  totalMod18,  totalMod19,  totalMod20,
                totalMod21,  totalMod22,  totalMod23,  totalMod24,
                totalMod25,  totalMod26,  totalMod27,  totalMod28,
                totalMod29,  totalMod30,  totalMod31,  totalMod32,
                totalMod33,  totalMod34,  totalMod35,  totalMod36,
                totalMod37,  totalMod38,  totalMod39,  totalMod40,
                totalMod41,  totalMod42,  totalMod43,  totalMod44,
                totalMod45,  totalMod46,  totalMod47,  totalMod48,
                totalMod49,  totalMod50,  totalMod51,  totalMod52
            };

            // intentional dummy values
            IDinPos = new List<int>()
            {
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1,
                -1, -1, -1, -1
            };
            attributeModForSkill = new List<int>()
            {
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0
            };
            MiscModForSkills = new List<int>()
            {
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0
            };
            totalModForSkills = new List<int>()
            {
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0
            };
            oldUDValues = new List<int>()
            {
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0
            };
        }
        public void blankCharacterData(int classID, int raceID)
        {
            // get the list of _all Skills_
            // check if a skill has subtyping, and go from there
            // magical
            // Current index, as in 'where in the 52 are we". this is for the boxes
            List<NameKey> classSkills = new List<NameKey>();
            classSkills = Class_skills.retrieveAllSkills(classID);              // IDs of the skills a clas sis good with. 
            List<NameKey> SkillChoices = Skills.retrieveAllSkills();            // All the skills we will put in the thing
            int cI = 0;                             // Current index, as in 'where in the 52 are we". this is for the boxes
            // itterates through all skills availe                              // TempSkill starts at 0, IDs start at 1
            List<SkillInfo> tempSkill = new List<SkillInfo>();                  // OPERATES OFF THE "ID IN POS" METHOD
            tempSkill = Skills.retrieveAllSkills(classID, raceID);              // WHICH IS TO SAY YOU WANT 
                                                                                // tempSkill[IDinPos[cI]-1]
                                                                                // ID in pos 0 = 1
                                                                                // Ci = 0
                                                                                // ID for first skill 1
                                                                                // position of skill_id 1 in tempskill = 0
                                                                                // i hate subtyped skills. 
            foreach (NameKey s in SkillChoices)
            {

                IDinPos[cI] = s.key;      // sets the ID in this position to the key of the currently selexcted SkillChoice
                //  MessageBox.Show("IDinPOS[ci] = " + IDinPos[cI].ToString() + "\n" +
                //                  "cI = " + cI.ToString());

                //  Exception duck = new Exception();
                //  throw duck;     // cant insert a break so fuck it. 

                // Misc. modifiers, affected by things like spells and Equipment and race. 
                // I might try to get race going later. // should be going now. 

                // adjusted int mod = attributes[3] + possible racial modifier. 
                // ugh ok ill get race information in this also :C


                if (tempSkill[IDinPos[cI] - 1].subType.ToUpper() == "YES")
                {
                    // subtyped things get 4 entries, unless they're speak language. 
                    if (tempSkill[IDinPos[cI] - 1].name == "Speak Language")
                    {
                        // Dont do normal things because this one is weird
                        ClassSkillLabels[cI].Text = "NO";             // 2 skillpoints per language
                        SkillNamelabels[cI].Text = tempSkill[IDinPos[cI] - 1].name;    // sets the name label
                        AttributeModLabels[cI].Text = "N/A";
                        miscModLabels[cI].Text = "N/A";
                        totalModLabels[cI].Text = "0 Languages Gained";
                        SubSkillComboBox[cI].Enabled = false;         // disables unneeded box
                                                                      // Technically we _could_ use that box, but this system will instead just make the languages UI aware that the player cna use more languages
                        cI++;                                         // eventually. 
                    }
                    else
                    {
                        //List<NameKey> subtypes = Skill_subtypes.retrieveAllSubskillsfor(tempSkill.skill_id);
                        for (int i = 0; i < 4; i++)
                        {

                            IDinPos[cI] = s.key;     // sets the ID in this position to the key of the currently selexcted SkillChoice
                                                                    // this has to be replicated here, because reasons! (if this was absent the ID would be -1)
                                                                    // to provide VARIETY you can select up to 4 different versions of this. 
                            Labeling(cI, tempSkill, classSkills);
                            SubSkillComboBox[cI].DropDownStyle = ComboBoxStyle.DropDownList;

                            List<NameKey> subtypes = Skill_subtypes.retrieveAllSubTypes(IDinPos[cI]);
                            foreach (NameKey sub in subtypes)
                            {
                                SubSkillComboBox[cI].Items.Add(sub);
                            }
                            // SubSkillComboBox[cI].SelectedIndex = 0;
                            cI++;       // this increments seperately because it is NEEDED. or something
                                        // look i just hate subskills. 
                        }
                    }
                }
                else
                {
                    // no subtyping, just 1 entry.
                    //--------------------Sets everything _but_ the combobox--------------------------//
                    Labeling(cI, tempSkill, classSkills);

                    //-----------------------Set ComboBox----------------------------------------//
                    SubSkillComboBox[cI].Enabled = false;         // disables unneeded box
                    cI++;
                }
                // we are finished with this row of boxes, and thus move on to the next. 
            }
        }
        public void updatePointsremainingLabel()
        {
            labelPoints.Text = pointsToSpend.ToString() + " points remaining";
        }
        public void Labeling(int cI, List<SkillInfo> tempSkill, List<NameKey> classSkills)
        {
            //------------------------------class skill labels---------------------------------------------//
            ClassSkillLabels[cI].Text = "NO";     // reset this from the default "unknown"
            foreach (NameKey skillID in classSkills)
            {
                if (skillID.key == tempSkill[IDinPos[cI] - 1].skill_id)
                {
                    // if this _is_ a class skill
                    ClassSkillLabels[cI].Text = "YES";
                }
            }
            //--------------------------------Set Skill name Label----------------------------------------------//
            SkillNamelabels[cI].Text = tempSkill[IDinPos[cI] - 1].name;    // sets the name label

            //------------------------------------Set attribute Mod Label---------------------------------------//
            attributeModForSkill[cI] = attribMods[tempSkill[IDinPos[cI] - 1].ability_id - 1];
            if (attributeModForSkill[cI] >= 0)
            {
                // Take the current attribute mod label, set it equal to the current skil's ability's abbr, and add the number at the end. 
                AttributeModLabels[cI].Text = tempSkill[IDinPos[cI] - 1].ability + ": +" + attributeModForSkill[cI].ToString();
            }
            else
            {
                // the lack of a sign is the only difference here. 
                AttributeModLabels[cI].Text = tempSkill[IDinPos[cI] - 1].ability + ": " + attributeModForSkill[cI].ToString();
            }

            //------------------------------------MiscModLabel Assignments-------------------------------------------------------------//
            miscModLabels[cI].Text = "+0";
            // Checks if the current skill is modified

            MiscModForSkills[cI] = tempSkill[IDinPos[cI] - 1].adjustment;
            if (MiscModForSkills[cI] >= 0)
            {
                miscModLabels[cI].Text = "+" + MiscModForSkills[cI].ToString();
            }
            else
            {
                miscModLabels[cI].Text = MiscModForSkills[cI].ToString();
            }

            totalModForSkills[cI] = MiscModForSkills[cI] + attributeModForSkill[cI] + (int)SkillRankUD[cI].Value;
            if (totalModForSkills[cI] >= 0)
            {
                totalModLabels[cI].Text = "+" + totalModForSkills[cI].ToString();
            }
            else
            {
                totalModLabels[cI].Text = totalModForSkills[cI].ToString();
            }
        }
        private void skilrank_ValueChanged(object sender, EventArgs e)
        {
            // update modifier labels
            // updates points remaining
            int cI = 0;
            for (cI = 0; cI < SkillRankUD.Count; cI++)
            {
                if ((NumericUpDown)sender == SkillRankUD[cI])
                {
                    break;      // determines the index of the affected row. a linear time operation because just (*^^&&^ hardcoding this
                }
            }
            int currentUDVal = (int)SkillRankUD[cI].Value;
            totalModForSkills[cI] = MiscModForSkills[cI] + attributeModForSkill[cI] + currentUDVal;
            if (totalModForSkills[cI] >= 0)
            {
                totalModLabels[cI].Text = "+" + totalModForSkills[cI].ToString();
            }
            else
            {
                totalModLabels[cI].Text = totalModForSkills[cI].ToString();
            }

            // calculate this based on the U/D's value versus the old one. 
            int pointsSpent = currentUDVal - oldUDValues[cI];       // points *spent*
            if (ClassSkillLabels[cI].Text.Equals("YES"))
            {
                // 1 to 1 point / rank costs
                pointsToSpend = pointsToSpend - pointsSpent;
            }
            else
            {
                // assume that it is not a class skill. this system wont handle half-ranks, sorry bub
                pointsToSpend = pointsToSpend - (2 * pointsSpent);
            }
            updatePointsremainingLabel();
        }

        private void skillSubmitButton_Click(object sender, EventArgs e)
        {
            if (pointsToSpend == 0)
            {
                // this tells the sending form that the data in here is valid!
                // we're going to add some code to package the data up more neatly though, to keep processing in-house
                StoreData();
                valid = true;
                this.Close();
            }
            else if (pointsToSpend < 0)
            {
                MessageBox.Show("Please spend all skillpoints before trying to save!");
            }
            else
            {
                MessageBox.Show("Please don't overspend skillpoints!");
            }
        }

        private List<Character_skills> StoreData()
        {
            // generates a List of CharacterSkills for the main form to use. 
            result = new List<Character_skills>();
            for (int cI = 0; cI < SkillRankUD.Count; cI++)
            {
                result.Add(new Character_skills(-1, IDinPos[cI], (int)SkillRankUD[cI].Value, totalModForSkills[cI], attributeModForSkill[cI], MiscModForSkills[cI]));
            }
            // These need the Character IDs tacked on
            return result;
        }

        private void universalInitialization2(int classID, int raceID, List<int> abilityScores)
        {
            // adjIntMod is the Intelegence modifier of a character after accounting for race adn such. 
            // abilityscores should be an array of the 6 scores in the normal order. 
            InitializeComponent();
            attributes = new List<int>();
            attributes = abilityScores;
            // --------------------------------- Calculate ability modifiers!-------------------------------------//
            attribMods = new List<int>();
            attribMods.Clear();       // helps ensure data integrity
            for (int i = 0; i < attributes.Count(); i++)
            {
                attribMods.Add((int)Math.Floor((double)attributes[i] / 2 - 5));
            }
            // 0 = str, normal IDs are this +1
            // 1 = dex
            // 2 = con
            // 3 = int
            // 4 = wis
            // 5 = cha
            // ------------------------------------------Setup other things that are less crazy----------------------------//
            Races tempRace = new Races();
            tempRace.retrieveRecord(raceID);
            // Exception duck = new Exception();
            // throw duck;// DUCKY IS THROWN BECAUSE OF THAT ISSUE!, that issue being "retrieve record doesnt exist" (yet)
            Classes tempClass = new Classes();
            tempClass.retrieveRecord(classID);

            effectiveIntMod = attribMods[3] + (int)(tempRace.extra_skill_points / 4.0);
            pointsToSpend = (tempClass.skill_points + effectiveIntMod) * 4;   // this is times four due to the first level stuff.
                                                                              // yes, races have their starting skillpoints set to lvl 1 and i (x/4)*4
            if (pointsToSpend < 1)
            {
                pointsToSpend = 4;                                          // i cant find the source right now but this is a thing. i think. 
            }
            updatePointsremainingLabel();
        }
    }
}
