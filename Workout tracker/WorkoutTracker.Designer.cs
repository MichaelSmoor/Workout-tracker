namespace Workout_tracker
{
    partial class WorkoutTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutTracker));
            this.tabTracker = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblLoginAnllela = new System.Windows.Forms.Label();
            this.lblLoginsteve = new System.Windows.Forms.Label();
            this.pbLoginAnllela = new System.Windows.Forms.PictureBox();
            this.pbLoginSteve = new System.Windows.Forms.PictureBox();
            this.tabWorkout = new System.Windows.Forms.TabPage();
            this.lblCommentaar = new System.Windows.Forms.Label();
            this.txtBoxCommentaar = new System.Windows.Forms.TextBox();
            this.lblNameAthlete = new System.Windows.Forms.Label();
            this.lblNaamOefening = new System.Windows.Forms.Label();
            this.lblMateriaal = new System.Windows.Forms.Label();
            this.lblOefening = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.lblHerhalingen = new System.Windows.Forms.Label();
            this.lblGewicht = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblSpiergroep = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudGewicht = new System.Windows.Forms.NumericUpDown();
            this.nudReps = new System.Windows.Forms.NumericUpDown();
            this.nudSets = new System.Windows.Forms.NumericUpDown();
            this.pbLogoWT = new System.Windows.Forms.PictureBox();
            this.cbOefening = new System.Windows.Forms.ComboBox();
            this.cbMateriaal = new System.Windows.Forms.ComboBox();
            this.cbSpier = new System.Windows.Forms.ComboBox();
            this.tabCompare = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbArray = new System.Windows.Forms.ListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.tabTracker.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginAnllela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginSteve)).BeginInit();
            this.tabWorkout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGewicht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoWT)).BeginInit();
            this.tabCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTracker
            // 
            this.tabTracker.Controls.Add(this.tabPage1);
            this.tabTracker.Controls.Add(this.tabWorkout);
            this.tabTracker.Controls.Add(this.tabCompare);
            this.tabTracker.Controls.Add(this.tabPage2);
            this.tabTracker.Location = new System.Drawing.Point(0, 2);
            this.tabTracker.Name = "tabTracker";
            this.tabTracker.SelectedIndex = 0;
            this.tabTracker.Size = new System.Drawing.Size(731, 400);
            this.tabTracker.TabIndex = 0;
            this.tabTracker.SelectedIndexChanged += new System.EventHandler(this.tabTracker_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.lblLoginAnllela);
            this.tabPage1.Controls.Add(this.lblLoginsteve);
            this.tabPage1.Controls.Add(this.pbLoginAnllela);
            this.tabPage1.Controls.Add(this.pbLoginSteve);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log in";
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // lblLoginAnllela
            // 
            this.lblLoginAnllela.AutoSize = true;
            this.lblLoginAnllela.BackColor = System.Drawing.Color.DimGray;
            this.lblLoginAnllela.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAnllela.Location = new System.Drawing.Point(508, 268);
            this.lblLoginAnllela.Name = "lblLoginAnllela";
            this.lblLoginAnllela.Size = new System.Drawing.Size(98, 37);
            this.lblLoginAnllela.TabIndex = 3;
            this.lblLoginAnllela.Text = "Anllela";
            // 
            // lblLoginsteve
            // 
            this.lblLoginsteve.AutoSize = true;
            this.lblLoginsteve.BackColor = System.Drawing.Color.DimGray;
            this.lblLoginsteve.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginsteve.Location = new System.Drawing.Point(127, 268);
            this.lblLoginsteve.Name = "lblLoginsteve";
            this.lblLoginsteve.Size = new System.Drawing.Size(85, 37);
            this.lblLoginsteve.TabIndex = 2;
            this.lblLoginsteve.Text = "Steve";
            // 
            // pbLoginAnllela
            // 
            this.pbLoginAnllela.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginAnllela.Image")));
            this.pbLoginAnllela.Location = new System.Drawing.Point(436, 53);
            this.pbLoginAnllela.Name = "pbLoginAnllela";
            this.pbLoginAnllela.Size = new System.Drawing.Size(216, 203);
            this.pbLoginAnllela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginAnllela.TabIndex = 1;
            this.pbLoginAnllela.TabStop = false;
            this.pbLoginAnllela.Click += new System.EventHandler(this.pbLoginAnllela_Click);
            // 
            // pbLoginSteve
            // 
            this.pbLoginSteve.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginSteve.Image")));
            this.pbLoginSteve.Location = new System.Drawing.Point(71, 53);
            this.pbLoginSteve.Name = "pbLoginSteve";
            this.pbLoginSteve.Size = new System.Drawing.Size(216, 203);
            this.pbLoginSteve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginSteve.TabIndex = 0;
            this.pbLoginSteve.TabStop = false;
            this.pbLoginSteve.Click += new System.EventHandler(this.pbLoginSteve_Click);
            // 
            // tabWorkout
            // 
            this.tabWorkout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabWorkout.BackgroundImage")));
            this.tabWorkout.Controls.Add(this.lblCommentaar);
            this.tabWorkout.Controls.Add(this.txtBoxCommentaar);
            this.tabWorkout.Controls.Add(this.lblNameAthlete);
            this.tabWorkout.Controls.Add(this.lblNaamOefening);
            this.tabWorkout.Controls.Add(this.lblMateriaal);
            this.tabWorkout.Controls.Add(this.lblOefening);
            this.tabWorkout.Controls.Add(this.lblSets);
            this.tabWorkout.Controls.Add(this.lblHerhalingen);
            this.tabWorkout.Controls.Add(this.lblGewicht);
            this.tabWorkout.Controls.Add(this.lblKg);
            this.tabWorkout.Controls.Add(this.lblSpiergroep);
            this.tabWorkout.Controls.Add(this.btnCompare);
            this.tabWorkout.Controls.Add(this.btnSave);
            this.tabWorkout.Controls.Add(this.nudGewicht);
            this.tabWorkout.Controls.Add(this.nudReps);
            this.tabWorkout.Controls.Add(this.nudSets);
            this.tabWorkout.Controls.Add(this.pbLogoWT);
            this.tabWorkout.Controls.Add(this.cbOefening);
            this.tabWorkout.Controls.Add(this.cbMateriaal);
            this.tabWorkout.Controls.Add(this.cbSpier);
            this.tabWorkout.Location = new System.Drawing.Point(4, 22);
            this.tabWorkout.Name = "tabWorkout";
            this.tabWorkout.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkout.Size = new System.Drawing.Size(723, 374);
            this.tabWorkout.TabIndex = 1;
            this.tabWorkout.Text = "Workout";
            this.tabWorkout.UseVisualStyleBackColor = true;
            // 
            // lblCommentaar
            // 
            this.lblCommentaar.AutoSize = true;
            this.lblCommentaar.BackColor = System.Drawing.Color.DimGray;
            this.lblCommentaar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaar.Location = new System.Drawing.Point(153, 340);
            this.lblCommentaar.Name = "lblCommentaar";
            this.lblCommentaar.Size = new System.Drawing.Size(84, 20);
            this.lblCommentaar.TabIndex = 19;
            this.lblCommentaar.Text = "Commentaar";
            // 
            // txtBoxCommentaar
            // 
            this.txtBoxCommentaar.Location = new System.Drawing.Point(241, 342);
            this.txtBoxCommentaar.Name = "txtBoxCommentaar";
            this.txtBoxCommentaar.Size = new System.Drawing.Size(261, 20);
            this.txtBoxCommentaar.TabIndex = 18;
            // 
            // lblNameAthlete
            // 
            this.lblNameAthlete.AutoSize = true;
            this.lblNameAthlete.BackColor = System.Drawing.Color.DimGray;
            this.lblNameAthlete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAthlete.Location = new System.Drawing.Point(8, 348);
            this.lblNameAthlete.Name = "lblNameAthlete";
            this.lblNameAthlete.Size = new System.Drawing.Size(87, 20);
            this.lblNameAthlete.TabIndex = 17;
            this.lblNameAthlete.Text = "Name athlete";
            // 
            // lblNaamOefening
            // 
            this.lblNaamOefening.AutoSize = true;
            this.lblNaamOefening.BackColor = System.Drawing.Color.DimGray;
            this.lblNaamOefening.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaamOefening.Location = new System.Drawing.Point(520, 261);
            this.lblNaamOefening.Name = "lblNaamOefening";
            this.lblNaamOefening.Size = new System.Drawing.Size(99, 20);
            this.lblNaamOefening.TabIndex = 16;
            this.lblNaamOefening.Text = "Naam oefening";
            // 
            // lblMateriaal
            // 
            this.lblMateriaal.AutoSize = true;
            this.lblMateriaal.BackColor = System.Drawing.Color.DimGray;
            this.lblMateriaal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaal.Location = new System.Drawing.Point(36, 86);
            this.lblMateriaal.Name = "lblMateriaal";
            this.lblMateriaal.Size = new System.Drawing.Size(62, 20);
            this.lblMateriaal.TabIndex = 15;
            this.lblMateriaal.Text = "Materiaal";
            // 
            // lblOefening
            // 
            this.lblOefening.AutoSize = true;
            this.lblOefening.BackColor = System.Drawing.Color.DimGray;
            this.lblOefening.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOefening.Location = new System.Drawing.Point(36, 155);
            this.lblOefening.Name = "lblOefening";
            this.lblOefening.Size = new System.Drawing.Size(63, 20);
            this.lblOefening.TabIndex = 14;
            this.lblOefening.Text = "Oefening";
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.BackColor = System.Drawing.Color.DimGray;
            this.lblSets.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSets.Location = new System.Drawing.Point(36, 202);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(36, 20);
            this.lblSets.TabIndex = 13;
            this.lblSets.Text = "Sets";
            // 
            // lblHerhalingen
            // 
            this.lblHerhalingen.AutoSize = true;
            this.lblHerhalingen.BackColor = System.Drawing.Color.DimGray;
            this.lblHerhalingen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerhalingen.Location = new System.Drawing.Point(36, 248);
            this.lblHerhalingen.Name = "lblHerhalingen";
            this.lblHerhalingen.Size = new System.Drawing.Size(80, 20);
            this.lblHerhalingen.TabIndex = 12;
            this.lblHerhalingen.Text = "Herhalingen";
            // 
            // lblGewicht
            // 
            this.lblGewicht.AutoSize = true;
            this.lblGewicht.BackColor = System.Drawing.Color.DimGray;
            this.lblGewicht.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGewicht.Location = new System.Drawing.Point(36, 291);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(56, 20);
            this.lblGewicht.TabIndex = 11;
            this.lblGewicht.Text = "Gewicht";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.DimGray;
            this.lblKg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(211, 291);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(26, 20);
            this.lblKg.TabIndex = 10;
            this.lblKg.Text = "Kg";
            // 
            // lblSpiergroep
            // 
            this.lblSpiergroep.AutoSize = true;
            this.lblSpiergroep.BackColor = System.Drawing.Color.DimGray;
            this.lblSpiergroep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpiergroep.Location = new System.Drawing.Point(36, 29);
            this.lblSpiergroep.Name = "lblSpiergroep";
            this.lblSpiergroep.Size = new System.Drawing.Size(77, 20);
            this.lblSpiergroep.TabIndex = 9;
            this.lblSpiergroep.Text = "Spiergroep";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(641, 342);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(524, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudGewicht
            // 
            this.nudGewicht.Location = new System.Drawing.Point(133, 291);
            this.nudGewicht.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudGewicht.Name = "nudGewicht";
            this.nudGewicht.Size = new System.Drawing.Size(72, 20);
            this.nudGewicht.TabIndex = 6;
            // 
            // nudReps
            // 
            this.nudReps.Location = new System.Drawing.Point(133, 248);
            this.nudReps.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudReps.Name = "nudReps";
            this.nudReps.Size = new System.Drawing.Size(57, 20);
            this.nudReps.TabIndex = 5;
            // 
            // nudSets
            // 
            this.nudSets.Location = new System.Drawing.Point(133, 202);
            this.nudSets.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSets.Name = "nudSets";
            this.nudSets.Size = new System.Drawing.Size(47, 20);
            this.nudSets.TabIndex = 4;
            // 
            // pbLogoWT
            // 
            this.pbLogoWT.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoWT.Image")));
            this.pbLogoWT.Location = new System.Drawing.Point(445, 28);
            this.pbLogoWT.Name = "pbLogoWT";
            this.pbLogoWT.Size = new System.Drawing.Size(241, 214);
            this.pbLogoWT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoWT.TabIndex = 3;
            this.pbLogoWT.TabStop = false;
            // 
            // cbOefening
            // 
            this.cbOefening.FormattingEnabled = true;
            this.cbOefening.Location = new System.Drawing.Point(133, 154);
            this.cbOefening.Name = "cbOefening";
            this.cbOefening.Size = new System.Drawing.Size(121, 21);
            this.cbOefening.TabIndex = 2;
            this.cbOefening.Text = "Kies oefening...";
            this.cbOefening.SelectedIndexChanged += new System.EventHandler(this.cbOefening_SelectedIndexChanged);
            // 
            // cbMateriaal
            // 
            this.cbMateriaal.FormattingEnabled = true;
            this.cbMateriaal.Location = new System.Drawing.Point(133, 88);
            this.cbMateriaal.Name = "cbMateriaal";
            this.cbMateriaal.Size = new System.Drawing.Size(121, 21);
            this.cbMateriaal.TabIndex = 1;
            this.cbMateriaal.Text = "Kies materiaal...";
            this.cbMateriaal.SelectedIndexChanged += new System.EventHandler(this.cbMateriaal_SelectedIndexChanged);
            // 
            // cbSpier
            // 
            this.cbSpier.FormattingEnabled = true;
            this.cbSpier.Location = new System.Drawing.Point(133, 28);
            this.cbSpier.Name = "cbSpier";
            this.cbSpier.Size = new System.Drawing.Size(121, 21);
            this.cbSpier.TabIndex = 0;
            this.cbSpier.Text = "Kies spiergroep...";
            this.cbSpier.SelectedIndexChanged += new System.EventHandler(this.cbSpier_SelectedIndexChanged);
            // 
            // tabCompare
            // 
            this.tabCompare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCompare.BackgroundImage")));
            this.tabCompare.Controls.Add(this.dgvResults);
            this.tabCompare.Location = new System.Drawing.Point(4, 22);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.Size = new System.Drawing.Size(723, 374);
            this.tabCompare.TabIndex = 2;
            this.tabCompare.Text = "Compare";
            this.tabCompare.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(9, 4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(707, 361);
            this.dgvResults.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.btnVerwijder);
            this.tabPage2.Controls.Add(this.txtArray);
            this.tabPage2.Controls.Add(this.btnVoegToe);
            this.tabPage2.Controls.Add(this.lbArray);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 374);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Array";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbArray
            // 
            this.lbArray.FormattingEnabled = true;
            this.lbArray.Location = new System.Drawing.Point(44, 6);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(586, 290);
            this.lbArray.TabIndex = 0;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(297, 325);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegToe.TabIndex = 1;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(124, 325);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(100, 20);
            this.txtArray.TabIndex = 2;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(423, 325);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // WorkoutTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 401);
            this.Controls.Add(this.tabTracker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkoutTracker";
            this.Text = "Workout tracker";
            this.tabTracker.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginAnllela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginSteve)).EndInit();
            this.tabWorkout.ResumeLayout(false);
            this.tabWorkout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGewicht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoWT)).EndInit();
            this.tabCompare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTracker;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabWorkout;
        private System.Windows.Forms.TabPage tabCompare;
        private System.Windows.Forms.Label lblLoginAnllela;
        private System.Windows.Forms.Label lblLoginsteve;
        private System.Windows.Forms.PictureBox pbLoginAnllela;
        private System.Windows.Forms.PictureBox pbLoginSteve;
        private System.Windows.Forms.Label lblNaamOefening;
        private System.Windows.Forms.Label lblMateriaal;
        private System.Windows.Forms.Label lblOefening;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.Label lblHerhalingen;
        private System.Windows.Forms.Label lblGewicht;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblSpiergroep;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudGewicht;
        private System.Windows.Forms.NumericUpDown nudReps;
        private System.Windows.Forms.NumericUpDown nudSets;
        private System.Windows.Forms.PictureBox pbLogoWT;
        private System.Windows.Forms.ComboBox cbOefening;
        private System.Windows.Forms.ComboBox cbMateriaal;
        private System.Windows.Forms.ComboBox cbSpier;
        private System.Windows.Forms.Label lblNameAthlete;
        private System.Windows.Forms.Label lblCommentaar;
        private System.Windows.Forms.TextBox txtBoxCommentaar;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbArray;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btnVerwijder;
    }
}

