namespace week3_2
{
    partial class MainForm1
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_myfavoriteartist = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_artist = new System.Windows.Forms.TextBox();
            this.checkbox_true = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_nextform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_myfavoriteartist
            // 
            this.label_myfavoriteartist.AutoSize = true;
            this.label_myfavoriteartist.Location = new System.Drawing.Point(12, 52);
            this.label_myfavoriteartist.Name = "label_myfavoriteartist";
            this.label_myfavoriteartist.Size = new System.Drawing.Size(88, 13);
            this.label_myfavoriteartist.TabIndex = 1;
            this.label_myfavoriteartist.Text = "My Favorite Artist";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(66, 6);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(100, 20);
            this.txtbox_name.TabIndex = 2;
            // 
            // txtbox_artist
            // 
            this.txtbox_artist.Location = new System.Drawing.Point(116, 49);
            this.txtbox_artist.Name = "txtbox_artist";
            this.txtbox_artist.Size = new System.Drawing.Size(115, 20);
            this.txtbox_artist.TabIndex = 3;
            // 
            // checkbox_true
            // 
            this.checkbox_true.AutoSize = true;
            this.checkbox_true.Location = new System.Drawing.Point(20, 134);
            this.checkbox_true.Name = "checkbox_true";
            this.checkbox_true.Size = new System.Drawing.Size(196, 17);
            this.checkbox_true.TabIndex = 4;
            this.checkbox_true.Text = "All of the content i put above is true!";
            this.checkbox_true.UseVisualStyleBackColor = true;
            this.checkbox_true.CheckedChanged += new System.EventHandler(this.checkbox_true_CheckedChanged);
            // 
            // button_submit
            // 
            this.button_submit.Enabled = false;
            this.button_submit.Location = new System.Drawing.Point(50, 352);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 40);
            this.button_submit.TabIndex = 5;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_nextform
            // 
            this.button_nextform.Location = new System.Drawing.Point(457, 352);
            this.button_nextform.Name = "button_nextform";
            this.button_nextform.Size = new System.Drawing.Size(105, 40);
            this.button_nextform.TabIndex = 6;
            this.button_nextform.Text = "Open Next Form";
            this.button_nextform.UseVisualStyleBackColor = true;
            this.button_nextform.Click += new System.EventHandler(this.button_nextform_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_nextform);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkbox_true);
            this.Controls.Add(this.txtbox_artist);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.label_myfavoriteartist);
            this.Controls.Add(this.label_name);
            this.Name = "MainForm1";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_myfavoriteartist;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_artist;
        private System.Windows.Forms.CheckBox checkbox_true;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_nextform;
    }
}

