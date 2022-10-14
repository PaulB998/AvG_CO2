namespace AvG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.producer_erstellen_button = new System.Windows.Forms.Button();
            this.consumer_erstellen_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fenster_oeffnen = new System.Windows.Forms.Button();
            this.fenster_schließen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // producer_erstellen_button
            // 
            this.producer_erstellen_button.Location = new System.Drawing.Point(12, 67);
            this.producer_erstellen_button.Name = "producer_erstellen_button";
            this.producer_erstellen_button.Size = new System.Drawing.Size(254, 77);
            this.producer_erstellen_button.TabIndex = 0;
            this.producer_erstellen_button.Text = "Producer erstellen";
            this.producer_erstellen_button.UseVisualStyleBackColor = true;
            this.producer_erstellen_button.Click += new System.EventHandler(this.producer_erstellen_button_Click);
            // 
            // consumer_erstellen_button
            // 
            this.consumer_erstellen_button.Location = new System.Drawing.Point(308, 67);
            this.consumer_erstellen_button.Name = "consumer_erstellen_button";
            this.consumer_erstellen_button.Size = new System.Drawing.Size(242, 77);
            this.consumer_erstellen_button.TabIndex = 1;
            this.consumer_erstellen_button.Text = "Consumer erstellen";
            this.consumer_erstellen_button.UseVisualStyleBackColor = true;
            this.consumer_erstellen_button.Click += new System.EventHandler(this.consumer_erstellen_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "CO2 Werte an MoM schicken";
            // 
            // fenster_oeffnen
            // 
            this.fenster_oeffnen.Location = new System.Drawing.Point(12, 188);
            this.fenster_oeffnen.Name = "fenster_oeffnen";
            this.fenster_oeffnen.Size = new System.Drawing.Size(254, 77);
            this.fenster_oeffnen.TabIndex = 3;
            this.fenster_oeffnen.Text = "Nachricht Fenster öffnen";
            this.fenster_oeffnen.UseVisualStyleBackColor = true;
            this.fenster_oeffnen.Click += new System.EventHandler(this.fenster_oeffnen_Click);
            // 
            // fenster_schließen
            // 
            this.fenster_schließen.Location = new System.Drawing.Point(12, 298);
            this.fenster_schließen.Name = "fenster_schließen";
            this.fenster_schließen.Size = new System.Drawing.Size(254, 77);
            this.fenster_schließen.TabIndex = 4;
            this.fenster_schließen.Text = "Nachricht Fenster schließen";
            this.fenster_schließen.UseVisualStyleBackColor = true;
            this.fenster_schließen.Click += new System.EventHandler(this.fenster_schließen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Steuereinheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fenster_schließen);
            this.Controls.Add(this.fenster_oeffnen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consumer_erstellen_button);
            this.Controls.Add(this.producer_erstellen_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button producer_erstellen_button;
        private Button consumer_erstellen_button;
        private Label label1;
        private Button fenster_oeffnen;
        private Button fenster_schließen;
        private Label label2;
    }
}