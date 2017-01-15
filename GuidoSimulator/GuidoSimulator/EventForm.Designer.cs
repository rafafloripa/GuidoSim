namespace GuidoSimulator
{
    partial class EventForm
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
            this.title_label = new System.Windows.Forms.Label();
            this.event_pictureBox = new System.Windows.Forms.PictureBox();
            this.description_label = new System.Windows.Forms.Label();
            this.effect_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.event_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(198, 12);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(76, 13);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "EVENT TITLE";
            // 
            // event_pictureBox
            // 
            this.event_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.event_pictureBox.Name = "event_pictureBox";
            this.event_pictureBox.Size = new System.Drawing.Size(180, 180);
            this.event_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event_pictureBox.TabIndex = 1;
            this.event_pictureBox.TabStop = false;
            // 
            // description_label
            // 
            this.description_label.Location = new System.Drawing.Point(198, 35);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(257, 106);
            this.description_label.TabIndex = 2;
            this.description_label.Text = "Event description";
            // 
            // effect_label
            // 
            this.effect_label.Location = new System.Drawing.Point(199, 145);
            this.effect_label.Name = "effect_label";
            this.effect_label.Size = new System.Drawing.Size(256, 47);
            this.effect_label.TabIndex = 3;
            this.effect_label.Text = "label1";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 207);
            this.Controls.Add(this.effect_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.event_pictureBox);
            this.Controls.Add(this.title_label);
            this.Name = "EventForm";
            this.Text = "EventForm";
            ((System.ComponentModel.ISupportInitialize)(this.event_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox event_pictureBox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label effect_label;
    }
}