# Player User Interface Requirements
1.  **Name:** Character Record  
    **Type:** functional.  
    **Summary:** A Character record sheet.
    
2. **Name:** Print Character Record  
    **Type:** functional.  
    **Summary:** Be able to print Character record sheet.
    
2. **Name:** Edit/Update Character Record  
    **Type:** functional.  
    **Summary:** Be able to edit and update the Character record sheet.

# Game Master User Interface Requirements
1.  **Name:** Form for entering spell data.  
    **Type:** functional.  
    **Summary:** A data entry form for the spell information used by the Game Master.
   
2.  **Name:** Form for entering creature data.  
    **Type:** functional.    
    **Summary:** A data entry form for the creature information used by the Game Master.

3.  **Name:** Form for entering item data.  
    **Type:** functional.    
    **Summary:** A data entry form for the item information used by the Game Master.

4.  **Name:** Form for entering class data.  
    **Type:** functional.    
    **Summary:** A data entry form for the class information used by the Game Master.

5.  **Name:** System Accuracy.  
    **Type:** Constraint.  
    **Summary:** The utility must adhere to both the system it was designed for (Dungeons and Dragons, 3.5th edition) and to the rules within, as such will need to preform mathmatical calculations accurately.  

6.  **Name:** Entity Initialization.  
    **Type:** functional.  
    **Summary:** The utility will offer the ability to select anything stored in the utility and enable it, Creating an instance of that creature. To differentiate between clones, Duplicates, and the like, a numerical dientifier will also be provided.  

7.  **Name:** Entity List.  
    **Type:** Functional.  
    **Summary:** A visual repository of Active entities, which are beings currently in play. This list will be Re-orderable to better represent initiative order, and provide some surface level information (HP, Controller).   

8.  **Name:** Active Entity Selector.  
    **Type:** Functional.  
    **Summary:** Allows the selection of any intialized entity, providing more detailed information at the press of a button and populating the Activated ability selector with the entity's possible actions.  
    
9.  **Name:** Activated Ability Selector.  
    **Type:** Functional.  
    **Summary:** Using the Active Entity Selector's chosen entity, this is a populated dropdown list of Actions the being could preform.    
    
10. **Name:** Target Entity(s) selector.  
    **Type:** Functional.  
    **Summary:** Will provide a dropdown of presently active entities, and will allow for the selection of multiple targeted beings.  
    
11. **Name:** Results Button.  
    **Type:** Functional.  
    **Summary:** The main focus of this entire endevour, and encompasses the most complex parts of D&D. This takes the Activated Ability as used by the Selected entity and calculates the results against the targeted Entity(s), streamlining each calculation, and automatically preforming the prerequisite dice rolls. Results are posted in the log.  

12. **Name:** Text based output and Log.  
    **Type:** functional.  
    **Summary:** User Readable text output, providing confirmation of entity initialization, results of actions, and most other system changes so that everything can be easily tracked. At user request, this can be exported to a TXT file as an adventuring log.   
    
13. **Name:** Log ammendums.  
    **Type:** functional.  
    **Summary:** The DM will be permitted to add typed notes to the log, While most additions will be left as typed, "/r" will prompt the utility to attempt to process it as a Dice roll request, to be provided in the standard XdY+Z format.   

14. **Name:** DM intervention and "undo".  
    **Type:** Functional.  
    **Summary:** provide the DM with the ability to alter the results of any action, by means of altering any initialized entity's character sheet. Normally, this will be done by returning HP to a target, or simply saying that a skill check succeeded against the hard evidence. The Utility will also keep records of past states to allow for a revision of the most recent action.    

15. **Name:** Speed of operations.  
    **Type:** Constraint.  
    **Summary:** The system must operate faster than an experienced DM, Which means that initial setup should be within 10 minutes, Initializing an entity should take within 10 seconds, and the results button's functionality within two minutes. Ideally, Bootup will be within a minute, and Any other action will be instantanious to the user's preception.  

    
# System Requirements
1.  **Name:** Operating systems  
    **Type:** Constraint.  
    **Summary:** System will run on Windows 7 and above  
    
2. **Name:** Wizards of the Coast Copyright  
   **Type:** Constraint.  
   **Summary:** System will be designed within the limitations of Wizards of the Coast Open Game License.  
    
3. **Name:** Dungeon & Dragons System Reference Document 3.5  
   **Type:** Constraint.  
   **Summary** System will follow guidelines of the System Referenced Document 3.   
   
4. **Name:** Display Open Game License Copyright  
   **Type:** Constraint.  
   **Summary:** Open Game License will be displayed per the Open Game License.  
   
5. **Name:** Database  
   **Type:** Constraint.  
   **Summary:** System will include an embedded database.

