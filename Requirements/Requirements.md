# Game Master User Interface Requirements
1.  **Name:** Form for entering spell data.  
    **Type:** functional.  
    **Summary:** A data entry form for the spell information used by the Game Master.
   
2.  **Name:** Form for entering monster data.  
    **Type:** functional.    
    **Summary:** A data entry form for the monster information used by the Game Master.
   
3.  **Name:** System for storing creature data.  
    **Type:** functional.  
    **Summary:** A collection of data that can be reconstructed to represent the entirety of a player character, NPC, or monster. Beings consist of 6 attributes, Race, Class, HP, Alignment, 39 easy to handle skills, 4 complex skills, monetary wealth, and their languages. Any other charecter niformation can be derived from this.  

4.  **Name:** System for storing effects data.  
    **Type:** functional.  
    **Summary:** Every Spell[5], Feat[6], Class Features[7], Special Ability[8] and Racial Ability[9] produce Effects. These effects are kept in an universal format for more effecient processing.  

5.  **Name:** System for storing spell data.  
    **Type:** functional.  
    **Summary:** The storage location for requirement [1], which properly parses and asses that data. This data mostly has to do with the requirements to cast the spell, in addition to containing the names of relevant effects, stored in requirement [4].  
   
6.  **Name:** System for storing Feats data.  
    **Type:** functional.  
    **Summary:** Feats are a fundimental aspect of characters in this game system. Storage would include prerequisites and relevant effects (requirement [4]).  

7.  **Name:** System for storing Class Features Data.  
    **Type:** functional.  
    **Summary:** Stores names and summaries of what each character class gains at what level. Additionally, each feature has an assosciated effect [4] so the utility can properly aknolege and utilize them. 

9.  **Name:** System for storing Special Abilities.  
    **Type:** functional.  
    **Summary:** more specific to NPCs and monsters than player characters, This system similarly summarizes and contains the effects of Special features, with links to relevant effects [4]. This is seperate from [6] and [5] to prevent allowing player characters to select illegal choices as their feats[6].  

10. **Name:** System Accuracy.  
    **Type:** Constraint.  
    **Summary:** The utility must adhere to both the system it was designed for (Dungeons and Dragons, 3.5th edition) and to the rules within, as such will need to preform mathmatical calculations accurately.  

11. **Name:** Entity Initialization.  
    **Type:** functional.  
    **Summary:** The utility will offer the ability to select anything stored in requirement [3] and enable it, Creating an instance of that creature. To differentiate between clones, Duplicates, and the like, a numerical dientifier will also be provided.  

12. **Name:** Entity List.  
    **Type:** Functional.  
    **Summary:** A visual repository of Active entities[11], which are beings currently in play. This list will be Re-orderable to better represent initiative order, and provide some surface level information (HP, Controller).   

13. **Name:** Active Entity Selector.  
    **Type:** Functional.  
    **Summary:** Defaulting to the Current turn's Entity[12], this will select the being of the DM's discresion, providing detailed character data and populating [14].  
    
14. **Name:** Activated Ability Selector.  
    **Type:** Functional.  
    **Summary:** Using the Active Entity Selector's chosen entity[13], this is a populated dropdown list of Actions the being could preform.  
    
15. **Name:** Target Entity(s) selector.  
    **Type:** Functional.  
    **Summary:** Will provide a dropdown of presently active entities[12], and will (hopefully) allow for the selection of multiple targeted beings.  
    
16. **Name:** Results Button.  
    **Type:** Functional.  
    **Summary:** The main focus of this entire endevour, and encompasses the most complex parts of D&D. This takes the Activated Ability [14] as used by the Selected entity [13] and calculates the results against the targeted Entity(s)[15], streamlining each calculation, and automatically preforming the prerequisite dice rolls. Results are posted in [17].  

17. **Name:** Text based output and Log.  
    **Type:** functional.  
    **Summary:** User Readable text output, providing confirmation of entity initialization[11], results of actions [16], and most other system changes so that everything can be easily tracked. At user request, this can be saved to a TXT file.   
    
18. **Name:** Log ammendums.  
    **Type:** functional.  
    **Summary:** The DM will be permitted to add typed notes to the log, While most additions will be left as typed, "/r" will prompt the utility to attempt to process it as a Dice roll request, to be provided in the standard XdY+Z format.   

19. **Name:** DM intervention.  
    **Type:** Functional.  
    **Summary:** provide the DM with the ability to alter the results of any action, by means of altering any initialized entity's character sheet. Normally, this will be done by returning HP to a target, or simply saying that a skill check succeeded against the hard evidence.   

20. **Name:** Speed of operations.  
    **Type:** constraint.  
    **Summary:** The system must operate faster than an experienced DM, Which means that initial setup should be within 10 minutes, Initializing an entity should take within 10 seconds, and the results button's functionality[16] within two minutes. Ideally, Bootup will be within a minute, and Any other action will be instantanious to the user's preception.  
    
21. **Name:** System for storing Items.  
    **Type:** functional.  
    **Summary:** Keeps records of magical and mundane items within the game world, with links to effects[4] like the other storage systems. Items have the additional descriptor of having a cost.   
