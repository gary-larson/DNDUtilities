# Player User Interface Requirements
1.  **Name:** Character_Record  **UPDATED**  
    **Type:** functional.  
    **Summary:** A Character record sheet, containing the following fields.  
      1. **Name:**  Char_Name  **NEW**  
         **Type:**  Functional  
         **Summary:**  the Character's name  
      2. **Name:**  Player_Name  **NEW**  
         **Type:**  Functional  
         **Summary:**  the Owner's name
      3. **Name:**  Char_Type  **NEW**  
         **Type:**  Functional  
         **Summary:**  the Character's type, followed by the subtype.   
      4. **Name:**  Char_Levels  **NEW**  
         **Type:**  Functional  
         **Summary:**  the creature's class levels, if applicable  
      5. **Name:**  Char_Attributes  **NEW**  
         **Type:**  Functional  
         **Summary:**  Every being has six attribute scores, which are intergers, or N/A for specific creature types
      6. **Name:**  Char_HP  **NEW**  
         **Type:**  Functional  
         **Summary:**  the Creatures Maximum hitpoints.    
      7. **Name:**  Char_Alignment  **NEW**  
         **Type:**  Functional  
         **Summary:**  The creature's alignment, allowing for "mostly X Y" style entries.    
      8. **Name:**  Char_Skills_simple  **NEW**  
         **Type:**  Functional  
         **Summary:**  The number of accumulated skilranks in the non-ambigious skills. 39 skills in total  
      9. **Name:**  Char_Skills_Complex  **NEW**  
         **Type:**  Functional  
         **Summary:**  The 4 remaining ambigious skills (Craft, knowledge, preform, and Profession), which require a descriptor on which sub-skill it represents. 
      0. **Name:**  Char_Wealth  **NEW**  
         **Type:**  Functional  
         **Summary:**  The total value of the creature's gold equivilant items  
      1. **Name:**  Char_Languages  **NEW**  
         **Type:**  Functional  
         **Summary:**  The languages known by the creature  
      2. **Name:**  Char_Feats  **NEW**  
         **Type:**  Functional  
         **Summary:**  A listing of all feats accumulated by a character    
      3. **Name:**  Char_Items  **NEW**  
         **Type:**  Functional  
         **Summary:**  A listing of all items held by a character, with a note of if something is presently equipped or not.  
      4. **Name:**  Char_XP  **NEW**  
         **Type:**  Functional  
         **Summary:**  Expressed as "Total experience points gained," this keeps track of the character's total XP gain     
      5. **Name:**  Char_Spells  **NEW**  
         **Type:**  Functional  
         **Summary:**  A list of spells a creature knows, does not handle prepared spells or spells per day, this is the Flesh-and-blood player's responsibility.     
      6. **Name:**  Char_CR  **NEW**  
         **Type:**  Functional  
         **Summary:**  The creature's Creature rating, with player characters having their ECL here instead.  
      7. **Name:**  Char_Size  **NEW**  
         **Type:**  Functional  
         **Summary:**  The creature's size, which affects a number of combat specific things.            

2. **Name:** Print_Char_Record  
    **Type:** functional.  
    **Summary:** Be able to print Character record sheet.
    
3. **Name:** Update_Char_Record  **UPDATED**  
    **Type:** functional.  
    **Summary:** Be able to edit and update the Character record sheet.
      1. **Name:**   Char_Field_Avaibility  **NEW**  
         **Type:**   Constraint  
         **Summary:**   Fields will only be editable when characters have sufficient experience to "level up". Even then, Past choices will not be changeable, beyond what the system normally allows.    
      2. **Name:**   available_Char_Options  **NEW**  
         **Type:**   Constraint  
         **Summary:**   Choices will only be presented when the system can verify that the character in question already fufills the prequisites.    
      3. **Name:**   Char_item_choices  **NEW**  
         **Type:**   Constraint  
         **Summary:**  Players will be able to add any items they desire to their character.  

4. **Name:** Char_Export  **NEW**  
    **Type:** functional.  
    **Summary:** The character sheet will be digitally exportable, allowing for the players to transfer it to the DM through a method fo their choosing.   
    
5. **Name:** Char_Presentation  **NEW**  
    **Type:** functional.  
    **Summary:** To minimize information overload, The charactersheet will be organized by categories of interest, such as Skills, feats, attributes, and Spells.  
    
# Game Master User Interface Requirements
1.  **Name:** Homebrew_data_entry  **UPDATED**  
    **Type:** functional.  
    **Summary:** A data entry form for homebrew data used by the Game Master.  
      1.  **Name:** Spell_Data_Entry  
          **Type:** functional.  
          **Summary:** A data entry form for the spell information used by the Game Master.  
      2.  **Name:** Creature_Data_Entry  
          **Type:** functional.    
          **Summary:** A data entry form for the creature information used by the Game Master.  
      3.  **Name:** Item_Data_Entry  
          **Type:** functional.    
          **Summary:** A data entry form for the item information used by the Game Master.  
      4.  **Name:** Class_Data_Entry  
          **Type:** functional.    
          **Summary:** A data entry form for the class information used by the Game Master.  
      5.  **Name:** Race_Data_Entry  **NEW**  
          **Type:** functional.    
          **Summary:** A data entry form for the racial information used by the Game Master.  

5.  **Name:** System_Accuracy  
    **Type:** Constraint.  
    **Summary:** The utility must adhere to both the system it was designed for (Dungeons and Dragons, 3.5th edition) and to the rules within, as such will need to preform mathmatical calculations accurately.  

6.  **Name:** Entity_Initialization.  **UPDATED**  
    **Type:** functional.  
    **Summary:** The utility will offer the ability to select anything stored in the utility and enable it, Creating an instance of that creature. To differentiate between clones, Duplicates, and the like, a numerical dientifier will also be provided.  
    1.  **Name:** Entity_Searchibility  **NEW**  
        **Type:** Functional  
        **Summary:** The Initializer will offer the ability to search by creature Type, subtype, CR, or Name.  
    2.  **Name:** Mass_Entity_Initialization  **NEW**  
        **Type:** Functional  
        **Summary:** The system will offer the DM the ability to initialize multiple creatures simultaniously, to allow for more rapid progression to the heart of an encounter.    

7.  **Name:** Entity_List  
    **Type:** Functional.  
    **Summary:** A visual repository of Active entities, which are beings currently in play. This list will be Re-orderable to better represent initiative order, and provide some surface level information (HP, Controller).   

8.  **Name:** Active_Entity_Selector  
    **Type:** Functional.  
    **Summary:** Allows the selection of any intialized entity, providing more detailed information at the press of a button and populating the Activated ability selector with the entity's possible actions.  
    
9.  **Name:** Activated_Ability_Selector  
    **Type:** Functional.  
    **Summary:** Using the Active Entity Selector's chosen entity, this is a populated dropdown list of Actions the being could preform.    
    
10. **Name:** Target_Entity_selector  
    **Type:** Functional.  
    **Summary:** Will provide a dropdown of presently active entities, and will allow for the selection of multiple targeted beings.  
    
11. **Name:** Results_Button.  **UPDATED**  
    **Type:** Functional.  
    **Summary:** The system will accept outside input for die rolls, and make the DM aware of whether the results neccessitate success or failure, and keep readily available spell and avaibility descriptions. Results are posted in the log.  
      1. **Name:** Modfier_Details **NEW**    
         **Type:** Functional  
         **Summary:** The system will provide, at DM request, a breakdown of the modifiers affecting a particular roll, to better facilitate the DM's ability to override them at any given time. 

12. **Name:** Text_Log  
    **Type:** functional.  
    **Summary:** User Readable text output, providing confirmation of entity initialization, results of actions, and most other system changes so that everything can be easily tracked. At user request, this can be exported to a TXT file as an adventuring log.   
    
13. **Name:** Text_Log_Additions  
    **Type:** functional.  
    **Summary:** The DM will be permitted to add typed notes to the log, While most additions will be left as typed, "/r" will prompt the utility to attempt to process it as a Dice roll request, to be provided in the standard XdY+Z format.   

14. **Name:** DM_Intervention  
    **Type:** Functional.  
    **Summary:** provide the DM with the ability to alter the results of any action, by means of altering any initialized entity's character sheet. Normally, this will be done by returning HP to a target, or simply saying that a skill check succeeded against the hard evidence. The Utility will also keep records of past states to allow for a revision of the most recent action.    

15. **Name:** Speed_of_operations  
    **Type:** Constraint.  
    **Summary:** The system must operate faster than an experienced DM, Which means that initial setup should be within 10 minutes, Initializing an entity should take within 10 seconds, and the results button's functionality within two minutes. Ideally, Bootup will be within a minute, and Any other action will be instantanious to the user's preception.  

16. **Name:** Temporary_Effects_Table  **NEW**  
    **Type:** Functional.  
    **Summary:** Will connect the Effects of temporary statuses to their respective characters, through DM modification, and will thus affect the numbers provided by the system.  
    
17. **Name:** DM_responsibility  **NEW**  
    **Type:** Constraint    
    **Summary:** It will be the DM's responsibility to handle a number of facets this sytem cannot reasonibly be expected to handle.    
      1. **Name:** Cheat_Prevention **NEW**    
         **Type:** Constraint  
         **Summary:** The system will provide the player's data in an easier to process manner, but will not attempt to validiate every last detail of a player's character.  
      2. **Name:** Spell_Descriptions **NEW**    
         **Type:** Constraint  
         **Summary:** The system will provide descriptions of a spell's effects. It will be up to the DM to interpret these and move forwards from there. The goal of this system is to not have the game play itself.   
         
# System Requirements
1.  **Name:** Operating_systems  
    **Type:** Constraint.  
    **Summary:** System will run on Windows 7 and above  
    
2. **Name:** WotC_Copyright  
   **Type:** Constraint.  
   **Summary:** System will be designed within the limitations of Wizards of the Coast Open Game License.  
    
3. **Name:** Dungeon & Dragons System Reference Document 3.5  
   **Type:** Constraint.  
   **Summary** System will follow guidelines of the System Referenced Document 3.   
   
4. **Name:** Display OGL Copyright  
   **Type:** Constraint.  
   **Summary:** Open Game License will be displayed per the Open Game License.  
   
5. **Name:** Database  
   **Type:** Constraint.  
   **Summary:** System will include an embedded database.  
   
6. **Name:** Content_Restrictions  **NEW**  
   **Type:** Constraint.  
   **Summary:** For the sake of consiseness, the system will neglect to include the rules for psionics and epic level characters.  

