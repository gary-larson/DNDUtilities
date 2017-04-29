namespace UICharacterCreation
{
    partial class newCharacterGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.pcNameLabel = new System.Windows.Forms.Label();
            this.pcNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.dietyLabel = new System.Windows.Forms.Label();
            this.dietyTextBox = new System.Windows.Forms.TextBox();
            this.alignmentLabel = new System.Windows.Forms.Label();
            this.alignmentComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.eyesLabel = new System.Windows.Forms.Label();
            this.eyesTextBox = new System.Windows.Forms.TextBox();
            this.hairLabel = new System.Windows.Forms.Label();
            this.hairTextBox = new System.Windows.Forms.TextBox();
            this.skinLabel = new System.Windows.Forms.Label();
            this.skinTextBox = new System.Windows.Forms.TextBox();
            this.submitGeneralInfo = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.AbilityScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.RacialModifierButton = new System.Windows.Forms.Button();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.reRollOneBox = new System.Windows.Forms.CheckBox();
            this.swapBox6 = new System.Windows.Forms.CheckBox();
            this.swapBox5 = new System.Windows.Forms.CheckBox();
            this.swapBox4 = new System.Windows.Forms.CheckBox();
            this.swapBox3 = new System.Windows.Forms.CheckBox();
            this.swapBox2 = new System.Windows.Forms.CheckBox();
            this.swapBox1 = new System.Windows.Forms.CheckBox();
            this.abilitySwapLabel = new System.Windows.Forms.Label();
            this.modLabel6 = new System.Windows.Forms.Label();
            this.modLabel5 = new System.Windows.Forms.Label();
            this.modLabel4 = new System.Windows.Forms.Label();
            this.modLabel3 = new System.Windows.Forms.Label();
            this.modLabel2 = new System.Windows.Forms.Label();
            this.modLabel1 = new System.Windows.Forms.Label();
            this.abilityModLabel = new System.Windows.Forms.Label();
            this.abilityTextBox6 = new System.Windows.Forms.TextBox();
            this.abilityTextBox5 = new System.Windows.Forms.TextBox();
            this.abilityTextBox4 = new System.Windows.Forms.TextBox();
            this.abilityTextBox3 = new System.Windows.Forms.TextBox();
            this.abilityTextBox2 = new System.Windows.Forms.TextBox();
            this.abilityTextBox1 = new System.Windows.Forms.TextBox();
            this.abilityScoreValue = new System.Windows.Forms.Label();
            this.abilityLabel6 = new System.Windows.Forms.Label();
            this.abilityLabel5 = new System.Windows.Forms.Label();
            this.abilityLabel4 = new System.Windows.Forms.Label();
            this.abilityLabel3 = new System.Windows.Forms.Label();
            this.abilityLabel2 = new System.Windows.Forms.Label();
            this.abilityLabel1 = new System.Windows.Forms.Label();
            this.AbilityNameLabel = new System.Windows.Forms.Label();
            this.abilityGenerationSelector = new System.Windows.Forms.ComboBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.addBackstoryButton = new System.Windows.Forms.Button();
            this.addSkillsButton = new System.Windows.Forms.Button();
            this.AbilityScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(199, 65);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 21);
            this.classComboBox.TabIndex = 0;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(196, 49);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(99, 13);
            this.ClassLabel.TabIndex = 1;
            this.ClassLabel.Text = "Choose Your Class:";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(196, 9);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(100, 13);
            this.raceLabel.TabIndex = 2;
            this.raceLabel.Text = "Choose Your Race:";
            // 
            // raceComboBox
            // 
            this.raceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(199, 25);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(121, 21);
            this.raceComboBox.TabIndex = 3;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // pcNameLabel
            // 
            this.pcNameLabel.AutoSize = true;
            this.pcNameLabel.Location = new System.Drawing.Point(9, 9);
            this.pcNameLabel.Name = "pcNameLabel";
            this.pcNameLabel.Size = new System.Drawing.Size(87, 13);
            this.pcNameLabel.TabIndex = 4;
            this.pcNameLabel.Text = "Character Name:";
            // 
            // pcNameTextBox
            // 
            this.pcNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.pcNameTextBox.MaxLength = 50;
            this.pcNameTextBox.Name = "pcNameTextBox";
            this.pcNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pcNameTextBox.TabIndex = 5;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(9, 48);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(70, 13);
            this.playerNameLabel.TabIndex = 6;
            this.playerNameLabel.Text = "Player Name:";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.playerNameTextBox.MaxLength = 50;
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerNameTextBox.TabIndex = 7;
            // 
            // dietyLabel
            // 
            this.dietyLabel.AutoSize = true;
            this.dietyLabel.Location = new System.Drawing.Point(9, 87);
            this.dietyLabel.Name = "dietyLabel";
            this.dietyLabel.Size = new System.Drawing.Size(65, 13);
            this.dietyLabel.TabIndex = 8;
            this.dietyLabel.Text = "Diety Name:";
            // 
            // dietyTextBox
            // 
            this.dietyTextBox.Location = new System.Drawing.Point(12, 103);
            this.dietyTextBox.MaxLength = 50;
            this.dietyTextBox.Name = "dietyTextBox";
            this.dietyTextBox.Size = new System.Drawing.Size(100, 20);
            this.dietyTextBox.TabIndex = 9;
            // 
            // alignmentLabel
            // 
            this.alignmentLabel.AutoSize = true;
            this.alignmentLabel.Location = new System.Drawing.Point(196, 89);
            this.alignmentLabel.Name = "alignmentLabel";
            this.alignmentLabel.Size = new System.Drawing.Size(95, 13);
            this.alignmentLabel.TabIndex = 10;
            this.alignmentLabel.Text = "Choose Alignment:";
            // 
            // alignmentComboBox
            // 
            this.alignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alignmentComboBox.FormattingEnabled = true;
            this.alignmentComboBox.Location = new System.Drawing.Point(199, 105);
            this.alignmentComboBox.Name = "alignmentComboBox";
            this.alignmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.alignmentComboBox.TabIndex = 11;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(407, 9);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(94, 13);
            this.genderLabel.TabIndex = 12;
            this.genderLabel.Text = "Character Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(410, 25);
            this.genderTextBox.MaxLength = 50;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 13;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(407, 48);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 13);
            this.heightLabel.TabIndex = 14;
            this.heightLabel.Text = "Height (inches):";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(407, 87);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(88, 13);
            this.weightLabel.TabIndex = 16;
            this.weightLabel.Text = "Weight (pounds):";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(407, 126);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(63, 13);
            this.ageLabel.TabIndex = 18;
            this.ageLabel.Text = "Age (years):";
            // 
            // eyesLabel
            // 
            this.eyesLabel.AutoSize = true;
            this.eyesLabel.Location = new System.Drawing.Point(407, 165);
            this.eyesLabel.Name = "eyesLabel";
            this.eyesLabel.Size = new System.Drawing.Size(33, 13);
            this.eyesLabel.TabIndex = 20;
            this.eyesLabel.Text = "Eyes:";
            // 
            // eyesTextBox
            // 
            this.eyesTextBox.Location = new System.Drawing.Point(410, 181);
            this.eyesTextBox.MaxLength = 50;
            this.eyesTextBox.Name = "eyesTextBox";
            this.eyesTextBox.Size = new System.Drawing.Size(100, 20);
            this.eyesTextBox.TabIndex = 21;
            // 
            // hairLabel
            // 
            this.hairLabel.AutoSize = true;
            this.hairLabel.Location = new System.Drawing.Point(407, 204);
            this.hairLabel.Name = "hairLabel";
            this.hairLabel.Size = new System.Drawing.Size(29, 13);
            this.hairLabel.TabIndex = 22;
            this.hairLabel.Text = "Hair:";
            // 
            // hairTextBox
            // 
            this.hairTextBox.Location = new System.Drawing.Point(410, 220);
            this.hairTextBox.MaxLength = 50;
            this.hairTextBox.Name = "hairTextBox";
            this.hairTextBox.Size = new System.Drawing.Size(100, 20);
            this.hairTextBox.TabIndex = 23;
            // 
            // skinLabel
            // 
            this.skinLabel.AutoSize = true;
            this.skinLabel.Location = new System.Drawing.Point(407, 243);
            this.skinLabel.Name = "skinLabel";
            this.skinLabel.Size = new System.Drawing.Size(31, 13);
            this.skinLabel.TabIndex = 24;
            this.skinLabel.Text = "Skin:";
            // 
            // skinTextBox
            // 
            this.skinTextBox.Location = new System.Drawing.Point(410, 259);
            this.skinTextBox.MaxLength = 50;
            this.skinTextBox.Name = "skinTextBox";
            this.skinTextBox.Size = new System.Drawing.Size(100, 20);
            this.skinTextBox.TabIndex = 25;
            // 
            // submitGeneralInfo
            // 
            this.submitGeneralInfo.Location = new System.Drawing.Point(410, 394);
            this.submitGeneralInfo.Name = "submitGeneralInfo";
            this.submitGeneralInfo.Size = new System.Drawing.Size(100, 23);
            this.submitGeneralInfo.TabIndex = 26;
            this.submitGeneralInfo.Text = "Submit";
            this.submitGeneralInfo.UseVisualStyleBackColor = true;
            this.submitGeneralInfo.Click += new System.EventHandler(this.submitGeneralInfo_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(410, 142);
            this.ageTextBox.MaxLength = 4;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 30;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(410, 103);
            this.weightTextBox.MaxLength = 4;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 31;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(410, 64);
            this.heightTextBox.MaxLength = 4;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 32;
            // 
            // AbilityScoreGroupBox
            // 
            this.AbilityScoreGroupBox.Controls.Add(this.RacialModifierButton);
            this.AbilityScoreGroupBox.Controls.Add(this.rollDiceButton);
            this.AbilityScoreGroupBox.Controls.Add(this.reRollOneBox);
            this.AbilityScoreGroupBox.Controls.Add(this.swapBox6);
            this.AbilityScoreGroupBox.Controls.Add(this.swapBox5);
            this.AbilityScoreGroupBox.Controls.Add(this.swapBox4);
            this.AbilityScoreGroupBox.Controls.Add(this.swapBox3);
            this.AbilityScoreGroupBox.Controls.Add(this.swapBox2);
            this.AbilityScoreGroupBox.Controls.Add(this.swapBox1);
            this.AbilityScoreGroupBox.Controls.Add(this.abilitySwapLabel);
            this.AbilityScoreGroupBox.Controls.Add(this.modLabel6);
            this.AbilityScoreGroupBox.Controls.Add(this.modLabel5);
            this.AbilityScoreGroupBox.Controls.Add(this.modLabel4);
            this.AbilityScoreGroupBox.Controls.Add(this.modLabel3);
            this.AbilityScoreGroupBox.Controls.Add(this.modLabel2);
            this.AbilityScoreGroupBox.Controls.Add(this.modLabel1);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityModLabel);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityTextBox6);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityTextBox5);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityTextBox4);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityTextBox3);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityTextBox2);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityTextBox1);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityScoreValue);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityLabel6);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityLabel5);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityLabel4);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityLabel3);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityLabel2);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityLabel1);
            this.AbilityScoreGroupBox.Controls.Add(this.AbilityNameLabel);
            this.AbilityScoreGroupBox.Controls.Add(this.abilityGenerationSelector);
            this.AbilityScoreGroupBox.Controls.Add(this.methodLabel);
            this.AbilityScoreGroupBox.Location = new System.Drawing.Point(13, 130);
            this.AbilityScoreGroupBox.Name = "AbilityScoreGroupBox";
            this.AbilityScoreGroupBox.Size = new System.Drawing.Size(369, 287);
            this.AbilityScoreGroupBox.TabIndex = 33;
            this.AbilityScoreGroupBox.TabStop = false;
            this.AbilityScoreGroupBox.Text = "Ability Scores";
            // 
            // RacialModifierButton
            // 
            this.RacialModifierButton.Location = new System.Drawing.Point(135, 253);
            this.RacialModifierButton.Name = "RacialModifierButton";
            this.RacialModifierButton.Size = new System.Drawing.Size(162, 23);
            this.RacialModifierButton.TabIndex = 31;
            this.RacialModifierButton.Text = "Apply Racial Modifiers";
            this.RacialModifierButton.UseVisualStyleBackColor = true;
            this.RacialModifierButton.Click += new System.EventHandler(this.RacialModifier_Click);
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Location = new System.Drawing.Point(165, 34);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(75, 23);
            this.rollDiceButton.TabIndex = 30;
            this.rollDiceButton.Text = "Roll!";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // reRollOneBox
            // 
            this.reRollOneBox.AutoSize = true;
            this.reRollOneBox.Location = new System.Drawing.Point(10, 253);
            this.reRollOneBox.Name = "reRollOneBox";
            this.reRollOneBox.Size = new System.Drawing.Size(77, 17);
            this.reRollOneBox.TabIndex = 29;
            this.reRollOneBox.Text = "Re-Roll 1\'s";
            this.reRollOneBox.UseVisualStyleBackColor = true;
            // 
            // swapBox6
            // 
            this.swapBox6.AutoSize = true;
            this.swapBox6.Location = new System.Drawing.Point(227, 217);
            this.swapBox6.Name = "swapBox6";
            this.swapBox6.Size = new System.Drawing.Size(75, 17);
            this.swapBox6.TabIndex = 28;
            this.swapBox6.Text = "swapBox6";
            this.swapBox6.UseVisualStyleBackColor = true;
            this.swapBox6.CheckedChanged += new System.EventHandler(this.swapBox_CheckedChanged);
            // 
            // swapBox5
            // 
            this.swapBox5.AutoSize = true;
            this.swapBox5.Location = new System.Drawing.Point(227, 190);
            this.swapBox5.Name = "swapBox5";
            this.swapBox5.Size = new System.Drawing.Size(75, 17);
            this.swapBox5.TabIndex = 27;
            this.swapBox5.Text = "swapBox5";
            this.swapBox5.UseVisualStyleBackColor = true;
            this.swapBox5.CheckedChanged += new System.EventHandler(this.swapBox_CheckedChanged);
            // 
            // swapBox4
            // 
            this.swapBox4.AutoSize = true;
            this.swapBox4.Location = new System.Drawing.Point(227, 163);
            this.swapBox4.Name = "swapBox4";
            this.swapBox4.Size = new System.Drawing.Size(75, 17);
            this.swapBox4.TabIndex = 26;
            this.swapBox4.Text = "swapBox4";
            this.swapBox4.UseVisualStyleBackColor = true;
            this.swapBox4.CheckedChanged += new System.EventHandler(this.swapBox_CheckedChanged);
            // 
            // swapBox3
            // 
            this.swapBox3.AutoSize = true;
            this.swapBox3.Location = new System.Drawing.Point(227, 136);
            this.swapBox3.Name = "swapBox3";
            this.swapBox3.Size = new System.Drawing.Size(75, 17);
            this.swapBox3.TabIndex = 25;
            this.swapBox3.Text = "swapBox3";
            this.swapBox3.UseVisualStyleBackColor = true;
            this.swapBox3.CheckedChanged += new System.EventHandler(this.swapBox_CheckedChanged);
            // 
            // swapBox2
            // 
            this.swapBox2.AutoSize = true;
            this.swapBox2.Location = new System.Drawing.Point(227, 109);
            this.swapBox2.Name = "swapBox2";
            this.swapBox2.Size = new System.Drawing.Size(75, 17);
            this.swapBox2.TabIndex = 24;
            this.swapBox2.Text = "swapBox2";
            this.swapBox2.UseVisualStyleBackColor = true;
            this.swapBox2.CheckedChanged += new System.EventHandler(this.swapBox_CheckedChanged);
            // 
            // swapBox1
            // 
            this.swapBox1.AutoSize = true;
            this.swapBox1.Location = new System.Drawing.Point(227, 82);
            this.swapBox1.Name = "swapBox1";
            this.swapBox1.Size = new System.Drawing.Size(75, 17);
            this.swapBox1.TabIndex = 23;
            this.swapBox1.Text = "swapBox1";
            this.swapBox1.UseVisualStyleBackColor = true;
            this.swapBox1.CheckedChanged += new System.EventHandler(this.swapBox_CheckedChanged);
            // 
            // abilitySwapLabel
            // 
            this.abilitySwapLabel.AutoSize = true;
            this.abilitySwapLabel.Location = new System.Drawing.Point(224, 63);
            this.abilitySwapLabel.Name = "abilitySwapLabel";
            this.abilitySwapLabel.Size = new System.Drawing.Size(73, 13);
            this.abilitySwapLabel.TabIndex = 22;
            this.abilitySwapLabel.Text = "Swap Scores:";
            // 
            // modLabel6
            // 
            this.modLabel6.AutoSize = true;
            this.modLabel6.Location = new System.Drawing.Point(186, 218);
            this.modLabel6.Name = "modLabel6";
            this.modLabel6.Size = new System.Drawing.Size(27, 13);
            this.modLabel6.TabIndex = 21;
            this.modLabel6.Text = "N/A";
            // 
            // modLabel5
            // 
            this.modLabel5.AutoSize = true;
            this.modLabel5.Location = new System.Drawing.Point(186, 191);
            this.modLabel5.Name = "modLabel5";
            this.modLabel5.Size = new System.Drawing.Size(27, 13);
            this.modLabel5.TabIndex = 20;
            this.modLabel5.Text = "N/A";
            // 
            // modLabel4
            // 
            this.modLabel4.AutoSize = true;
            this.modLabel4.Location = new System.Drawing.Point(186, 164);
            this.modLabel4.Name = "modLabel4";
            this.modLabel4.Size = new System.Drawing.Size(27, 13);
            this.modLabel4.TabIndex = 19;
            this.modLabel4.Text = "N/A";
            // 
            // modLabel3
            // 
            this.modLabel3.AutoSize = true;
            this.modLabel3.Location = new System.Drawing.Point(186, 137);
            this.modLabel3.Name = "modLabel3";
            this.modLabel3.Size = new System.Drawing.Size(27, 13);
            this.modLabel3.TabIndex = 18;
            this.modLabel3.Text = "N/A";
            // 
            // modLabel2
            // 
            this.modLabel2.AutoSize = true;
            this.modLabel2.Location = new System.Drawing.Point(186, 110);
            this.modLabel2.Name = "modLabel2";
            this.modLabel2.Size = new System.Drawing.Size(27, 13);
            this.modLabel2.TabIndex = 17;
            this.modLabel2.Text = "N/A";
            // 
            // modLabel1
            // 
            this.modLabel1.AutoSize = true;
            this.modLabel1.Location = new System.Drawing.Point(186, 83);
            this.modLabel1.Name = "modLabel1";
            this.modLabel1.Size = new System.Drawing.Size(27, 13);
            this.modLabel1.TabIndex = 16;
            this.modLabel1.Text = "N/A";
            // 
            // abilityModLabel
            // 
            this.abilityModLabel.AutoSize = true;
            this.abilityModLabel.Location = new System.Drawing.Point(186, 63);
            this.abilityModLabel.Name = "abilityModLabel";
            this.abilityModLabel.Size = new System.Drawing.Size(31, 13);
            this.abilityModLabel.TabIndex = 15;
            this.abilityModLabel.Text = "Mod:";
            // 
            // abilityTextBox6
            // 
            this.abilityTextBox6.Enabled = false;
            this.abilityTextBox6.Location = new System.Drawing.Point(135, 215);
            this.abilityTextBox6.MaxLength = 2;
            this.abilityTextBox6.Name = "abilityTextBox6";
            this.abilityTextBox6.Size = new System.Drawing.Size(42, 20);
            this.abilityTextBox6.TabIndex = 14;
            this.abilityTextBox6.TextChanged += new System.EventHandler(this.abilityTextBox_TextChanged);
            // 
            // abilityTextBox5
            // 
            this.abilityTextBox5.Enabled = false;
            this.abilityTextBox5.Location = new System.Drawing.Point(135, 188);
            this.abilityTextBox5.MaxLength = 2;
            this.abilityTextBox5.Name = "abilityTextBox5";
            this.abilityTextBox5.Size = new System.Drawing.Size(42, 20);
            this.abilityTextBox5.TabIndex = 13;
            this.abilityTextBox5.TextChanged += new System.EventHandler(this.abilityTextBox_TextChanged);
            // 
            // abilityTextBox4
            // 
            this.abilityTextBox4.Enabled = false;
            this.abilityTextBox4.Location = new System.Drawing.Point(135, 161);
            this.abilityTextBox4.MaxLength = 2;
            this.abilityTextBox4.Name = "abilityTextBox4";
            this.abilityTextBox4.Size = new System.Drawing.Size(42, 20);
            this.abilityTextBox4.TabIndex = 12;
            this.abilityTextBox4.TextChanged += new System.EventHandler(this.abilityTextBox_TextChanged);
            // 
            // abilityTextBox3
            // 
            this.abilityTextBox3.Enabled = false;
            this.abilityTextBox3.Location = new System.Drawing.Point(135, 134);
            this.abilityTextBox3.MaxLength = 2;
            this.abilityTextBox3.Name = "abilityTextBox3";
            this.abilityTextBox3.Size = new System.Drawing.Size(42, 20);
            this.abilityTextBox3.TabIndex = 11;
            this.abilityTextBox3.TextChanged += new System.EventHandler(this.abilityTextBox_TextChanged);
            // 
            // abilityTextBox2
            // 
            this.abilityTextBox2.Enabled = false;
            this.abilityTextBox2.Location = new System.Drawing.Point(135, 107);
            this.abilityTextBox2.MaxLength = 2;
            this.abilityTextBox2.Name = "abilityTextBox2";
            this.abilityTextBox2.Size = new System.Drawing.Size(42, 20);
            this.abilityTextBox2.TabIndex = 10;
            this.abilityTextBox2.TextChanged += new System.EventHandler(this.abilityTextBox_TextChanged);
            // 
            // abilityTextBox1
            // 
            this.abilityTextBox1.Enabled = false;
            this.abilityTextBox1.Location = new System.Drawing.Point(135, 80);
            this.abilityTextBox1.MaxLength = 2;
            this.abilityTextBox1.Name = "abilityTextBox1";
            this.abilityTextBox1.Size = new System.Drawing.Size(42, 20);
            this.abilityTextBox1.TabIndex = 9;
            this.abilityTextBox1.TextChanged += new System.EventHandler(this.abilityTextBox_TextChanged);
            // 
            // abilityScoreValue
            // 
            this.abilityScoreValue.AutoSize = true;
            this.abilityScoreValue.Location = new System.Drawing.Point(132, 64);
            this.abilityScoreValue.Name = "abilityScoreValue";
            this.abilityScoreValue.Size = new System.Drawing.Size(37, 13);
            this.abilityScoreValue.TabIndex = 8;
            this.abilityScoreValue.Text = "Value:";
            // 
            // abilityLabel6
            // 
            this.abilityLabel6.AutoSize = true;
            this.abilityLabel6.Location = new System.Drawing.Point(7, 218);
            this.abilityLabel6.Name = "abilityLabel6";
            this.abilityLabel6.Size = new System.Drawing.Size(35, 13);
            this.abilityLabel6.TabIndex = 7;
            this.abilityLabel6.Text = "label6";
            // 
            // abilityLabel5
            // 
            this.abilityLabel5.AutoSize = true;
            this.abilityLabel5.Location = new System.Drawing.Point(7, 191);
            this.abilityLabel5.Name = "abilityLabel5";
            this.abilityLabel5.Size = new System.Drawing.Size(35, 13);
            this.abilityLabel5.TabIndex = 6;
            this.abilityLabel5.Text = "label5";
            // 
            // abilityLabel4
            // 
            this.abilityLabel4.AutoSize = true;
            this.abilityLabel4.Location = new System.Drawing.Point(7, 164);
            this.abilityLabel4.Name = "abilityLabel4";
            this.abilityLabel4.Size = new System.Drawing.Size(35, 13);
            this.abilityLabel4.TabIndex = 5;
            this.abilityLabel4.Text = "label4";
            // 
            // abilityLabel3
            // 
            this.abilityLabel3.AutoSize = true;
            this.abilityLabel3.Location = new System.Drawing.Point(7, 137);
            this.abilityLabel3.Name = "abilityLabel3";
            this.abilityLabel3.Size = new System.Drawing.Size(35, 13);
            this.abilityLabel3.TabIndex = 4;
            this.abilityLabel3.Text = "label3";
            // 
            // abilityLabel2
            // 
            this.abilityLabel2.AutoSize = true;
            this.abilityLabel2.Location = new System.Drawing.Point(7, 110);
            this.abilityLabel2.Name = "abilityLabel2";
            this.abilityLabel2.Size = new System.Drawing.Size(35, 13);
            this.abilityLabel2.TabIndex = 3;
            this.abilityLabel2.Text = "label2";
            // 
            // abilityLabel1
            // 
            this.abilityLabel1.AutoSize = true;
            this.abilityLabel1.Location = new System.Drawing.Point(7, 83);
            this.abilityLabel1.Name = "abilityLabel1";
            this.abilityLabel1.Size = new System.Drawing.Size(35, 13);
            this.abilityLabel1.TabIndex = 2;
            this.abilityLabel1.Text = "label1";
            // 
            // AbilityNameLabel
            // 
            this.AbilityNameLabel.AutoSize = true;
            this.AbilityNameLabel.Location = new System.Drawing.Point(7, 64);
            this.AbilityNameLabel.Name = "AbilityNameLabel";
            this.AbilityNameLabel.Size = new System.Drawing.Size(38, 13);
            this.AbilityNameLabel.TabIndex = 1;
            this.AbilityNameLabel.Text = "Name:";
            // 
            // abilityGenerationSelector
            // 
            this.abilityGenerationSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abilityGenerationSelector.FormattingEnabled = true;
            this.abilityGenerationSelector.Items.AddRange(new object[] {
            "4d6 Drop Lowest",
            "1d8 + 10",
            "Manual Input"});
            this.abilityGenerationSelector.Location = new System.Drawing.Point(6, 36);
            this.abilityGenerationSelector.Name = "abilityGenerationSelector";
            this.abilityGenerationSelector.Size = new System.Drawing.Size(121, 21);
            this.abilityGenerationSelector.TabIndex = 0;
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(7, 20);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(104, 13);
            this.methodLabel.TabIndex = 0;
            this.methodLabel.Text = "Ability Score Method";
            // 
            // addBackstoryButton
            // 
            this.addBackstoryButton.Location = new System.Drawing.Point(410, 365);
            this.addBackstoryButton.Name = "addBackstoryButton";
            this.addBackstoryButton.Size = new System.Drawing.Size(100, 23);
            this.addBackstoryButton.TabIndex = 34;
            this.addBackstoryButton.Text = "Add Backstory";
            this.addBackstoryButton.UseVisualStyleBackColor = true;
            this.addBackstoryButton.Click += new System.EventHandler(this.addBackstoryButton_Click);
            // 
            // addSkillsButton
            // 
            this.addSkillsButton.Location = new System.Drawing.Point(410, 286);
            this.addSkillsButton.Name = "addSkillsButton";
            this.addSkillsButton.Size = new System.Drawing.Size(100, 23);
            this.addSkillsButton.TabIndex = 35;
            this.addSkillsButton.Text = "Add Skills";
            this.addSkillsButton.UseVisualStyleBackColor = true;
            // 
            // newCharacterGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 442);
            this.Controls.Add(this.addSkillsButton);
            this.Controls.Add(this.addBackstoryButton);
            this.Controls.Add(this.AbilityScoreGroupBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.submitGeneralInfo);
            this.Controls.Add(this.skinTextBox);
            this.Controls.Add(this.skinLabel);
            this.Controls.Add(this.hairTextBox);
            this.Controls.Add(this.hairLabel);
            this.Controls.Add(this.eyesTextBox);
            this.Controls.Add(this.eyesLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.alignmentComboBox);
            this.Controls.Add(this.alignmentLabel);
            this.Controls.Add(this.dietyTextBox);
            this.Controls.Add(this.dietyLabel);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.pcNameTextBox);
            this.Controls.Add(this.pcNameLabel);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.classComboBox);
            this.Name = "newCharacterGenerator";
            this.Text = "Character Creator";
            this.AbilityScoreGroupBox.ResumeLayout(false);
            this.AbilityScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Label pcNameLabel;
        private System.Windows.Forms.TextBox pcNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label dietyLabel;
        private System.Windows.Forms.TextBox dietyTextBox;
        private System.Windows.Forms.Label alignmentLabel;
        private System.Windows.Forms.ComboBox alignmentComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label eyesLabel;
        private System.Windows.Forms.TextBox eyesTextBox;
        private System.Windows.Forms.Label hairLabel;
        private System.Windows.Forms.TextBox hairTextBox;
        private System.Windows.Forms.Label skinLabel;
        private System.Windows.Forms.TextBox skinTextBox;
        private System.Windows.Forms.Button submitGeneralInfo;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.GroupBox AbilityScoreGroupBox;
        private System.Windows.Forms.ComboBox abilityGenerationSelector;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label AbilityNameLabel;
        private System.Windows.Forms.Label abilityLabel6;
        private System.Windows.Forms.Label abilityLabel5;
        private System.Windows.Forms.Label abilityLabel4;
        private System.Windows.Forms.Label abilityLabel3;
        private System.Windows.Forms.Label abilityLabel2;
        private System.Windows.Forms.Label abilityLabel1;
        private System.Windows.Forms.TextBox abilityTextBox6;
        private System.Windows.Forms.TextBox abilityTextBox5;
        private System.Windows.Forms.TextBox abilityTextBox4;
        private System.Windows.Forms.TextBox abilityTextBox3;
        private System.Windows.Forms.TextBox abilityTextBox2;
        private System.Windows.Forms.TextBox abilityTextBox1;
        private System.Windows.Forms.Label abilityScoreValue;
        private System.Windows.Forms.CheckBox swapBox6;
        private System.Windows.Forms.CheckBox swapBox5;
        private System.Windows.Forms.CheckBox swapBox4;
        private System.Windows.Forms.CheckBox swapBox3;
        private System.Windows.Forms.CheckBox swapBox2;
        private System.Windows.Forms.CheckBox swapBox1;
        private System.Windows.Forms.Label abilitySwapLabel;
        private System.Windows.Forms.Label modLabel6;
        private System.Windows.Forms.Label modLabel5;
        private System.Windows.Forms.Label modLabel4;
        private System.Windows.Forms.Label modLabel3;
        private System.Windows.Forms.Label modLabel2;
        private System.Windows.Forms.Label modLabel1;
        private System.Windows.Forms.Label abilityModLabel;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.CheckBox reRollOneBox;
        private System.Windows.Forms.Button addBackstoryButton;
        private System.Windows.Forms.Button RacialModifierButton;
        private System.Windows.Forms.Button addSkillsButton;
    }
}